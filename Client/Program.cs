using Pesto.Core;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var game = new Game("Client"))
            {
                game.Start();
            }
        }
    }
}
