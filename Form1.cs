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
        readonly bool NOlimit = true;
        readonly string MacAddress = DemClkFun.GetMacAddress();

        public Form1()
        {
            InitializeComponent();
            NOlimit = DemClkFun.DEMOcounter();
        }

        private void Clik_Click(object sender, EventArgs e)
        {
            score.Text = (Int32.Parse(score.Text)+1).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clik.Enabled = NOlimit;
            textBox1.Text = MacAddress;
        }

        private void actBtn_Click(object sender, EventArgs e)
        {
            activation newForm = new activation();
            newForm.Show();
        }
    }
}
