using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {


        static void Main(string[] args)
        {
            
            rectangle Safi = new rectangle ();
            Console.Write("Enter The length of the rectangle :");
            Safi.lengthA =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The width of the rectangle  :");
            Safi.width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The rectangle area is : " + Safi.A()+ "\t\t\t\t The rectangle Primeter is : " + Safi.P());
        
        




        Console.ReadKey();
            


        }
    }
}
