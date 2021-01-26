using System;

namespace Uppgift_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGenerator = new Random();
            int userPick;
            int computerPick;
            int userPoints = 0;
            int computerPoints = 0;                        
            bool repeat = true; 
            string YesOrNo;

            Console.WriteLine("Welcome to rock, paper, scissor!\n");

            while (repeat == true)
            {           
            
                Console.WriteLine("Press 1 for rock, 2 for paper & 3 for scissor");
            
                userPick = Convert.ToInt32(Console.ReadLine());
                computerPick = numberGenerator.Next(1,4);
            
                switch(userPick)           
                {
                    case 1:
                    if (computerPick == 1)
                    {
                        Console.WriteLine("The computer chose rock, it's a draw! No points. Current standing: \nUser: " + userPoints + "\nComputer: "  + computerPoints);
                    }
                    if (computerPick == 2)
                    {
                        computerPoints++;
                        Console.WriteLine("The computer chose paper, the computer wins! Current standing: \nUser: " + userPoints + "\nComputer: "  + computerPoints);
                    }
                    if (computerPick == 3)
                    {
                        userPoints++;
                        Console.WriteLine("The computer chose scissor, the user wins! Current standing: \nUser: " + userPoints + "\nComputer: "  + computerPoints);
                    }
                    break;

                    case 2:
                    if (computerPick == 1)
                    {
                        userPoints++;
                        Console.WriteLine("The computer chose rock, the user wins! Current standing: \nUser: " + userPoints + "\nComputer: "  + computerPoints);
                    }
                    if (computerPick == 2)
                    {
                        Console.WriteLine("The computer chose paper, it's a draw! No points. Current standing: \nUser: " + userPoints + "\nComputer: "  + computerPoints);
                    }
                    if (computerPick == 3)
                    {
                        computerPoints++;
                        Console.WriteLine("The computer chose scissor, the computer wins! Current standing: \nUser: " + userPoints + "\nComputer: "  + computerPoints);
                    }
                    break;

                    case 3:
                    if (computerPick == 1)
                    {
                        computerPoints++;
                        Console.WriteLine("The computer chose rock, the computer wins! Current standing: \nUser: " + userPoints + "\nComputer: "  + computerPoints);
                    }
                    if (computerPick == 2)
                    {
                        userPoints++;
                        Console.WriteLine("The computer chose, the user wins! Current standing: \nUser: " + userPoints + "\nComputer: "  + computerPoints);
                    }
                    if (computerPick == 3)
                    {
                        Console.WriteLine("The computer chose scissor, it's a draw! No points. Current standing: \nUser: " + userPoints + "\nComputer: "  + computerPoints);
                    }
                    break;

                    default: 
                        Console.WriteLine("Something went wrong");
                    break;
                } 

                Console.WriteLine("Wanna play again? y/n");
                Console.WriteLine("\n");
                YesOrNo = Console.ReadLine();

                if (YesOrNo=="n" || YesOrNo=="N" )
                {
                    repeat = false;
                    Console.WriteLine("Bye bye!");
                }                    
            }
            Console.ReadKey();
        }
    }        
}