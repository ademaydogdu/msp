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
        public void Register()
        {
            string[] regRootDegerler = Registry.CurrentUser.OpenSubKey(@"Software\MSP").GetValueNames();
            if (regRootDegerler.Contains("ServiceUrl") == false)
            {
                Registry.CurrentUser.OpenSubKey(@"Software\MSP", true).SetValue("ServiceUrl", "");
            }

            AppMain.ApiPath = Registry.CurrentUser.OpenSubKey(@"Software\MSP").GetValue("ServiceUrl").ToString();

        }
    }
}
