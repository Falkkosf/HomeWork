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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void butTurpinat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 Jaut5 = new Form6();
            Jaut5.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            labKoment.Text = "";
            butTurpinat.Visible = false;
            butParbaudit.Left = butTurpinat.Left;
        }

        private void butParbaudit_Click(object sender, EventArgs e)
        {
            if (radio4.Checked == true)
            {
                Form1.punkti++;
                labKoment.Text = "Pareizi!";
            }
            else
            {
                labKoment.Text = "Nepareizi!";
            }
            butParbaudit.Visible = false;
            butTurpinat.Visible = true;
            radio1.Enabled = false;
            radio2.Enabled = false;
            radio3.Enabled = false;
            radio4.Enabled = false;
        }
    }
}
