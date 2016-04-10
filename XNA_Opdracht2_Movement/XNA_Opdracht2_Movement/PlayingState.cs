using Microsoft.Xna.Framework;

namespace Opdracht2_Movement {
    class PlayingState : GameObjectList {
        public PlayingState()
            : base() {
            //Step 1.1: Create a PhysicsObject, place it in the middle of the screen and add it to the PlayingState.
            // Use the sprite "PurpleSoftColorBall" and scale = 30

            //Step 2.1: Create a SpaceShip, place it in the middle of the screen and add it to the PlayingState.
            // Use the sprite "spaceship"

            //Step 4.1: Create a Shield without starting velocity, place it in the middle of the screen and add it to the PlayingState.
            //Use the sprite "GreenSoftColorBall". 
        }

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
        }

        public override void HandleInput(InputHelper inputHelper) {
            //Step 1.2: If the left mousebutton is pressed, draw the PhysicsObject of step 1.1 on the position of the mouse.

            base.HandleInput(inputHelper);
        }
    }
}