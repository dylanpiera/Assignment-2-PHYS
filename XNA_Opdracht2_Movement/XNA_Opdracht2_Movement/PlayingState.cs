using Microsoft.Xna.Framework;

namespace Opdracht2_Movement {
    internal class PlayingState : GameObjectList {

        private GameObjectList balls;
        SpaceShip spaceShip;
        Shield shield;
        PhysicsObject target;


        public PlayingState() {
            balls = new GameObjectList();
            //Step 1.1: Create a PhysicsObject, place it in the middle of the screen and add it to the PlayingState.
            // Use the sprite "PurpleSoftColorBall" and scale = 30
            target = new PhysicsObject("PurpleSoftColorBall", new Vector2(BouncingGameWorld.Screen.X / 2, BouncingGameWorld.Screen.Y / 2), Vector2.Zero, 30, Vector2.Zero, "Target");
            target.Visible = false;

            //Step 2.1: Create a SpaceShip, place it in the middle of the screen and add it to the PlayingState.
            // Use the sprite "spaceship"
            spaceShip = new SpaceShip("blueship3", new Vector2(BouncingGameWorld.Screen.X / 2, BouncingGameWorld.Screen.Y / 2),target);

            //Step 4.1: Create a Shield without starting velocity, place it in the middle of the screen and add it to the PlayingState.
            //Use the sprite "GreenSoftColorBall". 
            shield = new Shield("GreenSoftColorBall", spaceShip, Vector2.Zero);

            this.Add(balls);
            this.Add(target);
            this.Add(shield);
            this.Add(spaceShip);
        }

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
        }

        public override void HandleInput(InputHelper inputHelper) {
            //Step 1.2: If the left mousebutton is pressed, draw the PhysicsObject of step 1.1 on the position of the mouse.

            base.HandleInput(inputHelper);
            if(inputHelper.MouseLeftButtonPressed())
            {
                target.Position = inputHelper.MousePosition;
                target.Visible = true;
                spaceShip.Target = this.target;
            }
        }
    }
}