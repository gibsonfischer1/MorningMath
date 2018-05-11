using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectName = "Morning Math";
            string projectVersion = "0.1.0";
            DateTime projectDate = new DateTime(2018, 5, 12, 5, 0, 0);
            DateTime dateOnly = projectDate.Date;
            string projectOwner = "Gibson Fischer";
            string projectPublisher = "DevPlug";
            int userCount = 0;
            
            Console.WriteLine("Project Name: {0}", projectName);
            Console.WriteLine("Project Version: {0}", projectVersion);
            Console.Write("Project Date: ");
            Console.WriteLine(dateOnly.ToString("d"));
            Console.WriteLine("Project Owner: {0}", projectOwner);
            Console.WriteLine("Project Publisher: {0}", projectPublisher);
            Console.WriteLine();
            Console.WriteLine("Hello!");
            Console.WriteLine("How many questions would you like to answer?");
            Console.WriteLine("Press ENTER to continue.");
            string userChoice = Console.ReadLine();
            userCount = int.Parse(userChoice);
            userCount = Convert.ToInt32(userChoice);
            Console.WriteLine();

            
            Random random = new Random();
            int systemCount = 0;
            int userScore = 0;

        next:

            if (systemCount < userCount)
            {
                int addone = random.Next(1, 101);
                int addtwo = random.Next(1, 101);
                int systemAnswer = (addone + addtwo);

                Console.Write("What is {0} + {1}? ", addone, addtwo);
                int userInt = 0;
                string userAnswer = Console.ReadLine();
                userInt = int.Parse(userAnswer);
                userInt = Convert.ToInt32(userAnswer);

                if (userInt == systemAnswer)
                { 
                    Console.WriteLine("Good job! {0} is the correct answer!", systemAnswer);
                    userScore++;
                }
                else
                    Console.WriteLine("Sorry, that is wrong! You put {0} while the correct answer is {1}.", userInt, systemAnswer);

                Console.WriteLine();

                systemCount++;
                goto next;
            }

            if (userScore != 1)
            {
                Console.WriteLine("You got {0} questions correct out of {1}!", userScore, userCount);
            }

            Console.WriteLine("You got {0} question correct out of {1}!", userScore, userCount);
            Console.WriteLine("Thank you for playing!");
            Console.ReadLine();
        }
    }
}
