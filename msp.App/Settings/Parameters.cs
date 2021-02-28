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
using System.IO.Ports;

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

        List<SelectIdValue> report_List = new List<SelectIdValue>()
        {
            new SelectIdValue(0, "Rapor Klasik"),
            new SelectIdValue(1, "Şablon 1"),
            new SelectIdValue(2, "Şablon 2"),
            new SelectIdValue(3, "Şablon 3"),
            new SelectIdValue(4, "Şablon 4"),
            new SelectIdValue(5, "Şablon 5"),
            new SelectIdValue(6, "Şablon 6"),
            new SelectIdValue(7, "Şablon 7"),
        };


        ParametersDTO _parameters = new ParametersDTO();
        MspTool oTool = new MspTool(); 

        private void Parameters_Load(object sender, EventArgs e)
        {
            string[] portlar = SerialPort.GetPortNames();
            foreach (string portAdi in portlar)
            {
                comboBoxEdit2.Properties.Items.Add(portAdi);
            }

            lcRapor.Properties.DataSource = report_List;
            lcRapor.Properties.DisplayMember = "Value";
            lcRapor.Properties.ValueMember = "Id";

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