
namespace CalculatorWithTests
{
    class Calculator
    {
        public decimal UsersFirstNumber { get; set; }
        public decimal Addition { get; set; }
        public decimal Subtraction { get; set; }
        public decimal Multiplication { get; set; }
        public decimal Division { get; set; }
        public int Factor { get; set; }

        public decimal GetAddition()
        {
            decimal additionSum = UsersFirstNumber + Addition;
            return additionSum;

        }

        public decimal GetSubtraction()
        {
            decimal subtractionSum = UsersFirstNumber - Subtraction;
            return subtractionSum;
        }

        public decimal GetMultiplication()
        {
            decimal multipiliedSum = UsersFirstNumber * Multiplication;
            return multipiliedSum;
        }

        public decimal GetDivision()
        {
            decimal dividedSum = UsersFirstNumber / Division;
            return dividedSum;
        }

        public int GetFactorial()
        {
            int num = 1;
            int usersNumber = decimal.ToInt32(UsersFirstNumber);
            while (usersNumber != 1)
            {
                num = num * usersNumber;
                usersNumber = usersNumber - 1;
            }
            return num;
        }
    }
}
