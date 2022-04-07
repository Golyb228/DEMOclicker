using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentAssertions.Common;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.IO;

namespace DEMOclicker
{
    public partial class activation : Form
    {
        IFirebaseConfig FBConfig = new FirebaseConfig
        {
            AuthSecret = "XOZ2xaLVM0sk5NxpoHvo3aaXkR0KcDLm81rdPPDh",
            BasePath = "https://clicker-5d12e-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient FBclient;

        bool dash = true;
        public activation()
        {
            InitializeComponent();
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

        private async void actBtn_Click(object sender, EventArgs e)
        {
            string tmp = "", MacAddress = DemClkFun.GetMacAddress();
            var data = new Data
            {
                MacAddress = MacAddress
            };
            FBclient = new FireSharp.FirebaseClient(FBConfig);
            
            
            try
            {
                FirebaseResponse response1 = await FBclient.GetTaskAsync(key1.Text);
                Data obj = response1.ResultAs<Data>();
                tmp = obj.MacAddress;
                if (tmp == "Free" || tmp == MacAddress)
                {
                    SetResponse response = await FBclient.SetTaskAsync(key1.Text, data);
                    Data result = response.ResultAs<Data>();
                    Form1.NOlimit = true;
                    File.AppendAllText(@"C:\Windows\Temp\DEMOclicker", key1.Text);
                    MessageBox.Show("Успешная активация!");
                    DemClkFun.DEMOcounterAsync();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ключ устарел!");
                }
            }
            catch
            {
                MessageBox.Show("Неверный ключ!");
            }
        }

        private void activation_Load(object sender, EventArgs e)
        {
            
        }
    }
}
