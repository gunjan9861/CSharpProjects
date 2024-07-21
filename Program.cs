using System;

namespace CSharpProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;
            int playerPoints = 0;
            int enemyPoints = 0;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.. ");
                Console.ReadKey();
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins the match");
                }
                else if (enemyRandomNum > playerRandomNum)

                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins the match");

                }
                else
                {
                    Console.WriteLine("Draw");
                }
                Console.WriteLine("The score is now Player:" + playerPoints + ". Enemy:" + enemyPoints);
                Console.WriteLine();
            }
            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("Youe win!");

            }
            else if (playerPoints < enemyPoints)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("Draw");
            }


            Console.ReadKey();
        }
    }
}



