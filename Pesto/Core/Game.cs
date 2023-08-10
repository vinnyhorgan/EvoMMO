using System;
using Raylib_cs;
using Pesto.Utility;

namespace Pesto.Core
{
    public class Game : IDisposable
    {
        public static Game Instance;

        public Game(string title = "Pesto Game", int width = 800, int height = 600, int targetFps = 60)
        {
            Logger.Init(true);

            Raylib.SetConfigFlags(ConfigFlags.FLAG_WINDOW_RESIZABLE | ConfigFlags.FLAG_WINDOW_ALWAYS_RUN | ConfigFlags.FLAG_MSAA_4X_HINT);
            Raylib.InitWindow(width, height, title);
            Raylib.SetWindowMinSize(width, height);
            Raylib.SetTargetFPS(targetFps);

            Raylib.InitAudioDevice();

            Instance = this;
        }

        public void Dispose()
        {
            Raylib.CloseAudioDevice();
            Raylib.CloseWindow();
        }

        public void Start()
        {
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.BLACK);

                Raylib.EndDrawing();
            }
        }
    }
}
