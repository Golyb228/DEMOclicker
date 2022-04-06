using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DEMOclicker
{
    public partial class Form1 : Form
    {
        public static bool NOlimit = false;
        private static bool Act = false;
        public Form1()
        {
            InitializeComponent();
            //FB.BDFB();
            if (!NOlimit)
            {
                NOlimit = DemClkFun.DEMOcounter();
                Act = true;
            }
        }

        private void Clik_Click(object sender, EventArgs e)
        {
            score.Text = (Int32.Parse(score.Text)+1).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clik.Enabled = NOlimit;
            actBtn.Enabled = !NOlimit;
        }

        private void actBtn_Click(object sender, EventArgs e)
        {
            if (NOlimit)
            {
                clik.Enabled = true;
                actBtn.Enabled = false;
            }
            else
            {
                activation newForm = new activation();
                newForm.Show();
            }
        }
    }
}
