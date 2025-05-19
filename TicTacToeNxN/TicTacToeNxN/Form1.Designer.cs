namespace TicTacToeNxN
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Player = new System.Windows.Forms.Label();
            this.comboBoxPlayer = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Choose_Mode = new System.Windows.Forms.Label();
            this.comboBoxChooseMode = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Give_N = new System.Windows.Forms.Label();
            this.Choose_Game = new System.Windows.Forms.Label();
            this.comboBoxChooseGame = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.Player);
            this.panel1.Controls.Add(this.comboBoxPlayer);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Choose_Mode);
            this.panel1.Controls.Add(this.comboBoxChooseMode);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Give_N);
            this.panel1.Controls.Add(this.Choose_Game);
            this.panel1.Controls.Add(this.comboBoxChooseGame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 113);
            this.panel1.TabIndex = 2;
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.Cursor = System.Windows.Forms.Cursors.Default;
            this.Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Player.Location = new System.Drawing.Point(261, 23);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(110, 32);
            this.Player.TabIndex = 9;
            this.Player.Text = "Player:";
            // 
            // comboBoxPlayer
            // 
            this.comboBoxPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBoxPlayer.FormattingEnabled = true;
            this.comboBoxPlayer.Items.AddRange(new object[] {
            "X",
            "O"});
            this.comboBoxPlayer.Location = new System.Drawing.Point(387, 27);
            this.comboBoxPlayer.Name = "comboBoxPlayer";
            this.comboBoxPlayer.Size = new System.Drawing.Size(91, 28);
            this.comboBoxPlayer.TabIndex = 8;
            this.comboBoxPlayer.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.Location = new System.Drawing.Point(840, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Choose_Mode
            // 
            this.Choose_Mode.AutoSize = true;
            this.Choose_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Choose_Mode.Location = new System.Drawing.Point(57, 62);
            this.Choose_Mode.Name = "Choose_Mode";
            this.Choose_Mode.Size = new System.Drawing.Size(210, 32);
            this.Choose_Mode.TabIndex = 6;
            this.Choose_Mode.Text = "Choose Mode:";
            // 
            // comboBoxChooseMode
            // 
            this.comboBoxChooseMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBoxChooseMode.FormattingEnabled = true;
            this.comboBoxChooseMode.Items.AddRange(new object[] {
            "Player vs Player",
            "Player vs Bot"});
            this.comboBoxChooseMode.Location = new System.Drawing.Point(282, 65);
            this.comboBoxChooseMode.Name = "comboBoxChooseMode";
            this.comboBoxChooseMode.Size = new System.Drawing.Size(196, 28);
            this.comboBoxChooseMode.TabIndex = 5;
            this.comboBoxChooseMode.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(742, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // Give_N
            // 
            this.Give_N.AutoSize = true;
            this.Give_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Give_N.Location = new System.Drawing.Point(520, 62);
            this.Give_N.Name = "Give_N";
            this.Give_N.Size = new System.Drawing.Size(206, 32);
            this.Give_N.TabIndex = 3;
            this.Give_N.Text = "Give us the N:";
            this.Give_N.Visible = false;
            // 
            // Choose_Game
            // 
            this.Choose_Game.AutoSize = true;
            this.Choose_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Choose_Game.Location = new System.Drawing.Point(510, 20);
            this.Choose_Game.Name = "Choose_Game";
            this.Choose_Game.Size = new System.Drawing.Size(216, 32);
            this.Choose_Game.TabIndex = 2;
            this.Choose_Game.Text = "Choose Game:";
            // 
            // comboBoxChooseGame
            // 
            this.comboBoxChooseGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBoxChooseGame.FormattingEnabled = true;
            this.comboBoxChooseGame.Items.AddRange(new object[] {
            "3x3",
            "5x5",
            "7x7",
            "NxN"});
            this.comboBoxChooseGame.Location = new System.Drawing.Point(742, 24);
            this.comboBoxChooseGame.Name = "comboBoxChooseGame";
            this.comboBoxChooseGame.Size = new System.Drawing.Size(91, 28);
            this.comboBoxChooseGame.TabIndex = 1;
            this.comboBoxChooseGame.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(87)))), ((int)(((byte)(56)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 439);
            this.panel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1062, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(920, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Give_N;
        private System.Windows.Forms.Label Choose_Game;
        private System.Windows.Forms.ComboBox comboBoxChooseGame;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Choose_Mode;
        private System.Windows.Forms.ComboBox comboBoxChooseMode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.ComboBox comboBoxPlayer;
    }
}

