using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTask
{
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
            using (FileStream fileStream = new FileStream($@"{path}\numbers.txt", FileMode.Create))
            {
                byte[] vs = Encoding.Default.GetBytes(stringNumbers);
                fileStream.Write(vs, 0, vs.Length);
            }
        }
    }
}
