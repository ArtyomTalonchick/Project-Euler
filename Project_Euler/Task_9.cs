//A Pythagorean triplet is a set of three natural numbers, a < b<c, for which,
//a2 + b2 = c2
//For example, 32 + 42 = 9 + 16 = 25 = 52.
//There exists exactly one Pythagorean triplet for which a + b + c = 1000.
//Find the product abc.

using System;

namespace Project_Euler
{
    class Task_9
    {
        private const int sum = 1000;

        public int Solution()
        {
            for (int a = 1; a < sum - 1; a++) 
            {
                var a_2 = Math.Pow(a, 2);
                for (int b = 1; b < sum - a - 1; b++) 
                {
                    if (a_2 + Math.Pow(b, 2) == Math.Pow(sum - a - b, 2))
                        return a * b * (sum - a - b);
                }
            }
            return -1;
        }
    }
}
