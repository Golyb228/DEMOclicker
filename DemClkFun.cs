using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace DEMOclicker
{
    internal class Data
    {
        public string MacAddress { get; set; }
    }
    class DemClkFun
    {

        static IFirebaseConfig FBConfig = new FirebaseConfig
        {
            AuthSecret = "XOZ2xaLVM0sk5NxpoHvo3aaXkR0KcDLm81rdPPDh",
            BasePath = "https://clicker-5d12e-default-rtdb.firebaseio.com/"
        };

        static IFirebaseClient FBclient;
        public static async Task<bool> DEMOcounterAsync(int limit = 5)//Ведет счетчек запусков. Возвращает ложь, если лимит исчерпан
        {
            string path = @"C:\Windows\Temp\DEMOclicker";
            int n = 0;
            bool key = false;
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                if (lines[0].Length > 1)
                {
                    key = true;
                }
                else
                {
                    key = false;
                    n = Convert.ToInt32(lines[0]);
                }
            }
            if (!key)
            {
                if (limit > n)
                {
                    MessageBox.Show("Это демо версия программы!\nОсталось бесплатных запусков: " + (limit - n));
                    File.CreateText(path).Close();
                    File.AppendAllText(path, Convert.ToString(n + 1));
                    return true;
                }
                else
                {
                    MessageBox.Show("Приобретите полную версию программы");
                    return false;
                }
            }
            else
            {
                Form1.BtnAct = false;
                return true;
                //    string tmp = "", MacAddress = GetMacAddress();
                //    var data = new Data
                //    {
                //        MacAddress = MacAddress
                //    };
                //    FBclient = new FireSharp.FirebaseClient(FBConfig);
                //    try
                //    {
                //        FirebaseResponse response1 = await FBclient.GetTaskAsync(lines[0]);
                //        Data obj = response1.ResultAs<Data>();
                //        tmp = obj.MacAddress;
                //        if (tmp == MacAddress)
                //        {
                //            Form1.BtnAct = false;
                //            return true;
                //        }
                //    }
                //    catch { }
            }

        }
        public static string GetMacAddress()//Возвращает список MAC-адресов, подключенных к интерфейсу PCI
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
            ("Select MACAddress,PNPDeviceID FROM Win32_NetworkAdapter WHERE MACAddress IS NOT NULL AND" +
             " PNPDeviceID IS NOT NULL AND" +
             " PhysicalAdapter = true");
            ManagementObjectCollection mObject = searcher.Get();

            string macs = (from ManagementObject obj in mObject
                           let pnp = obj["PNPDeviceID"].ToString()
                           where !(pnp.Contains("ROOT\\"))
                           select obj).Select(obj => obj["MACAddress"].ToString())
                .Aggregate<string, string>(null, (mac, currentMac) => mac + currentMac + ", ");
            macs = macs.Remove(macs.Length - 1, 1);
            return !string.IsNullOrEmpty(macs) ? macs.Substring(0, macs.Length - 1) : macs;
        }
    }
}
