using Msp.Infrastructure;
using Msp.Service.Mapping;
using Msp.Service.Service.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msp.App
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler(NetworkChange_NetworkAvailabilityChanged);

            AutoMapper.Mapper.Initialize(x => Mappings.Configure(x));

            StartUp _startup = new StartUp();
            _startup.Start();

            Application.Run(new MainForm());
        }


        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //SendError(e.Exception);
        }
        static void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            try
            {
                AppMain.NetworkConnected = e.IsAvailable;
                if (e.IsAvailable == false)
                {
                    //Application.ThreadException -= new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
                    DevExpress.XtraEditors.XtraMessageBox.Show("Ağ Bağlantı Hatası :" + Environment.NewLine
                        + "Programdan çıkabilir yada yarım kalan işleminiz varsa bağlantının düzelmesini bekleyebilirsiniz" + Environment.NewLine
                        + "Bağlantı sağlandığında ana ekrandaki menü aktif hale gelecektir.");
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bağlantı Sağlandı");
                }
            }
            catch (NetworkInformationException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }


    }
}
