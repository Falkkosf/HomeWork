using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Programma81
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            switch (Form1.punkti)
            {
                case 0: case 1: labRez.Text = "Pavisam vāji, tikai " + Form1.punkti + " no 5 punktiem"; break;
                case 2: case 3: labRez.Text = "Vari labāk, " + Form1.punkti + " no 5 punktiem"; break;
                case 4: labRez.Text = "Labi 4 no 5 punktiem"; break;
                case 5: labRez.Text = "Lieliski 5 no 5 punktiem"; break;
            }
            TimeSpan time = DateTime.Now.TimeOfDay - Start.EnterTime.TimeOfDay;
            labelTime.Text = "Izpildes Laiks: " + time.ToString();
            File.AppendAllText("rezultati.txt", "\nIzpildes Laiks: " + time + "\nPunkti: " + Form1.punkti);
        }
    }
}
