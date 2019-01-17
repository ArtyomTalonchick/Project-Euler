//The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
//  -------------
//Find the thirteen adjacent digits in the 1000-digit number that have the greatest product.What is the value of this product?

using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler
{
    class Task_8
    {
        private const int number = 13;
        private readonly string str;
        private ulong answer { get; set; }

        public Task_8()
        {
            str = System.IO.File.ReadAllText(@"..\..\..\Task_8.txt").Replace("\n", " ");
        }

        public ulong Solution()
        {
            answer = 0;
            int count = str.Length - number;
            ulong res = 1;
            for (int i = 0; i < count; i++)
            {
                res = 1;
                for (int j = 0; j < number; j++)
                {
                    res *= (ulong)(str[i + j] - 48);
                }
                if (res > answer)
                    answer = res;
            }
            return answer;
        }

    }
}
