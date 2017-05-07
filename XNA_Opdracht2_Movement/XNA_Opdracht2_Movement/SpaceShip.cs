using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Opdracht2_Movement {
    internal class SpaceShip : PhysicsObject {
        //Step 2.2: Declare a variable for the target position of the ship 
        private GameObject targetObject;
        private float radians;

        public float Angle
        {
            get { return radians; }
            set { radians = value; }
        }
        public Vector2 AngularDirection
        {
            get
            {
                return new Vector2((float)Math.Cos(Angle), (float)Math.Sin(Angle));
            }
            set
            {
                Angle = (float)Math.Atan2(value.Y, value.X);
            }
        }

        public GameObject Target
        {
            get
            {
                return targetObject;
            }
            set
            {
                targetObject = value;
            }
        }


        public SpaceShip(string assetName, Vector2 position, GameObject target)
            : base(assetName, position, Vector2.Zero, 50f, Vector2.Zero, "ship") {
            layer = 2;
            //Step 2.4: Initialize this object's fields
            this.targetObject = target;
        }

        public override void Update(GameTime gameTime) {
            //Step 2.6: Move the ship to the position of the target.

            //Step 2.7: Comment step 2.6. Adapt the velocity to make the ship move to the target, include Easing.
            //Step 2.8: To speed up the ship, make it move three times as fast as before.

            //Step 2.9: Detect that the target position is reached and stop moving.

            //Step 3.0: Compute the rotation of the ship.
            
            if((targetObject.Position - this.Position).LengthSquared() > 1)
            {
                AngularDirection = (targetObject.Position - this.Position);
                this.Velocity = (targetObject.Position - this.Position) * 0.5f;
            }
            else
            {
                this.Velocity = Vector2.Zero;
            }

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (!visible || sprite == null)
                return;

            spriteBatch.Draw(sprite.Sprite, GlobalPosition, null, Color.White, radians - MathHelper.ToRadians(90), Origin, 1.0f, SpriteEffects.None, 0);
        }

        //Step 3.1 Override the draw function to make the game draw the rotated spaceship.
        //Tip: Look at SpriteGameObject.Draw and SpriteSheet.Draw
    }
}