//The prime factors of 13195 are 5, 7, 13 and 29.
//What is the largest prime factor of the number 600851475143 ?

namespace Project_Euler
{
    class Task_3
    {
        private const ulong Number = 600851475143;

        public double Solution()
        {
            ulong Factor = 1;
            ulong MaxF = (ulong)System.Math.Sqrt(600851475143);
            for (ulong i = 1; i <= MaxF; i++)
            {
                if (IsPrime(i) && Number % i == 0)
                    Factor = i;
            }
            return Factor;
        }

        private bool IsPrime(ulong n)
        {
            bool isPrime = true;
            ulong MaxF =(ulong)System.Math.Sqrt(n);
            for (ulong i = 2; i <= MaxF; i++)
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
