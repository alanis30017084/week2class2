using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            // Task One - COMPARING INTEGERS 
            
            Console.Write("Please enter an integer: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter another integer: ");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine($"{num1} is larger than {num2}");
            }
            else if(num2 > num1)
            {
                Console.WriteLine($"{num2} is larger than {num1}");
            }
            else if(num1 == num2)
            {
                Console.WriteLine("These numbers are equal.");
            }
            else
            {
                Console.WriteLine("Oops, something went wrong.");
            }
            Console.ReadLine();
            


            //Task 2 - GUESS MY NUMBER
            /*
            Random rand = new Random ();
            int myNum = rand.Next(1,11);
            Console.WriteLine("Guess My Number\nChoose a number between 1 and 10: ");
            int userNum = int.Parse(Console.ReadLine());

            if(userNum == myNum)
            {
                Console.WriteLine("You have guessed our number.");
            }
            else
            {
                Console.WriteLine("You have guessed the incorrect number.");
                if(userNum > myNum)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                if(myNum > userNum)
                {
                    Console.WriteLine("Your guess is too low.");
                }
            }
            Console.WriteLine("Thank you for playing. Press ENTER to quit.");
            Console.ReadLine();
            */

            // TASK 3 - MARKING PROGRAM
            /*
            Console.Write("FIND MY GRADE\nPlease enter your final mark out of 100: ");
            int grade = int.Parse(Console.ReadLine());

            if(grade >89 && grade <101)
                Console.WriteLine("Your final grade is A+");
            
            else if(grade > 79 && grade < 90)
                Console.WriteLine("Your final grade is A");

            else if(grade > 69 && grade < 80)
                Console.WriteLine("Your final grade is B+");
            
            else if(grade > 59 && grade < 70)
                Console.WriteLine("Your final grade is B");
            
            else if(grade > 49 && grade < 60)
                Console.WriteLine("Your final grade is C");
            
            else if(grade > 39 && grade < 50)
                Console.WriteLine("Your final grade is D");
            
            else if(grade >= 0 && grade <40)
                Console.WriteLine("Your final grade is F");

            else
                Console.WriteLine("Invalid input. Please try again.");

            Console.WriteLine("\nPress ENTER to close program.");
            Console.ReadLine();
            */

            // TASK 4 - ODD OR EVEN
            /*
            Console.Write("Please enter a whole number: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            Console.WriteLine("Your number is even.");
            else
            Console.WriteLine("Your number is odd.");
            Console.ReadLine();
            */
            
            
        }
    }
}
