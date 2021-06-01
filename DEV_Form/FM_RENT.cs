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
    public partial class FM_RENT : BaseMDIChildForm
    {
        private DataTable dtTempNon = new DataTable();

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

        private void btnReturn_Click(object sender, EventArgs e)
        {

            // 1. 반납 여부를 변경한다 N -> Y
            // 1-1. 반납 일 데이터가 등록된다 
            // 1-2. 초과 비용을 계산후 등록한다.

            DBHelper helper = new DBHelper(true);
            String sRentID = dgvGrid.CurrentRow.Cells["RENTID"].Value.ToString();
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
