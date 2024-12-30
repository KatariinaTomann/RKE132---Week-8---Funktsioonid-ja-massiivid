using System;

namespace DataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C: \Users\karle\source\villains.txt";

            string[] dataFromFile = File.ReadAllLines(filePath);

            foreach (string element in dataFromFile)
            {
                Console.WriteLine(element);
            }
        }
    }
}

