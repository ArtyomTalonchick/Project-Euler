//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?


using System;
using System.Collections.Generic;

namespace Project_Euler
{
    class Task_5
    {
        private const int MaxNumber = 20;

        private Dictionary<int, int> Primes;

        public Task_5()
        {
            Primes = new Dictionary<int, int>();
            InitializationPrimes(MaxNumber + 1);
        }

        private void InitializationPrimes(int number)
        {
            for (int n = 2; n < number; n++)
            {
                for (int d = 2; d < n + 1; d++) 
                {
                    if (n % d != 0 || !IsPrime(d)) 
                        continue;
                    int _n = n;
                    int count = 0;
                    while (_n % d == 0)
                    {
                        _n /= d;
                        count++;
                    }
                    if (!Primes.ContainsKey(d))
                        Primes.Add(d, count);
                    else if(Primes[d] < count)
                        Primes[d] = count;
                }
            }
        }

        private bool IsPrime(int n)
        {
            bool isPrime = true;
            int MaxF = (int)System.Math.Sqrt(n);
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

        public double Solution()
        {
            int result = 1;
            foreach (var d in Primes)
            {
                result *= (int)Math.Pow(d.Key, d.Value);
            }
            return result;
        }

    }
}
