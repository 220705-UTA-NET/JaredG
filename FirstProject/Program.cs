using System;

namespace FirstProject
{
    class Game
    {
        public static void Main(string[] args)
        {
            //character creation
            //Name
            string tempName;
            //1 for human, 2 for Hobbit, 3 for field mouse
            int tempRace;
            //1 for Barbarian, 2 for Wizard, 3 for Missionary
            int tempClassType;
            //string for storing player answers
            string answer = "No";
            Console.WriteLine("Create your character!");

            //Name
            do
            {
                Console.Write("What is your name?: ");
                tempName = Console.ReadLine();
                do
                {
                    Console.WriteLine("You entered " + tempName);
                    Console.Write("Is this correct? Yes or no: ");
                    answer = Console.ReadLine().ToLower();
                    if(!(answer.Equals("yes") || answer.Equals("no")))
                    {
                        Console.WriteLine("Yes or no only please.");
                    }
                }while(!(answer.Equals("yes") || answer.Equals("no")));
            }while(!answer.Equals("yes"));
            Console.WriteLine("Excellent!");

            //Race
            Console.WriteLine("Time to choose your race.");
            Console.Write("Enter 1 for Human or 2 for Hobbit: ");
            answer = Console.ReadLine();
            if(answer.Equals("1") || answer.Equals("2"))
            {
                tempRace = Convert.ToInt32(answer);
                if(tempRace == 1)
                    Console.WriteLine("You have chosen Human!");
                else
                    Console.WriteLine("You have chosen Hobbit!");
            }
            else
            {
                Console.WriteLine("You have chosen Field Mouse!");
                tempRace = 3;
            }

            //Class
            do
            {
                Console.WriteLine("Finally, what is your class?");
                do
                {
                    Console.Write("Enter 1 for Barbarian, 2 for Wizard, or 3 for Missionary: ");
                    answer = Console.ReadLine();
                    if(!(answer.Equals("1") || answer.Equals("2") || answer.Equals("3")))
                    {
                        Console.WriteLine("Please enter 1, 2 or 3.");
                    }
                }while(!(answer.Equals("1") || answer.Equals("2") || answer.Equals("3")));
            }while(!(answer.Equals("1") || answer.Equals("2") || answer.Equals("3")));
            tempClassType = Convert.ToInt32(answer);
            if(tempClassType == 1)
            {
                Console.WriteLine("You have chosen the mighty barbarian!");
            }
            else if(tempClassType == 2)
            {
                Console.WriteLine("You have chosen the learned wizard!");
            }
            else
            {
                Console.WriteLine("You have chosen the faithful missionary!");
            }

            Console.WriteLine("You are {0}, the {1} {2}!", tempName, tempRace, tempClassType);
        }
    }
}

