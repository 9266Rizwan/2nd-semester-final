using System.Drawing;

namespace PACMAN.GL
{
    internal abstract class Enemy : GameObject
    {
        public Enemy(GameObjectType type, Image displayImage) : base(type, displayImage)
        {
        }
        public abstract GameCell Move();
    }
}
