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
using Msp.Service.Repository;
using Msp.Models.Models;
using Msp.Service.Service.Settings;
using Msp.Models.Models.Utilities;
using Msp.App.Tool;

namespace Msp.App.Settings
{
    public partial class Parameters : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public Parameters()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        ParametersDTO _parameters = new ParametersDTO();
        MspTool oTool = new MspTool(); 

        private void Parameters_Load(object sender, EventArgs e)
        {
            _parameters = _repository.Run<SettingsService, ParametersDTO>(x => x.Get_Parameters());
            bs_Parameter.DataSource = _parameters;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bs_Parameter.EndEdit();
            if (oTool.get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {
                    var response = _repository.Run<SettingsService, ActionResponse<ParametersDTO>>(x => x.Save_Parameters(_parameters));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }
    }
}