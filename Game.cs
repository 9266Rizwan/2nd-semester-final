using System.Drawing;

namespace PACMAN.GL
{
    internal class Game
    {
        public static GameObject GetBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, Properties.Resources.simplebox);
            return blankGameObject;
        }
        public static GameObject GetRewardGameObject()
        {
            GameObject rewardGameObject = new GameObject(GameObjectType.REWARD, Properties.Resources.pallet);
            return rewardGameObject;
        }
        public static Image GetGameObjectImage(char displayCharacter)
        {
            Image img = Properties.Resources.simplebox;
            if (displayCharacter == '|' || displayCharacter == '%')
                img = Properties.Resources.vertical;
            else if (displayCharacter == '#')
                img = Properties.Resources.horizontal;
            else if (displayCharacter == '.')
                img = Properties.Resources.pallet;
            else if (displayCharacter == 'P' || displayCharacter == 'p')
                img = Properties.Resources.player;
            else if (displayCharacter == 'H' || displayCharacter == 'h')
                img = Properties.Resources.PlaneP1;
            else if (displayCharacter == 'V' || displayCharacter == 'v')
                img = Properties.Resources.Left;
            else if (displayCharacter == 'R' || displayCharacter == 'r')
                img = Properties.Resources.ghost_red;
            else if (displayCharacter == 'S' || displayCharacter == 's')
                img = Properties.Resources.ghost_fright;

            return img;
        }
        public static Image GetGameObjectImage(string name)
        {
            Image img = Properties.Resources.simplebox;
            if (name == "vertical")
                img = Properties.Resources.vertical;
            else if (name == "horizontal")
                img = Properties.Resources.horizontal;
            else if (name == "reward")
                img = Properties.Resources.pallet;
            else if (name == "Player")
                img = Properties.Resources.PlaneP;
            else if (name == "VerticalEnemy")
                img = Properties.Resources.monster;
            else if (name == "HorizontalEnemy")
                img = Properties.Resources.Left;
            else if (name == "enemy3")
                img = Properties.Resources.ghost_red;
            else if (name == "enemy4")
                img = Properties.Resources.ghost_fright;

            return img;
        }
    }
}
