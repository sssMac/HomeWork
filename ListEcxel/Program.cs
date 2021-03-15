using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ListEcxel
{
    class Program
    {
        static void Main()
        {
            List<string[]> date = ReadingFile();

            date = RemoveFirstLine(date);
            date = SortPriority(date);
            PrintResult(date);

            date = DateAcceptSort(date);
            date = DateArrivedSort(date);


            date = RemoveLastLine(date);

        }

        public static List<string[]> ReadingFile()
        { 
            string path = (@"C:\Users\IlyaNB\source\repos\HomeWork\ListEcxel\Sample.csv");

            List<string[]> resultList = new List<string[]>();
            List<string> line = new List<string>();

            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 150; i++)
                {
                    line.Add(sr.ReadLine());
                }

                for (int i = 0; i < line.Count; i++)
                {
                    resultList.Add(line[i].Split(';'));
                }
                return resultList;
            }
        }

        static List<string[]> RemoveFirstLine(List<string[]> list)
        {
            List<string[]> res = new List<string[]>();

            for (int i = 1; i < list.Count; i++)
            {
                res.Add(list[i]);
            }
            return res;
        }
        static List<string[]> RemoveLastLine(List<string[]> list)
        {
            List<string[]> res = new List<string[]>();

            for (int i = 0; i < list.Count-1; i++)
            {
                res.Add(list[i]);
            }
            return res;
        }
        static List<string[]> SortPriority(List<string[]> list)
        {
            List<string[]> res = new List<string[]>();

            List<string[]> low = new List<string[]>();
            List<string[]> medium = new List<string[]>();
            List<string[]> high = new List<string[]>();
            List<string[]> notSpec = new List<string[]>();
            List<string[]> critical = new List<string[]>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i][3] == "Low") low.Add(list[i]);
                else if (list[i][3] == "Medium") medium.Add(list[i]);
                else if (list[i][3] == "High") high.Add(list[i]);
                else if (list[i][3] == "Not Specified") notSpec.Add(list[i]);
                else if (list[i][3] == "Critical") critical.Add(list[i]);
            }

            res.AddRange(critical);
            res.AddRange(high);
            res.AddRange(medium);
            res.AddRange(low);
            res.AddRange(notSpec);

            return res;
        }
        static List<string[]> DateAcceptSort(List<string[]> list)
        {
            return list.OrderBy(x => DateTime.Parse(x[2])).ToList();
        }
        static List<string[]> DateArrivedSort(List<string[]> list)
        {
            return list.OrderBy(x => DateTime.Parse(x[20])).ToList();
        }

        static void PrintResult(List<string[]> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                foreach (string res in list[i])
                    Console.Write(res);
                Console.WriteLine();
            }
        }
    }
}
