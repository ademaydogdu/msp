using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Deployment.Application;

namespace Msp.App.App
{
    public partial class UpdateProgress : DevExpress.XtraEditors.XtraForm
    {
        public UpdateProgress()
        {
            InitializeComponent();

            Text = "Güncelleme kontrol ediliyor...";

            ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
            ad.CheckForUpdateCompleted += OnCheckForUpdateCompleted;
            ad.CheckForUpdateProgressChanged += OnCheckForUpdateProgressChanged;

            ad.CheckForUpdateAsync();
        }
        private void OnCheckForUpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
        {
            lblStatus.Text = String.Format("İndriliyor: {0}. {1:D}K of {2:D}K İndirildi.", GetProgressString(e.State), e.BytesCompleted / 1024, e.BytesTotal / 1024);
            progressBar1.Value = e.ProgressPercentage;
        }

        string GetProgressString(DeploymentProgressState state)
        {
            if (state == DeploymentProgressState.DownloadingApplicationFiles)
            {
                return "Uygulama Dosyaları";
            }
            if (state == DeploymentProgressState.DownloadingApplicationInformation)
            {
                return "Uygulama Bilgileri";
            }
            return "Güncelleme Bilgileri";
        }

        private void OnCheckForUpdateCompleted(object sender, CheckForUpdateCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("ERROR: Could not retrieve new version of the application. Reason: \n" + e.Error.Message + "\nPlease report this error to the system administrator.");
                return;
            }
            if (e.Cancelled)
            {
                MessageBox.Show("The update was cancelled.");
            }

            // Ask the user if they would like to update the application now. 
            if (e.UpdateAvailable)
            {
                if (!e.IsUpdateRequired)
                {
                    long updateSize = e.UpdateSizeBytes;
                    DialogResult dr = MessageBox.Show(string.Format("Yeni Bir güncelleme mevcut ({0}K) .", updateSize / 1024), "Yeni güncelleme", MessageBoxButtons.OK);
                    BeginUpdate();
                }
                else
                {
                    MessageBox.Show("A mandatory update is available for your application. We will install the update now, after which we will save all of your in-progress data and restart your application.");
                    BeginUpdate();
                }
            }
            //else
            //{
            //    ShowMainForm();
            //}
        }

        // Show the main application form 


        private void BeginUpdate()
        {
            Text = "Güncelleme indiriliyor...";
            ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
            ad.UpdateCompleted += ad_UpdateCompleted;
            ad.UpdateProgressChanged += ad_UpdateProgressChanged;

            ad.UpdateAsync();
        }

        void ad_UpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
        {
            String progressText = String.Format("{0:D}K nın {1:D}K indirildi - {2:D}% tamamlandı", e.BytesCompleted / 1024, e.BytesTotal / 1024, e.ProgressPercentage);
            progressBar1.Value = e.ProgressPercentage;
            lblStatus.Text = progressText;
        }

        void ad_UpdateCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Güncelleme yarıda kesildi");
                return;
            }
            if (e.Error != null)
            {
                MessageBox.Show("Hatta: Uygulamanın son hali indirelemdi. Sebebi: \n" + e.Error.Message + "\n lütfen bu hatayı sistem yöneticisine bildiriniz.");
                return;
            }

            //DialogResult dr = MessageBox.Show("Uygulama indirme işlemi tamamlandı. Uygulamanız Yeniden başlatılacak? ", "Yendiden başlat...", MessageBoxButtons.OK);
            Application.Restart();
        }
    }
}