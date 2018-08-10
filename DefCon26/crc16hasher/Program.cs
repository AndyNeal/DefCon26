using System;
using System.Text;

namespace crc16hasher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Agent 3oH ID ";
            var target = new System.Collections.Generic.List<string>() { "fb38", "8cc2", "55a5", "4f1a", "318a" };

            //for (int i=1; i<1000; i++)
            int i = 0;
            while (true)
            {
                //Guid guid = Guid.NewGuid();
                //var bytes = Encoding.ASCII.GetBytes(guid.ToString());
                var bytes = Encoding.ASCII.GetBytes(input + i);
                string hex = Crc16.ComputeChecksum(bytes).ToString("x2");
                if (target.Contains(hex))
                {
                    Console.WriteLine(input + i); //c061
                    Console.ReadLine();
                }
                i++;
            }

            Console.Write("Done!");
            Console.ReadKey();
            //var bytes = HexToBytes(input);
            //var bytes = Encoding.ASCII.GetBytes(input);
            //string hex = Crc16.ComputeChecksum(bytes).ToString("x2");
            //Console.WriteLine(hex); //c061
            //Console.ReadLine();
        }
        static byte[] HexToBytes(string input)
        {
            byte[] result = new byte[input.Length / 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Convert.ToByte(input.Substring(2 * i, 2), 16);
            }
            return result;
        }

        public static class Crc16
        {
            const ushort polynomial = 0xA001;
            static readonly ushort[] table = new ushort[256];

            public static ushort ComputeChecksum(byte[] bytes)
            {
                ushort crc = 0;
                for (int i = 0; i < bytes.Length; ++i)
                {
                    byte index = (byte)(crc ^ bytes[i]);
                    crc = (ushort)((crc >> 8) ^ table[index]);
                }
                return crc;
            }

            static Crc16()
            {
                ushort value;
                ushort temp;
                for (ushort i = 0; i < table.Length; ++i)
                {
                    value = 0;
                    temp = i;
                    for (byte j = 0; j < 8; ++j)
                    {
                        if (((value ^ temp) & 0x0001) != 0)
                        {
                            value = (ushort)((value >> 1) ^ polynomial);
                        }
                        else
                        {
                            value >>= 1;
                        }
                        temp >>= 1;
                    }
                    table[i] = value;
                }
            }
        }

    }
}

