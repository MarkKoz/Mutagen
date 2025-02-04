using Mutagen.Bethesda.Plugins.Binary.Streams;
using Noggog;
using System.Buffers.Binary;

namespace Mutagen.Bethesda.Plugins.Binary.Overlay;

internal static class BinaryOverlayArrayHelper
{
    public static ReadOnlyMemorySlice<T> EnumSliceFromFixedSize<T>(
        ReadOnlyMemorySlice<byte> mem,
        int amount,
        byte enumLength)
        where T : struct, Enum
    {
        T[] ret = new T[amount];
        for (int i = 0; i < amount; i++)
        {
            ret[i] = Enums<T>.TryConvert(BinaryPrimitives.ReadInt32LittleEndian(mem.Slice(i * enumLength)), default(T));
        }
        return ret;
    }

    public static ReadOnlyMemorySlice<float> FloatSliceFromFixedSize(
        ReadOnlyMemorySlice<byte> mem,
        int amount)
    {
        return mem.Span.Slice(0, amount * 4).AsFloatSpan().ToArray();
    }
}