//A palindromic number reads the same both ways.
//The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
//Find the largest palindrome made from the product of two 3-digit numbers.

using System.Linq;

namespace Project_Euler
{
    class Task_4
    {
        private const int min = 101;
        private const int max = 1000;

        private int answer { get; set; }

        public Task_4()
        {
            answer = -1;
        }
        
        public double Solution()
        {
            for (int i = min; i <= max; i++)
            {
                for (int j = min; j <= max; j++)
                {
                    int n = i * j;
                    if (n > answer && IsPalindrome(n))
                        answer = n;
                }
            }
            return answer;
        }

        private bool IsPalindrome (int n)
        {
            bool result = true;
            string str = n.ToString();
            int count = str.Count();
            for (int i = 0; i < count / 2; i++) 
            {
                if (str[i] != str[count - i - 1])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

    }
}
