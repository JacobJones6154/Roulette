using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette123
{
    public class Wallet
    {

        public static int bet;
        public static int money = 500;

        public static int Bet()
        {
        BetMoney:
            Console.WriteLine("How much do you want to bet");
            bet = int.Parse(Console.ReadLine());
            if (bet > money)
            {
                Console.WriteLine("Try betting something reasonable this time, you cant afford that.");
                goto BetMoney;
            }
            return bet;


        }
    }
}
