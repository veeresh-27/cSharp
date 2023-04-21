using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veeresh_Assingment
{
    class Assignment04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Enter Array Elements");

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array Values are");
            foreach(int ele in array)
            {
                Console.Write(ele+" ");
            }

            Console.ReadLine();
        }
    }
}
