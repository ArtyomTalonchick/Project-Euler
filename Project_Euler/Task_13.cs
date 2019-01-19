//Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project_Euler
{
    class Task_13
    {
        private int answer { get; set; }
        private List<string> list { get; set; }

        public Task_13()
        {
            answer = -1;
            list = new List<string>();
            using (StreamReader sr = new StreamReader(@"..\..\..\Task_13.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
        }

        public string Solution()
        {
            int carry = 0;
            for (int i = list[0].Length - 1; i > 9; i--) 
            {
                foreach (var str in list)
                {
                    carry += Convert.ToInt32(str[i]) - '0';
                }
                carry /= 10;
            }

            ulong answer = (ulong)carry;
            foreach (var str in list)
            {
                answer += Convert.ToUInt64(str.Substring(0, 10));
            }
            
            return (answer.ToString()).Substring(0,10);
        }

    }
}
