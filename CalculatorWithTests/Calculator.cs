
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
            throw new NotImplementedException();
        }

        public decimal GetSubtraction()
        {
            throw new NotImplementedException();
        }

        public decimal GetMultiplication()
        {
            throw new NotImplementedException();
        }

        public decimal GetDivision()
        {
            throw new NotImplementedException();
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
