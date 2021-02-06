using Microsoft.Win32;
using Msp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.WindowsRegistry
{
    public class RegistryService 
    {
        List<string> keys = new List<string>() { @"Software\MSP" };

        public void Register()
        {
            foreach (var item in keys)
            {
                CreateRegistry(item);
            }

            string[] regRootDegerler = Registry.CurrentUser.OpenSubKey(@"Software\MSP").GetValueNames();
            if (regRootDegerler.Contains("ServiceUrl") == false)
            {
                Registry.CurrentUser.OpenSubKey(@"Software\MSP", true).SetValue("ServiceUrl", "");
            }

            AppMain.ApiPath = Registry.CurrentUser.OpenSubKey(@"Software\MSP").GetValue("ServiceUrl").ToString();

        }

        private void CreateRegistry(string path) => Registry.CurrentUser.CreateSubKey(path);
    }
}
