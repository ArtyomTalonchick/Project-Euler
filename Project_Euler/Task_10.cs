//The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
//Find the sum of all the primes below two million.

using System;

namespace Project_Euler
{
    class Task_10
    {
        private const int max = 2000000; 

        public ulong Solution()
        {
            ulong sum = 0;
            for (int i = 2; i < max + 1; i++) 
            {
                if (IsPrime(i))
                    sum += (ulong)i;
            }
            return sum;
        }

        private bool IsPrime(int n)
        {
            if (n == 1)
                return false;
            bool isPrime = true;
            int MaxF = (int)Math.Sqrt(n);
            for (int i = 2; i <= MaxF; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
