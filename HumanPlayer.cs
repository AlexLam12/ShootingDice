using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            int response = 0;
        
            Console.WriteLine($"Pick a number between 1 and {DiceSize}: ");
            response = int.Parse(Console.ReadLine()); 

            return response;
        }
    }
}