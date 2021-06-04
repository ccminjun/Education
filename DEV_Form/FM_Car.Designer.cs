
namespace DEV_FORM
{
    partial class FM_Car
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefresh1 = new System.Windows.Forms.Button();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoGas = new System.Windows.Forms.RadioButton();
            this.rdoHybrid = new System.Windows.Forms.RadioButton();
            this.rdoOil = new System.Windows.Forms.RadioButton();
            this.rdoTot = new System.Windows.Forms.RadioButton();
            this.rdoLpg = new System.Windows.Forms.RadioButton();
            this.rdoElec = new System.Windows.Forms.RadioButton();
            this.txtCarCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkWait = new System.Windows.Forms.CheckBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cboRentCost = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.GroupBox();
            this.btnPicDelete = new System.Windows.Forms.Button();
            this.btnPicSave = new System.Windows.Forms.Button();
            this.btnLoadPic = new System.Windows.Forms.Button();
            this.picCarImg = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvGridCar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.btnRefresh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCarImg)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGridCar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Size = new System.Drawing.Size(1726, 144);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Location = new System.Drawing.Point(0, 144);
            this.groupBox2.Size = new System.Drawing.Size(1726, 603);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.btnRefresh1);
            this.groupBox3.Controls.Add(this.txtCarName);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtCarCode);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.chkWait);
            this.groupBox3.Controls.Add(this.dtpStart);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtpEnd);
            this.groupBox3.Controls.Add(this.cboRentCost);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 20);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(1720, 127);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "차량 조회";
            // 
            // btnRefresh1
            // 
            this.btnRefresh1.Location = new System.Drawing.Point(974, 73);
            this.btnRefresh1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh1.Name = "btnRefresh1";
            this.btnRefresh1.Size = new System.Drawing.Size(124, 30);
            this.btnRefresh1.TabIndex = 16;
            this.btnRefresh1.Text = "입력값 초기화";
            this.btnRefresh1.UseVisualStyleBackColor = true;
            this.btnRefresh1.Click += new System.EventHandler(this.btnRefresh1_Click);
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(420, 19);
            this.txtCarName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(177, 25);
            this.txtCarName.TabIndex = 15;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoGas);
            this.groupBox4.Controls.Add(this.rdoHybrid);
            this.groupBox4.Controls.Add(this.rdoOil);
            this.groupBox4.Controls.Add(this.rdoTot);
            this.groupBox4.Controls.Add(this.rdoLpg);
            this.groupBox4.Controls.Add(this.rdoElec);
            this.groupBox4.Location = new System.Drawing.Point(504, 52);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(325, 70);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "연료 분류";
            // 
            // rdoGas
            // 
            this.rdoGas.AutoSize = true;
            this.rdoGas.Location = new System.Drawing.Point(102, 19);
            this.rdoGas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoGas.Name = "rdoGas";
            this.rdoGas.Size = new System.Drawing.Size(73, 19);
            this.rdoGas.TabIndex = 16;
            this.rdoGas.Text = "휘발유";
            this.rdoGas.UseVisualStyleBackColor = true;
            // 
            // rdoHybrid
            // 
            this.rdoHybrid.AutoSize = true;
            this.rdoHybrid.Location = new System.Drawing.Point(8, 44);
            this.rdoHybrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoHybrid.Name = "rdoHybrid";
            this.rdoHybrid.Size = new System.Drawing.Size(69, 19);
            this.rdoHybrid.TabIndex = 12;
            this.rdoHybrid.Text = "Hybrid";
            this.rdoHybrid.UseVisualStyleBackColor = true;
            // 
            // rdoOil
            // 
            this.rdoOil.AutoSize = true;
            this.rdoOil.Location = new System.Drawing.Point(102, 46);
            this.rdoOil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoOil.Name = "rdoOil";
            this.rdoOil.Size = new System.Drawing.Size(58, 19);
            this.rdoOil.TabIndex = 15;
            this.rdoOil.Text = "경유";
            this.rdoOil.UseVisualStyleBackColor = true;
            // 
            // rdoTot
            // 
            this.rdoTot.AutoSize = true;
            this.rdoTot.Checked = true;
            this.rdoTot.Location = new System.Drawing.Point(189, 46);
            this.rdoTot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoTot.Name = "rdoTot";
            this.rdoTot.Size = new System.Drawing.Size(93, 19);
            this.rdoTot.TabIndex = 14;
            this.rdoTot.TabStop = true;
            this.rdoTot.Text = "전체 조회";
            this.rdoTot.UseVisualStyleBackColor = true;
            // 
            // rdoLpg
            // 
            this.rdoLpg.AutoSize = true;
            this.rdoLpg.Location = new System.Drawing.Point(189, 19);
            this.rdoLpg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoLpg.Name = "rdoLpg";
            this.rdoLpg.Size = new System.Drawing.Size(57, 19);
            this.rdoLpg.TabIndex = 13;
            this.rdoLpg.Text = "LPG";
            this.rdoLpg.UseVisualStyleBackColor = true;
            // 
            // rdoElec
            // 
            this.rdoElec.AutoSize = true;
            this.rdoElec.Location = new System.Drawing.Point(8, 19);
            this.rdoElec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoElec.Name = "rdoElec";
            this.rdoElec.Size = new System.Drawing.Size(73, 19);
            this.rdoElec.TabIndex = 11;
            this.rdoElec.Text = "전기차";
            this.rdoElec.UseVisualStyleBackColor = true;
            // 
            // txtCarCode
            // 
            this.txtCarCode.Location = new System.Drawing.Point(125, 19);
            this.txtCarCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCarCode.Name = "txtCarCode";
            this.txtCarCode.Size = new System.Drawing.Size(177, 25);
            this.txtCarCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "차량 코드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "차량 명";
            // 
            // chkWait
            // 
            this.chkWait.AutoSize = true;
            this.chkWait.Location = new System.Drawing.Point(368, 79);
            this.chkWait.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkWait.Name = "chkWait";
            this.chkWait.Size = new System.Drawing.Size(109, 19);
            this.chkWait.TabIndex = 10;
            this.chkWait.Text = "대기중 검색";
            this.chkWait.UseVisualStyleBackColor = true;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(836, 19);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(115, 25);
            this.dtpStart.TabIndex = 4;
            this.dtpStart.Value = new System.DateTime(1800, 1, 3, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "가격별 검색";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(980, 19);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(119, 25);
            this.dtpEnd.TabIndex = 5;
            this.dtpEnd.Value = new System.DateTime(2021, 5, 25, 10, 25, 4, 0);
            // 
            // cboRentCost
            // 
            this.cboRentCost.FormattingEnabled = true;
            this.cboRentCost.Location = new System.Drawing.Point(125, 76);
            this.cboRentCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboRentCost.Name = "cboRentCost";
            this.cboRentCost.Size = new System.Drawing.Size(177, 23);
            this.cboRentCost.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "등록 일자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(960, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "~";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Controls.Add(this.btnPicDelete);
            this.btnRefresh.Controls.Add(this.btnPicSave);
            this.btnRefresh.Controls.Add(this.btnLoadPic);
            this.btnRefresh.Controls.Add(this.picCarImg);
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRefresh.Location = new System.Drawing.Point(3, 336);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Size = new System.Drawing.Size(1720, 265);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "이미지 조회";
            // 
            // btnPicDelete
            // 
            this.btnPicDelete.Location = new System.Drawing.Point(717, 38);
            this.btnPicDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPicDelete.Name = "btnPicDelete";
            this.btnPicDelete.Size = new System.Drawing.Size(85, 30);
            this.btnPicDelete.TabIndex = 3;
            this.btnPicDelete.Text = "삭제";
            this.btnPicDelete.UseVisualStyleBackColor = true;
            this.btnPicDelete.Click += new System.EventHandler(this.btnPicDelete_Click);
            // 
            // btnPicSave
            // 
            this.btnPicSave.Location = new System.Drawing.Point(611, 37);
            this.btnPicSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPicSave.Name = "btnPicSave";
            this.btnPicSave.Size = new System.Drawing.Size(100, 30);
            this.btnPicSave.TabIndex = 2;
            this.btnPicSave.Text = "저장";
            this.btnPicSave.UseVisualStyleBackColor = true;
            this.btnPicSave.Click += new System.EventHandler(this.btnPicSave_Click);
            // 
            // btnLoadPic
            // 
            this.btnLoadPic.Location = new System.Drawing.Point(465, 37);
            this.btnLoadPic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoadPic.Name = "btnLoadPic";
            this.btnLoadPic.Size = new System.Drawing.Size(139, 30);
            this.btnLoadPic.TabIndex = 1;
            this.btnLoadPic.Text = "이미지 불러오기";
            this.btnLoadPic.UseVisualStyleBackColor = true;
            this.btnLoadPic.Click += new System.EventHandler(this.btnLoadPic_Click);
            // 
            // picCarImg
            // 
            this.picCarImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCarImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.picCarImg.Location = new System.Drawing.Point(4, 21);
            this.picCarImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picCarImg.Name = "picCarImg";
            this.picCarImg.Size = new System.Drawing.Size(438, 241);
            this.picCarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarImg.TabIndex = 0;
            this.picCarImg.TabStop = false;
            this.picCarImg.Click += new System.EventHandler(this.picCarImg_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvGridCar);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 20);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(1720, 316);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "차량 정보";
            // 
            // dgvGridCar
            // 
            this.dgvGridCar.AllowUserToAddRows = false;
            this.dgvGridCar.AllowUserToDeleteRows = false;
            this.dgvGridCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGridCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGridCar.Location = new System.Drawing.Point(4, 21);
            this.dgvGridCar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvGridCar.Name = "dgvGridCar";
            this.dgvGridCar.RowHeadersWidth = 51;
            this.dgvGridCar.RowTemplate.Height = 25;
            this.dgvGridCar.Size = new System.Drawing.Size(1712, 292);
            this.dgvGridCar.TabIndex = 3;
            this.dgvGridCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrid_CellClick);
            this.dgvGridCar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGridCar_CellDoubleClick);
            // 
            // FM_Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1726, 747);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FM_Car";
            this.Text = "FM_Car";
            this.Load += new System.EventHandler(this.FM_ITEM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.btnRefresh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCarImg)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGridCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRefresh1;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoGas;
        private System.Windows.Forms.RadioButton rdoHybrid;
        private System.Windows.Forms.RadioButton rdoOil;
        private System.Windows.Forms.RadioButton rdoTot;
        private System.Windows.Forms.RadioButton rdoLpg;
        private System.Windows.Forms.RadioButton rdoElec;
        private System.Windows.Forms.TextBox txtCarCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkWait;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cboRentCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvGridCar;
        private System.Windows.Forms.GroupBox btnRefresh;
        private System.Windows.Forms.Button btnPicDelete;
        private System.Windows.Forms.Button btnPicSave;
        private System.Windows.Forms.Button btnLoadPic;
        private System.Windows.Forms.PictureBox picCarImg;
    }
}