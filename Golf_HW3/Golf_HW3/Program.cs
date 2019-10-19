using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Golf
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES
            double radian = 0.0;
            int attempt = 0;




            Console.Write("Welcome! You are trying to hit a target that is 751 meters away.\n");

            do
            {
                Console.Write("Please enter a velocity: ");
                double velocity = double.Parse(Console.ReadLine());
                Console.Write("Now please enter an angle for the cannon: ");
                double angle = double.Parse(Console.ReadLine());
                while (angle < 0 || angle > 90)
                {
                    Console.Write("Invalid. Enter an angle from 0 to 90: ");
                    angle = double.Parse(Console.ReadLine());
                }

                radian = (angle * Math.PI) / 180;
                // double timeFlight = (velocity * Math.Sin(radian)) + Math.Pow(((velocity * velocity) * (Math.Sin(radian) * Math.Sin(radian)) + 20.0 * 2 * Math.Sin(radian)), 0.5) / 10.0;
                double equ1 = velocity * Math.Sin(radian);
                double equ2 = Math.Pow(velocity, 2) * Math.Pow(Math.Sin(radian), 2);
                double equ3 = 20.0 * 2.0 * Math.Sin(radian);
                double finalEquation = (equ1 + Math.Pow(equ2 + equ3, 0.5)) / 10;
                double distanceTrav = velocity * Math.Cos(radian) * finalEquation;
                double distanceLeft = distanceTrav - 751;


                Console.Write("\nA cannonball fired with an initial velocity of " + velocity + " m/s, at and angle of " + angle + " degrees " +
                    "\nfrom the ground, will strike the ground " + distanceTrav + " meters away."
                    + " You are " + distanceLeft + " meters\naway from the target.\n\n");
                attempt++;
                if (distanceLeft > 0 && distanceLeft < 1)
                {
                    Console.Write("SUCCESSFUL HIT! Thank you for playing!\n");
                    break;
                }
            } while (attempt < 10);
        }
    }
}
