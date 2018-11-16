namespace BusinessEthicsGame
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.player = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.scoreBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.posedQuestion = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.health = new System.Windows.Forms.Label();
            this.healthBox = new System.Windows.Forms.PictureBox();
            this.WinLose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player.Image = global::BusinessEthicsGame.Properties.Resources.standing;
            this.player.InitialImage = null;
            this.player.Location = new System.Drawing.Point(344, 257);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(85, 115);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DimGray;
            this.panel.Controls.Add(this.scoreBox);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.score);
            this.panel.Controls.Add(this.health);
            this.panel.Controls.Add(this.healthBox);
            this.panel.Location = new System.Drawing.Point(0, 666);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(785, 100);
            this.panel.TabIndex = 1;
            // 
            // scoreBox
            // 
            this.scoreBox.BackColor = System.Drawing.Color.Transparent;
            this.scoreBox.Image = global::BusinessEthicsGame.Properties.Resources.star;
            this.scoreBox.Location = new System.Drawing.Point(3, 50);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(50, 50);
            this.scoreBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scoreBox.TabIndex = 4;
            this.scoreBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.posedQuestion);
            this.panel1.Location = new System.Drawing.Point(146, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 100);
            this.panel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(551, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 78);
            this.button3.TabIndex = 0;
            this.button3.Text = "Option 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onButton3Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(470, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 78);
            this.button2.TabIndex = 0;
            this.button2.Text = "Option 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onButton2Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(389, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Option 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onButton1Click);
            // 
            // posedQuestion
            // 
            this.posedQuestion.AutoSize = true;
            this.posedQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.posedQuestion.Location = new System.Drawing.Point(13, 10);
            this.posedQuestion.Name = "posedQuestion";
            this.posedQuestion.Size = new System.Drawing.Size(0, 13);
            this.posedQuestion.TabIndex = 0;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.score.Location = new System.Drawing.Point(70, 58);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(69, 33);
            this.score.TabIndex = 2;
            this.score.Text = "0/10";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.BackColor = System.Drawing.Color.Transparent;
            this.health.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.health.Location = new System.Drawing.Point(56, 10);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(83, 33);
            this.health.TabIndex = 1;
            this.health.Text = "10/10";
            this.health.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // healthBox
            // 
            this.healthBox.BackColor = System.Drawing.Color.Transparent;
            this.healthBox.Image = ((System.Drawing.Image)(resources.GetObject("healthBox.Image")));
            this.healthBox.Location = new System.Drawing.Point(3, 3);
            this.healthBox.Name = "healthBox";
            this.healthBox.Size = new System.Drawing.Size(50, 50);
            this.healthBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.healthBox.TabIndex = 0;
            this.healthBox.TabStop = false;
            // 
            // WinLose
            // 
            this.WinLose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WinLose.AutoSize = true;
            this.WinLose.BackColor = System.Drawing.Color.Transparent;
            this.WinLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinLose.ForeColor = System.Drawing.Color.Red;
            this.WinLose.Location = new System.Drawing.Point(212, 9);
            this.WinLose.Name = "WinLose";
            this.WinLose.Size = new System.Drawing.Size(0, 91);
            this.WinLose.TabIndex = 3;
            this.WinLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.BackgroundImage = global::BusinessEthicsGame.Properties.Resources.grass;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 766);
            this.Controls.Add(this.WinLose);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ethical Dilemma (Hit ESC for help)";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyPressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.onKeyReleased);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox healthBox;
        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label posedQuestion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox scoreBox;
        private System.Windows.Forms.Label WinLose;
    }
}