using System;
using System.Collections.Generic;
using System.Text;

namespace HomeW10_calculate
{
    public class Calculate : ICalculation
    {
        int num1;
        int num2;
        string operate;
        public void Calculating(int a, int b, string oper)
        {
            num1 = a;
            num2 = b;
            operate = oper;

            {
                if (oper == "+")
                {
                    Console.WriteLine(a + b);
                }
                else if (oper == "-")
                {
                    Console.WriteLine(a - b);
                }
                else if (oper == "*")
                {
                    Console.WriteLine(a * b);
                }
                else if (oper == "/")
                     if (b != 0)
                    Console.WriteLine(a / b);
                     else Console.WriteLine("0 bolmek olmaz");
                    }
                }
            }
        }

