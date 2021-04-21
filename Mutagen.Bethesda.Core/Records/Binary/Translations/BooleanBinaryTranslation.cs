using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Records.Binary.Streams;
using System;

namespace Mutagen.Bethesda.Records.Binary.Translations
{
    public class BooleanBinaryTranslation : PrimitiveBinaryTranslation<bool>
    {
        public readonly static BooleanBinaryTranslation Instance = new BooleanBinaryTranslation();
        public override int ExpectedLength => 1;

        public override bool Parse(MutagenFrame reader)
        {
            return reader.Reader.ReadBoolean();
        }

        public override void Write(MutagenWriter writer, bool item)
        {
            writer.Write(item);
        }

        public void WriteAsMarker(
            MutagenWriter writer,
            bool item,
            RecordType header)
        {
            try
            {
                if (!item) return;
                using (HeaderExport.Header(writer, header, ObjectType.Subrecord))
                {
                    // Presence of marker signifies true
                }
            }
            catch (Exception ex)
            {
                throw SubrecordException.Enrich(ex, header);
            }
        }

        public bool Parse(
            MutagenFrame reader,
            byte byteLength)
        {
            return byteLength switch
            {
                1 => reader.ReadBoolean(),
                2 => reader.ReadUInt16() > 0,
                4 => reader.ReadUInt32() > 0,
                _ => throw new NotImplementedException(),
            };
        }

        public void Write(
            MutagenWriter writer,
            bool item,
            RecordType header,
            byte byteLength)
        {
            try
            {
                using (HeaderExport.Header(writer, header, ObjectType.Subrecord))
                {
                    writer.Write(item ? 1 : 0, byteLength);
                }
            }
            catch (Exception ex)
            {
                throw SubrecordException.Enrich(ex, header);
            }
        }

        public void WriteNullable(
            MutagenWriter writer,
            bool? item,
            RecordType header,
            byte byteLength)
        {
            try
            {
                if (!item.HasValue) return;
                using (HeaderExport.Header(writer, header, ObjectType.Subrecord))
                {
                    writer.Write(item.Value ? 1 : 0, byteLength);
                }
            }
            catch (Exception ex)
            {
                throw SubrecordException.Enrich(ex, header);
            }
        }
    }
}
