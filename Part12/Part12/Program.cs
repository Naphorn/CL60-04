using System;
namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Please enter Name : ");
                string fname = Console.ReadLine();
                Console.Write("Please enter Lastname : ");
                string lname = Console.ReadLine();
                Console.Write("Please enter ID : ");
                int val1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter Grade : ");
                string val2 = (Console.ReadLine());
                
                Console.WriteLine("Name : " +fname);
                Console.WriteLine("Lastname : " + lname);
                Console.WriteLine("ID : " + val1);
                Console.WriteLine("Grade : " + val2)ว
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }
        }
    }
}