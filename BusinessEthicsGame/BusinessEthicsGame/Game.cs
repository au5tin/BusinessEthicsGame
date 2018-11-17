using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessEthicsGame
{
    
    public partial class Game : Form
    {
        public NPC[] npcs = new NPC[4];
        public Keys direction = Keys.Sleep;
        public Random rand = new Random();
        public const int numQuestions = 5;
        public int healthScore = 10;
        public int pointScore = 0;
        public int num = 0;

        public Tuple<String, int, int, int>[] questions = {
            new Tuple<String, int, int, int>("{0} is walking by a pond and notices their child and 2 stranger's children\n" +
                                   "drowning.  If {0} was a Utilitarian, what should they do?", 1, 2, -2),
            new Tuple<String, int, int, int>("{0} is the manager of a company branch.  One of their long time co-workers\n" +
                                   " is getting old and is starting to cost the business extra money.  What\n" +
                                   "should {0} do in this situation?", 1, -2, 2),
            new Tuple<String, int, int, int>("{0} is working at a company and accidentally stumbles upon some files\n" +
                                             "showing that the company is possibly stealing millions of dollars a year.\n" +
                                             "What is the best course of action for {0}?", -2,2,1),
            new Tuple<String, int, int, int>("{0} came upon a train track lever and saw 4 workers on one track and a\n" +
                                             "single worker on the other track.  A train is coming and the track is\n" +
                                             "currently set to the 4 workers. What should {0} do?", 2,1,-2),
            new Tuple<String, int, int, int>("{0} is poor and starving.  They have 2 young children and need to get food\n" +
                                             "to survive.  What should they do that would be permissible?", 1,2,-2)
        };

        public Tuple<String, String, String>[] answers = {
            new Tuple<String, String, String>("Save Their Child", "Save Stranger's Children", "Ignore the Situation"),
            new Tuple<String, String, String>("Talk With Them to Clarify Issue", "Continue With Employment", "Let Them Go"),
            new Tuple<String, String, String>("Help and Make Money", "Follow Chain of Command", "Whistle-Blow"),
            new Tuple<String, String, String>("Defer the Train to 1 Worker", "Ignore So You Weren't Involved", "Let the Train hit the 4 Workers"),
            new Tuple<String, String, String>("Beg", "Steal", "Kill")
        };

        public Game()
        {
            InitializeComponent();

            this.Load += Game_Load;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            npcs[0] = new NPC(Properties.Resources.idle1, 10, 10, "Keith");
            npcs[1] = new NPC(Properties.Resources.idle2, 700, 10, "Sally");
            npcs[2] = new NPC(Properties.Resources.idle3, 10, 520, "David");
            npcs[3] = new NPC(Properties.Resources.idle4, 700, 510, "Brian");
            foreach (var n in npcs)
            {
                n.image.SizeMode = PictureBoxSizeMode.AutoSize;
                n.image.BackColor = Color.Transparent;
                Controls.Add(n.image);
            }
        }

        private void onKeyReleased(object sender, KeyEventArgs e)
        {
            player.Image = Properties.Resources.standing;
            direction = Keys.Sleep; //Random Key
        }

        private void onKeyPressed(object sender, KeyEventArgs e)
        {
            //Escape for Help
            if (e.KeyCode == Keys.Escape)
            {
                helpForm popup = new helpForm();
                popup.Show();
            }
            //E for Interaction
            else if (e.KeyCode == Keys.E && getNPC() != null && posedQuestion.Text == "")
            {
                panel1.Focus();
                askQuestion(getNPC());
            }
            else if (direction != e.KeyCode)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        player.Image = Properties.Resources.walking_backward;
                        //NW Character from bottom
                        if (player.Top - 10 <= 140 && player.Left <= 75)
                            break;
                        //NE Character from bottom
                        if (player.Top - 10 <= 165 && player.Left >= 600)
                            break;
                        if (player.Top - 10 >= 0)
                            player.Top -= 10;
                        break;
                    case Keys.A:
                        player.Image = Properties.Resources.walking_left;
                        //NW Character from right
                        if (player.Top <= 140 && player.Left - 10 <= 75)
                            break;
                        //SW Character from right
                        if (player.Top >= 385 && player.Left - 10 <= 75)
                            break;
                        if (player.Left - 10 >= 0)
                            player.Left -= 10;
                        break;
                    case Keys.S:
                        player.Image = Properties.Resources.walking_forward;
                        //SW Character from top
                        if (player.Top + 10 >= 385 && player.Left <= 75)
                            break;
                        //SE Character from top
                        if (player.Top + 10 >= 385 && player.Left >= 600)
                            break;
                        if (player.Bottom + 10 <= DisplayRectangle.Height - 100)
                            player.Top += 10;
                        break;
                    case Keys.D:
                        player.Image = Properties.Resources.walking_right;
                        //NE Character from left
                        if (player.Top <= 165 && player.Left + 10 >= 600)
                            break;
                        //SE Character from left
                        if (player.Top >= 385 && player.Left + 10 >= 600)
                            break;
                        if (player.Right + 10 <= DisplayRectangle.Width)
                            player.Left += 10;
                        break;
                }
                direction = e.KeyCode;
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        //NW Character from bottom
                        if (player.Top - 10 <= 140 && player.Left <= 75)
                            break;
                        //NE Character from bottom
                        if (player.Top - 10 <= 165 && player.Left >= 600)
                            break;
                        if (player.Top - 10 >= 0)
                            player.Top -= 10;
                        break;
                    case Keys.A:
                        //NW Character from right
                        if (player.Top <= 140 && player.Left - 10 <= 75)
                            break;
                        //SW Character from right
                        if (player.Top >= 385 && player.Left - 10 <= 75)
                            break;
                        if (player.Left - 10 >= 0)
                            player.Left -= 10;
                        break;
                    case Keys.S:
                        //SW Character from top
                        if (player.Top + 10 >= 385 && player.Left <= 75)
                            break;
                        //SE Character from top
                        if (player.Top + 10 >= 385 && player.Left >= 600)
                            break;
                        if (player.Bottom + 10 <= DisplayRectangle.Height - 100)
                            player.Top += 10;
                        break;
                    case Keys.D:
                        //NE Character from left
                        if (player.Top <= 165 && player.Left + 10 >= 600)
                            break;
                        //SE Character from left
                        if (player.Top >= 385 && player.Left + 10 >= 600)
                            break;
                        if (player.Right + 10 <= DisplayRectangle.Width)
                            player.Left += 10;
                        break;
                }
            }
        }

        public NPC getNPC()
        {
            if (player.Top <= 150 && player.Left <= 85)
                return npcs[0];
            else if (player.Top <= 175 && player.Left >= 590)
                return npcs[1];
            else if (player.Top >= 375 && player.Left <= 85)
                return npcs[2];
            else if (player.Top >= 375 && player.Left >= 590)
                return npcs[3];
            return null;
        }

        public void askQuestion(NPC npc)
        {
            int r = num % numQuestions;
            posedQuestion.Text = String.Format(questions[r].Item1, npc.name);
            button1.Enabled = button2.Enabled = button3.Enabled = true;
            button1.Text = answers[r].Item1;
            button2.Text = answers[r].Item2;
            button3.Text = answers[r].Item3;
        }

        private void onButton1Click(object sender, MouseEventArgs e)
        {
            if (questions[num % numQuestions].Item2 > 0)
            {
                pointScore += questions[num % numQuestions].Item2;
                if (pointScore > 10)
                    pointScore = 10;
                score.Text = pointScore + "/10";
            }
            else
            {
                healthScore += questions[num % numQuestions].Item2;
                if (healthScore < 0)
                    healthScore = 0;
                health.Text = healthScore + "/10";
            }
            resetStuff();
            checkState();
        }

        private void onButton2Click(object sender, MouseEventArgs e)
        {
            if (questions[num % numQuestions].Item3 > 0)
            {
                pointScore += questions[num % numQuestions].Item3;
                if (pointScore > 10)
                    pointScore = 10;
                score.Text = pointScore + "/10";
            }
            else
            {
                healthScore += questions[num % numQuestions].Item3;
                if (healthScore < 0)
                    healthScore = 0;
                health.Text = healthScore + "/10";
            }
            resetStuff();
            checkState();
        }

        private void onButton3Click(object sender, MouseEventArgs e)
        {
            if (questions[num % numQuestions].Item4 > 0)
            {
                pointScore += questions[num % numQuestions].Item4;
                if (pointScore > 10)
                    pointScore = 10;
                score.Text = pointScore + "/10";
            }
            else
            {
                healthScore += questions[num % numQuestions].Item4;
                if (healthScore < 0)
                    healthScore = 0;
                health.Text = healthScore + "/10";
            }
            resetStuff();
            checkState();
        }

        public void checkState()
        {
            if (healthScore == 0)
            {
                WinLose.ForeColor = Color.Red;
                WinLose.Text = "You Lose";
                WinLose.Focus();
            }
            else if (pointScore == 10)
            {
                WinLose.ForeColor = Color.Yellow;
                WinLose.Text = "You Won!";
                WinLose.Focus();
            }
        }

        public void resetStuff()
        {
            num++;
            button1.Enabled = button2.Enabled = button3.Enabled = false;
            button1.Text = "Option 1";
            button2.Text = "Option 2";
            button3.Text = "Option 3";
            posedQuestion.Text = "";
            ActiveForm.Focus();
        }
    }

    public class NPC
    {
        public PictureBox image;
        public String name;
        
        public NPC(Bitmap b, int x, int y, String n)
        {
            this.name = n;
            this.image = new PictureBox();
            this.image.Image = b;
            this.image.Location = new Point(x, y);
        }
    }
}
