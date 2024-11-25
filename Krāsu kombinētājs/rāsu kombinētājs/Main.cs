using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rāsu_kombinētājs
{
    public partial class Main : Form
    {
        Color BackGround = Color.White;
        


        public Main()
        {
            InitializeComponent();
        }

        private void button_ApplyChange_Click(object sender, EventArgs e)
        {
            this.BackColor = BackGround;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackGround = Color.Black;
            pictureBox_ColorPreview.BackColor = BackGround;
        } 
        private void buttonBlack_Click(object sender, EventArgs e)
        {
            BackGround = Color.Black;
            pictureBox_ColorPreview.BackColor = BackGround;
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            BackGround = Color.White;
            pictureBox_ColorPreview.BackColor = BackGround;
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            BackGround = Color.Red;
            pictureBox_ColorPreview.BackColor = BackGround;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            BackGround = Color.Green;
            pictureBox_ColorPreview.BackColor = BackGround;
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            BackGround = Color.Blue;
            pictureBox_ColorPreview.BackColor = BackGround;
        }

        

        private void button_ChooseColor_Click(object sender, EventArgs e)
        {
            panelColors.Enabled = !panelColors.Enabled;
            panelColors.Visible = !panelColors.Visible;
        }

        private void buttonColorApplyText_Click(object sender, EventArgs e)
        {
            this.ForeColor = BackGround;
        }
    }
}
