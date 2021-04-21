using Mutagen.Bethesda.Records.Binary.Streams;
using System;

namespace Mutagen.Bethesda.Records.Binary.Translations
{
    public class DateTimeBinaryTranslation : PrimitiveBinaryTranslation<DateTime>
    {
        public readonly static DateTimeBinaryTranslation Instance = new DateTimeBinaryTranslation();
        public override int ExpectedLength => 4;

        public override DateTime Parse(MutagenFrame reader)
        {
            reader.Reader.Position += 4;
            return DateTime.Now;
        }

        public override void Write(MutagenWriter writer, DateTime item)
        {
            writer.Write(new byte[4]);
        }
    }
}
