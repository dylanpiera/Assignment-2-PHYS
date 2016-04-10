using Microsoft.Xna.Framework;

namespace Opdracht2_Movement {
    internal class PhysicsObject : SpriteGameObject {
        private readonly float radius;
        protected Vector2 acceleration;

        public PhysicsObject(string assetName, Vector2 position, Vector2 velocity, float radius, Vector2 acceleration, string id)
            : base(assetName, 1, id) {
            this.position = position;
            this.velocity = velocity;
            origin = new Vector2(Width / 2f, Height / 2f);
            this.radius = radius;
            scale = radius * 2 / Width;
            this.acceleration = acceleration;
        }

        public override void Update(GameTime gameTime) {
            if (position.X < radius) {
                position.X = radius;
                velocity.X *= -1f;
            }
            if (position.X > GameEnvironment.Screen.X - radius) {
                position.X = GameEnvironment.Screen.X - radius;
                velocity.X *= -1f;
            }
            if (position.Y < radius) {
                position.Y = radius;
                velocity.Y *= -1f;
            }
            if (position.Y > GameEnvironment.Screen.Y - radius) {
                position.Y = GameEnvironment.Screen.Y - radius;
                velocity.Y *= -1f;
            }

            velocity += acceleration;
            base.Update(gameTime);
        }
    }
}