using System;
namespace variableProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            const double SunTo_Mercury_Distance = 35983594.61;  // miles
            Console.WriteLine("SunTo_Mercury_Distance = {0} a.u.", SunTo_Mercury_Distance * value1);
            double SunTo_Mercury_TimeOfLight = SunTo_Mercury_Distance / lightSpeed; // miles 
            Console.WriteLine("SunTo_Mercury_TimeOfLight = {0} minutes", SunTo_Mercury_TimeOfLight / 60d);
            Console.WriteLine("");
        }
    }
}
