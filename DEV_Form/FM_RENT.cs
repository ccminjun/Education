using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace DEV_FORM
{
    public partial class FM_RENT : BaseMDIChildForm
    {
        private DataTable dtTempNon = new DataTable();
        private SqlConnection Connect = null;

        public FM_RENT()
        {
            InitializeComponent();
        }
        private void FM_RENT_Load(object sender, EventArgs e)
        {
            // 깡통 테이블 생성 (데이터 그리드뷰 셋팅)
            dtTempNon.Columns.Add("RENTID");
            dtTempNon.Columns.Add("CLIENTID");
            dtTempNon.Columns.Add("CARCODE");
            dtTempNon.Columns.Add("RENTSTARTDATE");
            dtTempNon.Columns.Add("RETURNDATE");
            dtTempNon.Columns.Add("REALRETURNDATE");
            dtTempNon.Columns.Add("RENTFLAG");
            dtTempNon.Columns.Add("INSURANCETYPE");
            dtTempNon.Columns.Add("COST");
            dtTempNon.Columns.Add("FIRSTDATE");
            dtTempNon.Columns.Add("MAKER");
            dtTempNon.Columns.Add("IMGCONTRACT");
            dtTempNon.Columns.Add("EXTRACOST");

            //화면이 열릴때 그리드뷰에 비어있는 데이터 테이블을 미리 등록한다.
            dgvGrid.DataSource = dtTempNon;

            // 그리드 뷰의 헤더 명칭 선언
            dgvGrid.Columns["RENTID"].HeaderText = "렌트ID";
            dgvGrid.Columns["CLIENTID"].HeaderText = "고객ID";
            dgvGrid.Columns["CARCODE"].HeaderText = "차량ID";
            dgvGrid.Columns["RENTSTARTDATE"].HeaderText = "렌트시작일";
            dgvGrid.Columns["RETURNDATE"].HeaderText = "반납예정일";
            dgvGrid.Columns["REALRETURNDATE"].HeaderText = "실제반납일";
            dgvGrid.Columns["RENTFLAG"].HeaderText = "반납여부";
            dgvGrid.Columns["INSURANCETYPE"].HeaderText = "보험종류";
            dgvGrid.Columns["COST"].HeaderText = "비용";
            dgvGrid.Columns["FIRSTDATE"].HeaderText = "추가날짜";
            dgvGrid.Columns["MAKER"].HeaderText = "관리자";
            dgvGrid.Columns["IMGCONTRACT"].HeaderText = "계약서";
            dgvGrid.Columns["EXTRACOST"].HeaderText = "추가비용";

            // 컬럼의 수정 여부를 지정한다 (수정 못하게 하겠다 = ReadOnly)
            dgvGrid.Columns["RENTID"].ReadOnly = true;
            dgvGrid.Columns["RENTSTARTDATE"].ReadOnly = true;
            dgvGrid.Columns["RETURNDATE"].ReadOnly = true;
            dgvGrid.Columns["COST"].ReadOnly = true;
        }

        public override void Inquire()
        {
            DBHelper helper = new DBHelper(false);
            try
            {
                String sRentID        = txtRentID.Text;
                String sClientName    = txtClientID.Text;
                String sCarCode       = txtCarCode.Text;
                String sRentStartDate = dtpStart.Text;
                String sReturnDate    = dtpEnd.Text;
                String sInsuranceType = "";
                String sRentFlag      = "";
                String sExtraCost = "";

                if (rdoInsur1.Checked == true) sInsuranceType = "N";
                else if (rdoInsur2.Checked == true) sInsuranceType = "S";
                else sInsuranceType = "";

                if (chkNreturn.Checked == true) sRentFlag = "N";

                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("SP_4_Rent_S1", CommandType.StoredProcedure
                                            , helper.CreateParameter("RENTID"       , sRentID)
                                            , helper.CreateParameter("CLIENTID"     , sClientName)
                                            , helper.CreateParameter("CARCODE"      , sCarCode)
                                            , helper.CreateParameter("RENTSTARTDATE", sRentStartDate)
                                            , helper.CreateParameter("RETURNDATE"   , sReturnDate)
                                            , helper.CreateParameter("RENTFLAG"     , sRentFlag)
                                            , helper.CreateParameter("INSURANCETYPE", sInsuranceType)
                                            , helper.CreateParameter("EXTRACOST", sExtraCost)
                                            );


                if (dtTemp.Rows.Count == 0)
                {
                    dgvGrid.DataSource = null;
                    MessageBox.Show("조회할 데이터가 없습니다");
                }
                else
                {
                    //그리드 뷰에 데이터 삽입
                    dgvGrid.DataSource = dtTemp;
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

        public override void Save()
        {
            base.Save();
            if (dgvGrid.Rows.Count == 0) return;

            string sRentID = string.Empty;
            string sClientName = string.Empty;
            string sCarCode = string.Empty;
            string sRentStartDate = string.Empty;
            string sReturnDate = string.Empty;
            string sCost = string.Empty;
            string sInsuranceType = string.Empty;
            string sRentFlag = string.Empty;




            DataTable dataTemp1 = ((DataTable)dgvGrid.DataSource).GetChanges();// 기존에 데이터 소스에 저장된 내용과 바뀐 부분을 체크하는 함수
            if (dataTemp1 == null) return; // 바뀐 내용들만 dtTemp에 추가

            if (MessageBox.Show("데이터를 등록 하시겠습니까?", "데이터 저장", MessageBoxButtons.YesNo) == DialogResult.No) return;
            DBHelper helper = new DBHelper(true);
            try
            {
                //트랜잭션 설정, 데이터 테이블의 상태 체크
                foreach (DataRow drRow in dataTemp1.Rows)
                {
                    switch (drRow.RowState)
                    {
                        case DataRowState.Deleted:
                            drRow.RejectChanges();
                            sRentID = drRow["RENTID"].ToString();
                            sCarCode = drRow["CARCODE"].ToString();

                            helper.ExecuteNoneQuery("SP_4_RENT_D1", CommandType.StoredProcedure, helper.CreateParameter("RENTID", sRentID)
                                                                                               , helper.CreateParameter("CARCODE", sCarCode));
                            break;

                        case DataRowState.Added:
                            sClientName = drRow["CLIENTID"].ToString();
                            sCarCode = drRow["CARCODE"].ToString();
                            sRentStartDate = drRow["RENTSTARTDATE"].ToString();
                            sReturnDate = drRow["RETURNDATE"].ToString();
                            sInsuranceType = drRow["INSURANCETYPE"].ToString();
                            sCost = drRow["COST"].ToString();


                            helper.ExecuteNoneQuery("SP_4_Rent_I2", CommandType.StoredProcedure
                                                      , helper.CreateParameter("CLIENTID", sClientName)
                                                      , helper.CreateParameter("CARCODE", sCarCode)
                                                      , helper.CreateParameter("RENTSTARTDATE", sRentStartDate)
                                                      , helper.CreateParameter("RETURNDATE", sReturnDate)
                                                      , helper.CreateParameter("INSURANCETYPE", sInsuranceType)
                                                      , helper.CreateParameter("COST", sCost)
                                                      , helper.CreateParameter("MAKER", Commoncs.LoginUserID)
                                                      );


                            break;

                        case DataRowState.Modified:
                            sRentID = drRow["RENTID"].ToString();
                            sClientName = drRow["CLIENTID"].ToString();
                            sCarCode = drRow["CARCODE"].ToString();
                            sRentStartDate = drRow["RENTSTARTDATE"].ToString();
                            sReturnDate = drRow["RETURNDATE"].ToString();
                            sInsuranceType = drRow["INSURANCETYPE"].ToString();
                            sCost = drRow["COST"].ToString();


                            helper.ExecuteNoneQuery("SP_4_Rent_U2", CommandType.StoredProcedure
                                                      , helper.CreateParameter("RENTID", sRentID)
                                                      , helper.CreateParameter("CLIENTID", sClientName)
                                                      , helper.CreateParameter("CARCODE", sCarCode)
                                                      , helper.CreateParameter("RENTSTARTDATE", sRentStartDate)
                                                      , helper.CreateParameter("RETURNDATE", sReturnDate)
                                                      , helper.CreateParameter("INSURANCETYPE", sInsuranceType)
                                                      , helper.CreateParameter("COST", sCost)
                                                      , helper.CreateParameter("MAKER", Commoncs.LoginUserID)
                                                      );
                            break;
                    }
                }
                //성공 시 DB COMMIT
                helper.Commit();
                //메세지
                SendKeys.SendWait("{ENTER}");
                MessageBox.Show("정상적으로 등록 하였습니다.");

                //재조회
                Inquire();
            }
            catch (Exception ex)
            {
                //트랜잭션 롤백
                helper.Rollback();
                // 메세지
                MessageBox.Show(ex.ToString());
                MessageBox.Show("데이터 등록에 실패하였습니다.");
            }
            finally
            {
                //DB Close
                helper.Close();
            }
        }

        public override void DoNew()
        {
            base.DoNew();
            DataRow dr = ((DataTable)dgvGrid.DataSource).NewRow();
            ((DataTable)dgvGrid.DataSource).Rows.Add(dr);

            // 마지막에 추가된 행 선택
            int MaxRow = dgvGrid.Rows.Count - 1;
            dgvGrid.Rows[MaxRow].Selected = true;
            dgvGrid.CurrentCell = dgvGrid.Rows[MaxRow].Cells[0];

        }
        public override void Delete()
        {
            base.Delete();
            if (dgvGrid.Rows.Count == 0) return;

            String sRentID = dgvGrid.CurrentRow.Cells["RENTID"].Value.ToString();
            DataTable dtTemp = (DataTable)dgvGrid.DataSource;
            for (int i = 0; i < dtTemp.Rows.Count; i++)
            {
                if (dtTemp.Rows[i].RowState == DataRowState.Deleted) continue;
                if (dtTemp.Rows[i][0].ToString() == sRentID)
                {
                    dtTemp.Rows[i].Delete();
                    break;
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FM_RENT_ADD fm_rent_add = new FM_RENT_ADD();
            fm_rent_add.ShowDialog();
        }

        private void btnPicSave_Click(object sender, EventArgs e)
        {
            //픽쳐박스 이미지 저장

            if (picCtrImg.Image == null) return;  // Picturebox에 이미지가 없을 경우 리턴
            if (picCtrImg.Tag.ToString() == "") return; //  picItemImage.Tag = Dialog.FileName; 에서 tag로 저장한 내용이 없으면 리턴
            if (MessageBox.Show("선택한 이미지로 등록하시겠습니까?", "이미지 등록", MessageBoxButtons.YesNo) == DialogResult.No) return;

            string sImagefile = string.Empty;
            //이미지 불러오기 및 저장, 파일 탐색기 호출

            Byte[] bImage = null;
            Connect = new SqlConnection(Commoncs.DbPath);


            try
            {
                #region Save Image
                FileStream stream = new FileStream(picCtrImg.Tag.ToString(), FileMode.Open, FileAccess.Read);  // 파일에서 그림파일을 가져올 수 있도록 경로와 방법을 지정(읽기전용)
                BinaryReader reader = new BinaryReader(stream);  // 그림을 바이너리 형식으로 변환해준다.
                bImage = reader.ReadBytes(Convert.ToInt32(stream.Length)); // Byte로 변환해준다.
                reader.Close();
                stream.Close();
                //바이너리 코드는 컴퓨터가 인식할 수 있는 0/1로 된 2진법 코드
                //byte를 컴퓨터는 알수 있다.
                #endregion

                #region Connect Open
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connect;
                Connect.Open();
                #endregion

                #region Parameter Cmd
                string sRentID = dgvGrid.CurrentRow.Cells["RENTID"].Value.ToString();
                cmd.CommandText = "UPDATE TB_4_RENT SET IMGCONTRACT = @IMAGE WHERE RENTID = @RENTID";
                cmd.Parameters.AddWithValue("@IMAGE", bImage); // byte 형식의 이미지 파일  -- @IMAGE로 업데이트 
                cmd.Parameters.AddWithValue("@RENTID", sRentID);
                cmd.ExecuteNonQuery();
                Connect.Close();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류입니다. 관리자에게 문의하세요", ToString());
            }

            MessageBox.Show("정상적으로 저장되었습니다.");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            // 1. 반납 여부를 변경한다 N -> Y
            // 1-1. 반납 일 데이터가 등록된다 
            // 1-2. 초과 비용을 계산후 등록한다.

            DBHelper helper = new DBHelper(true);
            String sRentID = dgvGrid.CurrentRow.Cells["RENTID"].Value.ToString();
            String sCarcode = dgvGrid.CurrentRow.Cells["CARCODE"].Value.ToString();
            String sRealReturnDate = dgvGrid.CurrentRow.Cells["REALRETURNDATE"].Value.ToString();
            String sExtraCost = dgvGrid.CurrentRow.Cells["EXTRACOST"].Value.ToString();
            String sRentFlag = dgvGrid.CurrentRow.Cells["EXTRACOST"].Value.ToString();

            // 반납 가능한 데이터 인지 확인 필요
            if (dgvGrid.Rows.Count == 0) return;
            if (dgvGrid.CurrentRow.Cells["RENTFLAG"].Value.ToString() == "반납확인")
            {
                MessageBox.Show("이미 반납된 차량입니다.");
                return;
            }
            if (MessageBox.Show("반납 하시겠습니까?", "반납",
                MessageBoxButtons.YesNo) == DialogResult.No) return;
            // N 이 맞는지도 확인
            try
            {
                helper.ExecuteNoneQuery("SP_4_Rent_U1", CommandType.StoredProcedure
                                                       , helper.CreateParameter("RENTID", sRentID)
                                                       , helper.CreateParameter("CARCODE", sCarcode)
                                                       );
                helper.Commit();
                MessageBox.Show("정상적으로 반납 되었습니다.");
                Inquire();
            }
            catch (Exception ex)
            {
                helper.Rollback();
                MessageBox.Show("데이터 등록에 실패하였습니다.");
            }
            finally
            {

                helper.Close();
            }


        }
    }
}
