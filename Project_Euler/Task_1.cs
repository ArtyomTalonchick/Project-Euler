//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
//The sum of these multiples is 23.
//Find the sum of all the multiples of 3 or 5 below 1000.


namespace Project_Euler
{
    public class Task_1
    {
        private int Number { get; set; }

        public Task_1(int number)
        {
            Number = number;
        }

        public int Solution()
        {
            int sum = 0;
            for (int i = 0; i < Number; i++) 
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

    }
}
