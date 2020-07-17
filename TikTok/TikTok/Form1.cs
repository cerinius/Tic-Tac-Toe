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

        

        public TicTac()
        {
            InitializeComponent();
        }


        private void button_click(object sender, EventArgs e)
        {

            Button gamebutton = (Button)sender;
            if (gamebutton.Text == "")
            {
                if (clickedbutton)
                    gamebutton.Text = "X";
                else
                    gamebutton.Text = "O";
                clickedbutton = !clickedbutton;

            }

        }
        


    }
}
