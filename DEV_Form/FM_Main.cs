using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DEV_FORM
{
    public partial class FM_Main : DEV_FORM.BaseMDIChildForm
    {
        public FM_Main()
        {
            InitializeComponent();
        }
        private void FM_Main_Load(object sender, EventArgs e)
        {


        }
        public override void Inquire()
        {
            base.Inquire();

            // DB HELPER 선언
            DBHelper helper = new DBHelper(false);
            try
            {
                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("SP_4_Main_S1", CommandType.StoredProcedure);

                if (dtTemp.Rows.Count == 0)
                {
                    Available.Text = null;
                    Using.Text = null;
                    Fixing.Text = null;
                    Disposal.Text = null;
                    Delay.Text = null;
                }
                else
                {
                    string UsingCar = dtTemp.Rows[2][1].ToString();
                    Using.Text = UsingCar;
                    
                    string AvailableCar = dtTemp.Rows[3][1].ToString();
                    Available.Text = AvailableCar;

                    string FixingCar = dtTemp.Rows[1][1].ToString();
                    Fixing.Text = FixingCar;

                    string DisposalCar = dtTemp.Rows[0][1].ToString();
                    Disposal.Text = DisposalCar;

                    
                }
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

        /*private void picAvailable_Click(object sender, EventArgs e)
        {
            DBHelper helper = new DBHelper(false);
            try
            {
                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("SP_4_Main_S1", CommandType.StoredProcedure);
                if (dtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("조회할 데이터가 없습니다");
                    return;
                }

                int Value = Convert.ToInt32(dtTemp.Rows[0]["RENTFLAG"]);
                MessageBox.Show($"사용가능 차량은 {Value}대 입니다.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                helper.Close();
            }
           
        }*/
    }
}
