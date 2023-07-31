using System.Drawing;

namespace PACMAN.GL
{
    internal class Player : GameObject
    {
        public int SCORE = 0;
        public int LIVES = 3;
        public Player(Image DisplayImage, GameCell CurrentCell) : base(GameObjectType.PLAYER, DisplayImage)
        {
            this.CurrentCell = CurrentCell;
        }
        public GameCell Move(GameDirection direction)
        {
            GameCell currentCell = CurrentCell;
            GameCell nextCell = currentCell.NextCell(direction);
            CurrentCell = nextCell;
            if (currentCell != nextCell)
                currentCell.SetGameObject(Game.GetBlankGameObject());
            return nextCell;
        }
    }
}
