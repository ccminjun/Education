﻿using DC00_assm;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KFQS_Form
{
    public partial class MM_StockOUT : DC00_WinForm.BaseMDIChildForm
    {
        //그리드 셋팅 할 수 있도록 도와주는 함수 클래스
        UltraGridUtil _GridUtill = new UltraGridUtil();
        //공장 변수 입력
        //private sPlantCode = LoginInfo
        public MM_StockOUT()
        {
            InitializeComponent();
        }
        private void MM_StockOUT_Load(object sender, EventArgs e)
        {   // 그리드 셋팅하고 시작한다.
            try
            {
                _GridUtill.InitializeGrid(this.grid1, false, true, false, "", false); //그리드1 의 기본 설정 내용
                // PLANTCODE값을 보여줄때는 공장으로, null값 허용, varchar형식, 130,130, 문자열은 왼쪽 정렬, 보여주고 수정은X)
                _GridUtill.InitColumnUltraGrid(grid1, "CHK"          , "선택"     , true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, true);
                _GridUtill.InitColumnUltraGrid(grid1, "PLANTCODE"    , "공장"     , true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, true);
                _GridUtill.InitColumnUltraGrid(grid1, "MAKEDATE"     , "입고일자" , true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, true);
                _GridUtill.InitColumnUltraGrid(grid1, "ITEMCODE"     , "품목"     , true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, true);
                _GridUtill.InitColumnUltraGrid(grid1, "ITEMNAME"     , "품목명"   , true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, true);
                _GridUtill.InitColumnUltraGrid(grid1, "MATLOTNO"     , "LOTNO"    , true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, true);
                _GridUtill.InitColumnUltraGrid(grid1, "STOCKQTY"     , "수량"     , true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, true);
                _GridUtill.InitColumnUltraGrid(grid1, "UNITCODE"     , "단위"     , true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, true);
                _GridUtill.InitColumnUltraGrid(grid1, "WHCODE"       , "창고"     , true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, true);
                _GridUtill.InitColumnUltraGrid(grid1, "MAKER"        , "입고자"   , true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, true);
               
                //셋팅 내역을 바인딩
                _GridUtill.SetInitUltraGridBind(grid1);

                //콤보 박스 셋팅
                Common _Common = new Common();
                DataTable dtTemp = new DataTable();
                //PLANTCODE 기준정보 가져와서 데이터 테이블에 추가
                dtTemp = _Common.Standard_CODE("PLANTCODE");
                //데이터 테이블에 있는 데이터를 해당 콤보박스에 추가
                Common.FillComboboxMaster(this.cboPlantCode_H, dtTemp, dtTemp.Columns["CODE_ID"].ColumnName, dtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
                UltraGridUtil.SetComboUltraGrid(this.grid1, "PLANTCODE", dtTemp, "CODE_ID", "CODE_NAME"); // 그리드 상에 콤보박스를 넣는 방법
                //콤보박스에 데이터를 집어넣는 함수를 사용 , 공장콤보박스에 코드아이디라는 컬럼의 아이템 이름을 밸류로 쓰고 보여주는 내용으로는 네임을 사용할거다. 
                // 전체선택은 ALL로 표시하되 아무것도 없게 표시하라.
                
                //품목 명의 콤보박스
                dtTemp = _Common.GET_ItemCodeFERT_Code("ROH");
                Common.FillComboboxMaster(this.cboItemName_H, dtTemp, dtTemp.Columns["CODE_ID"].ColumnName, dtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");




               
                // 창고 콤보박스 추가
                dtTemp = _Common.Standard_CODE("WHCODE","MINORCODE='WH003'");
                Common.FillComboboxMaster(this.cboWHCODE_H, dtTemp, dtTemp.Columns["CODE_ID"].ColumnName, dtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
                UltraGridUtil.SetComboUltraGrid(this.grid1, "WHCODE", dtTemp, "CODE_ID", "CODE_NAME");

                // 출고 저장위치 콤보박스 추가
                dtTemp = _Common.Standard_CODE("STORAGELOCCODE", "RELCODE1='WH003'");
                Common.FillComboboxMaster(this.cboStorageloccode_H, dtTemp, dtTemp.Columns["CODE_ID"].ColumnName, dtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
                UltraGridUtil.SetComboUltraGrid(this.grid1, "STORAGELOCCODE", dtTemp, "CODE_ID", "CODE_NAME");


                dtpStart.Value = string.Format("{0:yyyy-MM-01}", DateTime.Now);
                cboWHCODE_H.Value = "WH003";

            }
            catch (Exception ex)
            {
                ShowDialog(ex.Message, DC00_WinForm.DialogForm.DialogType.OK);
            }
        }
        public override void DoInquire()
        {
            base.DoInquire();
            DBHelper helper = new DBHelper(false);
            try
            {
                string sPlantcode      = cboPlantCode_H.Value.ToString();
                string sItemname       = cboItemName_H.Value.ToString();
                string sWhcode         = cboWHCODE_H.Value.ToString();
                string sStorageloccode = cboStorageloccode_H.Value.ToString();
                string sLotno          = txtLOTNo_H.Text.ToString();
                string sStartdate      = dtpStart.Text.ToString();
                string sEnddate        = dtpEnd.ToString();

                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("19MM_StockOUT_S1", CommandType.StoredProcedure
                                          , helper.CreateParameter("PLANTCODE" , sPlantcode , DbType.String, ParameterDirection.Input)
                                          , helper.CreateParameter("ITEMCODE"  , sItemname  , DbType.String, ParameterDirection.Input)
                                          , helper.CreateParameter("MATLOTNO"  , sLotno     , DbType.String, ParameterDirection.Input)
                                          , helper.CreateParameter("STARTDATE" , sStartdate , DbType.String, ParameterDirection.Input)
                                          , helper.CreateParameter("ENDDATE"   , sEnddate   , DbType.String, ParameterDirection.Input));
                this.ClosePrgForm();
                //조회중이라고 뜨는 동그란 표시를 꺼주는 코드 base 내에 설정되어있음

                if (dtTemp.Rows.Count > 0) // 데이터가 있으면 바인딩해서 그리드에 출력
                {
                    grid1.DataSource = dtTemp;
                    grid1.DataBinds(dtTemp);
                }
                else
                {
                    _GridUtill.Grid_Clear(grid1);
                    ShowDialog("조회할 데이터가 없습니다.", DC00_WinForm.DialogForm.DialogType.OK);
                }
            }
            catch (Exception ex)
            {
                ShowDialog(ex.Message, DC00_WinForm.DialogForm.DialogType.OK);
            }
            finally { helper.Close(); }

        }
        public override void DoNew()
        {
            base.DoNew();
            this.grid1.InsertRow();

            //여기엔 뭘추가하지..?
        }
        public override void DoDelete()
        {
            base.DoDelete();
            this.grid1.DeleteRow();
        }
        public override void DoSave()
        {
            base.DoSave();
            DataTable dtTemp = new DataTable();
            dtTemp = grid1.chkChange();
            if (dtTemp.Rows.Count == 0) return;
            DBHelper helper = new DBHelper("", true);
            try
            {
                if (ShowDialog("해당 사항을 저장 하시겠습니까?", DC00_WinForm.DialogForm.DialogType.YESNO) == System.Windows.Forms.DialogResult.Cancel)
                { return; }

                foreach (DataRow drrow in dtTemp.Rows)
                {


                    switch (drrow.RowState)
                    {
                        case DataRowState.Deleted:
                            drrow.RejectChanges();//삭제된 줄을 복원시켜라
                            helper.ExecuteNoneQuery("19MM_StockOUT_D1", CommandType.StoredProcedure, helper.CreateParameter("PLANTCODE", Convert.ToString(drrow["PLANTCODE"]), DbType.String, ParameterDirection.Input)
                                                                                                   , helper.CreateParameter("MATLOTNO", Convert.ToString(drrow["MATLOTNO"]), DbType.String, ParameterDirection.Input));
                            break;

                            if (Convert.ToString(drrow["WORKERID"]) == string.Empty)// 아이디 안넣으면 불가
                            {
                                this.ClosePrgForm();
                                this.ShowDialog("작업자 ID를 입력하세요.", DC00_WinForm.DialogForm.DialogType.OK);
                                return;
                            }

                        case DataRowState.Added:
                            helper.ExecuteNoneQuery("19MM_StockOUT_I1"
                                                    , CommandType.StoredProcedure
                                                    , helper.CreateParameter("PLANTCODE", Convert.ToString(drrow["PLANTCODE"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("WORKERID", Convert.ToString(drrow["WORKERID"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("WORKERNAME", Convert.ToString(drrow["WORKERNAME"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("GRPID", Convert.ToString(drrow["GRPID"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("DEPTCODE", Convert.ToString(drrow["DEPTCODE"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("BANCODE", Convert.ToString(drrow["BANCODE"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("USEFLAG", Convert.ToString(drrow["USEFLAG"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("PHONENO", Convert.ToString(drrow["PHONENO"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("INDATE", Convert.ToString(drrow["INDATE"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("OUTDATE", Convert.ToString(drrow["OUTDATE"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("MAKER", LoginInfo.UserID, DbType.String, ParameterDirection.Input));
                            break;
                        case DataRowState.Modified:
                            helper.ExecuteNoneQuery("19MM_StockOUT_U1"
                                                   , CommandType.StoredProcedure
                                                   , helper.CreateParameter("PLANTCODE", Convert.ToString(drrow["PLANTCODE"]), DbType.String, ParameterDirection.Input)
                                                   , helper.CreateParameter("WORKERID", Convert.ToString(drrow["WORKERID"]), DbType.String, ParameterDirection.Input)
                                                   , helper.CreateParameter("WORKERNAME", Convert.ToString(drrow["WORKERNAME"]), DbType.String, ParameterDirection.Input)
                                                   , helper.CreateParameter("GRPID", Convert.ToString(drrow["GRPID"]), DbType.String, ParameterDirection.Input)
                                                   , helper.CreateParameter("DEPTCODE", Convert.ToString(drrow["DEPTCODE"]), DbType.String, ParameterDirection.Input)
                                                   , helper.CreateParameter("BANCODE", Convert.ToString(drrow["BANCODE"]), DbType.String, ParameterDirection.Input)
                                                   , helper.CreateParameter("USEFLAG", Convert.ToString(drrow["USEFLAG"]), DbType.String, ParameterDirection.Input)
                                                   , helper.CreateParameter("PHONENO", Convert.ToString(drrow["PHONENO"]), DbType.String, ParameterDirection.Input)
                                                   , helper.CreateParameter("INDATE", Convert.ToString(drrow["INDATE"]), DbType.String, ParameterDirection.Input)
                                                   , helper.CreateParameter("OUTDATE", Convert.ToString(drrow["OUTDATE"]), DbType.String, ParameterDirection.Input)
                                                   , helper.CreateParameter("EDITOR", LoginInfo.UserID, DbType.String, ParameterDirection.Input));


                            break;
                    }
                }
                if (helper.RSCODE == "S")
                {
                    helper.Commit();
                    this.ShowDialog("정상적으로 등록 되었습니다.", DC00_WinForm.DialogForm.DialogType.OK);
                    DoInquire();
                }
            }
            catch (Exception ex)
            {
                helper.Rollback();
            }
            finally
            {
                helper.Close();
            }

        }
    }
}
