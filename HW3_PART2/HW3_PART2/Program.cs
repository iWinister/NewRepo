using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_PART2
{
    class Program
    {
        static void Main(string[] args)
        {

            // VARIABLES
            double velocity = 0;
            double gravConstant = 0;
            double height = 660;
            bool playAgain = true;
            string playResp;

            // INTRODUCTION AND INSTRUCTIONS
            Console.Write("Your target building height is 660 feet.\n");
            Console.Write("Please enter the gravatational constant for the planet on which Superman" +
                " \nis currently attempting this jump. Remember that the units should be in" +
                " feet/second^2.\n\n");

            // DO LOOP TO KEEP RUNNING FOR MULTIPLE ATTEMPTS
            do
            {
                // GRAV CONSTANT TO MAKE SURE IT IS POSITIVE
                Console.Write("Gravitational Constant: ");
                gravConstant = double.Parse(Console.ReadLine());
                while (gravConstant < 0)
                {
                    Console.Write("\nInvalid, must be positive. Input a number: ");
                    gravConstant = double.Parse(Console.ReadLine());
                }

                // FORMULA
                velocity = Math.Sqrt(2 * gravConstant * height);

                // FINAL RESULT PRINT
                Console.Write("\nSuperman must jump with an intial velocity of at least " + velocity + " feet/second.\n\n");
                Console.Write("Would you like to try another value? (Y/N) ");
                playResp = Console.ReadLine().ToUpper().Trim();

                // DETERMINES IF USER WANTS TO GO AGAIN, IF NO, LOOP BREAKS AND GAME ENDS
                if (playResp == "N")
                {
                    Console.Write("\nThanks for playing.\n");
                    playAgain = false;
                    break;
                }
            } while (playAgain = true);
        }
    }
}
