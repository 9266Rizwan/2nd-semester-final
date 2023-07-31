using System.Drawing;

namespace PACMAN.GL
{
    internal class Fire : GameObject
    {
        GameDirection direction;
        public Fire(Image image, GameCell CurrentCell, GameDirection direction) : base(GameObjectType.ENEMY, image)
        {
            this.direction = direction;
            this.CurrentCell = CurrentCell;
        }
        public GameCell Move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.NextCell(direction);
            this.CurrentCell = nextCell;

            currentCell.SetGameObject(Game.GetBlankGameObject());
            return nextCell;
        }
    }
}
