//In the 20×20 grid below, four numbers along a diagonal line have been marked in red.
//------------
//The product of these numbers is 26 × 63 × 78 × 14 = 1788696.
//What is the greatest product of four adjacent numbers in the same direction(up, down, left, right, or diagonally) in the 20×20 grid?


using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project_Euler
{
    class Task_11
    {
        private int answer { get; set; }
        private int[,] array { get; set; }

        public Task_11()
        {
            answer = -1;
            array = new int[20, 20];
            using (StreamReader sr = new StreamReader(@"..\..\..\Task_11.txt")) 
            {
                string line;
                for (int i = 0; i < 20; i++) 
                {
                    line = sr.ReadLine();
                    for (int j=0; j<line.Length; j+=3)
                    {
                        array[i, j / 3] = Convert.ToInt32(line.Substring(j, 2));
                    }
                }
            }            
        }

        public int Solution()
        {
            int res;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    // left - right
                    if (j < 20 - 3)
                    {                        
                        res = 1;
                        for (int n = 0; n < 4; n++)
                        {
                            res *= array[i, j + n];
                        }
                        if (res > answer)
                            answer = res;
                    }
                    // up - down
                    if (i < 20 - 3)
                    {
                        res = 1;
                        for (int n = 0; n < 4; n++)
                        {
                            res *= array[i + n, j];
                        }
                        if (res > answer)
                            answer = res;
                    }
                    // main diagonal  
                    if (i < 20 - 3 && j < 20 - 3)
                    {
                        res = 1;
                        for (int n = 0; n < 4; n++)
                        {
                            res *= array[i + n, j + n];
                        }
                        if (res > answer)
                            answer = res;
                    }
                    // side diagonal
                    if (i < 20 - 3 && j > 3) 
                    {
                        res = 1;
                        for (int n = 0; n < 4; n++)
                        {
                            res *= array[i + n, j - n];
                        }
                        if (res > answer)
                            answer = res;
                    }                    
                }
            }

            return answer;
        }

    }
}
