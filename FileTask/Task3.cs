using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTask
{
    class Task3
    {
        public void Task(string path)
        {
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
        }
    }
}
