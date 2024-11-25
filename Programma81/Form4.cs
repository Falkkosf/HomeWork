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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void butTurpinat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 Jaut4 = new Form5();
            Jaut4.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            labKoment.Text = "";
            butTurpinat.Visible = false;
            butParbaudit.Left = butTurpinat.Left;
        }

        private void butParbaudit_Click(object sender, EventArgs e)
        {
            if (check1.Checked == true && check2.Checked == false &&
                check3.Checked == false && check4.Checked == true)
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
            check1.Enabled = false;
            check2.Enabled = false;
            check3.Enabled = false;
            check4.Enabled = false;
        }
    }
}
