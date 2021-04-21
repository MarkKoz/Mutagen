using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Records.Binary.Streams;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Mutagen.Bethesda.Records.Binary.Translations
{
    public interface IPrimitiveBinaryTranslation
    {
        int ExpectedLength { get; }
    }

    public abstract class PrimitiveBinaryTranslation<T> : IPrimitiveBinaryTranslation
        where T : struct
    {
        public abstract int ExpectedLength { get; }

        public abstract T Parse(MutagenFrame reader);

        public bool Parse(MutagenFrame reader, [MaybeNullWhen(false)] out T item)
        {
            item = Parse(reader);
            return true;
        }

        public abstract void Write(MutagenWriter writer, T item);

        public void WriteNullable(MutagenWriter writer, T? item)
        {
            if (!item.HasValue) return;
            Write(writer, item.Value);
        }

        public void Write(
            MutagenWriter writer,
            T item,
            RecordType header,
            Action<MutagenWriter, T>? write = null)
        {
            write ??= this.Write;
            try
            {
                using (HeaderExport.Header(writer, header, ObjectType.Subrecord))
                {
                    write(writer, item);
                }
            }
            catch (Exception ex)
            {
                throw SubrecordException.Enrich(ex, header);
            }
        }

        public void Write(
            MutagenWriter writer,
            T item,
            Action<MutagenWriter, T>? write = null)
        {
            write ??= Write;
            write(writer, item);
        }

        public void WriteNullable(
            MutagenWriter writer,
            T? item,
            RecordType header,
            Action<MutagenWriter, T>? write = null)
        {
            if (!item.HasValue) return;
            write ??= this.Write;
            try
            {
                using (HeaderExport.Header(writer, header, ObjectType.Subrecord))
                {
                    write(writer, item.Value);
                }
            }
            catch (Exception ex)
            {
                throw SubrecordException.Enrich(ex, header);
            }
        }

        public void WriteNullable(
            MutagenWriter writer,
            T? item,
            Action<MutagenWriter, T>? write = null)
        {
            if (!item.HasValue) return;
            write ??= this.Write;
            write(writer, item.Value);
        }
    }
}
