using Opdracht2_Movement;

namespace XNA_Opdracht2_Movement {
#if WINDOWS || XBOX
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main(string[] args)
        {
            using (var game = new BouncingGameWorld())
            {
                game.Run();
            }
        }
    }
#endif
}

