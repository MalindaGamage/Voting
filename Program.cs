using System;

namespace Voting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int input = int.Parse(Console.ReadLine());

            int Presidents = CalculatePresidents(input);
            Console.WriteLine($"You have voted for {Presidents} Presidents!");
            Console.ReadKey();
        }

        public static int CalculatePresidents(int age)
        {
            int eligibleYears = age - 18;
            int Presidents = 0;

            if (eligibleYears <= 0)
            {
                Console.WriteLine("Look like You are not old enough to vote!");
                return 0;
            }

            for (int i = 0; i < eligibleYears; i++)
            {
                if (i % 4 == 0)
                {
                    Presidents++;
                }
            }
            return Presidents;
        }
    }
}
