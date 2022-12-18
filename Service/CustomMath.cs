using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CustomMath
    {
        public void Factorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i < n; i++)
            {
                factorial *= i;

            }
            Console.WriteLine(factorial);
        }


        public void Array(int[]arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==1)
                {
                    count++; 
                }
               
            }
               Console.WriteLine(count);
        }

    }
}
