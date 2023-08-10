using Pesto.Core;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var game = new Game("Server"))
            {
                game.Start();
            }
        }
    }
}
