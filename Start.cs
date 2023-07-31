using PACMAN.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PACMAN
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainGame mainGame = new MainGame();
            mainGame.Show();
        }

        private void insructBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Instructions instructions = new Instructions();
            instructions.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void gameLbl_Click(object sender, EventArgs e)
        {

        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
