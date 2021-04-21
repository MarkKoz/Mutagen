using Mutagen.Bethesda.Records.Binary.Streams;
using Noggog;
using System;
using System.Buffers.Binary;

namespace Mutagen.Bethesda.Records.Binary.Translations
{
    public class P3Int16BinaryTranslation : PrimitiveBinaryTranslation<P3Int16>
    {
        public readonly static P3Int16BinaryTranslation Instance = new P3Int16BinaryTranslation();
        public override int ExpectedLength => 4;

        public override P3Int16 Parse(MutagenFrame reader)
        {
            return new P3Int16(
                reader.Reader.ReadInt16(),
                reader.Reader.ReadInt16(),
                reader.Reader.ReadInt16());
        }

        public override void Write(MutagenWriter writer, P3Int16 item)
        {
            writer.Write(item.X);
            writer.Write(item.Y);
            writer.Write(item.Z);
        }

        public static P3Int16 Read(ReadOnlySpan<byte> span)
        {
            return new P3Int16(
                BinaryPrimitives.ReadInt16LittleEndian(span),
                BinaryPrimitives.ReadInt16LittleEndian(span.Slice(2)),
                BinaryPrimitives.ReadInt16LittleEndian(span.Slice(4)));
        }
    }
}
