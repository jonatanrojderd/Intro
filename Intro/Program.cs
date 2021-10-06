using System;

namespace Intro
{
    class Program
    {
        private static ConsoleColor _originalTextColor;
        
        static void Main(string[] args)
        {
            _originalTextColor = Console.ForegroundColor;
            
            Calculator calculator = new Calculator();

            bool runApplication = true;
            while (runApplication)
            {
                SetTextColor(_originalTextColor);
                
                Console.WriteLine("Please enter an integer:");
                string input = Console.ReadLine();
                bool leftHandSideParsed = double.TryParse(input, out double leftHandSide);

                while (leftHandSideParsed == false)
                {
                    Console.WriteLine("Please enter an integer: ");
                    input = Console.ReadLine();
                    leftHandSideParsed = double.TryParse(input, out leftHandSide);
                }

                Console.WriteLine("Please enter another one:");
                input = Console.ReadLine();
                bool rightHandSideParsed = double.TryParse(input, out double rightHandSide);
                while (rightHandSideParsed == false)
                {
                    Console.WriteLine("That is not valid, enter an integer.");
                    input = Console.ReadLine();
                    rightHandSideParsed = double.TryParse(input, out rightHandSide);
                }

                Console.WriteLine("Please enter +, -, / or *.");
                ConsoleKeyInfo selectedOperator = Console.ReadKey(true);
                while (selectedOperator.KeyChar != '+' &&
                       selectedOperator.KeyChar != '-' &&
                       selectedOperator.KeyChar != '/' &&
                       selectedOperator.KeyChar != '*')
                {
                    Console.WriteLine("Please enter +, -, / or *.");
                    selectedOperator = Console.ReadKey();
                }

                double result;
                if (selectedOperator.KeyChar == '+')
                {
                    result = calculator.Add(leftHandSide, rightHandSide);
                }
                else if (selectedOperator.KeyChar == '-')
                {
                    result = calculator.Subtract(leftHandSide, rightHandSide);
                }
                else if (selectedOperator.KeyChar == '/')
                {
                    if (rightHandSide != 0)
                    {
                        result = calculator.Divide(leftHandSide, rightHandSide);
                    }
                    else
                    {
                        SetTextColor(ConsoleColor.Yellow);
                        Console.WriteLine("Cannot divide by zero!");
                        continue;
                    }
                }
                else if (selectedOperator.KeyChar == '*')
                {
                    result = calculator.Multiply(leftHandSide, rightHandSide);
                }
                else
                {
                    result = 0;
                }

                Console.WriteLine("The result is: " + result);

                Console.WriteLine("Do you wanna exit the program?\n[Y]es, [N]o.");
                if (Console.ReadKey(true).KeyChar == 'y')
                {
                    runApplication = false;
                }
            }
        }

        private static void SetTextColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
    }

    public class Calculator
    {
        public double Add(double leftHandSide, double rightHandSide)
        {
            return leftHandSide + rightHandSide;
        }

        public double Subtract(double leftHandSide, double rightHandSide) => leftHandSide - rightHandSide;

        public double Divide(double leftHandSide, double rightHandSide)
        {
            return leftHandSide / rightHandSide;
        }

        public double Multiply(double leftHandSide, double rightHandSide)
        {
            return leftHandSide * rightHandSide;
        }
    }
}