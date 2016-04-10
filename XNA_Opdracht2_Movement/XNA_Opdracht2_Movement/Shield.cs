﻿using Microsoft.Xna.Framework;

namespace Opdracht2_Movement {
    internal class Shield : PhysicsObject {
        //Step 4.2: Declare a variable for the target of the shield

        public Shield(string assetName, SpaceShip ship, Vector2 velocity)
            : base(assetName, ship.Position + new Vector2(30, 30), velocity, 15f, Vector2.Zero, "shield") {
            //Step 4.3:Set the ship parameter as the target of this shield
        }

        public override void Update(GameTime gameTime) {
            //Step 4.3: Calculate springing force. F = -x * k => force = -displacement * k

            //Step 4.4 Use force as acceleration

            base.Update(gameTime);
        }
    }
}