using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Imaging;
using Microsoft.VisualBasic;
using System.Transactions;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.IO;

namespace DEV_Form
{
    public partial class FM_Car : Form
    {
        private SqlConnection Connect = null; // 접속 정보 객체 명명
        // 접속 주소 
        private string strConn = "Data Source=222.235.141.8; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";

        public FM_Car()
        {
            InitializeComponent();
        }

        private void FM_ITEM_Load(object sender, EventArgs e)
        {
            try
            {
                #region ComboBox Connect
                // 콤보박스 품목 상세 데이터 조회 및 추가
                // 접속 정보 커넥선 에 등록 및 객체 선언
                Connect = new SqlConnection(strConn);
                Connect.Open();
                #endregion

                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;
                }

                #region ComboBox Search
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT ITEMDESC FROM TB_TESTITEM_JJG ", Connect);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                cboCost.DataSource = dtTemp;
                cboCost.DisplayMember = "ITEMDESC"; // 눈으로 보여줄 항목
                cboCost.ValueMember = "ITEMDESC"; // 실제 데이터를 처리할 코드 항목 
                cboCost.Text = "";

                #endregion

                #region Fix Date
                // 원하는 날짜 픽스
                dtpEnd.Text = string.Format("{0:yyyy-MM-01}", DateTime.Now);
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connect.Close();
            }
        }

    }
}
