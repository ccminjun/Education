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
    public partial class FM_SearchCar : BaseSearchChildForm
    {
        public FM_SearchCar()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DBHelper helper = new DBHelper(false);
            try
            {
                String sCarName = "";//차량 모델
                String sCarMaker = ""; //차량 회사
                String sCarType = "";
                String sCarSize = "";
                String startPrice = txtFirstPrice.Text; //시작가격 
                String endPrice = txtLastPrice.Text; //끝가격

                int iStartPrice = 0;
                if (startPrice == "") iStartPrice = 0;
                else iStartPrice = Int32.Parse(startPrice);

                int iEndPrice = 0;
                if (endPrice == "") iEndPrice = 3000000;
                else iEndPrice = Int32.Parse(endPrice);


                if (rdbOil.Checked == true) sCarType = "Oil";
                else if (rdbElect.Checked == true) sCarType = "Elec";
                else if (rdbLPG.Checked == true) sCarType = "LPG";
                else if (rdbHybrid.Checked == true) sCarType = "Hyb";
                else if (rdbGas.Checked == true) sCarType = "Gas";
                else sCarType = "";

                if (rdbBS.Checked == true) sCarSize = "BS";
                else if (rdbSL.Checked == true) sCarSize = "SL";
                else if (rdbSS.Checked == true) sCarSize = "SS";
                else if (rdbMS.Checked == true) sCarSize = "MS";
                else if (rdbSSUV.Checked == true) sCarSize = "SSUV";
                else if (rdbMSUV.Checked == true) sCarSize = "MSUV";
                else if (rdbBSUV.Checked == true) sCarSize = "BSUV";
                else if (rdbBRV.Checked == true) sCarSize = "BRV";

                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("SP_4_Car_S2", CommandType.StoredProcedure
                                          , helper.CreateParameter("CARNAME", sCarName)
                                          , helper.CreateParameter("CARMAKER", sCarMaker)
                                          , helper.CreateParameter("CARTYPE", sCarType)
                                          , helper.CreateParameter("CARSIZE", sCarSize)
                                          , helper.CreateParameter("STARTPRICE", iStartPrice)
                                          , helper.CreateParameter("UseFlag", "W")
                                          , helper.CreateParameter("ENDPRICE", iEndPrice));
                if(dtTemp.Rows.Count == 0)
                {
                    dgvGrid.DataSource = null;
                    MessageBox.Show("조회할 데이터가 없습니다.");
                }
                else
                {
                    //그래드 뷰에 데이터 삽입
                    dgvGrid.DataSource = dtTemp;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                helper.Close();
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (this.dgvGrid.Rows.Count == 0) return;

            this.Tag = dgvGrid.CurrentRow.Cells["CARCODE"].Value.ToString();
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void FM_SearchCar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Tag == null)
            {
                this.Tag = "";
            }
        }
    }
}
