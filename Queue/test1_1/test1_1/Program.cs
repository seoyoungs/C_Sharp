using System;

namespace test1_1
{
    class Program
    {
        const int K = 5;
        byte[] mmm = new byte[K];
        
        static void Main(string[] args)
        {
            DataStructure dataStructure; //구조체 사용(변수)
            dataStructure.Header = 1;
            dataStructure.Command = 50;

            byte[] data = new byte[20];

            data[0] = 1;

            for(int i = 0; i < data.Length; i++)
            {
                data[i] = (byte)i;                
            }

            dataStructure.Data = data;
            byte[] packet = dataStructure.MakePacket();

            Console.WriteLine("Hello World!");
        }        
    }

    public struct DataStructure //구조체 정의
    {
        public byte Header;
        public byte Command;
        public byte[] Data;

        public byte[] MakePacket()
        {
            byte[] packet = new byte[Data.Length + 2]; // 22
            packet[0] = Header;
            packet[1] = Command;
            for(int i = 0; i < Data.Length; i++)
            {
                packet[i+2] = Data[i];
            }

            return packet;
        }
    } 
}
