
namespace DEV_form
{
    partial class FM_RENT_ADD
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
            this.btnClient = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnContract = new System.Windows.Forms.Button();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpRentEnd = new System.Windows.Forms.DateTimePicker();
            this.txtExpCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbInsurance = new System.Windows.Forms.ComboBox();
            this.dtpRentStart = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(74, 52);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(94, 29);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "고객조회";
            this.btnClient.UseVisualStyleBackColor = true;
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(333, 54);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(94, 29);
            this.btnCar.TabIndex = 1;
            this.btnCar.Text = "차량조회";
            this.btnCar.UseVisualStyleBackColor = true;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(174, 54);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(125, 27);
            this.txtClientID.TabIndex = 2;
            this.txtClientID.Text = "고객아이디";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(433, 55);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(125, 27);
            this.txtCarID.TabIndex = 3;
            this.txtCarID.Text = "차량아이디";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnContract);
            this.groupBox1.Controls.Add(this.dgvContract);
            this.groupBox1.Location = new System.Drawing.Point(29, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 314);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "계약서이미지등록";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(370, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(465, 244);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnContract
            // 
            this.btnContract.Location = new System.Drawing.Point(370, 209);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(185, 29);
            this.btnContract.TabIndex = 1;
            this.btnContract.Text = "파일불러오기";
            this.btnContract.UseVisualStyleBackColor = true;
            // 
            // dgvContract
            // 
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.Location = new System.Drawing.Point(20, 37);
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.RowHeadersWidth = 51;
            this.dgvContract.RowTemplate.Height = 29;
            this.dgvContract.Size = new System.Drawing.Size(337, 236);
            this.dgvContract.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpRentEnd);
            this.groupBox2.Controls.Add(this.txtExpCost);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbInsurance);
            this.groupBox2.Controls.Add(this.dtpRentStart);
            this.groupBox2.Location = new System.Drawing.Point(29, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 207);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "내역등록";
            // 
            // dtpRentEnd
            // 
            this.dtpRentEnd.Location = new System.Drawing.Point(279, 63);
            this.dtpRentEnd.Name = "dtpRentEnd";
            this.dtpRentEnd.Size = new System.Drawing.Size(211, 27);
            this.dtpRentEnd.TabIndex = 8;
            // 
            // txtExpCost
            // 
            this.txtExpCost.Location = new System.Drawing.Point(279, 141);
            this.txtExpCost.Name = "txtExpCost";
            this.txtExpCost.Size = new System.Drawing.Size(162, 27);
            this.txtExpCost.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "보험선택";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "예상비용";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "반납예정일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "렌트시작일";
            // 
            // cmbInsurance
            // 
            this.cmbInsurance.FormattingEnabled = true;
            this.cmbInsurance.Location = new System.Drawing.Point(35, 140);
            this.cmbInsurance.Name = "cmbInsurance";
            this.cmbInsurance.Size = new System.Drawing.Size(151, 28);
            this.cmbInsurance.TabIndex = 2;
            // 
            // dtpRentStart
            // 
            this.dtpRentStart.Location = new System.Drawing.Point(33, 63);
            this.dtpRentStart.Name = "dtpRentStart";
            this.dtpRentStart.Size = new System.Drawing.Size(211, 27);
            this.dtpRentStart.TabIndex = 0;
            // 
            // FM_RENT_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 671);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.btnClient);
            this.Name = "FM_RENT_ADD";
            this.Text = "FM_RENT_ADD";
            this.Load += new System.EventHandler(this.FM_RENT_ADD_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpRentEnd;
        private System.Windows.Forms.TextBox txtExpCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbInsurance;
        private System.Windows.Forms.DateTimePicker dtpRentStart;
    }
}