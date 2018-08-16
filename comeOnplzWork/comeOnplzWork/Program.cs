using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comeOnplzWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello retard, time to catch up");
            Console.ReadLine();

            //loops

            Console.WriteLine("Please enter your first number");
            int start = int.Parse (Console.ReadLine());
            
           
            Console.WriteLine("Please enter your 2nd number");
            int end = int.Parse(Console.ReadLine());


            for (int L = start; L <= end; L++) 

            
            {
                Console.WriteLine("{0} {1} {2}", (L*10), (L * 100), (L * 1000));
            }
            Console.ReadKey();
            




        


        }
    }
}
