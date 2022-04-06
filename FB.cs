using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace DEMOclicker
{
    class FB
    {
        public async static void BDFB()
        {
            IFirebaseConfig Config = new FirebaseConfig
            {
                AuthSecret = "XOZ2xaLVM0sk5NxpoHvo3aaXkR0KcDLm81rdPPDh",
                BasePath = "https://clicker-5d12e-default-rtdb.firebaseio.com/"
            };

            IFirebaseClient client = new FireSharp.FirebaseClient(Config);

            try
            {

                FirebaseResponse response1 = await client.GetTaskAsync(File.ReadAllLines(@"C:\Windows\Temp\DEMOclicker")[0]);
                Data obj = response1.ResultAs<Data>();
                if (obj.MacAddress == DemClkFun.GetMacAddress())
                {
                    Form1.NOlimit = true;
                }
            }
            catch { }
        }
    }
}
