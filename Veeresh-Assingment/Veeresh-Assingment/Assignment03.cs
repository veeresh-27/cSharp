using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veeresh_Assingment
{
    class Assignment03
        
    {
        enum Operators
        {
            Add, Subtract, Multiply, Divid, Modulus, Square,Squareroot 
        }

        static double Calculate(string op, double v1, double v2)
        {
            double res = 0;

            switch (op)
            {
                case "3":
                    res = v1 * v2;
                    break;
                case "1":
                    res = v1 + v2;
                    break;
                case "2":
                    res = v1 - v2;
                    break;
                case "4":
                    res = v1 / v2;
                    break;
                case "5":
                    res = v1 % v2;
                    break;
                case "6":
                        res = v1 * v1;
                    break;
                case "7":
                    res = Math.Sqrt(v1);
                    break;
                default:
                    Console.WriteLine("INVALID OPERATOR");
                    break;

            }
            return res;

        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Calculator");


                Console.WriteLine("Operations");
                Console.WriteLine("Enter 1 for addition");
                Console.WriteLine("Enter 2 for subtraction");
                Console.WriteLine("Enter 3 for multiplication");
                Console.WriteLine("Enter 4 for division");
                Console.WriteLine("Enter 5 for modulus");
                Console.WriteLine("Enter 6 for sqaure");
                Console.WriteLine("Enter 7 for sqaureroot");

                string option = Console.ReadLine();
                double v1;
                double v2 = 0;
                if(option == "6" || option == "7")
                {
                    Console.WriteLine("Enter the value");
                    v1 =double.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Enter Value One");
                    v1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Value two");
                    v2 = double.Parse(Console.ReadLine());
                }
                double res = Calculate(option, v1, v2);                                
                Console.WriteLine("Res: " + res);

                Console.WriteLine("type 1 to Continue and 0 to exit");
                int ex = int.Parse(Console.ReadLine());

                if(ex == 0)
                {
                    return;
                }
                Console.Clear();

            }

 


        }
    }
}
