//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            // Weight of a man in kg on Earth
            Console.Write("Enter some weight: ");
            double manWeight = double.Parse(Console.ReadLine());

            // gravitational field of the Moon
            double gravityRatio = 0.17;

            // Weight of a man in kg on Moon
            Console.WriteLine("Weight of a man on Moon is: " + (manWeight * gravityRatio) + " kg");
        }
    }
}
