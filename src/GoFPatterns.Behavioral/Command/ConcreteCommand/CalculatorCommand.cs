using System;
using GoFPatterns.Behavioral.Command.AbstractCommand;
using GoFPatterns.Behavioral.Command.Receiver;

namespace GoFPatterns.Behavioral.Command.ConcreteCommand
{
    public class CalculatorCommand : UndoableOperation
    {
        public Calculator Calculator { get; private set; }
        public char MathematicalOperator { get; private set; }
        public int Value { get; private set; }

        public CalculatorCommand(Calculator calculator, char mathematicalOperator, int value)
        {
            Calculator = calculator;
            MathematicalOperator = mathematicalOperator;
            Value = value;
        }

        public override void Execute()
        {
            Calculator.Operation(MathematicalOperator, Value);
        }

        public override void UnExecute()
        {
            Calculator.Operation(Undo(MathematicalOperator), Value);
        }

        private char Undo(char mathematicalOperator)
        {
            switch (mathematicalOperator)
            {
                case '+':
                    return '-';
                case '-':
                    return '+';
                case '*':
                    return '/';
                case '/':
                    return '*';
                default:
                    throw new ArgumentException("mathematicalOperator");
            }
        }
    }
}
