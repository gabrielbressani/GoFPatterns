namespace GoFPatterns.Behavioral.Command.AbstractCommand
{
    public abstract class UndoableOperation
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
