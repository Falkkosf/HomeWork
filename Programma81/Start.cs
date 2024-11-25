using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Programma81
{
    
    public partial class Start : Form
    {
        string UserName;
        public static DateTime EnterTime;

        public Start()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UserName = textBox1.Text;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (UserName.Length >= 3)
            {
                this.Hide();
                Form1 Jaut2 = new Form1();
                Jaut2.Show();
                File.WriteAllText("rezultati.txt", "User Name: " + UserName + "\nTime: " + DateTime.Now.TimeOfDay + "\nDate: " + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day);
                DateTime EnterTime = DateTime.Now;
            }

        }
    }
}
