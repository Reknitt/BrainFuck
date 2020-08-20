using System;
using System.IO;

namespace BF
{
    class Program
    {
        static void Main()
        {
            string text = "";
            string path = @"C:\Users\Паша\Desktop\Hello.bf";

            //Console.Write("Введите путь до файла .bf: ");
            //path = Console.ReadLine();

            using (StreamReader sr = new StreamReader(path))
            {
                text += sr.ReadToEnd();
            }


            BrainFuck bf = new BrainFuck(100);
            bf.StartBF(text);

            Console.ReadLine();
        }
    }
}
