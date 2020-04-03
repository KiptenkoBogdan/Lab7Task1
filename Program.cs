using System;
using System.IO;
using System.Collections.Generic;

namespace Lab7Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\User\Desktop\C#Programming\Lab7Task1\equasion.txt";
            //@"C:\Users\User\Desktop\Lab7Task1\equasion.txt" - если папка на рабочем столе
            string equasion;
            int lBracket = 0, rBracket = 0;
            List<Char> symbols = new List<Char>();

            using (StreamReader MyFile = new StreamReader(filePath))
            {
                while ((equasion = MyFile.ReadLine()) != null)
                {
                    foreach (Char c in equasion)
                        symbols.Add(c);
                    symbols.Add('\n');
                }
            }

            Console.WriteLine("Text from file:");
            for (int i = 0; i != symbols.Count; i++)
            {
                Console.Write(symbols[i]);
                if (symbols[i] == '(')
                    lBracket++;
                else if (symbols[i] == ')')
                    rBracket++;
            }

            Console.Write("Result: ");
            if (lBracket == rBracket)
            {
                Console.WriteLine("Equal number of brackets ()");
            }
            else if (lBracket > rBracket)
            {
                Console.WriteLine("More left brackets (");
            }
            else
            {
                Console.WriteLine("More right brackets )");
            }
            Console.ReadKey();
        }
    }
}
