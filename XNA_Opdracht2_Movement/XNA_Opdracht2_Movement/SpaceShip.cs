﻿using Microsoft.Xna.Framework;

namespace Opdracht2_Movement {
    internal class SpaceShip : PhysicsObject {
        //Step 2.2: Declare a variable for the target position of the ship 

        //Step 2.3: Declare a variable for keeping track of the rotation of the ship

        public SpaceShip(string assetName, Vector2 position)
            : base(assetName, position, Vector2.Zero, 50f, Vector2.Zero, "ship") {
            layer = 2;
            //Step 2.4: Initialize this object's fields
        }

        //Step 2.5: Set the target position of the ship to the mouse position when the left button is pressed.
        //Tip: override HandleInput

        public override void Update(GameTime gameTime) {
            //Step 2.6: Move the ship to the position of the target.

            //Step 2.7: Comment step 2.6. Adapt the velocity to make the ship move to the target, include Easing.
            //Step 2.8: To speed up the ship, make it move three times as fast as before.

            //Step 2.9: Detect that the target position is reached and stop moving.

            //Step 3.0: Compute the rotation of the ship.

            base.Update(gameTime);
        }

        //Step 3.1 Override the draw function to make the game draw the rotated spaceship.
        //Tip: Look at SpriteGameObject.Draw and SpriteSheet.Draw
    }
}