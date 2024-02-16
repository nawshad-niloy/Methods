using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {   
        static void Greet()
        {
            Console.WriteLine("Good Night");
        }
        
        static void Main(string[] args)
        {
            Greet();
            int[] a = new int[5];
            int i;
            for(i=0;i<5;i++)
            {
                Console.Write($"Enter {i}th Elemnt = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(i=0;i<5;i++)
            {
                Console.Write($"{i}th element : " + a[i]+"\n");
            }
        }
    }
}
