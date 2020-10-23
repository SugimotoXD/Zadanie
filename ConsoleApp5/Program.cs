using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("entet a:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("enter b:");
                int b = int.Parse(Console.ReadLine());
                Console.Write("enter c:");
                int c = int.Parse(Console.ReadLine());
                bool x = (a < 45) ^ (b < 45) ^ (c < 45);

                Console.WriteLine(x);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

       