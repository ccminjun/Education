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
            this.Tag = "NO";
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
                            , helper.CreateParameter("CARSIZE", sCarsize));

                cboCarSize.DataSource = DataTemp;
                cboCarSize.DisplayMember = "CARSIZE";
                cboCarSize.ValueMember = "CARSIZE";
                cboCarSize.Text = "";

                DataTable DataTemp1 = new DataTable();
                DataTemp1 = helper.FillTable("SP_4_CAR_S5", CommandType.StoredProcedure
                            , helper.CreateParameter("CARTYPE", sCartype));

                cboCarType.DataSource = DataTemp1;
                cboCarType.DisplayMember = "CARTYPE";
                cboCarType.ValueMember = "CARTYPE";
                cboCarType.Text = "";

                dtpDate.Text = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { helper.Close(); }

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            Car.sType = cboCarType.SelectedValue.ToString();
            Car.sSize = cboCarSize.SelectedValue.ToString();
            Car.sMaker = txtCarMaker.Text.ToString();
            Car.sName = txtCarName.Text.ToString();
            Car.sNum = txtCarNum.Text.ToString();
            Car.sPrice = txtRentPrice.Text.ToString();
            Car.sDate = dtpDate.Text.ToString();

            if (this.cboCarType.Text == "" || this.cboCarType.Text == "" || this.txtCarMaker.Text == "" || this.txtCarName.Text == "" || this.txtCarNum.Text == "" || this.txtRentPrice.Text == "" || this.dtpDate.Text == "")
            {
                MessageBox.Show("모든 값을 입력해야 추가가 가능합니다.");
                return;
            }
            this.Tag = "OKAY";
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("해당 화면을 닫으시겠습니까?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            this.Close();
        }
    }
}

