using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTok
{
    public partial class TicTac : Form
    {

        bool clickedbutton = true;

        
        public int count = 0;
        public int plyr1 = 0;
        public int plyr2 = 0;


        public TicTac()
        {
            InitializeComponent();
        }


        private void button_click(object sender, EventArgs e)
        {

            Button gamebutton = sender as Button;
            if (gamebutton.Text == "")
            {
                if (clickedbutton)
                {
                    gamebutton.Text = "X";
                    lblnames.Text = "Player 2";
                    count++;
                }
                else
                {
                    gamebutton.Text = "O";
                    lblnames.Text = "Player 1";
                    count++;
                }

                clickedbutton = !clickedbutton;
            }
            if ((button1.Text != "" && button1.Text == button2.Text && button1.Text == button3.Text) ||
                (button1.Text != "" && button1.Text == button4.Text && button1.Text == button7.Text) ||
                (button1.Text != "" && button1.Text == button5.Text && button1.Text == button9.Text) ||
                (button2.Text != "" && button2.Text == button5.Text && button2.Text == button8.Text) ||
                (button3.Text != "" && button3.Text == button6.Text && button3.Text == button9.Text) ||
                (button3.Text != "" && button3.Text == button5.Text && button3.Text == button7.Text) ||
                (button4.Text != "" && button4.Text == button5.Text && button4.Text == button6.Text) ||
                (button7.Text != "" && button7.Text == button8.Text && button7.Text == button9.Text))
            {
                if (count % 2 == 0)
                {
                    lblnames.Text = "Player 2";
                    MessageBox.Show("Player 2 wins");
                    plyr2++;
                    lblscore2.Text = plyr2.ToString();
                }
                else
                {
                    lblnames.Text = "Player 1";
                    MessageBox.Show("Player 1 wins");
                    plyr1++;
                    lblscore1.Text = plyr1.ToString();
                }
                playagain();
            }



        }
                

    private void Exitgame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnresetgame_Click(object sender, EventArgs e)
        {
            resetgamebtn();
            playagain();

        }
        private void Btnplayagain_Click(object sender, EventArgs e)
        {
            playagain();
        }

        public void resetgamebtn()
        {
            plyr1 = 0;
            plyr2 = 0;
            lblscore1.Text = "";
            lblscore2.Text = "";
        }
        public void playagain()
        {
            count = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            lblnames.Text = "Player 1";


        }

        
    }
}
