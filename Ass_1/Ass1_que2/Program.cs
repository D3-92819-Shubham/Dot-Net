using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1_que2
{

    public class Calculator
    {
        private int num1;
        private int num2;

        public Calculator():this(0, 0)
        {
        }

        public Calculator(int num1, int num2)
        {

            this.num1 = num1;
            this.num2 = num2;

        }

        public int choice()
        {
            Console.WriteLine("Enter the choice: ");

            Console.WriteLine("1.Add");
            Console.WriteLine("2.Sub");
            Console.WriteLine("3.Mul");
            Console.WriteLine("4.Div");

            Console.WriteLine("Enter the choice : ");
            string chooice = Console.ReadLine();
            int num1 = int.Parse(chooice);

            return num1;

        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            int ch;
            int res, n1, n2;

            Console.WriteLine("Enter num1 : ");
            String num1 = Console.ReadLine();
            n1 = int.Parse(num1);


            Console.WriteLine("Enter num2 : ");
            String num2 = Console.ReadLine();
            n2 = int.Parse(num2);

            while ((ch = c1.choice()) != 0)
            {
                switch (ch)
                {

                    case 1:
                        Console.WriteLine(n1 + n2);
                        break;

                    case 2:
                        Console.WriteLine(n1 - n2);
                        break;

                    case 3:
                        Console.WriteLine(n1 * n2);
                        break;

                    case 4:
                        Console.WriteLine(n1 / n2);
                        break;

                    default:
                        break;
                }

            }
        }
    }
}
