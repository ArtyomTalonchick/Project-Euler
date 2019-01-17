//The sum of the squares of the first ten natural numbers is,
//12 + 22 + ... + 102 = 385
//The square of the sum of the first ten natural numbers is,
//(1 + 2 + ... + 10)2 = 552 = 3025
//Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum 
//  is 3025 − 385 = 2640.
//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.


using System;
using System.Collections.Generic;

namespace Project_Euler
{
    class Task_6
    {
        private const int MaxNumber = 101;
        
        public int Solution()
        {
            int result = 0;
            for (int i = 1; i < MaxNumber; i++)
            {
                for (int j= 1; j < MaxNumber; j++)
                {
                    if (i != j)
                        result += i * j;
                }
            }


            return result;
        }

    }
}
