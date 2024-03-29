﻿using DEV_Form;
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

namespace DEV_Form
{
    public partial class Fm_Cust_ : Form
    {
        #region Connection Init
        private SqlConnection Conn = null;
        private string ConnInfo = "Data Source=222.235.141.8; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";

        #endregion

        public Fm_Cust_()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                #region Connection Open
                Conn = new SqlConnection(ConnInfo);
                Conn.Open();

                if (Conn.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Failed to connect to database.");
                    return;
                }
                #endregion

                #region Variable Init
                string custCode = txtCustCode.Text;
                string custType = "";   // string.Empty 쓰면 null로 받지만 ""로 해야함 , 중간에 어느 값이라도 들어갈 수 있기 때문에
                string custName = txtCustName.Text;
                string startDate = dtpStart.Text.ToString();
                string endDate = dtpEnd.Text.ToString();
                string bizType = "";

                // 라이도 버튼에 따른 상태값 구분
                if (rdoCVP.Checked == true) bizType = "상용차 부품";
                else if (rdoAVP.Checked == true) bizType = "자동차부품";
                else if (rdoCUT.Checked == true) bizType = "절삭가공";
                else if (rdoCSR.Checked == true) bizType = "펌프압축기";
                else bizType = "";

                // 고객사만 검색 체크박스 선택 구분
                if (chkCustOnly.Checked == true) custType = "C";
                #endregion

                #region Fill Data
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT CUSTCODE, " +
                                                                   "CASE WHEN CUSTTYPE = 'C' THEN '고객사'" +
                                                                   "WHEN CUSTTYPE = 'V' THEN '협력사'" +
                                                                   "END AS CUSTTYPE, " +
                                                                   "CUSTNAME, " +
                                                                   "BIZCLASS, " +
                                                                   "BIZTYPE,  " +
                                                                   "CASE WHEN USEFLAG = 'Y' THEN '사용'" +
                                                                   "WHEN USEFLAG = 'N' THEN '미사용'" +
                                                                   "END AS USEFLAG, " +
                                                                   "FIRSTDATE, " +
                                                                   "MAKEDATE, " +
                                                                   "MAKER, " +
                                                                   "EDITDATE, " +
                                                                   "EDITOR " +
                                                                   "FROM TB_CUST_CMJ WITH(NOLOCK) " +
                                                                   $"WHERE CUSTCODE LIKE '%{custCode}%' " + // $ 는 '" + + "' 와 같음
                                                                   $"AND CUSTTYPE LIKE '%{custType}%' "+
                                                                   $"AND CUSTNAME LIKE '%{custName}%' " +
                                                                   $"AND BIZTYPE LIKE '%{bizType}%' " +
                                                                   $"AND FIRSTDATE BETWEEN '{startDate}' AND '{endDate}'",
                                                                   Conn);
                DataTable DtTemp = new DataTable();
                Adapter.Fill(DtTemp);
                #endregion

                #region Show Data
                if (DtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("검색 조건에 맞는 데이터가 없습니다.");
                    dgvGrid.DataSource = null;
                    return;
                }
                dgvGrid.DataSource = DtTemp;
                #endregion

                #region Column Set
                dgvGrid.Columns["CUSTCODE"].HeaderText = "거래처 코드";
                dgvGrid.Columns["CUSTTYPE"].HeaderText = "거래처 타입";
                dgvGrid.Columns["CUSTNAME"].HeaderText = "거래처명";
                dgvGrid.Columns["BIZCLASS"].HeaderText = "업태";
                dgvGrid.Columns["BIZTYPE"].HeaderText = "종목";
                dgvGrid.Columns["USEFLAG"].HeaderText = "사용여부";
                dgvGrid.Columns["FIRSTDATE"].HeaderText = "거래일자";
                dgvGrid.Columns["MAKEDATE"].HeaderText = "등록일시";
                dgvGrid.Columns["MAKER"].HeaderText = "등록자";
                dgvGrid.Columns["EDITDATE"].HeaderText = "수정일시";
                dgvGrid.Columns["EDITOR"].HeaderText = "수정자";

                dgvGrid.Columns[0].Width = 100;
                dgvGrid.Columns[1].Width = 100;
                dgvGrid.Columns[2].Width = 200;
                dgvGrid.Columns[3].Width = 200;
                dgvGrid.Columns[4].Width = 100;


                // 수정 안되게 읽기만 가능하게 바꿔줌
                dgvGrid.Columns["CUSTCODE"].ReadOnly = true;
                dgvGrid.Columns["CUSTTYPE"].ReadOnly = true;
                dgvGrid.Columns["MAKER"].ReadOnly = true;
                dgvGrid.Columns["MAKEDATE"].ReadOnly = true;
                dgvGrid.Columns["EDITOR"].ReadOnly = true;
                dgvGrid.Columns["EDITDATE"].ReadOnly = true;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvGrid.Rows.Count == 0) return; // 데이타가 없을때 추가하면 오류가 뜨지 않음 but 불안정 추가하고싶어도 추가하지 못함
            DataRow Dr = ((DataTable)dgvGrid.DataSource).NewRow(); // 깡통 줄을 만들어라
            ((DataTable)dgvGrid.DataSource).Rows.Add(Dr); // 추가해라
            dgvGrid.Columns["CUSTCODE"].ReadOnly = false;
            dgvGrid.Columns["CUSTTYPE"].ReadOnly = false;

            // 마지막에 추가 된 행 선택
            int MaxRow = dgvGrid.Rows.Count - 1; // 로우와 인덱스 숫자를 맞추기 위해
            dgvGrid.Rows[MaxRow].Selected = true;
            dgvGrid.CurrentCell = dgvGrid.Rows[MaxRow].Cells[0];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvGrid.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 저장하시겠습니까??", "Save", MessageBoxButtons.YesNo) == DialogResult.No) return;

            #region Variable Init
            string custCode = dgvGrid.CurrentRow.Cells["CUSTCODE"].Value.ToString();
            string custType = dgvGrid.CurrentRow.Cells["CUSTTYPE"].Value.ToString();
            string custName = dgvGrid.CurrentRow.Cells["CUSTNAME"].Value.ToString();
            string bizClass = dgvGrid.CurrentRow.Cells["BIZCLASS"].Value.ToString();
            string bizType = dgvGrid.CurrentRow.Cells["BIZTYPE"].Value.ToString();
            string useFlag = dgvGrid.CurrentRow.Cells["USEFLAG"].Value.ToString();
            string firstDate = dgvGrid.CurrentRow.Cells["FIRSTDATE"].Value.ToString();

            if (custCode == "" || custType == "" || firstDate == "")
            {
                MessageBox.Show("'거래처 코드', '거래처 타입', '거래일자' 는 빈칸으로 남겨둘 수 없습니다.");
                return;
            }

            // 고객사나 C로 입력하지 않으면 V로 입력된다. 구문
            if (custType == "고객사" || custType == "C") custType = "C";
            else custType = "V";

            if (useFlag == "미사용" || useFlag == "N") useFlag = "N";
            else useFlag = "Y";
            #endregion

            #region Transaction Decl
            SqlCommand Cmd = new SqlCommand();
            SqlTransaction Txn;
            #endregion

            #region Connection Open
            Conn = new SqlConnection(ConnInfo);
            Conn.Open();
            #endregion

            #region Transaction Init
            Txn = Conn.BeginTransaction("Test Transaction");
            Cmd.Transaction = Txn;
            Cmd.Connection = Conn;
            #endregion

            #region Transaction Commit
            Cmd.CommandText = "UPDATE TB_CUST_CMJ                      " +
                             $"   SET CUSTNAME   = '{custName}',       " +
                             $"       BIZCLASS   = '{bizClass}',       " +
                             $"       BIZTYPE    = '{bizType}',        " +
                             $"       USEFLAG    = '{useFlag}',        " +
                             $"       FIRSTDATE  = '{firstDate}',      " +
                             $"       EDITOR     = '{Common.LogInID}', " +
                             $"       EDITDATE   =   GETDATE()         " +
                             $" WHERE CUSTCODE   = '{custCode}'        " +
                             $"   AND CUSTTYPE   = '{custType}'        " +

                             " IF (@@ROWCOUNT =0)                     " +
                             " INSERT INTO TB_CUST_CMJ (CUSTCODE,     CUSTTYPE,     CUSTNAME,     BIZCLASS,     BIZTYPE,     USEFLAG,     FIRSTDATE,   MAKEDATE,   MAKER) " +
                             $"VALUES (               '{custCode}', '{custType}', '{custName}', '{bizClass}', '{bizType}', '{useFlag}', '{firstDate}', GETDATE(), '{Common.LogInID}')";
            Cmd.ExecuteNonQuery();
            Txn.Commit();
            #endregion

            MessageBox.Show("성공적으로 저장하였습니다.");
            Conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvGrid.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 삭제하시겠습니까?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No) return;

            #region Transaction Decl
            SqlCommand Cmd = new SqlCommand();
            SqlTransaction Txn;
            #endregion

            #region Connection Open
            Conn = new SqlConnection(ConnInfo);
            Conn.Open();
            #endregion

            #region Transaction Init
            Txn = Conn.BeginTransaction("Begin Transaction");
            Cmd.Transaction = Txn;
            Cmd.Connection = Conn;
            #endregion

            try
            {
                string delCustCode = dgvGrid.CurrentRow.Cells["CUSTCODE"].Value.ToString();

                #region Transaction Commit
                Cmd.CommandText = $"DELETE TB_CUST_CMJ WHERE CUSTCODE = '{delCustCode}'";
                Cmd.ExecuteNonQuery();
                Txn.Commit();
                #endregion

                MessageBox.Show("성공적으로 데이터를 삭제하였습니다.");
                btnSearch_Click(null, null);
            }
            catch (Exception ex)
            {
                Txn.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }

    }
}
