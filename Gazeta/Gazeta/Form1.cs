using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private F2 gazeta;
        private void button1_Click(object sender, EventArgs e)
        {
            gazeta = new F2();
            gazeta.Visible = true;
        }
        private F4 gazet;
        private void button2_Click(object sender, EventArgs e)
        {
            gazet = new F4();
            gazet.Visible = true;
        }
        private F6 gaze;
        private void button3_Click(object sender, EventArgs e)
        {
            gaze = new F6();
            gaze.Visible = true;

        }
        private F10 gaz;
        private void button4_Click(object sender, EventArgs e)
        {
            gaz = new F10();
            gaz.Visible = true;
        }
    }
}
