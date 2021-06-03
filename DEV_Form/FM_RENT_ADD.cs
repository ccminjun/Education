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
    public partial class FM_RENT_ADD : BaseMDIChildForm
    {
        public FM_RENT_ADD()
        {
            InitializeComponent();
            this.Tag = "NONE";
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            FM_SearchCar formCar = new FM_SearchCar();
            formCar.ShowDialog();
            if (formCar.Tag.ToString() != "") txtCarID.Text = formCar.Tag.ToString();
            else txtCarID.Text = "";

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FM_SearchClient formClient = new FM_SearchClient();
            formClient.ShowDialog();
            if (formClient.Tag.ToString() != "") txtClientID.Text = formClient.Tag.ToString();
            else txtClientID.Text = "";
        }

        private void FM_RENT_ADD_Load(object sender, EventArgs e)
        {
            DBHelper helper = new DBHelper(false);
            try
            {
                string sInsurance = cmbInsurance.Text;

                DataTable DataTemp = new DataTable();
                DataTemp = helper.FillTable("SP_4_Rent_S2", CommandType.StoredProcedure, helper.CreateParameter("INSURANCETYPE", sInsurance));

                cmbInsurance.DataSource = DataTemp;
                cmbInsurance.DisplayMember = "INSURANCETYPE";
                cmbInsurance.ValueMember = "INSURANCETYPE";
                cmbInsurance.Text = "";

                dtpRentStart.Text = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
                dtpRentEnd.Text = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { helper.Close(); }



        }

        private void btnCost_Click(object sender, EventArgs e)
        {

            if (dtpRentStart == null) return;
            if (dtpRentEnd == null) return;
            if (txtClientID == null) return;
            if (txtCarID == null) return;

            TimeSpan ts;

            string rStart = dtpRentStart.Value.ToShortDateString();
            string rEnd = dtpRentEnd.Value.ToShortDateString();

            DateTime startDay = Convert.ToDateTime(rStart);
            DateTime endDay = Convert.ToDateTime(rEnd);

            ts = endDay - startDay;

            int day = ts.Days;




            DBHelper helper = new DBHelper(false);
            try
            {

                string sCarcode = txtCarID.Text;
                DataTable DataTemp = new DataTable();
                DataTemp = helper.FillTable("SP_4_Rent_S3", CommandType.StoredProcedure, helper.CreateParameter("CARCODE", sCarcode));
                int Value = Convert.ToInt32(DataTemp.Rows[0][0]);


                
                if (cmbInsurance.Text == "일반 보험")
                { txtExpCost.Text = $"{day * Value + 10000}"; }
                else
                { txtExpCost.Text = $"{day * Value + 20000}"; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                helper.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtClientID.Text == "") return;
            Rent.sID = txtClientID.Text.ToString();

            if (this.txtCarID.Text == "") return;
            Rent.sCarID = txtCarID.Text.ToString();

            if (this.dtpRentStart.Text == "") return;
            Rent.sDate1 = dtpRentStart.Text.ToString();

            if (this.dtpRentEnd.Text == "") return;
            Rent.sDate2 = dtpRentEnd.Text.ToString();

            if (this.cmbInsurance.Text == "") return;
            Rent.sInsur = cmbInsurance.Text.ToString();

            if (this.txtExpCost.Text == "") return;
            Rent.sCost = txtExpCost.Text.ToString();

            this.Tag = "SAVE";
            this.Close();
        }
    }
}
