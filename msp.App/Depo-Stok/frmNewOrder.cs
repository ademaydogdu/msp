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
using msp.App;
using Msp.Infrastructure;
using Msp.Service.Repository;
using DevExpress.XtraEditors.Controls;
using static Msp.App.Depo_Stok.frmNewOrder.orderRecStatus;

namespace Msp.App.Depo_Stok
{
    public partial class frmNewOrder : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmNewOrder()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        public FormOpenType _FormOpenType;

        private void btnFindCTransaction_Click(object sender, EventArgs e)
        {
            frmCurrentTransactions frm = new frmCurrentTransactions();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmOrdersReceived_Load(object sender, EventArgs e)
        {
            orderRecStatus cList = new orderRecStatus();
            cList.Add(new CurStatus(0, "Beklemede"));
            cList.Add(new CurStatus(1, "Tamamlandı"));


            oROrderStatusLE.Properties.DataSource = cList;
            oROrderStatusLE.Properties.DisplayMember = "Name";
            oROrderStatusLE.Properties.ValueMember = "Id";

            oROrderStatusLE.Properties.Columns.Add(new LookUpColumnInfo("Id", "ID", 20));
            oROrderStatusLE.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name", 80));

            oROrderStatusLE.Properties.TextEditStyle = TextEditStyles.Standard;

        }

        public class orderRecStatus : System.Collections.CollectionBase
        {
            public CurStatus this[int index]
            {
                get { return (CurStatus)(List[index]); }
                set { List[index] = value; }
            }

            public int Add(CurStatus value)
            {
                return List.Add(value);
            }



            public class CurStatus
            {
                private string name;
                private int id;

                public CurStatus(int _id, string _name)
                {
                    id = _id;
                    name = _name;
                }

                public string Name
                {
                    get { return name; }
                    set { name = value; }
                }

                public int Id
                {
                    get { return id; }
                    set { id = value; }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmStok frm = new frmStok();
            this.Show();
        }
    }
}