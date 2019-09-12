using System;
using System.Text;

namespace FizzBazz
{
    public class FizzBuzz
    {
        public string FizzBuzzWoof(int input)
        {
            StringBuilder sb = new StringBuilder();
            bool isFizz = input % 3 == 0 || input.ToString().Contains("3");
            bool isBuzz = input % 5 == 0 || input.ToString().Contains("5");
            bool isWoof = input % 7 == 0 || input.ToString().Contains("7");

            if (isFizz)
            {
                sb.Append("Fizz");
            }

            if (isBuzz)
            {
                sb.Append("Buzz");
            }

            if (isWoof)
            {
                sb.Append("Woof");
            }

            if (!isFizz && !isBuzz & !isWoof)
            {
                sb.Append(input.ToString());
            }

            return sb.ToString();
        }
    }
}