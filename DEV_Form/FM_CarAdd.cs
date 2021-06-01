using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEV_FORM
{
    public partial class FM_CarAdd : Form
    {
        public FM_CarAdd(string carcode)
        {
            InitializeComponent();
        }

        private void FM_CarAdd_Load(object sender, EventArgs e)
        {
            DBHelper helper = new DBHelper(false);
            try
            {
                string sCarsize = cboCarSize.Text;
                string sCartype = cboCarType.Text;

                DataTable DataTemp = new DataTable();
                DataTemp = helper.FillTable("SP_4_CAR_S4", CommandType.StoredProcedure
                    , helper.CreateParameter("CARSIZE", sCarsize)
                    , helper.CreateParameter("CARTYPE",sCartype));

                cboCarSize.DataSource = DataTemp;      cboCarType.DataSource = DataTemp;
                cboCarSize.DisplayMember = "CARSIZE";  cboCarType.DisplayMember = "CARTYPE";
                cboCarSize.ValueMember = "CARSIZE";    cboCarType.ValueMember = "CARTYPE";
                cboCarSize.Text = "";                  cboCarType.Text = "";

                dtpDate.Text = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { helper.Close(); }

        }
    }
}
