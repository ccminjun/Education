
namespace DEV_FORM
{
    partial class FM_CarAdd
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCarSize = new System.Windows.Forms.ComboBox();
            this.cboCarType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCarNum = new System.Windows.Forms.TextBox();
            this.txtRentPrice = new System.Windows.Forms.TextBox();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.txtCarMaker = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.dtpDate);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cboCarSize);
            this.groupBox4.Controls.Add(this.cboCarType);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnInput);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(711, 93);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "차량 선택";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(422, 24);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(182, 25);
            this.dtpDate.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "구매일시";
            // 
            // cboCarSize
            // 
            this.cboCarSize.FormattingEnabled = true;
            this.cboCarSize.Location = new System.Drawing.Point(92, 64);
            this.cboCarSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCarSize.Name = "cboCarSize";
            this.cboCarSize.Size = new System.Drawing.Size(188, 23);
            this.cboCarSize.TabIndex = 5;
            // 
            // cboCarType
            // 
            this.cboCarType.FormattingEnabled = true;
            this.cboCarType.Location = new System.Drawing.Point(92, 23);
            this.cboCarType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCarType.Name = "cboCarType";
            this.cboCarType.Size = new System.Drawing.Size(188, 23);
            this.cboCarType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "사이즈";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "연료";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(422, 58);
            this.btnInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(99, 30);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "입력";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCarNum);
            this.groupBox3.Controls.Add(this.txtRentPrice);
            this.groupBox3.Controls.Add(this.txtCarName);
            this.groupBox3.Controls.Add(this.txtCarMaker);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 99);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(711, 118);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "차량 정보";
            // 
            // txtCarNum
            // 
            this.txtCarNum.Location = new System.Drawing.Point(433, 33);
            this.txtCarNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarNum.Name = "txtCarNum";
            this.txtCarNum.Size = new System.Drawing.Size(180, 25);
            this.txtCarNum.TabIndex = 11;
            // 
            // txtRentPrice
            // 
            this.txtRentPrice.Location = new System.Drawing.Point(433, 69);
            this.txtRentPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRentPrice.Name = "txtRentPrice";
            this.txtRentPrice.Size = new System.Drawing.Size(182, 25);
            this.txtRentPrice.TabIndex = 10;
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(102, 69);
            this.txtCarName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(188, 25);
            this.txtCarName.TabIndex = 9;
            // 
            // txtCarMaker
            // 
            this.txtCarMaker.Location = new System.Drawing.Point(102, 33);
            this.txtCarMaker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarMaker.Name = "txtCarMaker";
            this.txtCarMaker.Size = new System.Drawing.Size(188, 25);
            this.txtCarMaker.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "렌트 가격";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "차량 명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "차량 번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "제조사";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "닫기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FM_CarAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 217);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FM_CarAdd";
            this.Text = "FM_CarAdd";
            this.Load += new System.EventHandler(this.FM_CarAdd_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCarSize;
        private System.Windows.Forms.ComboBox cboCarType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCarNum;
        private System.Windows.Forms.TextBox txtRentPrice;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtCarMaker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}