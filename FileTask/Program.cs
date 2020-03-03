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
        static void Main(string[] args)
        {
            string path = Path.GetFullPath("File-Task");
            DirectoryInfo driveInfo = new DirectoryInfo(path);
            if (!driveInfo.Exists)
                driveInfo.Create();

            //Задача 1:
            var task1 = new Task1();
            task1.Task(path);

            //Задача 2:
            var task2 = new Task2();
            task2.Task(path);

            //Задача 3:
            var task3 = new Task3();
            task3.Task(path);

            Console.Read();            
        }
    }
}
