using System;

namespace FirstApplication
{
    class RPSGame
    {
        static void Main()
        {
            String MenuChoice;
            Console.Clear();
            Console.WriteLine("\n\t ROCK-PAPER-SCISSOR-LIZARD-SPOCK");
            Console.WriteLine("\t 1.PLAY");
            Console.WriteLine("\t 2.RULES");
            Console.WriteLine("\t 3.EXIT");
            MenuChoice=Console.ReadLine();
            switch(MenuChoice)
            {
                case "1": RPSGame obj = new RPSGame();
                          obj.Result();
                          Main();
                          break;
                case "2": Console.Clear();
                          Console.WriteLine("General Rules of the GAME are: \n 1.Rock Beats Scissors\n 2.Paper Beats Rock\n 3.Scissors Beat Paper\n 4.Rock Beats Lizard");
                          Console.WriteLine(" 5.Lizard Beats Spock\n 6.Spock Beats Scissors\n 7.Scissors Beats Lizard\n 8.Lizard Beats Paper\n 9.Spock Beats Rock\n 10.Paper Beats Spock");
                          Console.WriteLine("\n Enter any key to go back");
                          Console.ReadLine();
                          Main();
                          break;
                case "3": Console.Clear();
                          Environment.Exit(-1);
                          break;
                default: Console.WriteLine("Wrong Option.. Try Again\n Press Enter");
                         Console.WriteLine();
                         Main();
                         break;
            }
            
        }
             public void Result()
        {
            int UserChoiceI,CompChoice,UserScore=0,CompScore=0;
            String UserChoiceS;
            int i=1;
            for(i=1;i<4;i++)
            {
                Console.Clear();
                Console.WriteLine("\nRound : {0}",i);
                Console.WriteLine("Make a Choice:\n1.Rock 2.Paper 3.Scissor 4.Lizard 5.Spock 6.Main Menu");
                UserChoiceS=Console.ReadLine();

                switch(UserChoiceS)
                {
                    case "1":Console.WriteLine("You Choose Rock");
                           break;
                    case "2":Console.WriteLine("You Choose Paper");
                           break;
                    case "3":Console.WriteLine("You Choose Scissor");
                           break;
                    case "4":Console.WriteLine("You Choose Lizard");
                           break;
                    case "5":Console.WriteLine("You Choose Spock");
                           break;
                    case "6": return;
                    default:Console.WriteLine("Wrong Input! Wasted Turn");
                            Console.ReadLine();
                           continue;
                }   

                UserChoiceI=Convert.ToInt32(UserChoiceS);
                Random r = new Random();
                CompChoice=(r.Next(1,100))%5;

                switch(CompChoice)
                {
                    case 0:Console.WriteLine("Computer Choose Rock");
                           break;
                    case 1:Console.WriteLine("Computer Choose Paper");
                           break;
                    case 2:Console.WriteLine("Computer Choose Scissor");
                           break;
                    case 3:Console.WriteLine("Computer Choose Lizard");
                           break;
                    case 4:Console.WriteLine("Computer Choose Spock");
                           break;

                }

                int temp = (UserChoiceI-(CompChoice+1));
                if(temp==0)
                {
                    Console.WriteLine("It's a DRAW");
                    Console.WriteLine("Score: \t YOU: {0} \t COMPUTER: {1} \n Press Enter to Continue",UserScore,CompScore);
                    Console.ReadLine();
                }
                else if((temp==1 && (UserChoiceI != 4 || UserChoiceI !=5) ) || (temp==-2 && UserChoiceI == 1) || temp==-3 || temp==4 || (temp==2 && UserChoiceI != 3) || (temp==-1 && (UserChoiceI !=2 || UserChoiceI !=1)))
                {
                    Console.WriteLine("You WIN this Round");
                    UserScore++;
                    Console.WriteLine("Score: \t YOU: {0} \t COMPUTER: {1} \n Press Enter to Continue",UserScore,CompScore);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You LOSE this Round");
                    CompScore++;
                    Console.WriteLine("Score: \t YOU: {0} \t COMPUTER: {1} \n Press Enter to Continue",UserScore,CompScore);
                    Console.ReadLine();
                }   
            }
            if(UserScore>CompScore)
            {
                Console.WriteLine("\n\nYOU WIN :)");
                Console.ReadLine();
            }
            else if(UserScore<CompScore)
            {
                Console.WriteLine("\n\nYOU LOSE :(");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n\nIT's a TIE.");
                Console.ReadLine();
            }
        }
    }
}