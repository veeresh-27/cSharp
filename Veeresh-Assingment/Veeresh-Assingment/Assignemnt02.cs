using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veeresh_Assingment
{
    class Assignemnt02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Enter Array Elements");

            for(int i = 0; i<n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Even Numbers: ");    
            foreach(int i in array)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine("\nOdd Numbers: ");
            foreach (int i in array)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
