using System;
using System.Collections.Generic;
using System.Text;



namespace CalculatorWithTests
{
    public class Program
    {
        static decimal GetDecimalAnswerFromUser(string question)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            decimal answer = decimal.Parse(response);
            return answer;
        }

        static string UsersChoiceResponse(string answer)
        {
            string usersAnswerChoice = Console.ReadLine();
            return usersAnswerChoice;
        }


        static void Main(string[] args)
        {
            Calculator test = new Calculator();

            //Console.WriteLine("What number would you like to use for our test?");
            //string firstNumberResponse = Console.ReadLine();
            test.UsersFirstNumber = GetDecimalAnswerFromUser("What number would you like to use for our test?");


            string usersChoice = " ";

            while (usersChoice != "Q")
            {
                Console.WriteLine("What would you like to do with this number:");

                Console.WriteLine("Add?");
                Console.WriteLine("Subtract?");
                Console.WriteLine("Multiply?");
                Console.WriteLine("Divide?");
                Console.WriteLine("Factorial?");

                string usersAnswerChoice = Console.ReadLine();
                    
        
                if (usersAnswerChoice.ToUpper() == "ADD")
                {
                    test.Addition = GetDecimalAnswerFromUser("How much would you like to add to this number?");
                    decimal additionTotal = test.GetAdditionTotal();


                    Console.WriteLine(" " + test.UsersFirstNumber + " + " + test.Addition + " = " + additionTotal + "");
                }
                else if (usersAnswerChoice.ToUpper() == "SUBTRACT")
                {
                    test.Subtraction = GetDecimalAnswerFromUser("How much would you like to subtract from this number?");
                    decimal subtractionTotal = test.GetSubtractionTotal();


                    Console.WriteLine(" " + test.UsersFirstNumber + " - " + test.Subtraction + " = " + subtractionTotal + "");
                }
                else if (usersAnswerChoice.ToUpper() == "MULTIPLY")
                {
                    test.Multiplication = GetDecimalAnswerFromUser("okay, by what number?");
                    decimal multiplicationTotal = test.GetMultiplicationTotal();


                    Console.WriteLine(" " + test.UsersFirstNumber + " * " + test.Multiplication + " = " + multiplicationTotal + "");
                }
                else if (usersAnswerChoice.ToUpper() == "DIVIDE") 
                {
                    test.Division = GetDecimalAnswerFromUser("by how much?");
                    decimal divisionTotal = test.GetDivisionTotal();

                    
                    Console.WriteLine(" " + test.UsersFirstNumber + " / " + test.Division + " = " + divisionTotal + "");
                }
                else if(usersAnswerChoice.ToUpper() == "FACTORIAL")
                {
                    int firstUsersNumber = decimal.ToInt32(test.UsersFirstNumber);
                    int factorTotal;

                    factorTotal = test.GetFactorialTotal(firstUsersNumber);


                    Console.WriteLine("The factor total for " + test.UsersFirstNumber + " is " + factorTotal + "!");

                }

                Console.WriteLine("The test is finished running!");
                return;
            }
            


            //Console.WriteLine("How much would you like to add to this number?");
            //string numberBeingAdded = Console.ReadLine();
            //test.Addition = GetDecimalAnswerFromUser("How much would you like to add to this number?");

            
            //decimal additionSum = test.UsersFirstNumber + test.Addition;
            //Console.WriteLine(additionSum);

            
            //Console.WriteLine("How much would you like to subtract from this number?");
            //string numberBeingSubtracted = Console.ReadLine();
            //test.Subtraction = decimal.Parse(numberBeingSubtracted);

            //decimal subtractionSum = test.UsersFirstNumber - test.Subtraction;
            //Console.WriteLine(subtractionSum);



            //Console.WriteLine("okay, by what number?");
            //string numberBeingMultiplied = Console.ReadLine();
            //test.Multiplication = decimal.Parse(numberBeingMultiplied);

            //decimal multipiliedSum = test.UsersFirstNumber * test.Multiplication;
            //Console.WriteLine(multipiliedSum);




            //Console.WriteLine("by how much?");
            //string numberBeingDivided = Console.ReadLine();
            //test.Division = decimal.Parse(numberBeingDivided);

            //decimal dividedSum = test.UsersFirstNumber / test.Division;
            //Console.WriteLine(dividedSum);

            

        }
    }
}
