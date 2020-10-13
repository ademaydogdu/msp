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
using Msp.Models.Models.Sale;

namespace Msp.App.Satis
{
    public partial class frmSpeedSatis : DevExpress.XtraEditors.XtraForm
    {
        public frmSpeedSatis()
        {
            InitializeComponent();
        }
        List<SpeedSaleProductDTO> speedSaleProducts = new List<SpeedSaleProductDTO>();


        private void frmSpeedSatis_Load(object sender, EventArgs e)
        {

        }




    }
}