﻿using System;
namespace variableProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data type : int");
            Console.WriteLine("Size :" + sizeof(int));
            Console.WriteLine("Minimum Value :" + int.MinValue);
            Console.WriteLine("Maximum Value :" + int.MaxValue);
        }
    }
}