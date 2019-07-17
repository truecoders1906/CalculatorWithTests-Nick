using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWithTests
{
    public class Calculator
    {
        public decimal UsersFirstNumber { get; set; }
        public decimal Addition { get; set; }
        public decimal Subtraction { get; set; }
        public decimal Multiplication { get; set; }
        public decimal Division { get; set; }
        public int Factor { get; set; }

        
        public decimal GetAdditionTotal()
        {
            return UsersFirstNumber + Addition;
            //decimal additionTotal = UsersFirstNumber + Addition;
            //return additionTotal;

        }

        public decimal GetSubtractionTotal()
        {
            return UsersFirstNumber - Subtraction;
            //decimal subtractionTotal = UsersFirstNumber - Subtraction;
            //return subtractionTotal;
        }

        public decimal GetMultiplicationTotal()
        {
            return UsersFirstNumber * Multiplication;
            //decimal multipiliedTotal = UsersFirstNumber * Multiplication;
            //return multipiliedTotal;
        }

        public decimal GetDivisionTotal()
        {
            return UsersFirstNumber / Division;
            //decimal dividedTotal = UsersFirstNumber / Division;
            //return dividedTotal;
        }

        public int GetFactorialTotal(int usersNumber)
        {
            int usersNumberChoice = 1;
            
            while (usersNumber != 1)
            {
                usersNumberChoice = usersNumberChoice * usersNumber;
                usersNumber = usersNumber - 1;
            }
            return usersNumberChoice;
        }
    }
}
