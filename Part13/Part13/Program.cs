using System;
namespace variableProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data type : decimal");
            Console.WriteLine("Size :" + sizeof(decimal));
            Console.WriteLine("Minimum Value :" + decimal.MinValue);
            Console.WriteLine("Maximum Value :" + decimal.MaxValue);
        }
    }
}
