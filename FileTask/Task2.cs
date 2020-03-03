﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTask
{
    class Task2
    {
        public void Task(string path)
        {
            var array = new string[] { "red", "green", "black", "white", "blue" };
            using (StreamWriter streamWriter = new StreamWriter($@"{path}\ColorsRecordedInColumn.txt"))
            {
                for (int i = 0; i < array.Length; i++)
                    streamWriter.WriteLine(array[i]);
            }
        }
    }
}
