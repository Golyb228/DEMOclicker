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
        public static bool BtnAct = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Clik_Click(object sender, EventArgs e)
        {
            score.Text = (Int32.Parse(score.Text)+1).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NOlimit = DemClkFun.DEMOcounterAsync().Result;
            clik.Enabled = NOlimit;
            actBtn.Visible = BtnAct;
        }

        private void actBtn_Click(object sender, EventArgs e)
        {
            if (BtnAct)
            {
                activation newForm = new activation();
                newForm.Show();
            }
            else 
            {
                clik.Enabled = NOlimit;
                actBtn.Visible = BtnAct;
            }
        }
    }
}
