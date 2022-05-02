using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Day17.txt";

            int[,] iArr = new int[4, 4] { { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 }, { 4, 4, 4, 4 } };
            double[,] dArr = new double[5, 5] { {0.1,0.2,0.3,0.4,0.5 },
                { 1.1, 1.2, 1.3, 1.4, 1.5 },
                { 2.1, 2.2, 2.3, 2.4, 2.5 },
                {3.1,3.2,3.3,3.4,3.5 },
                {4.1,4.2,.3,4.4,4.5 } };
            string FIO = "Nedostoev Denis";
            DateTime bday = new DateTime(2002, 11, 18);
            DateTime today = DateTime.Now;
            FileInfo fi = new FileInfo(filePath);
            if (!fi.Exists)
                Console.WriteLine("Файл не существует , он будет создан в директории проекта");
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8))
            {
                sw.WriteLine(FIO);
                sw.WriteLine("Birthday: " + bday.ToLongDateString());
                sw.WriteLine($"\nRows: {iArr.GetUpperBound(0) + 1}");
                sw.WriteLine($"Columns: {iArr.GetUpperBound(1) + 1}");
                for (int i = 0; i < iArr.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < iArr.GetUpperBound(1) + 1; j++)
                    {
                        sw.Write(iArr[i, j].ToString());
                    }
                    sw.Write(" | ");
                }
                sw.WriteLine(" ");
                sw.WriteLine($"\nRows: {dArr.GetUpperBound(0) + 1}");
                sw.WriteLine($"Columns: {dArr.GetUpperBound(1) + 1}");
                for (int i = 0; i < dArr.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < dArr.GetUpperBound(1) + 1; j++)
                    {
                        sw.Write(dArr[i, j].ToString() + " ");
                    }
                    sw.WriteLine();
                }
                sw.WriteLine("Today: " + today.ToLongDateString());
            }
            FileStream fs1 = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs1))
            {
                string buff;
                while ((buff = sr.ReadLine()) != null)
                    WriteLine(buff);

            }
        }
    }
}