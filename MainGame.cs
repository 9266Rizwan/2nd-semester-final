using EZInput;
using PACMAN.GL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PACMAN
{
    public partial class MainGame : Form
    {
        Player player;
        HorizontalEnemy enemyH;
        VerticalEnemy enemyV;
        SmartEnemy enemyS;
        RandomEnemy enemyR;
        GameCell startCell;
        List<Enemy> Enemies = new List<Enemy>();
        List<Fire> PlayerBullets = new List<Fire>();
        List<Fire> EnemyBullets = new List<Fire>();
        public MainGame()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GameGrid grid = new GameGrid("maze.txt", 16, 33);

            Image playerImage = Game.GetGameObjectImage('P');
            Image enemyHImage = Game.GetGameObjectImage('H');
            Image enemyVImage = Game.GetGameObjectImage('V');
            Image enemySImage = Game.GetGameObjectImage('S');
            Image enemyRImage = Game.GetGameObjectImage('R');

            startCell = grid.GetCell(10, 18);
            player = new Player(playerImage, startCell);

            GameCell enemyHCell = grid.GetCell(1, 2);
            enemyH = new HorizontalEnemy(enemyHImage, enemyHCell, GameDirection.RIGHT);

            GameCell enemyVCell = grid.GetCell(2, 1);
            enemyV = new VerticalEnemy(enemyVImage, enemyVCell, GameDirection.DOWN);

            GameCell enemySCell = grid.GetCell(7, 5);
            enemyS = new SmartEnemy(enemySImage, enemySCell, player);

            GameCell enemyRCell = grid.GetCell(10, 10);
            enemyR = new RandomEnemy(enemyRImage, enemyRCell);

            Enemies.Add(enemyH);
            Enemies.Add(enemyV);
            Enemies.Add(enemyR);
            Enemies.Add(enemyS);

            PrintMaze(grid);

        }
        private void PrintMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
                for (int y = 0; y < grid.Columns; y++)
                {
                    GameCell cell = grid.GetCell(x, y);
                    Controls.Add(cell.PictureBox);
                }
            }
        }
        private void GameLoop_Tick(object sender, EventArgs e)
        {
            PrintScore();
            MovePlayer();
            PlayerBulletsGeneration();
            MovePlayerBullets();
            MoveEnemies();
            MoveEnemyBullets();
        }
        private void enemyLoop_Tick(object sender, EventArgs e)
        {
            EnemyBulletsGeneration();
        }
        private void MoveEnemyBullets()
        {
            foreach (Fire fire in EnemyBullets)
            {
                fire.Move();
                EnemyBulletsCollisions(fire);
            }
        }
        private void EnemyBulletsCollisions(Fire fire)
        {
            if (Collision.CollisionCheck(player, fire) && playerHealth.Value > 0)
            {
                playerHealth.Value -= 5;
            }
        }
        private void EnemyBulletsGeneration()
        {
            Image RightBullet = Properties.Resources.RightFire;
            Image DownBullet = Properties.Resources.DownFire;

            Fire fireV = new Fire(RightBullet, enemyV.CurrentCell.NextCell(GameDirection.RIGHT), GameDirection.RIGHT);
            Fire fireH = new Fire(DownBullet, enemyH.CurrentCell.NextCell(GameDirection.DOWN), GameDirection.DOWN);

            EnemyBullets.Add(fireH);
            EnemyBullets.Add(fireV);
        }
        private void PrintScore()
        {
            ScoreBox.Text = player.SCORE.ToString();
            LivesBox.Text = player.LIVES.ToString();
        }
        private void MovePlayer()
        {
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                player.Move(GameDirection.LEFT);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                player.Move(GameDirection.RIGHT);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                player.Move(GameDirection.UP);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                player.Move(GameDirection.DOWN);
            }
        }
        private void PlayerBulletsGeneration()
        {
            if (Keyboard.IsKeyPressed(Key.W))
            {
                Image UpBullet = Properties.Resources.UpFire;
                Fire fire = new Fire(UpBullet, player.CurrentCell.NextCell(GameDirection.UP), GameDirection.UP);
                PlayerBullets.Add(fire);
            }
            if (Keyboard.IsKeyPressed(Key.A))
            {
                Image LeftBullet = Properties.Resources.LeftFire;
                Fire fire = new Fire(LeftBullet, player.CurrentCell.NextCell(GameDirection.LEFT), GameDirection.LEFT);
                PlayerBullets.Add(fire);
            }
            if (Keyboard.IsKeyPressed(Key.S))
            {
                Image DownBullet = Properties.Resources.DownFire;
                Fire fire = new Fire(DownBullet, player.CurrentCell.NextCell(GameDirection.DOWN), GameDirection.DOWN);
                PlayerBullets.Add(fire);
            }
            if (Keyboard.IsKeyPressed(Key.D))
            {
                Image RightBullet = Properties.Resources.RightFire;
                Fire fire = new Fire(RightBullet, player.CurrentCell.NextCell(GameDirection.RIGHT), GameDirection.RIGHT);
                PlayerBullets.Add(fire);
            }
        }
        private void MovePlayerBullets()
        {
            foreach (Fire bullet in PlayerBullets)
            {
                bullet.Move();
                PlayerBulletsCollision(bullet);
            }
        }
        private void PlayerBulletsCollision(Fire bullet)
        {
            if (Collision.CollisionCheck(enemyV, bullet) && enemy1Health.Value > 0)
            {
                enemy1Health.Value -= 10;
                player.SCORE++;
            }
            if (Collision.CollisionCheck(enemyH, bullet) && enemy2Health.Value > 0)
            {
                enemy2Health.Value -= 10;
                player.SCORE++;
            }
            if (Collision.CollisionCheck(enemyS, bullet) && enemy3Health.Value > 0)
            {
                enemy3Health.Value -= 10;
                player.SCORE++;
            }
            if (Collision.CollisionCheck(enemyR, bullet) && enemy4Health.Value > 0)
            {
                enemy4Health.Value -= 10;
                player.SCORE++;
            }
        }
        private void MoveEnemies()
        {
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move();
                GameRunning(enemy);
            }
        }
        private void GameRunning(Enemy enemy)
        {
            if (Collision.CollisionCheck(player, enemy))
            {
                if (player.LIVES == 0 && playerHealth.Value <= 0)
                {
                    GameLoop.Enabled = false;
                    EnemyLoop.Enabled = false;
                    pictureBox1.Visible = true;
                }
                else
                {
                    if (playerHealth.Value <= 0)
                    {
                        player.LIVES--;
                        GameLoop.Enabled = false;
                        EnemyLoop.Enabled = false;
                        player.currentCell = startCell;
                        MessageBox.Show("1 Live Lost : Reamining Lives : " + player.LIVES, "Player Position Reset", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        GameLoop.Enabled = true;
                        EnemyLoop.Enabled = true;
                        playerHealth.Value = 100;
                    }
                    if (playerHealth.Value > 0)
                    {
                        playerHealth.Value -= 5;
                    }
                }
            }
            if (player.LIVES >= 1 && playerHealth.Value > 0 && enemy1Health.Value <= 0 && enemy2Health.Value <= 0 && enemy3Health.Value <= 0 && enemy4Health.Value <= 0)
            {
                GameLoop.Enabled = false;
                EnemyLoop.Enabled = false;
                pictureBox1.Visible = true;

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            GameLoop.Enabled = false;
            EnemyLoop.Enabled = false;
            DialogResult result = MessageBox.Show("Returning to Main Menu : All your progress will be lost", "SHOOT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Hide();
                Start start = new Start();
                start.Show();
            }
            else
            {
                GameLoop.Enabled = true;
                EnemyLoop.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
