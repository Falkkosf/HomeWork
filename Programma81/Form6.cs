using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programma81
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void butRezult_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 Rezult = new Form7();
            Rezult.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            labKoment.Text = "";
            butRezult.Visible = false;
            butParbaudit.Left = butRezult.Left;
        }

        private void butParbaudit_Click(object sender, EventArgs e)
        {
            if (check1.Checked == false && check2.Checked == true &&
                check3.Checked == false && check4.Checked == true && check4.Checked == true)
            {
                Form1.punkti++;
                labKoment.Text = "Pareizi!";
            }
            else
            {
                labKoment.Text = "Nepareizi!";
            }
            butParbaudit.Visible = false;
            butRezult.Visible = true;
            check1.Enabled = false;
            check2.Enabled = false;
            check3.Enabled = false;
            check4.Enabled = false;
            check5.Enabled = false;
        }
    }
}
