using Mutagen.Bethesda.Records.Binary.Streams;

namespace Mutagen.Bethesda.Records.Binary.Translations
{
    public class Int32BinaryTranslation : PrimitiveBinaryTranslation<int>
    {
        public readonly static Int32BinaryTranslation Instance = new Int32BinaryTranslation();
        public override int ExpectedLength => 4;

        public override int Parse(MutagenFrame reader)
        {
            return reader.Reader.ReadInt32();
        }

        public override void Write(MutagenWriter writer, int item)
        {
            writer.Write(item);
        }
    }
}
