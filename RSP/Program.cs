using static System.Formats.Asn1.AsnWriter;

namespace RSP
{
    internal class Program
    {
        enum Weapon
        {
            Rock = 1,
            Scissors,
            Paper
        }

        public static void Main(string[] args)
        {
            int roundCount = 0;
            int winCount = 0;
            int score = 0;
            

            Console.WriteLine("Hello, this is a game Rock-Paper-Scissors !!");
            Console.Write("Enter your nickname: ");
            string nickname = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());


            if (age < 12) Console.WriteLine("Sorry, the game is only available for ages 12 and up.");

            Stat(nickname, age, roundCount, winCount, score);

            
        }




        public static void Stat(string name, int a, int rounds, int wins, int s)
        {
            Console.WriteLine("STATISTICS");
            Console.WriteLine();
            Console.WriteLine(name + " " + a);
            Console.WriteLine(rounds + " rounds are played");
            Console.WriteLine(wins + " wins");

            Console.WriteLine();
            Console.WriteLine("Are you ready for battle!?");
            string readiness = Console.ReadLine();

            if (readiness == "no") 
            {
                Console.WriteLine("Goodbay " + name);
                return;
            }

            Random rand = new Random();
            //////////////////////////////////////////////// roun 1
            int AIweapon = rand.Next(1, 4);
            bool result = playRound(1, AIweapon);
            rounds++;

            if (result) s++;
            /////////////////////////////////////////////// round 2
            AIweapon = rand.Next(1, 4);
            result = playRound(2, AIweapon);
            rounds++;

            if (result) s++;
            /////////////////////////////////////////////// roun 3
            AIweapon = rand.Next(1, 4);
            result = playRound(3, AIweapon);
            rounds++;
            if (result) s++;
            /////////////////////////////////////
            
            if (s >= 2) 
            {
                Console.WriteLine("***************** YOU WON *****************");
                
                wins++;
            }
            else 
            {
                Console.WriteLine(".................. YOU LOSE ................");
            }

            Stat(name, a, rounds, wins, s);
        }

         public static bool playRound(int roundNum, int a)
        {
        Console.WriteLine();
        Console.WriteLine("ROUND " + roundNum);
        Console.WriteLine();
        Console.WriteLine("Choose your weapon (enter a number): ");
        Console.WriteLine();
        Console.WriteLine("1 - Rock");
        Console.WriteLine("2 - Scissors");
        Console.WriteLine("3 - Paper");
        Console.WriteLine();
        Console.WriteLine("HINT:");
        Console.WriteLine("Paper beat rocks, but loses to scissors.");
        Console.WriteLine("Scissors beat paper, but lose to rocks.");
        Console.WriteLine("Rock beat scissors, but loses to paper.");
        Console.WriteLine();

        int playerWeapon = int.Parse(Console.ReadLine());

        if (playerWeapon != 1 && playerWeapon != 2 && playerWeapon != 3)
        {
            Console.WriteLine("Invalid imput. try again");
            playerWeapon = int.Parse(Console.ReadLine());
        }


        Weapon weapon = (Weapon)a;


        Console.WriteLine();
        Console.WriteLine("The enemy has chosen " + weapon);

        bool roundWin = false;

        switch (playerWeapon)
        {
            case 1:
                if (a == 1)
                {
                    Console.WriteLine("DRAW");
                    roundWin = false;
                }
                if (a == 2)
                {
                    Console.WriteLine("YOU WON THE ROUND!");
                    roundWin = true;
                }
                if (a == 3)
                {
                    Console.WriteLine("YOU LOSE THE ROUND!");
                    roundWin = false;
                }
                break;

            case 2:
                if (a == 1)
                {
                    Console.WriteLine("YOU LOSE THE ROUND!");
                    roundWin = false;
                }
                if (a == 2)
                {
                    Console.WriteLine("DRAW");
                    roundWin = false;
                }
                if (a == 3)
                {
                    Console.WriteLine("YOU WON THE ROUND!");
                    roundWin = true;
                }
                break;

            case 3:
                if (a == 1)
                {
                    Console.WriteLine("YOU WON THE ROUND!");
                    roundWin = true;
                }
                if (a == 2)
                {
                    Console.WriteLine("YOU LOSE THE ROUND!");
                    roundWin = false;
                }
                if (a == 3)
                {
                    Console.WriteLine("DRAW");
                    roundWin = false;
                }
                break;
        }

        return roundWin;
    }

    }   
}
