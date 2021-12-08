using System;

namespace ITEA_HW3
{
    class Program
    {
        static double Task1(double A, int B)
        {
            double result = A;

            if (B == 0)
            {
                result = 1;
            }
            else
            {
                for (double i = 2; i <= B; i++)
                {
                    result *= A;
                }
            }

            return result;
        }

        static double Task3(double A)
        {
            int count = 0;

            for (int i = 1; i * i < A; i++)
            {
                ++count;
            }

            return count;
        }

        static int Task4(int A)
        {
            int result = 0;

            for (int i = A - 1; i >= 0; i--)
            {
                if (A % i == 0)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        static int Task5(int A, int B)
        {
            int sum = 0;

            if (A > B)
            {
                (A, B) = (B, A);
            }

            while (A <= B)
            {
                if (A % 7 == 0)
                {
                    sum += A;
                }

                ++A;
            }

            return sum;
        }

        static int Task6(int number)
        {
            int a = 1;
            int b = 1;
            int fictive = 0;

            for (int i = 0; i < number; i++)
            {
                a = a + b;
                fictive = b;
                b = a - fictive;
            }

            return fictive;
        }

        static int Task7(int number1, int number2)
        {
            while (number1 != 0 && number2 != 0)
            {
                if (number1 > number2)
                {
                    number1 %= number2;
                }
                else
                {
                    number2 %= number1;
                }
            }

            return number1 + number2;
        }

        static double Task8(int number)
        {
            double lowerLimit = 0;
            double upperLimit = number;
            double x = (upperLimit + lowerLimit) / 2;

            while (Math.Abs(number - x * x * x) > 0.001)
            {
                if (number < x * x * x)
                {
                    upperLimit = x;
                    x = Math.Round((upperLimit + lowerLimit) / 2, 3);
                }
                else
                {
                    lowerLimit = x;
                    x = Math.Round((upperLimit + lowerLimit) / 2, 3);
                }
            }

            return x;
        }

        static int Task9(int number)
        {
            int count = 0;

            while (number != 0)
            {
                int currentDigit = number % 10;
                number /= 10;

                if (currentDigit % 2 == 1)
                {
                    ++count;
                }
            }

            return count;
        }

        static int Task10(int number)
        {
            int newNumber = 0;

            while (number != 0)
            {
                int currentDigit = number % 10;
                number /= 10;
                newNumber *= 10;
                newNumber += currentDigit;
            }

            return newNumber;
        }

        static bool Task12(int number1, int number2)
        {
            bool result = false;

            while (number1 != 0)
            {
                int currentDigit1 = number1 % 10;
                number1 /= 10;
                int dummy_number2 = number2;

                while (dummy_number2 != 0)
                {
                    int currentDigit2 = dummy_number2 % 10;
                    dummy_number2 /= 10;

                    if (currentDigit1 == currentDigit2)
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }

        static void Main(string[] args)
        {

        }
    }
}
