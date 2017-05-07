#region Using Statements

using Microsoft.Xna.Framework;

#endregion

namespace Opdracht2_Movement {
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class BouncingGameWorld : GameEnvironment {
        public BouncingGameWorld() {
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent() {
            base.LoadContent();

            screen = new Point(1080, 720);
            SetFullScreen(false);
            gameStateManager.AddGameState("playingState", new PlayingState());

            gameStateManager.SwitchTo("playingState");
            IsMouseVisible = true;
        }
    }
}
