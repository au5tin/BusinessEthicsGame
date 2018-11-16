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
            else if (e.KeyCode == Keys.E && getNPC() != null)
            {
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
            int r = rand.Next(0, 2);
            posedQuestion.Text = String.Format(npc.questions[r].Item1, npc.name);
        }
    }

    public class NPC
    {
        public Tuple<String, int>[] questions = {
            new Tuple<String, int>("{0} is walking by a pond and notices a child drowing", 0),
            new Tuple<String, int>("{0} was talking to Lynda and noticed something strange", 0)
            //new Tuple<String, int>("", 0),
            //new Tuple<String, int>("", 0),
            //new Tuple<String, int>("", 0),
            //new Tuple<String, int>("", 0)
        };

        public Tuple<String, String, String>[] answers = {
            new Tuple<String, String, String>("Save", "Call", "Ignore"),
            new Tuple<String, String, String>("Really?", "How?", "Yeet") };
            //new Tuple<String, String, String>("", "", ""),
            //new Tuple<String, String, String>("", "", ""),
            //new Tuple<String, String, String>("", "", ""),
            //new Tuple<String, String, String>("", "", "")};

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
