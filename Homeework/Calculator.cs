using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homeework
{
    public class Calculator
    {
        public void Calculat()
        {
            float result = 0;
            Console.WriteLine("Birinci ededi daxil edin");

            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Operator daxil edin");
            string op = Console.ReadLine();

            switch (op)
            {

                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            Console.WriteLine("Cavab=" + result);


        }



    }




}

