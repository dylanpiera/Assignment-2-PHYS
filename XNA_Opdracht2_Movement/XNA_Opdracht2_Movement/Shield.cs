using Microsoft.Xna.Framework;

namespace Opdracht2_Movement {
    internal class Shield : PhysicsObject {
        //Step 4.2: Declare a variable for the target of the shield
        GameObject target;
        Vector2 force, gravity, springForce, acceleration;
        float mass;

        public Shield(string assetName, SpaceShip ship, Vector2 velocity)
            : base(assetName, ship.Position, velocity, 100f, Vector2.Zero, "shield") {
            //Step 4.3:Set the ship parameter as the target of this shield
            this.target = ship;
            force = Vector2.Zero;
            gravity = -Vector2.One;
            mass = 1f;
        }

        public override void Update(GameTime gameTime) {
            //Step 4.3: Calculate springing force. F = -x * k => force = -displacement * k
            springForce = (target.Position - this.Position) * 1f;
            
            force += gravity;
            force += springForce;
            acceleration = force / mass;
            force = Vector2.Zero;
            this.Velocity += acceleration;
            //Step 4.4 Use force as acceleration

            base.Update(gameTime);
        }
    }
}