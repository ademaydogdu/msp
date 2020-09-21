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

        private void Parameters_Load(object sender, EventArgs e)
        {
            _parameters = _repository.Run<SettingsService, ParametersDTO>(x => x.Get_Parameters());
            bs_Parameter.DataSource = _parameters;
        }

    }
}