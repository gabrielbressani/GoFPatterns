using GoFPatterns.Behavioral.Command.Invoker;

namespace GoFPatterns.Behavioral.Command
{
    public class RealWorld
    {
        public static void Run()
        {
            var user = new User();

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            user.Undo(4);
            user.Redo(3);
        }
    }
}
