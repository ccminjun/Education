
namespace DEV_FORM
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
            this.dtpRentEnd = new System.Windows.Forms.DateTimePicker();
            this.txtExpCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbInsurance = new System.Windows.Forms.ComboBox();
            this.dtpRentStart = new System.Windows.Forms.DateTimePicker();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCost = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnCost);
            this.groupBox1.Controls.Add(this.dtpRentEnd);
            this.groupBox1.Controls.Add(this.txtExpCost);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbInsurance);
            this.groupBox1.Controls.Add(this.dtpRentStart);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.None;
            this.groupBox1.Location = new System.Drawing.Point(26, 76);
            this.groupBox1.Size = new System.Drawing.Size(499, 160);
            this.groupBox1.Text = "내역 등록";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.None;
            this.groupBox2.Location = new System.Drawing.Point(26, 11);
            this.groupBox2.Size = new System.Drawing.Size(499, 58);
            this.groupBox2.Text = "조회";
            // 
            // dtpRentEnd
            // 
            this.dtpRentEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentEnd.Location = new System.Drawing.Point(243, 49);
            this.dtpRentEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpRentEnd.Name = "dtpRentEnd";
            this.dtpRentEnd.Size = new System.Drawing.Size(188, 25);
            this.dtpRentEnd.TabIndex = 16;
            this.dtpRentEnd.Value = new System.DateTime(2021, 6, 2, 0, 0, 0, 0);
            // 
            // txtExpCost
            // 
            this.txtExpCost.Location = new System.Drawing.Point(243, 111);
            this.txtExpCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExpCost.Name = "txtExpCost";
            this.txtExpCost.Size = new System.Drawing.Size(144, 25);
            this.txtExpCost.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "보험선택";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "예상비용";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "반납예정일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "렌트시작일";
            // 
            // cmbInsurance
            // 
            this.cmbInsurance.FormattingEnabled = true;
            this.cmbInsurance.Location = new System.Drawing.Point(26, 112);
            this.cmbInsurance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbInsurance.Name = "cmbInsurance";
            this.cmbInsurance.Size = new System.Drawing.Size(135, 23);
            this.cmbInsurance.TabIndex = 10;
            // 
            // dtpRentStart
            // 
            this.dtpRentStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentStart.Location = new System.Drawing.Point(24, 49);
            this.dtpRentStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpRentStart.Name = "dtpRentStart";
            this.dtpRentStart.Size = new System.Drawing.Size(188, 25);
            this.dtpRentStart.TabIndex = 9;
            this.dtpRentStart.Value = new System.DateTime(2021, 6, 2, 0, 0, 0, 0);
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(371, 32);
            this.txtCarID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(112, 25);
            this.txtCarID.TabIndex = 7;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(140, 31);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(112, 25);
            this.txtClientID.TabIndex = 6;
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(282, 31);
            this.btnCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(84, 30);
            this.btnCar.TabIndex = 5;
            this.btnCar.Text = "차량조회";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(52, 29);
            this.btnClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(84, 30);
            this.btnClient.TabIndex = 4;
            this.btnClient.Text = "고객조회";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(329, 250);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(431, 250);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "닫기";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCost
            // 
            this.btnCost.Location = new System.Drawing.Point(393, 107);
            this.btnCost.Name = "btnCost";
            this.btnCost.Size = new System.Drawing.Size(84, 30);
            this.btnCost.TabIndex = 17;
            this.btnCost.Text = "조회";
            this.btnCost.UseVisualStyleBackColor = true;
            this.btnCost.Click += new System.EventHandler(this.btnCost_Click);
            // 
            // FM_RENT_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 295);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.btnClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FM_RENT_ADD";
            this.Text = "FM_RENT_ADD";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.FM_RENT_ADD_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnClient, 0);
            this.Controls.SetChildIndex(this.btnCar, 0);
            this.Controls.SetChildIndex(this.txtClientID, 0);
            this.Controls.SetChildIndex(this.txtCarID, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpRentEnd;
        private System.Windows.Forms.TextBox txtExpCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbInsurance;
        private System.Windows.Forms.DateTimePicker dtpRentStart;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCost;
    }
}