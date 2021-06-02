
namespace DEV_FORM
{
    partial class FM_RentClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoBlacklist = new System.Windows.Forms.RadioButton();
            this.rdoGeneral = new System.Windows.Forms.RadioButton();
            this.rdoVip = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPicDelete = new System.Windows.Forms.Button();
            this.btnPicSave = new System.Windows.Forms.Button();
            this.btnPicUpload = new System.Windows.Forms.Button();
            this.picLicenseImg = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLicenseImg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.txtClientName);
            this.groupBox1.Controls.Add(this.txtClientID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Size = new System.Drawing.Size(952, 113);
            this.groupBox1.Text = "고객 조회";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.dgvGrid);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 113);
            this.groupBox2.Size = new System.Drawing.Size(952, 317);
            this.groupBox2.Text = "고객 정보";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "고객 ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "가입일자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "고객 이름";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(92, 26);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(182, 25);
            this.txtClientID.TabIndex = 3;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(377, 28);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(169, 25);
            this.txtClientName.TabIndex = 4;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(92, 64);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(180, 25);
            this.dtpStart.TabIndex = 8;
            this.dtpStart.Value = new System.DateTime(2021, 5, 31, 12, 17, 51, 0);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(302, 64);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(180, 25);
            this.dtpEnd.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoAll);
            this.groupBox3.Controls.Add(this.rdoBlacklist);
            this.groupBox3.Controls.Add(this.rdoGeneral);
            this.groupBox3.Controls.Add(this.rdoVip);
            this.groupBox3.Location = new System.Drawing.Point(584, 25);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(338, 60);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "고객등급";
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(227, 23);
            this.rdoAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(93, 19);
            this.rdoAll.TabIndex = 3;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "고객 전체";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // rdoBlacklist
            // 
            this.rdoBlacklist.AutoSize = true;
            this.rdoBlacklist.Location = new System.Drawing.Point(128, 23);
            this.rdoBlacklist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoBlacklist.Name = "rdoBlacklist";
            this.rdoBlacklist.Size = new System.Drawing.Size(103, 19);
            this.rdoBlacklist.TabIndex = 2;
            this.rdoBlacklist.TabStop = true;
            this.rdoBlacklist.Text = "블랙리스트";
            this.rdoBlacklist.UseVisualStyleBackColor = true;
            // 
            // rdoGeneral
            // 
            this.rdoGeneral.AutoSize = true;
            this.rdoGeneral.Location = new System.Drawing.Point(69, 23);
            this.rdoGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoGeneral.Name = "rdoGeneral";
            this.rdoGeneral.Size = new System.Drawing.Size(58, 19);
            this.rdoGeneral.TabIndex = 1;
            this.rdoGeneral.TabStop = true;
            this.rdoGeneral.Text = "일반";
            this.rdoGeneral.UseVisualStyleBackColor = true;
            // 
            // rdoVip
            // 
            this.rdoVip.AutoSize = true;
            this.rdoVip.Location = new System.Drawing.Point(17, 23);
            this.rdoVip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoVip.Name = "rdoVip";
            this.rdoVip.Size = new System.Drawing.Size(49, 19);
            this.rdoVip.TabIndex = 0;
            this.rdoVip.TabStop = true;
            this.rdoVip.Text = "VIP";
            this.rdoVip.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "~";
            // 
            // dgvGrid
            // 
            this.dgvGrid.AllowUserToAddRows = false;
            this.dgvGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrid.Location = new System.Drawing.Point(3, 20);
            this.dgvGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.RowHeadersWidth = 51;
            this.dgvGrid.RowTemplate.Height = 29;
            this.dgvGrid.Size = new System.Drawing.Size(946, 295);
            this.dgvGrid.TabIndex = 1;
            this.dgvGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrid_CellClick);
            this.dgvGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGrid_CellMouseDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.btnPicDelete);
            this.groupBox4.Controls.Add(this.btnPicSave);
            this.groupBox4.Controls.Add(this.btnPicUpload);
            this.groupBox4.Controls.Add(this.picLicenseImg);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 430);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(952, 182);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "면허증 이미지 관리";
            // 
            // btnPicDelete
            // 
            this.btnPicDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnPicDelete.Location = new System.Drawing.Point(463, 82);
            this.btnPicDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPicDelete.Name = "btnPicDelete";
            this.btnPicDelete.Size = new System.Drawing.Size(84, 30);
            this.btnPicDelete.TabIndex = 3;
            this.btnPicDelete.Text = "삭제";
            this.btnPicDelete.UseVisualStyleBackColor = false;
            this.btnPicDelete.Click += new System.EventHandler(this.btnPictDelete_Click);
            // 
            // btnPicSave
            // 
            this.btnPicSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnPicSave.Location = new System.Drawing.Point(356, 82);
            this.btnPicSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPicSave.Name = "btnPicSave";
            this.btnPicSave.Size = new System.Drawing.Size(84, 30);
            this.btnPicSave.TabIndex = 2;
            this.btnPicSave.Text = "저장";
            this.btnPicSave.UseVisualStyleBackColor = false;
            this.btnPicSave.Click += new System.EventHandler(this.btnPicSave_Click);
            // 
            // btnPicUpload
            // 
            this.btnPicUpload.BackColor = System.Drawing.SystemColors.Control;
            this.btnPicUpload.Location = new System.Drawing.Point(356, 39);
            this.btnPicUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPicUpload.Name = "btnPicUpload";
            this.btnPicUpload.Size = new System.Drawing.Size(190, 30);
            this.btnPicUpload.TabIndex = 1;
            this.btnPicUpload.Text = "이미지 불러오기";
            this.btnPicUpload.UseVisualStyleBackColor = false;
            this.btnPicUpload.Click += new System.EventHandler(this.btnPicUpload_Click);
            // 
            // picLicenseImg
            // 
            this.picLicenseImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLicenseImg.Location = new System.Drawing.Point(5, 20);
            this.picLicenseImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLicenseImg.Name = "picLicenseImg";
            this.picLicenseImg.Size = new System.Drawing.Size(325, 130);
            this.picLicenseImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLicenseImg.TabIndex = 0;
            this.picLicenseImg.TabStop = false;
            this.picLicenseImg.Click += new System.EventHandler(this.picLicenseImg_Click);
            // 
            // FM_RentClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 612);
            this.Controls.Add(this.groupBox4);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FM_RentClient";
            this.Text = "FM_RentUser";
            this.Load += new System.EventHandler(this.FM_RentClient_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLicenseImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoBlacklist;
        private System.Windows.Forms.RadioButton rdoGeneral;
        private System.Windows.Forms.RadioButton rdoVip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox picLicenseImg;
        private System.Windows.Forms.Button btnPicDelete;
        private System.Windows.Forms.Button btnPicSave;
        private System.Windows.Forms.Button btnPicUpload;
    }
}