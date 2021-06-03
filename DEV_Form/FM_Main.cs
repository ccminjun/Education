using System.Data;

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DEV_FORM
{
    public partial class FM_Main : DEV_FORM.BaseMDIChildForm
    {
        public FM_Main()
        {
            InitializeComponent();
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

                // RENTFLAG가 N인 차량 중에서 현재날짜가 RETURNDATE보다 초과된경우 COUNT
                DataTable dtTemp2 = new DataTable();
                dtTemp2 = helper.FillTable("SP_4_Main_S2", CommandType.StoredProcedure);

                DataTable dtTemp3 = new DataTable();
                dtTemp3 = helper.FillTable("SP_4_Main_S3", CommandType.StoredProcedure);

                if (dtTemp.Rows.Count == 0 || dtTemp2.Rows.Count == 0 || dtTemp3.Rows.Count == 0)
                {
                    Available.Text = null;
                    Using.Text = null;
                    Fixing.Text = null;
                    Disposal.Text = null;
                    Delay.Text = null;
                    ClientTop1.Text = null;
                    ClientTop2.Text = null;
                    ClientTop3.Text = null;
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

                    string DelayCar = dtTemp2.Rows[0][0].ToString();
                    Delay.Text = DelayCar;

                    string Top1 = dtTemp3.Rows[0][1].ToString();
                    ClientTop1.Text = Top1;

                    string Top2 = dtTemp3.Rows[1][1].ToString();
                    ClientTop2.Text = Top2;

                    string Top3 = dtTemp3.Rows[2][1].ToString();
                    ClientTop3.Text = Top3;
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


        private void MakeColumnChart()
        {
            DBHelper helper = new DBHelper(false);
            DataTable dtTemp1 = new DataTable();
            DataTable dtTemp2 = new DataTable();
            DataTable dtTemp3 = new DataTable();


            chart1.Series.Clear();
            chart2.Series.Clear();
            chart3.Series.Clear();


            dtTemp1 = helper.FillTable("SP_4_CHART_S1", CommandType.StoredProcedure, helper.CreateParameter("NONE", ""));
            if (dtTemp1.Rows.Count == 0)
            {
                return;
            }
            //데이터 테이블을 차트에 바인딩한다.
            chart1.DataBindTable(dtTemp1.DefaultView, "월");
            //바인딩 된 시리즈의 이름을 지정한다.
            chart1.Series[0].Name = "월별 총 비용";
            chart1.Series[0].Color = Color.Green;//차트의 색상변경
            chart1.Series[0].IsValueShownAsLabel = true;//차트에 값 표시
            helper.Close();

            string sYear = "2021";//  string.Format("{0:yyyy}", DateTime.Now);
            dtTemp2 = helper.FillTable("SP_4_CHART_S2", CommandType.StoredProcedure, helper.CreateParameter("YEAR", sYear));
            if (dtTemp2.Rows.Count == 0)
            {
                return;
            }
            chart2.DataBindTable(dtTemp2.DefaultView, "년");
            //바인딩 된 시리즈의 이름을 지정한다.
            chart2.Series[0].Name = "연별 총 비용";
            chart2.Series[0].Color = Color.Green;//차트의 색상변경
            chart2.Series[0].IsValueShownAsLabel = true;//차트에 값 표시
            chart2.Series[0].IsValueShownAsLabel = true;//차트에 값 표시
            helper.Close();

            dtTemp3 = helper.FillTable("SP_4_CHART_S3", CommandType.StoredProcedure, helper.CreateParameter("YEAR", sYear));
            if (dtTemp3.Rows.Count == 0)
            {
                return;
            }
            chart3.DataBindTable(dtTemp3.DefaultView, "분기");
            //바인딩 된 시리즈의 이름을 지정한다.
            chart3.Series[0].Name = "분기별 총 비용";
            chart3.Series[0].Color = Color.Green;//차트의 색상변경
            chart3.Series[0].IsValueShownAsLabel = true;//차트에 값 표시
            helper.Close();

        }

        private void FM_Main_Load(object sender, EventArgs e)
        {
            MakeColumnChart();
        }
    }
    
}
