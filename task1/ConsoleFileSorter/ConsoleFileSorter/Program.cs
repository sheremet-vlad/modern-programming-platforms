using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\study\test.txt";
            Console.Write("process...");
            Split(filePath);
            SortTheChunks();
            MergeTheChunks();
        }

        static void Split(string file)
        {
            int splitNum = 1;
            StreamWriter sw = new StreamWriter(string.Format("E:\\split{0:d5}.dat", splitNum), false, Encoding.Unicode);

            using (StreamReader sr = new StreamReader(file, Encoding.Unicode))
            {
                while (sr.Peek() >= 0)
                {
                    sw.WriteLine(sr.ReadLine());

                    if (sw.BaseStream.Length > 100000000 && sr.Peek() >= 0)
                    {
                        sw.Close();
                        splitNum++;
                        sw = new StreamWriter(string.Format("E:\\split{0:d5}.dat", splitNum), false, Encoding.Unicode);
                    }
                }
            }
            sw.Close();
        }

        static void SortTheChunks()
        {
            foreach (string path in Directory.GetFiles("E:\\", "split*.dat"))
            {
                string[] contents = File.ReadAllLines(path, Encoding.Unicode);

                Array.Sort(contents);

                string newpath = path.Replace("split", "sorted");

                File.WriteAllLines(newpath, contents, Encoding.Unicode);

                File.Delete(path);

                contents = null;
                GC.Collect();
            }
        }

        static void MergeTheChunks()
        {
            string[] paths = Directory.GetFiles("E:\\", "sorted*.dat");
            int chunks = paths.Length;
            int recordsize = 100;
            int records = 10000000;
            int maxusage = 500000000;
            int buffersize = maxusage / chunks;
            double recordoverhead = 7.5;
            int bufferlen = (int)(buffersize / recordsize / recordoverhead);

            StreamReader[] readers = new StreamReader[chunks];
            for (int i = 0; i < chunks; i++)
                readers[i] = new StreamReader(paths[i], Encoding.Unicode);

            Queue<string>[] queues = new Queue<string>[chunks];
            for (int i = 0; i < chunks; i++)
                queues[i] = new Queue<string>(bufferlen);

            for (int i = 0; i < chunks; i++)
                LoadQueue(queues[i], readers[i], bufferlen);

            StreamWriter sw = new StreamWriter("E:\\BigFileSorted.txt", false, Encoding.Unicode);
            bool done = false;
            int lowestIndex, j;
            string lowestValue;

            while (!done)
            {
                lowestIndex = -1;
                lowestValue = "";
                for (j = 0; j < chunks; j++)
                {
                    if (queues[j] != null)
                    {
                        if (lowestIndex < 0 || String.CompareOrdinal(queues[j].Peek(), lowestValue) < 0)
                        {
                            lowestIndex = j;
                            lowestValue = queues[j].Peek();
                        }
                    }
                }

                if (lowestIndex == -1)
                {
                    done = true; break;
                }

                sw.WriteLine(lowestValue);

                queues[lowestIndex].Dequeue();

                if (queues[lowestIndex].Count == 0)
                {
                    LoadQueue(queues[lowestIndex], readers[lowestIndex], bufferlen);

                    if (queues[lowestIndex].Count == 0)
                    {
                        queues[lowestIndex] = null;
                    }
                }
            }
            sw.Close();

            for (int i = 0; i < chunks; i++)
            {
                readers[i].Close();
                File.Delete(paths[i]);
            }

        }

        static void LoadQueue(Queue<string> queue, StreamReader file, int records)
        {
            for (int i = 0; i < records; i++)
            {
                if (file.Peek() < 0) break;
                queue.Enqueue(file.ReadLine());
            }
        }
    }

}
