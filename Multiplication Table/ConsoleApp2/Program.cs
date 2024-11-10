using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A Multiplication Table ");
            Console.WriteLine();

            Console.Write("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= 10; i++) {
                
                Console.WriteLine("{0} x {1} = {2} ",i,number,i*number);
            
            
            }




             Console.ReadKey();
        }
    }
}
