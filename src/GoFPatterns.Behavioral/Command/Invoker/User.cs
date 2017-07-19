using GoFPatterns.Behavioral.Command.AbstractCommand;
using GoFPatterns.Behavioral.Command.ConcreteCommand;
using GoFPatterns.Behavioral.Command.Receiver;
using System.Collections.Generic;

namespace GoFPatterns.Behavioral.Command.Invoker
{
    public class User
    {
        public Calculator Calculator { get; private set; }
        public List<UndoableOperation> ExecutedCommands { get; private set; }
        private int _numberOfCommands = 0;

        public void Compute(char mathematicalOperator, int value)
        {
            UndoableOperation command =
                new CalculatorCommand(Calculator, mathematicalOperator, value);

            command.Execute();

            ExecutedCommands.Add(command);
            _numberOfCommands++;
        }

        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (_numberOfCommands > 0)
                {
                    var command = ExecutedCommands[--_numberOfCommands];
                    command.UnExecute();
                }
            }
        }

        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (_numberOfCommands < ExecutedCommands.Count - 1)
                {
                    var command = ExecutedCommands[_numberOfCommands++];
                    command.Execute();
                }
            }
        }
    }
}
