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
            else Stat(nickname, age, roundCount, winCount, score);


        }




        public static void Stat(string name, int a, int rounds, int wins, int s)
        {
            Console.WriteLine();
            Console.WriteLine("STATISTICS");
            Console.WriteLine();
            Console.WriteLine("Playr: " + name + " Age: " + a);
            Console.WriteLine();
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
            Console.Clear();

            //////////////////////////////////////////////// roun 1
            int AIweapon = rand.Next(1, 4);
            bool result = playRound(1, AIweapon);
            rounds++;
            if (result) s++;
            Console.WriteLine("Press any key to contitue.");
            Console.ReadLine();
            Console.Clear();

            /////////////////////////////////////////////// round 2
            AIweapon = rand.Next(1, 4);
            result = playRound(2, AIweapon);
            rounds++;
            if (result) s++;
            Console.WriteLine("Press any key to contitue.");
            Console.ReadLine();
            Console.Clear();

            /////////////////////////////////////////////// roun 3
            AIweapon = rand.Next(1, 4);
            result = playRound(3, AIweapon);
            rounds++;
            if (result) s++;
            Console.WriteLine("Press any key to contitue.");
            Console.ReadLine();
            Console.Clear();

            /////////////////////////////////////

            if (s >= 2)
            {
                Console.WriteLine("***************** YOU WON THE BATTLE *****************");
                Console.WriteLine();
                Console.WriteLine(Praise()); 
                wins++;
            }
            else
            {
                Console.WriteLine(".................. YOU LOSE THE BATTLE ................");
                Console.WriteLine();
                Console.WriteLine(Encouragement());
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to contitue.");
            Console.ReadLine();
            Console.Clear();

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
            Console.WriteLine("  [][] ");
            Console.WriteLine("[][][][]");
            Console.WriteLine("  [][]");
            Console.WriteLine();
            Console.WriteLine("2 - Scissors");
            Console.WriteLine("[]  [][] ");
            Console.WriteLine("[][]");
            Console.WriteLine("[]  [][]");
            Console.WriteLine();
            Console.WriteLine("3 - Paper");
            Console.WriteLine("[][][][] ");
            Console.WriteLine("[]    []");
            Console.WriteLine("[][][][]");
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

            Console.Clear();

            Weapon weapon = (Weapon)a;


            switch (playerWeapon)
            {
                case 1:
                    Console.WriteLine("  [][] ");
                    Console.WriteLine("[][][][]");
                    Console.WriteLine("  [][]");
                    break;

                case 2:
                    Console.WriteLine("[]  [][] ");
                    Console.WriteLine("[][]");
                    Console.WriteLine("[]  [][]");
                    break;

                case 3:
                    Console.WriteLine("[][][][] ");
                    Console.WriteLine("[]    []");
                    Console.WriteLine("[][][][]");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("    VS");
            Console.WriteLine();

            switch (a)
            {
                case 1:
                    Console.WriteLine("  [][] ");
                    Console.WriteLine("[][][][]");
                    Console.WriteLine("  [][]");
                    break;

                case 2:
                    Console.WriteLine("[]  [][] ");
                    Console.WriteLine("[][]");
                    Console.WriteLine("[]  [][]");
                    break;

                case 3:
                    Console.WriteLine("[][][][] ");
                    Console.WriteLine("[]    []");
                    Console.WriteLine("[][][][]");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("The enemy has chosen " + weapon);
            Console.WriteLine();

            Console.WriteLine();
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
            //
            return roundWin;


        }

        public static string Praise()
        {
            Random rand = new Random();
            int messageNum = rand.Next(1, 4);
            string message = "";

            switch (messageNum)
            {
                case 1:
                    message = "Perfectly! You did a great job!";
                    break;

                case 2:
                    message = "Unbelievable! Your skills are impeccable!";
                    break;

                case 3:
                    message = "You are a real champion! ";
                    break;

            }

        return message;
        }


        public static string Encouragement()
        {
            Random rand = new Random();
            int messageNum = rand.Next(1, 4);
            string message = "";

            switch (messageNum)
            {
                case 1:
                    message = "Every failed step is an opportunity to learn and grow!";
                    break;

                case 2:
                    message = "Gather your strength and come back even stronger!";
                    break;

                case 3:
                    message = "It's important to rise up and keep going!";
                    break;

            }

            return message;
        }












    }   
}
