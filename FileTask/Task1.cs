using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTask
{
    //Задача 1. Создайте файл numbers.txt и запишите в него натуральные числа от 1 до 500 через запятую.
    class Task1
    {
        private static string Builder(int firstValue, int seconValue)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = firstValue; i <= seconValue; i++)
            {
                stringBuilder.AppendFormat(i.ToString() + ",");
            }
            return stringBuilder.ToString();
        }

        public void Task(string path)
        {
            var stringNumbers = Builder(1, 500);
            using (StreamWriter streamWriter = new StreamWriter($@"{path}\numbers.txt",true,Encoding.Default))
            {
                streamWriter.Write(stringNumbers);
            }            
        }
    }
}
