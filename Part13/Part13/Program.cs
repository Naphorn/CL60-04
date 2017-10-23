using System;
namespace variableProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data type : uint");
            Console.WriteLine("Size :" + sizeof(uint));
            Console.WriteLine("Minimum Value :" + uint.MinValue);
            Console.WriteLine("Maximum Value :" + uint.MaxValue);
        }
    }
}
