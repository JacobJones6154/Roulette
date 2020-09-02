using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Roulette123
{  
    public class BettingChoices
    {


        static Random Spin = new Random();
        public static string WheelSpin;
        public static string[] binNumber = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "00" };
        public static int[] binDozens = { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 0 };
        public static int[] binColumns = { 0, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 0 };

        public static string[] binColor = { "Green", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Green" };
        public static string SpinRouletteWheel()
        {
           WheelSpin = binNumber[Spin.Next(binNumber.Length)];
            Console.WriteLine($"The wheel stopped on: [{WheelSpin}]: {binColor[int.Parse(WheelSpin)]}");
            return WheelSpin;
        }

        public static void Numbers()
        {
            Console.WriteLine("What number would you like to place your bet on?");
            int numberSelection = int.Parse(Console.ReadLine());
            Wallet.Bet();
            if (numberSelection == int.Parse(SpinRouletteWheel()))
            {
                Wallet.money += Wallet.bet * 35;
                Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                Console.ReadKey();

            }
            else
            {
                Wallet.money -= Wallet.bet;
                Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                Console.ReadKey();
            }
        }
        public static void OddsEven()
        {
            Console.WriteLine("Please choose Odd or Even");
            string oddevenSelection = Console.ReadLine().ToLower();
            Wallet.Bet();
            int checkWheelNumber = int.Parse(SpinRouletteWheel());

            if (oddevenSelection == "even" && checkWheelNumber != int.Parse("0") && checkWheelNumber != int.Parse("00"))
            {
                if (checkWheelNumber % 2 == 0)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
            else if (oddevenSelection == "odd" && checkWheelNumber != int.Parse("0") && checkWheelNumber != int.Parse("00"))
            {
                if (checkWheelNumber % 2 == 1)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else if (checkWheelNumber % 2 == 0)
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }


        }
        public static void RedBlack()
        {
            Console.WriteLine("Please choose Red or Black to bet on.");
            string redOrBlack = Console.ReadLine().ToLower();
            Wallet.Bet();
            int checkWheelNumber = int.Parse(SpinRouletteWheel());
            string color = binColor[checkWheelNumber];

            if (redOrBlack == "red")
            {
                if (color == "Red")
                {

                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
            else if (redOrBlack == "black")
            {
                if (color == "Black")
                {

                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
            else if (redOrBlack == "Green")
            {
                Wallet.money -= Wallet.bet;
                Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                Console.ReadKey();
            }


        }
        public static void LowHigh()
        {
            Console.WriteLine("Please choose Low or High to bet on.");
            string lowOrHigh = Console.ReadLine().ToLower();
            Wallet.Bet();
            int checkWheelNumber = int.Parse(SpinRouletteWheel());

            if (lowOrHigh == "low")
            {
                if (checkWheelNumber <= 18 && checkWheelNumber > 0)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
            else if (lowOrHigh == "high")
            {
                if (checkWheelNumber > 19)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
        }
        public static void Dozen()
        {
            Console.WriteLine("Please choose 1st, 2nd, 3rd dozens to bet on.");
            string dozens = Console.ReadLine().ToLower();
            Wallet.Bet();
            int checkWheelNumber = int.Parse(SpinRouletteWheel());

            if (dozens == "1st")
            {
                if (((checkWheelNumber - 1) / 12) + 1 == 1)
                {
                    Wallet.money += Wallet.bet * 2;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
            if (dozens == "2nd")
            {
                if (((checkWheelNumber - 1) / 12) + 1 == 2)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
            if (dozens == "3rd")
            {
                if (((checkWheelNumber - 1) / 12) + 1 == 3)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
        }
        public static void Street()
        {
            Console.WriteLine("Please choose 1-12 to place a streets bet.");
            string streetsBet = Console.ReadLine().ToLower();
            Wallet.Bet();
            int checkWheelNumber = int.Parse(SpinRouletteWheel());

            if (streetsBet == "1")
            { 
                if (((checkWheelNumber - 1) /3) +1 == 1)
                {
                    Wallet.money += Wallet.bet * 11;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }

            }
            if (streetsBet == "2")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 2)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
            if (streetsBet == "3")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 3)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
            if (streetsBet == "4")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 4)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
            if (streetsBet == "5")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 5)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
            if (streetsBet == "6")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 6)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
            if (streetsBet == "7")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 7)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
            if (streetsBet == "8")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 8)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
            if (streetsBet == "9")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 9)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
            if (streetsBet == "10")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 10)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
            if (streetsBet == "11")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 11)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }
            if (streetsBet == "12")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 12)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }
            }

        }
        public static void Columns()
        {

            Console.WriteLine("Please choose 1st, 2nd, or 3rd to place a columns bet.");
            string columnsBet = Console.ReadLine().ToLower();
            Wallet.Bet();
            int checkWheelNumber = int.Parse(SpinRouletteWheel());

            while (checkWheelNumber > 3)
            {
                checkWheelNumber -= 3;
            }
            if (columnsBet == "1st")
            {
                if (checkWheelNumber == 1)
                {
                    Wallet.money += Wallet.bet * 2;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }

            }
           
           else if (columnsBet == "2nd")
            {
                if (checkWheelNumber == 2)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }

            }

            else if (columnsBet == "3rd")
            {
                if (checkWheelNumber == 3)
                {
                    Wallet.money += Wallet.bet;
                    Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                    Console.ReadKey();
                }
                else
                {
                    Wallet.money -= Wallet.bet;
                    Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                    Console.ReadKey();
                }

            }


        }
        public static void SixNumbers()
        {
            Console.WriteLine("Please choose one of the following for your six numbers bet:");
            Console.WriteLine("1 for rows 1 and 4; 4 for rows 4 and 7;\n7 for rows 7 and 10; 10 for rows 10 and 13;" );
            Console.WriteLine("13 for rows 13 and 16; 16 for rows 16 and 19;\n19 for rows 19 and 22; 22 for rows 22 and 25;" );
            Console.WriteLine("25 for rows 25 and 28; 28 for rows 28 and 31;\n31 for rows 31 and 34.");
            int sixNumberBet = int.Parse(Console.ReadLine());
            Wallet.Bet();
            int checkWheelNumber = int.Parse(SpinRouletteWheel());

          if (checkWheelNumber != 0 && (checkWheelNumber == sixNumberBet || checkWheelNumber == sixNumberBet + 1 || checkWheelNumber == sixNumberBet + 2 || checkWheelNumber == sixNumberBet + 3 ||
                checkWheelNumber == sixNumberBet + 4 || checkWheelNumber == sixNumberBet + 5 || checkWheelNumber == sixNumberBet + 6))
            {
                Wallet.money += Wallet.bet * 5;
                Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                Console.ReadKey();
            }
            else
            {
                Wallet.money -= Wallet.bet;
                Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                Console.ReadKey();
            }
        }
        public static void SplitBet()
        {
            Console.WriteLine("Please choose two numbers that are next to each other to place a split bet");
            Console.WriteLine("For example, 1 and 2, 2 and 5 or 0 and 00.");
            int splitBet1 = int.Parse(Console.ReadLine());
            int splitBet2 = int.Parse(Console.ReadLine());
            Wallet.Bet();
            int checkWheelNumber = int.Parse(SpinRouletteWheel());

            if (checkWheelNumber == splitBet1 || checkWheelNumber ==splitBet2)
            {
                Wallet.money += Wallet.bet * 17;
                Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                Console.ReadKey();
            }
            else
            {
                Wallet.money -= Wallet.bet;
                Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                Console.ReadKey();
            }



        }
        public static void Corners()
        {
            Console.WriteLine("Please choose 4 numbers that form a corner bet");
            Console.WriteLine("For example: 1/2/4/5 or 23/24/26/27");
            Console.WriteLine("First number:");
            int cornerbet1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number:");
            int cornerbet2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Third number:");
            int cornerbet3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Fourth number:");
            int cornerbet4 = int.Parse(Console.ReadLine());
            Wallet.Bet();
            int checkWheelNumber = int.Parse(SpinRouletteWheel());

            if (checkWheelNumber == cornerbet1 || checkWheelNumber == cornerbet2 || checkWheelNumber == cornerbet3 || checkWheelNumber == cornerbet4)
            {
                Wallet.money += Wallet.bet * 8 ;
                Console.WriteLine($"Nice job, you guessed correctly, now you have {Wallet.money} bucks! ");
                Console.ReadKey();
            }
            else
            {
                Wallet.money -= Wallet.bet;
                Console.WriteLine($"Sorry, you lost {Wallet.bet}");
                Console.ReadKey();
            }

        }
    }
}

