using System;

namespace GoFPatterns.Behavioral.Command.Receiver
{
    public class Calculator
    {
        private int _currentValue = 0;

        public void Operation(char mathematicalOperator, int value)
        {
            switch (mathematicalOperator)
            {
                case '+':
                    _currentValue += value;
                    break;
                case '-':
                    _currentValue -= value;
                    break;
                case '*':
                    _currentValue *= value;
                    break;
                case '/':
                    _currentValue /= value;
                    break;
            }

            Console.WriteLine($"Current value = { _currentValue } (0 {mathematicalOperator} {value})");
        }
    }
}
