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
    public partial class Form1 : Form
    {
        public static int punkti=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void butSakt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Jaut1 = new Form2();
            Jaut1.Show();
        }
    }
}
