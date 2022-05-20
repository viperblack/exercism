using System;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        var buffer = new byte[9];
        var bytes = BitConverter.GetBytes(reading);

        buffer[0] = reading switch
        {
            >= int.MinValue and < short.MinValue => (256 - 4),  //0x0fc or (256-4) or (byte)(256 - BitConverter.GetBytes((int)reading).Length)
            >= short.MinValue and < 0 => (256 - 2),             //0x0fe or (256 -2) or (byte)(256 - BitConverter.GetBytes((short)reading).Length)
            >= 0 and <= ushort.MaxValue => 2,                   //0x02 or 2 or (byte)BitConverter.GetBytes((ushort)reading).Length
            > ushort.MaxValue and <= int.MaxValue => (256 - 4), //0x0fc or (256-4) or (byte)(256 - BitConverter.GetBytes((int)reading).Length)
            > int.MinValue and <= uint.MaxValue => 4,           //0x004 or 4 or (byte)BitConverter.GetBytes((uint)reading).Length
            _ => (256 - 8)                                      //0x0f8 or (256-8) or (byte)(256 - BitConverter.GetBytes((long)reading).Length)
        };

        int prefix = Math.Abs((buffer[0] < 8) ? buffer[0] : buffer[0] - 256); //Using Math.Abs to handling negative ones
        Array.Copy(bytes, 0, buffer, 1, prefix);
        return buffer;
    }
    public static long FromBuffer(byte[] buffer)
    {
        int prefix = buffer[0];
        switch (prefix)
        {
            case (256 - 8): return BitConverter.ToInt64(buffer, 1);
            case (256 - 4): return BitConverter.ToInt32(buffer, 1);
            case (256 - 2): return BitConverter.ToInt16(buffer, 1);
            case 002: return BitConverter.ToUInt16(buffer, 1);
            case 004: return BitConverter.ToUInt32(buffer, 1);
            default: return 0;
        }
    }
}
