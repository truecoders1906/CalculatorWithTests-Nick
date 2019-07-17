using System;

namespace CalculatorWithTests
{
    class Program
    {
        static decimal GetDecimalAnswerFromUser(string question)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            decimal answer = decimal.Parse(response);
            return answer;
        }


        static void Main(string[] args)
        {
            Calculator test = new Calculator();

            Console.WriteLine("What number would you like to use for our test?");
            string firstNumberResponse = Console.ReadLine();
            test.UsersFirstNumber = GetDecimalAnswerFromUser("What number would you like to use for our test?");


            string usersChoice = " ";

            while (usersChoice != "Q")
            {
                Console.WriteLine("What would you like to do with this number?");
                Console.WriteLine("Add?");
                Console.WriteLine("Subtract?");
                Console.WriteLine("Multiply?");
                Console.WriteLine("Divide?");
                Console.WriteLine("Factorial?");
            }
            


            Console.WriteLine("How much would you like to add to this number?");
            string numberBeingAdded = Console.ReadLine();
            test.Addition = GetDecimalAnswerFromUser("How much would you like to add to this number?");

            
            decimal additionSum = test.UsersFirstNumber + test.Addition;
            Console.WriteLine(additionSum);

            
            Console.WriteLine("How much would you like to subtract from this number?");
            string numberBeingSubtracted = Console.ReadLine();
            test.Subtraction = decimal.Parse(numberBeingSubtracted);

            decimal subtractionSum = test.UsersFirstNumber - test.Subtraction;
            Console.WriteLine(subtractionSum);



            Console.WriteLine("okay, by what number?");
            string numberBeingMultiplied = Console.ReadLine();
            test.Multiplication = decimal.Parse(numberBeingMultiplied);

            decimal multipiliedSum = test.UsersFirstNumber * test.Multiplication;
            Console.WriteLine(multipiliedSum);




            Console.WriteLine("by how much?");
            string numberBeingDivided = Console.ReadLine();
            test.Division = decimal.Parse(numberBeingDivided);

            decimal dividedSum = test.UsersFirstNumber / test.Division;
            Console.WriteLine(dividedSum);

            int FactorialSum = test.Factor;

        }
    }
}
