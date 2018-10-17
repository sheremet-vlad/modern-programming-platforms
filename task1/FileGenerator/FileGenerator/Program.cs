using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileGenerator
{
    class Program
    {
        public const int MAX_VALUE = 65532;
        public const int CONVERT_BYTE_TO_MB = 1024 * 1024;
        public const int MAX_LENGTH = 220;

        static void Main(string[] args)
        {
            Console.Write("Enter file size in mb \n");
            long fileSize = long.Parse(Console.ReadLine());
            fileSize = fileSize * CONVERT_BYTE_TO_MB / 2;
            
            string filePath = @"E:\study\test.txt";

            try
            {
                StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Unicode);
                Random random = new Random();
                int length;
                string tempString;

                while (fileSize != 0)
                {
                    if (fileSize < MAX_LENGTH)
                    {
                        length = (int)fileSize;
                    }
                    else
                    {
                        length = random.Next(MAX_LENGTH);
                    }
                    
                    tempString = CreateString(length);
                    sw.Write(tempString);

                    fileSize -= length;
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        static string CreateString(int size)
        {
            Random random = new Random();

            char[] chars = new char[size];

            for (int i = 0; i < size; i++)
            {
                chars[i] = (char)random.Next(MAX_VALUE);
            }

            return new string(chars) + "\n";
        }

    }
}
