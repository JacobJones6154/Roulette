using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette123
{
    public class StartHere
    {

        public static void BetSelect()
        {
            while (Wallet.money > 0)
            {
                Console.WriteLine($"You have {Wallet.money} bucks!");
                Console.WriteLine("Please Make a bet selection:");
                Console.WriteLine("1. Numbers");
                Console.WriteLine("2. Evens/Odds");
                Console.WriteLine("3. Reds/Blacks");
                Console.WriteLine("4. Lows/Highs");
                Console.WriteLine("5. Dozens: row thirds");
                Console.WriteLine("6. Columns");
                Console.WriteLine("7. Street: rows");
                Console.WriteLine("8. 6 Numbers: double rows");
                Console.WriteLine("9. Split: at the edge of any two contiguous numbers");
                Console.WriteLine("10. Corner: at the intersection of any four contiguous  numbers");
                
                int betSelection = new int();
                betSelection = int.Parse(Console.ReadLine());
                if (betSelection == 1)
                {
                    BettingChoices.Numbers();
                }
                if (betSelection == 2)
                {
                    BettingChoices.OddsEven();
                }
                if (betSelection == 3)
                {
                    BettingChoices.RedBlack();
                }
                if (betSelection == 4)
                {
                    BettingChoices.LowHigh();
                }
                if (betSelection == 5)
                {
                    BettingChoices.Dozen();
                }
                if (betSelection == 6)
                {
                    BettingChoices.Columns();
                }
                if (betSelection == 7)
                {
                    BettingChoices.Street();
                }
                if (betSelection == 8)
                {
                    BettingChoices.SixNumbers();
                }
                if (betSelection == 9)
                {
                    BettingChoices.SplitBet();
                }
                if (betSelection == 10)
                {
                    BettingChoices.Corners();
                }
                Console.Clear();
            }
            Console.WriteLine("Thanks for playing, I enjoyed taking your money.");


        }
    }
}
