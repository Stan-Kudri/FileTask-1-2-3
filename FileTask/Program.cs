using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTask
{
    /*Задача 1. Создайте файл numbers.txt и запишите в него натуральные числа от 1 до 500 через запятую.

    Задача 2. Дан массив строк: "red", "green", "black", "white", "blue". Запишите в файл элементы массива построчно (каждый элемент в новой строке).

    Задача 3. Возьмите любой текстовый файл, и найдите в нем размер самой длинной строки.*/

    class Program
    {
        public static string Task1(int firstValue, int seconValue)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = firstValue; i <= seconValue; i++)
            {
                stringBuilder.AppendFormat(i.ToString() + ",");
            }
            return stringBuilder.ToString();
        }

        static void Main(string[] args)
        {
            string path = Path.GetFullPath("File-Task");
            DirectoryInfo driveInfo = new DirectoryInfo(path);
            if (!driveInfo.Exists)
                driveInfo.Create();

            //Задача 1:
            var stringNumbers = Task1(1, 500);
            using (FileStream fileStream = new FileStream($@"{path}\numbers.txt", FileMode.Create))
            {
                byte[] vs = Encoding.Default.GetBytes(stringNumbers);
                fileStream.Write(vs, 0, vs.Length);
            }

            //Задача 2:
            var array = new string[] { "red", "green", "black", "white", "blue" };
            using (StreamWriter streamWriter = new StreamWriter($@"{path}\ColorsRecordedInColumn.txt"))
            {
                for (int i = 0; i < array.Length; i++)
                    streamWriter.WriteLine(array[i]);
            }

            //Задача 3:
            using (StreamReader streamReader = new StreamReader($@"{path}\ColorsRecordedInColumn.txt"))
            {
                int max = 0;
                while (!streamReader.EndOfStream)
                {
                    string s = streamReader.ReadLine();
                    if (max < s.Length)
                    {
                        max = s.Length;
                    }
                }
                streamReader.Close();
                Console.WriteLine("Размер самой длинной строки: " + max);

            }
            Console.Read();            
        }
    }
}
