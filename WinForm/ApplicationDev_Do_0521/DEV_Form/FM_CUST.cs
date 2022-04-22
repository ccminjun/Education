using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEV_Form;

namespace DEV_Form
{
    public partial class FM_CUST : Form
    {
        public FM_CUST()
        {
            InitializeComponent();
        }

        private SqlConnection Connect = null; //접속 정보 객체 명명
        string strConn = "Data Source=61.105.9.203; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Connect = new SqlConnection(strConn);
                Connect.Open();
                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실피해하였습니다");
                    return;
                }

                //조회를 위한 파라메터 특징
                string sCustCode = txtCustCode.Text;//품목코드
                string sCustName = txtCustName.Text;//품목 명
                string sStartDate = dtpStart.Text;  //거래 시작 일자
                string sEndDate = dtpEnd.Text;      //거래 종료 일자
                string schkname = "V";
                string sProduct = "상용차 부품";

                if (rdoProduct2.Checked == true) sProduct = "자동차부품"; //이름으로만 검색
                else if (rdoProduct3.Checked == true) sProduct = "절삭가공"; //이름으로만 검색
                else if (rdoProduct4.Checked == true) sProduct = "펌프압축"; //이름으로만 검색


                if (chkName.Checked == false) schkname = "C"; //이름으로만 검색


                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT    CUSTCODE,  " +
                                                               "       CUSTTYPE,  " +
                                                               "       CUSTNAME,  " +
                                                               "       BIZCLASS, "  +
                                                               "       BIZTYPE,"    +
                                                               "       USEFLAG,"   +
                                                               "       FIRSTDATE, " +
                                                               "       MAKEDATE,  " +
                                                               "       MAKER,     " +
                                                               "       EDITDATE,  " +
                                                               "       EDITOR     " +
                                                               " FROM TB_CUST_CMJ WITH(NOLOCK) " +
                                                               " WHERE CUSTCODE LIKE '%" + sCustCode + "%' " +
                                                               "   AND CUSTNAME LIKE '%" + sCustName + "%' " +
                                                               "   AND CUSTTYPE LIKE '%" + schkname + "%' "  +
                                                               "   AND BIZTYPE LIKE '%" + sProduct + "%' "   
                                                               , Connect);
                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);
                    
                if (dtTemp.Rows.Count == 0)
                {
                    dgvGrid.DataSource = null;
                    return;
                }
                dgvGrid.DataSource = dtTemp; //데이터 그리드 뷰테 데이터 테이블 등록

                // 그리드뷰의 헤더 명칭 선언
                dgvGrid.Columns["CUSTCODE"].HeaderText = "거래처 코드";
                dgvGrid.Columns["CUSTTYPE"].HeaderText = "거래처 타입";
                dgvGrid.Columns["CUSTNAME"].HeaderText = "거래처 명";
                dgvGrid.Columns["BIZCLASS"].HeaderText = "업태";
                dgvGrid.Columns["BIZTYPE"].HeaderText = "종목";
                dgvGrid.Columns["USEFLAG"].HeaderText = "사용 여부";
                dgvGrid.Columns["FIRSTDATE"].HeaderText = "거래 일자";
                dgvGrid.Columns["MAKEDATE"].HeaderText = "등록 일시";
                dgvGrid.Columns["MAKER"].HeaderText = "등록자";
                dgvGrid.Columns["EDITDATE"].HeaderText = "수정일시";
                dgvGrid.Columns["EDITOR"].HeaderText = "수정자";

                // 그리드 뷰의 폭 지정
                dgvGrid.Columns[0].Width = 100;
                dgvGrid.Columns[1].Width = 100;
                dgvGrid.Columns[2].Width = 100;
                dgvGrid.Columns[3].Width = 100;
                dgvGrid.Columns[4].Width = 100;

                // 컬럼의 수정 여부를 지정한다.
                dgvGrid.Columns["CUSTCODE"].ReadOnly = true;
                dgvGrid.Columns["MAKER"].ReadOnly = true;
                dgvGrid.Columns["MAKEDATE"].ReadOnly = true;
                dgvGrid.Columns["EDITOR"].ReadOnly = true;
                dgvGrid.Columns["EDITDATE"].ReadOnly = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"예외발생 {ex}");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 선택된 행을 삭제한다.
            if (this.dgvGrid.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 삭제 하시겠습니까", "데이터삭제", MessageBoxButtons.YesNo)
                == DialogResult.No) return;

            SqlCommand cmd = new SqlCommand();
            SqlTransaction tran;

            Connect = new SqlConnection(strConn);
            Connect.Open();

            // 트랜잭션 관리를 위한 권한 위임
            tran = Connect.BeginTransaction("TranStart");
            cmd.Transaction = tran;
            cmd.Connection = Connect;

            try
            {
                string CustCode = dgvGrid.CurrentRow.Cells["CUSTCODE"].Value.ToString();
                cmd.CommandText = "DELETE TB_CUST_CMJ WHERE CUSTCODE = '" + CustCode + "'";

                cmd.ExecuteNonQuery();

                // 성공 시 DB Commit
                tran.Commit();
                MessageBox.Show("정상적으로 삭제 하였습니다.");
                btnSearch_Click(null, null); // 데이터 재조회

            }
            catch
            {
                tran.Rollback();
                MessageBox.Show("데리터 삭제에 실패 하였습니다.");

            }
            finally
            {
                Connect.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvGrid.Rows.Count == 0) return; // 아무것도 없을 때 추가누르면 오류나는걸 방지
            // 데이터 그리드 뷰에 신규 행 추가
            DataRow dr = ((DataTable)dgvGrid.DataSource).NewRow();  // 데이터소스에 들어가있는 데이터들을 데이터 테이블 형식으로 만들어라. 어떤형식으로? dgvGrid에 있는 열과 똑같은 형태로 만들어라.
            ((DataTable)dgvGrid.DataSource).Rows.Add(dr);
            dgvGrid.Columns["CUSTCODE"].ReadOnly = false; // 아이템코드열을 false로 주고 꼭 입력하게 하는 형태로 만든것
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvGrid.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 등록 하시겠습니까?", "데이터 등록", MessageBoxButtons.YesNo) == DialogResult.No) return;

            string sCustCode  = dgvGrid.CurrentRow.Cells["CUSTCODE"].Value.ToString();
            string schkname   = dgvGrid.CurrentRow.Cells["CUSTTYPE"].Value.ToString();
            string sCustName  = dgvGrid.CurrentRow.Cells["CUSTNAME"].Value.ToString();
            string sProduct   = dgvGrid.CurrentRow.Cells["BIZCLASS"].Value.ToString();
            string sProduct2   = dgvGrid.CurrentRow.Cells["BIZTYPE"].Value.ToString();
            string sItemFlag  = dgvGrid.CurrentRow.Cells["USEFLAG"].Value.ToString();
            string sProdate   = dgvGrid.CurrentRow.Cells["FIRSTDATE"].Value.ToString();

            SqlCommand cmd = new SqlCommand();
            SqlTransaction Tran;

            Connect = new SqlConnection(strConn);
            Connect.Open();

            // 트랜잭션 설정
            Tran = Connect.BeginTransaction("TestTran");
            cmd.Transaction = Tran;
            cmd.Connection = Connect;
            cmd.CommandText = "UPDATE TB_CUST_CMJ                                               " +
                                      "    SET CUSTCODE    = '" + sCustCode + "',               " +
                                      "        CUSTTYPE    = '" + schkname + "',                " +
                                      "        CUSTNAME    = '" + sCustName + "',               " +
                                      "        BIZCLASS    = '" + sProduct + "',                " +
                                      "        BIZTYPE     = '" + sProduct2 + "',               " +
                                      "        USEFLAG     = '" + sItemFlag + "',               " +
                                      "        FIRSTDATE   = '" + sProdate + "',                " +   

                                      //    "        EDITOR = '',  "  + 
                                      "        EDITOR = '" + DEV_Form.Common.LogInID + "',  " +
                                      "        EDITDATE = GETDATE()     " +
                                      "  WHERE ITEMCODE = '" + sCustCode + "'" +
                                          " IF (@@ROWCOUNT =0) " +
                                      "INSERT INTO TB_CUST_CMJ(CUSTCODE,           CUSTTYPE,            CUSTNAME,           BIZCLASS,          BIZTYPE,           USEFLAG,             FIRSTDATE,      MAKEDATE,     MAKER) " +
                                           "VALUES(      '" + sCustCode + "', '" + schkname + "',  '" + sCustName + "', '" + sProduct + "','" + sProduct2 + "','" + sItemFlag + "', '" + sProdate + "',GETDATE(),'" + Common.LogInID + "')";


            cmd.ExecuteNonQuery();

            //성공 시  DB COMMIT
            Tran.Commit();
            MessageBox.Show("정상적으로 등록 하였습니다.");
            Connect.Close();
        }
    }

}


