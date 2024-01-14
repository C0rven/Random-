using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int lower, higher;
            int triesCount = 5;
            int userInput;
            Random rand = new Random();

            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            higher = rand.Next(number + 1, number + 10);

            Console.WriteLine($"Number from 0 to 100, hes higher {lower}" +$", but lower our {higher}.");
            Console.WriteLine($"wtf IS this number,  U have {triesCount}Trying to guess") ;

            while(triesCount -- > 0)
            {
                Console.Write("Your Answer:");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == number) 
                {
                    Console.WriteLine("You're right." + number + ".");
                    break;

                }
                else
                {
                    Console.WriteLine("You're not right, try again");
                }
            }
            if (triesCount < 0)
            {
                Console.WriteLine("U lose, u have a number " + number + ".");
            }
        }
    }
}
