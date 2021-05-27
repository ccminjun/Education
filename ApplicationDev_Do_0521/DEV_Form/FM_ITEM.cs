using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using DEV_Form;

namespace DEV_Form
{
    public partial class FM_ITEM : Form, ChildInterFace
    {
        public FM_ITEM()
        {
            InitializeComponent();
        }
        
        public void Inquire()
        {
            btnSearch_Click(null, null);
        }
        public void Donew()
        {
        }
        public void Delete()
        {

        }
        public void Save()
        {
        }

        private  SqlConnection Connect = null; //접속 정보 객체 명명
        string strConn = "Data Source=222.235.141.8; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FM_ITEM_Load(object sender, EventArgs e)
        {
            try
            {
                // 콤보박스 품목 상세 데이터 조회 및 추가
                // 콤보박스 품목 상세 데이터 조회 및 추가
                Connect = new SqlConnection(strConn); //접속 정보 커넥션에 등록 및 객체 선언
                Connect.Open();

                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실피해하였습니다");
                    return;
                }

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT ITEMDESC FROM TB_TESTITEM_CMJ;", Connect);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                cboItemDesc.DataSource = dtTemp;
                cboItemDesc.DisplayMember = "ITEMDESC"; // 눈으로 보여줄 항목
                cboItemDesc.ValueMember = "ITEMDESC"; // 실제 데이터를 처리할 코드 항목
                cboItemDesc.Text = "";

                //원하는 날짜 픽스
                dtpStart.Text = string.Format("{0:2020-01-01}", DateTime.Now); // 0:yyyy-MM-01 넣어도 됨

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connect.Close();
            }
        }

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
                string sItemCode = txtItemCode.Text;//품목코드
                string sItemName = txtItemName.Text;//품목 명
                string sStartDate = dtpStart.Text;  //출시 시작 일자
                string sEndDate = dtpEnd.Text;      //출시 종료 일자
                string sItemDesc = cboItemDesc.Text;//품목 상세
                string sEndFlag = "N";
                if (rboEnd.Checked == true) sEndFlag = "Y";      //단종 여부
                if (chkNameOnly.Checked == true) sItemCode = ""; //이름으로만 검색

                SqlDataAdapter Adapter = new SqlDataAdapter(   "SELECT ITEMCODE,  " +
                                                               "       ITEMNAME,  " +
                                                               "       ITEMDESC,  " +
                                                               "       ITEMDESC2, " +
                                                               "       CASE WHEN ENDFLAG = 'Y' THEN '단종' "   +
                                                               "       WHEN ENDFLAG = 'N' THEN '생산' END AS ENDFLAG," +
                                                               "       PRODATE,  "  +
                                                               "       MAKEDATE,  " +
                                                               "       MAKER,     " +
                                                               "       EDITDATE,  " +
                                                               "       EDITOR     " +
                                                               " FROM TB_TESTITEM_CMJ WITH(NOLOCK) "         +
                                                               " WHERE ITEMCODE LIKE '%" + sItemCode + "%' " +
                                                               "   AND ITEMNAME LIKE '%" + sItemName + "%' " +
                                                               "   AND ITEMDESC LIKE '%" + sItemDesc + "%' " +
                                                               "   AND ENDFLAG  = '" + sEndFlag + "'"        +
                                                               "   AND PRODATE BETWEEN  '" + sStartDate + "'AND'" + sEndDate + "'"
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
                dgvGrid.Columns["ITEMCODE"].HeaderText    = "품목 코드";
                dgvGrid.Columns["ITEMNAME"].HeaderText    = "품목 명";
                dgvGrid.Columns["ITEMDESC"].HeaderText    = "품목 상세";
                dgvGrid.Columns["ITEMDESC2"].HeaderText   = "품목 상세2";
                dgvGrid.Columns["ENDFLAG"].HeaderText     = "단종 여부";
                dgvGrid.Columns["MAKEDATE"].HeaderText    = "등록 일시";
                dgvGrid.Columns["MAKER"].HeaderText       = "등록자";
                dgvGrid.Columns["EDITDATE"].HeaderText    = "수정일시";
                dgvGrid.Columns["EDITOR"].HeaderText      = "수정자";

                // 그리드 뷰의 폭 지정
                dgvGrid.Columns[0].Width = 100;
                dgvGrid.Columns[1].Width = 100;
                dgvGrid.Columns[2].Width = 100;
                dgvGrid.Columns[3].Width = 100;
                dgvGrid.Columns[4].Width = 100;

                // 컬럼의 수정 여부를 지정한다.
                dgvGrid.Columns["ITEMCODE"].ReadOnly    = true;
                dgvGrid.Columns["MAKER"].ReadOnly       = true;
                dgvGrid.Columns["MAKEDATE"].ReadOnly    = true;
                dgvGrid.Columns["EDITOR"].ReadOnly      = true;
                dgvGrid.Columns["EDITDATE"].ReadOnly    = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"예외발생 {ex}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvGrid.Rows.Count == 0) return; // 아무것도 없을 때 추가누르면 오류나는걸 방지
            // 데이터 그리드 뷰에 신규 행 추가
            DataRow dr = ((DataTable)dgvGrid.DataSource).NewRow();  // 데이터소스에 들어가있는 데이터들을 데이터 테이블 형식으로 만들어라. 어떤형식으로? dgvGrid에 있는 열과 똑같은 형태로 만들어라.
            ((DataTable)dgvGrid.DataSource).Rows.Add(dr);
            dgvGrid.Columns["ITEMCODE"].ReadOnly = false; // 아이템코드열을 false로 주고 꼭 입력하게 하는 형태로 만든것
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
                string Itemcode = dgvGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString();
                cmd.CommandText = "DELETE TB_TESTITEM_CMJ WHERE ITEMCODE = '" + Itemcode + "'";

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 선택된 행 데이터 저장
            if (dgvGrid.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 등록 하시겠습니까?", "데이터 등록", MessageBoxButtons.YesNo) == DialogResult.No) return;

            string sItemCode      =  dgvGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString();
            string sItemName      =  dgvGrid.CurrentRow.Cells["ITEMNAME"].Value.ToString();
            string sItemDesc      =  dgvGrid.CurrentRow.Cells["ITEMDESC"].Value.ToString();
            string sItemDesc2     =  dgvGrid.CurrentRow.Cells["ITEMDESC2"].Value.ToString();
            string sItemEndFlag   =  dgvGrid.CurrentRow.Cells["ENDFLAG"].Value.ToString();
            string sProdate       =  dgvGrid.CurrentRow.Cells["PRODATE"].Value.ToString();

            SqlCommand cmd = new SqlCommand();
            SqlTransaction Tran;

            Connect = new SqlConnection(strConn);
            Connect.Open();

            // 데이터 조회 후 해당 데이터가 있는지 확인 후 UPDATE, INSERT 구문 분기
            //string sSql = "SELECT ITEMCODE FROM TB_TESTITEM_CMJ WHERE ITEMCODE = '" + sItemCode + "'";
            //SqlDataAdapter adapter = new SqlDataAdapter(sSql, Connect);
            //DataTable dtTemp = new DataTable();
            //adapter.Fill(dtTemp);

            // 트랜잭션 설정
            Tran = Connect.BeginTransaction("TestTran");
            cmd.Transaction = Tran;
            cmd.Connection = Connect;
            cmd.CommandText = "UPDATE TB_TestItem_CMJ                                         " +
                                      "    SET ITEMNAME = '"    + sItemName + "',             " +
                                      "        ITEMDESC = '"    + sItemDesc + "',             " +
                                      "        ITEMDESC2 = '"   + sItemDesc2 + "',            " +
                                      "        ENDFLAG = '"     + "N" + "',                   " +
                                      "        PRODATE = '"    + sProdate + "',              " +
                                  //    "        EDITOR = '',  "  + 
                                      "        EDITOR = '"    + Common.LogInID + "',  " +
                                      "        EDITDATE = GETDATE()     " +
                                      "  WHERE ITEMCODE = '" + sItemCode + "'" +
                                          " IF (@@ROWCOUNT =0) " +
                                      "INSERT INTO TB_TestItem_CMJ(ITEMCODE,           ITEMNAME,            ITEMDESC,           ITEMDESC2,          ENDFLAG,           PRODATE,      MAKEDATE,     MAKER) " +
                                      "VALUES('" + sItemCode + "','" + sItemName + "','" + sItemDesc + "','" + sItemDesc2 + "','" + "N" + "','" + sProdate + "',GETDATE(),'"+Common.LogInID+"')";

            //// 데이터가 있는 경우 UPDATE, 없는 경우 INSERT
            //if (dtTemp.Rows.Count == 0)
            //{
            //    //데이터가 없으니 INSERT 해라
            //    cmd.CommandText = "INSERT INTO TB_TESTITEM_CMJ (ITEMCODE, ITEMNAME, ITEMDESC, ITEMDESC2, ENDFLAG, PRODATE, MAKEDATE, MAKER)" +
            //                      "                       VALUES('" + sItemCode + "', '" + sItemName + "', '" + sItemDesc + "', '" + sItemDesc2 + "', '" + "N" + "', '" + sProdate + "', GETDATE(),'" + "" + "')";
            //}
            //else
            //{
            //    //데이터가 있으니 update 해라
            //    cmd.CommandText = "UPDATE TB_TestItem_CMJ                                " +
            //                      "    SET ITEMNAME = '"   + sItemName + "',             " +
            //                      "        ITEMDESC = '"   + sItemDesc + "',             " +
            //                      "        ITEMDESC2 = '"  + sItemDesc2 + "',            " +
            //                      "        ENDFLAG = '"    + "N" + "',          " +
            //                      "        PRODDATE = '"   + sProdate + "',              " +
            //                      "        EDITOR = '',  " +
            //                      //"        EDITOR = '"   + Commoncs.LoginUserID + "',  " +
            //                      "        EDITDATE = GETDATE()     " +
            //                      "  WHERE ITEMCODE = '"   + sItemCode                     + "'";
            //}
            cmd.ExecuteNonQuery();

            //성공 시  DB COMMIT
            Tran.Commit();
            MessageBox.Show("정상적으로 등록 하였습니다.");
            Connect.Close();
        }

        private void btnLoadPic_Click(object sender, EventArgs e)
        {
            string sImageFile = string.Empty;
            // 이미지 불러오기 및 저장, 파일 탐색기 호출

            OpenFileDialog Dialog = new OpenFileDialog();
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                sImageFile = Dialog.FileName;
                picItemImage.Tag = Dialog.FileName;
                // 지정된 파일에서 이미지를 만들어 픽쳐박스에 넣는다.
                picItemImage.Image = Bitmap.FromFile(sImageFile);
            }
        }

        private void picItemImage_Click(object sender, EventArgs e)
        {
            // 픽쳐박스 크기 최대화 및 이전 사이즈로
            if(this.picItemImage.Dock == System.Windows.Forms.DockStyle.Fill)
            {
            // 이미지가 가득채워져있는 상태이면 원상태로 바꿔라
                this.picItemImage.Dock = System.Windows.Forms.DockStyle.None;
            }
            else
            {
                // 이미지가 가득 채워져 있지 않으면 가득 채워라
                picItemImage.Dock = System.Windows.Forms.DockStyle.Fill;
                // 이미지를 가장 앞으로 가지고 온다.
                picItemImage.BringToFront();
            }
        }

        private void btnPicSave_Click(object sender, EventArgs e)
        {
            if (dgvGrid.Rows.Count == 0) return;
            if (picItemImage.Image == null) return;
            if (picItemImage.Tag.ToString() == "") return;

            if (MessageBox.Show("선택된 이미지로 등록하시겠습니까?", "이미지등록", MessageBoxButtons.YesNo) == DialogResult.No) return;


            Byte[] bImage = null;
            Connect = new SqlConnection(strConn);
            try
            {  // 파일을 불러오기 위한 피알 경로 방법 지정
                FileStream stream = new FileStream(picItemImage.Tag.ToString(),
                                                   FileMode.Open,
                                                   FileAccess.Read);
                // 읽어들인 파일을 바이너리 코드로 변환
                BinaryReader reader = new BinaryReader(stream); //Binary 0 1 0 1 로 구성된 데이터, 컴퓨터가 읽을 수 있음
                //만들어진 바이너리 코드 이미지를 Byte화 하여 저장
                bImage = reader.ReadBytes(Convert.ToInt32(stream.Length));
                reader.Close();
                stream.Close();
                // 바이너리 코드는 컴퓨터가 인식할 수 없는 0과 1로 구성된 이진코드
                // 바이트코드는 CPU가 아닌 가상머신에서 이해할 수 있는 코드

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connect;
                Connect.Open();

                String sItemCode = dgvGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString();
                cmd.CommandText = "UPDATE TB_TESTITEM_CMJ SET ITEMIMG = @IMAGE " +
                                   "WHERE ITEMCODE = @ITEMCODE";
                cmd.Parameters.AddWithValue("@IMAGE", bImage); ;
                cmd.Parameters.AddWithValue("@ITEMCODE", sItemCode);
                cmd.ExecuteNonQuery();
                Connect.Close();
                MessageBox.Show("이미지가 등록 되었습니다.");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");

            }

        }

        private void dgvGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sItemCode = dgvGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString();
            Connect = new SqlConnection(strConn);
            Connect.Open();
            try
            {  //이미지 초기화
                picItemImage.Image = null;
                string sSql = "SELECT ITEMIMG FROM TB_TESTITEM_CMJ WHERE ITEMCODE = '" + sItemCode + "' AND ITEMIMG IS NOT NULL"; //컬럼의 값이 NULL이 아닌것만 조인
                SqlDataAdapter Adapter = new SqlDataAdapter(sSql, Connect);
                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                if (dtTemp.Rows.Count == 0) return;

                byte[] bImage = null;
                bImage = (byte[])dtTemp.Rows[0]["ITEMIMG"]; //이미지를 byte화 한다.
                if (bImage != null)
                {
                    picItemImage.Image = new Bitmap(new MemoryStream(bImage)); 
                    picItemImage.BringToFront();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}");

            }
            finally
            {
                Connect.Close();
            }
        }

        private void btnPicDelete_Click(object sender, EventArgs e)
        {
            //품목에 저장된 이미지 삭제
            if (dgvGrid.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 이미지를 삭제하시겠습니까?", "이미지 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;

            SqlCommand cmd = new SqlCommand();
            Connect = new SqlConnection(strConn);
            Connect.Open();

            try
            {
                string sItemCode = dgvGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString();
                cmd.CommandText = "UPDATE TB_TESTITEM_CMJ SET ITEMIMG = null WHERE ITEMCODE = '" + sItemCode  +"'";
                cmd.Connection = Connect;
                cmd.ExecuteNonQuery();
                picItemImage.Image = null;
                MessageBox.Show("정상적으로 삭제 하였습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");

            }
        }
    }
}
