namespace Pesto.Core
{
    public class Game
    {
        private static Game _instance;

        private Game()
        {

        }

        public static Game Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Game();
                }

                return _instance;
            }
        }
    }
}
