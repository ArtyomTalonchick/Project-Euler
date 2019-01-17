﻿//Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
//By starting with 1 and 2, the first 10 terms will be:
//1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
//By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
//  find the sum of the even-valued terms.

namespace Project_Euler
{
    class Task_2
    {
        private const ulong Number=4000000;

        public ulong Solution()
        {
            ulong sum = 0;
            ulong n = 1;
            for (ulong i = 1; n <= Number; i += n) 
            {
                if (i % 2 == 0)
                    sum += i;
                if (n % 2 == 0)
                    sum += n;
                n += i;
            }
            return sum;
        }
    }
}
