using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebaseAdmin;
using FluentAssertions.Common;

namespace DEMOclicker
{
    public partial class activation : Form
    {
        bool dash = true;
        public activation()
        {
            InitializeComponent();
        }

        public void ConfigureServices()
        {
            // Initialize the Firebase Admin SDK
            FirebaseApp.Create();
        }

        private void key1_TextChanged(object sender, EventArgs e)
        {
            if ((key1.Text.Length == 4 || key1.Text.Length == 9) && dash)
            {
                key1.Text += "-";
                key1.SelectionStart = key1.Text.Length;
            }
        }

        private void key1_KeyDown(object sender, KeyEventArgs e)
        {
            dash = !((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete));
        }
    }
}
