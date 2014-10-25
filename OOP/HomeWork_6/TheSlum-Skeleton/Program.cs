using TheSlum.GameEngine;

namespace TheSlum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new MyGameEngine();
            engine.Run();
        }
    }
}
