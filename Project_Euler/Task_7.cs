//By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
//What is the 10 001st prime number?

namespace Project_Euler
{
    class Task_7
    {
        private const int NumberOfPrime = 10001;

        public int Solution()
        {
            int Num = NumberOfPrime + 1;
            for (int i = 1; ; i++)
            {
                if (IsPrime(i))
                    Num--;
                if (Num == 0)
                    return i;
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
    }
}
