using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace DEMOclicker
{
    internal class Data
    {
        public string MacAddress { get; set; }
    }
    class DemClkFun
    {
        public static bool DEMOcounter(int limit = 5)//Ведет счетчек запусков. Возвращает ложь, если лимит исчерпан
        {
            string path = @"C:\Windows\Temp\DEMOclicker";
            int n = 0;

            if (File.Exists(path))
                n = Convert.ToInt32(File.ReadAllLines(path)[0]);

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
