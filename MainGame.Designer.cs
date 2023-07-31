namespace PACMAN
{
    partial class MainGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.LivesBox = new System.Windows.Forms.TextBox();
            this.LivesLabel = new System.Windows.Forms.Label();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.playerHealth = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.enemy1Health = new System.Windows.Forms.ProgressBar();
            this.enemy4Health = new System.Windows.Forms.ProgressBar();
            this.enemy3Health = new System.Windows.Forms.ProgressBar();
            this.enemy2Health = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EnemyLoop = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Interval = 200;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // LivesBox
            // 
            this.LivesBox.BackColor = System.Drawing.Color.Black;
            this.LivesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LivesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesBox.ForeColor = System.Drawing.Color.White;
            this.LivesBox.Location = new System.Drawing.Point(245, 489);
            this.LivesBox.Margin = new System.Windows.Forms.Padding(2);
            this.LivesBox.Name = "LivesBox";
            this.LivesBox.ReadOnly = true;
            this.LivesBox.Size = new System.Drawing.Size(67, 22);
            this.LivesBox.TabIndex = 5;
            this.LivesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LivesLabel
            // 
            this.LivesLabel.AutoSize = true;
            this.LivesLabel.BackColor = System.Drawing.Color.Transparent;
            this.LivesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesLabel.ForeColor = System.Drawing.Color.White;
            this.LivesLabel.Location = new System.Drawing.Point(167, 489);
            this.LivesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LivesLabel.Name = "LivesLabel";
            this.LivesLabel.Size = new System.Drawing.Size(67, 24);
            this.LivesLabel.TabIndex = 4;
            this.LivesLabel.Text = "LIVES";
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.BackColor = System.Drawing.Color.Black;
            this.mainMenuBtn.FlatAppearance.BorderSize = 3;
            this.mainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.mainMenuBtn.ForeColor = System.Drawing.Color.Red;
            this.mainMenuBtn.Location = new System.Drawing.Point(1005, 8);
            this.mainMenuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(134, 38);
            this.mainMenuBtn.TabIndex = 7;
            this.mainMenuBtn.Text = "MENU";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(2, 489);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(81, 24);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "SCORE";
            // 
            // ScoreBox
            // 
            this.ScoreBox.BackColor = System.Drawing.Color.Black;
            this.ScoreBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreBox.ForeColor = System.Drawing.Color.White;
            this.ScoreBox.Location = new System.Drawing.Point(85, 489);
            this.ScoreBox.Margin = new System.Windows.Forms.Padding(2);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.ReadOnly = true;
            this.ScoreBox.Size = new System.Drawing.Size(67, 22);
            this.ScoreBox.TabIndex = 3;
            this.ScoreBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScoreBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // playerHealth
            // 
            this.playerHealth.Location = new System.Drawing.Point(502, 500);
            this.playerHealth.Name = "playerHealth";
            this.playerHealth.Size = new System.Drawing.Size(161, 12);
            this.playerHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.playerHealth.TabIndex = 9;
            this.playerHealth.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 489);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "HEALTH";
            // 
            // enemy1Health
            // 
            this.enemy1Health.Location = new System.Drawing.Point(992, 124);
            this.enemy1Health.Name = "enemy1Health";
            this.enemy1Health.Size = new System.Drawing.Size(142, 10);
            this.enemy1Health.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemy1Health.TabIndex = 11;
            this.enemy1Health.Value = 100;
            // 
            // enemy4Health
            // 
            this.enemy4Health.Location = new System.Drawing.Point(992, 304);
            this.enemy4Health.Name = "enemy4Health";
            this.enemy4Health.Size = new System.Drawing.Size(142, 10);
            this.enemy4Health.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemy4Health.TabIndex = 13;
            this.enemy4Health.Value = 100;
            // 
            // enemy3Health
            // 
            this.enemy3Health.Location = new System.Drawing.Point(992, 251);
            this.enemy3Health.Name = "enemy3Health";
            this.enemy3Health.Size = new System.Drawing.Size(142, 10);
            this.enemy3Health.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemy3Health.TabIndex = 14;
            this.enemy3Health.Value = 100;
            // 
            // enemy2Health
            // 
            this.enemy2Health.Location = new System.Drawing.Point(992, 184);
            this.enemy2Health.Name = "enemy2Health";
            this.enemy2Health.Size = new System.Drawing.Size(142, 10);
            this.enemy2Health.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemy2Health.TabIndex = 15;
            this.enemy2Health.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(988, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enemy4 Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(988, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Enemy3 Health";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(988, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Enemy2 Health";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(988, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Enemy1 Health";
            // 
            // EnemyLoop
            // 
            this.EnemyLoop.Enabled = true;
            this.EnemyLoop.Interval = 500;
            this.EnemyLoop.Tick += new System.EventHandler(this.enemyLoop_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PACMAN.Properties.Resources.images;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(307, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 312);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1178, 538);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enemy2Health);
            this.Controls.Add(this.enemy3Health);
            this.Controls.Add(this.enemy4Health);
            this.Controls.Add(this.enemy1Health);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerHealth);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.LivesBox);
            this.Controls.Add(this.LivesLabel);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.ScoreLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHOOTING TIME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.TextBox LivesBox;
        private System.Windows.Forms.Label LivesLabel;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.TextBox ScoreBox;
        private System.Windows.Forms.ProgressBar playerHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar enemy1Health;
        private System.Windows.Forms.ProgressBar enemy4Health;
        private System.Windows.Forms.ProgressBar enemy3Health;
        private System.Windows.Forms.ProgressBar enemy2Health;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer EnemyLoop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

