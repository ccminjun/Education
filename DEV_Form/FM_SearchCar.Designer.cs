
namespace DEV_FORM
{
    partial class FM_SearchCar
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbElect = new System.Windows.Forms.CheckBox();
            this.chbGas = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chbBS = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFirstPrice = new System.Windows.Forms.TextBox();
            this.txtLastPrice = new System.Windows.Forms.TextBox();
            this.chbLpg = new System.Windows.Forms.CheckBox();
            this.chbHybrid = new System.Windows.Forms.CheckBox();
            this.chbOil = new System.Windows.Forms.CheckBox();
            this.chbSL = new System.Windows.Forms.CheckBox();
            this.chbSS = new System.Windows.Forms.CheckBox();
            this.chbSSUV = new System.Windows.Forms.CheckBox();
            this.chbMSUV = new System.Windows.Forms.CheckBox();
            this.chbBSUV = new System.Windows.Forms.CheckBox();
            this.chbMS = new System.Windows.Forms.CheckBox();
            this.chbBRV = new System.Windows.Forms.CheckBox();
            this.txtMaker = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(45, 242);
            this.groupBox2.Size = new System.Drawing.Size(439, 205);
            // 
            // btnSelect
            // 
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaker);
            this.groupBox1.Controls.Add(this.chbBRV);
            this.groupBox1.Controls.Add(this.chbMS);
            this.groupBox1.Controls.Add(this.chbBSUV);
            this.groupBox1.Controls.Add(this.chbMSUV);
            this.groupBox1.Controls.Add(this.chbSSUV);
            this.groupBox1.Controls.Add(this.chbSS);
            this.groupBox1.Controls.Add(this.chbSL);
            this.groupBox1.Controls.Add(this.chbOil);
            this.groupBox1.Controls.Add(this.chbHybrid);
            this.groupBox1.Controls.Add(this.chbLpg);
            this.groupBox1.Controls.Add(this.txtLastPrice);
            this.groupBox1.Controls.Add(this.txtFirstPrice);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chbBS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chbGas);
            this.groupBox1.Controls.Add(this.chbElect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Size = new System.Drawing.Size(439, 196);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "모델명";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(64, 24);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 25);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "회사명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "차연료";
            // 
            // chbElect
            // 
            this.chbElect.AutoSize = true;
            this.chbElect.Location = new System.Drawing.Point(75, 65);
            this.chbElect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbElect.Name = "chbElect";
            this.chbElect.Size = new System.Drawing.Size(59, 19);
            this.chbElect.TabIndex = 5;
            this.chbElect.Text = "전기";
            this.chbElect.UseVisualStyleBackColor = true;
            // 
            // chbGas
            // 
            this.chbGas.AutoSize = true;
            this.chbGas.Location = new System.Drawing.Point(137, 66);
            this.chbGas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbGas.Name = "chbGas";
            this.chbGas.Size = new System.Drawing.Size(74, 19);
            this.chbGas.TabIndex = 6;
            this.chbGas.Text = "휘발유";
            this.chbGas.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "차사이즈";
            // 
            // chbBS
            // 
            this.chbBS.AutoSize = true;
            this.chbBS.Location = new System.Drawing.Point(75, 98);
            this.chbBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbBS.Name = "chbBS";
            this.chbBS.Size = new System.Drawing.Size(94, 19);
            this.chbBS.TabIndex = 8;
            this.chbBS.Text = "대형 승용";
            this.chbBS.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "가격";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "~";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(366, 160);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 30);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFirstPrice
            // 
            this.txtFirstPrice.Location = new System.Drawing.Point(58, 151);
            this.txtFirstPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstPrice.Name = "txtFirstPrice";
            this.txtFirstPrice.Size = new System.Drawing.Size(112, 25);
            this.txtFirstPrice.TabIndex = 14;
            // 
            // txtLastPrice
            // 
            this.txtLastPrice.Location = new System.Drawing.Point(205, 151);
            this.txtLastPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastPrice.Name = "txtLastPrice";
            this.txtLastPrice.Size = new System.Drawing.Size(112, 25);
            this.txtLastPrice.TabIndex = 15;
            // 
            // chbLpg
            // 
            this.chbLpg.AutoSize = true;
            this.chbLpg.Location = new System.Drawing.Point(210, 66);
            this.chbLpg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbLpg.Name = "chbLpg";
            this.chbLpg.Size = new System.Drawing.Size(58, 19);
            this.chbLpg.TabIndex = 18;
            this.chbLpg.Text = "LPG";
            this.chbLpg.UseVisualStyleBackColor = true;
            // 
            // chbHybrid
            // 
            this.chbHybrid.AutoSize = true;
            this.chbHybrid.Location = new System.Drawing.Point(271, 66);
            this.chbHybrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbHybrid.Name = "chbHybrid";
            this.chbHybrid.Size = new System.Drawing.Size(70, 19);
            this.chbHybrid.TabIndex = 19;
            this.chbHybrid.Text = "Hybrid";
            this.chbHybrid.UseVisualStyleBackColor = true;
            // 
            // chbOil
            // 
            this.chbOil.AutoSize = true;
            this.chbOil.Location = new System.Drawing.Point(343, 66);
            this.chbOil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbOil.Name = "chbOil";
            this.chbOil.Size = new System.Drawing.Size(47, 19);
            this.chbOil.TabIndex = 20;
            this.chbOil.Text = "Oil";
            this.chbOil.UseVisualStyleBackColor = true;
            // 
            // chbSL
            // 
            this.chbSL.AutoSize = true;
            this.chbSL.Location = new System.Drawing.Point(166, 99);
            this.chbSL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbSL.Name = "chbSL";
            this.chbSL.Size = new System.Drawing.Size(94, 19);
            this.chbSL.TabIndex = 21;
            this.chbSL.Text = "소형 경차";
            this.chbSL.UseVisualStyleBackColor = true;
            // 
            // chbSS
            // 
            this.chbSS.AutoSize = true;
            this.chbSS.Location = new System.Drawing.Point(258, 98);
            this.chbSS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbSS.Name = "chbSS";
            this.chbSS.Size = new System.Drawing.Size(94, 19);
            this.chbSS.TabIndex = 22;
            this.chbSS.Text = "소형 승용";
            this.chbSS.UseVisualStyleBackColor = true;
            // 
            // chbSSUV
            // 
            this.chbSSUV.AutoSize = true;
            this.chbSSUV.Location = new System.Drawing.Point(75, 121);
            this.chbSSUV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbSSUV.Name = "chbSSUV";
            this.chbSSUV.Size = new System.Drawing.Size(92, 19);
            this.chbSSUV.TabIndex = 23;
            this.chbSSUV.Text = "소형 SUV";
            this.chbSSUV.UseVisualStyleBackColor = true;
            // 
            // chbMSUV
            // 
            this.chbMSUV.AutoSize = true;
            this.chbMSUV.Location = new System.Drawing.Point(167, 119);
            this.chbMSUV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbMSUV.Name = "chbMSUV";
            this.chbMSUV.Size = new System.Drawing.Size(92, 19);
            this.chbMSUV.TabIndex = 24;
            this.chbMSUV.Text = "중형 SUV";
            this.chbMSUV.UseVisualStyleBackColor = true;
            // 
            // chbBSUV
            // 
            this.chbBSUV.AutoSize = true;
            this.chbBSUV.Location = new System.Drawing.Point(258, 119);
            this.chbBSUV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbBSUV.Name = "chbBSUV";
            this.chbBSUV.Size = new System.Drawing.Size(92, 19);
            this.chbBSUV.TabIndex = 25;
            this.chbBSUV.Text = "대형 SUV";
            this.chbBSUV.UseVisualStyleBackColor = true;
            // 
            // chbMS
            // 
            this.chbMS.AutoSize = true;
            this.chbMS.Location = new System.Drawing.Point(348, 98);
            this.chbMS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbMS.Name = "chbMS";
            this.chbMS.Size = new System.Drawing.Size(94, 19);
            this.chbMS.TabIndex = 26;
            this.chbMS.Text = "중형 승용";
            this.chbMS.UseVisualStyleBackColor = true;
            // 
            // chbBRV
            // 
            this.chbBRV.AutoSize = true;
            this.chbBRV.Location = new System.Drawing.Point(348, 120);
            this.chbBRV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbBRV.Name = "chbBRV";
            this.chbBRV.Size = new System.Drawing.Size(82, 19);
            this.chbBRV.TabIndex = 27;
            this.chbBRV.Text = "대형 RV";
            this.chbBRV.UseVisualStyleBackColor = true;
            // 
            // txtMaker
            // 
            this.txtMaker.Location = new System.Drawing.Point(280, 26);
            this.txtMaker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaker.Name = "txtMaker";
            this.txtMaker.Size = new System.Drawing.Size(148, 25);
            this.txtMaker.TabIndex = 28;
            // 
            // FM_SearchCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 518);
            this.Name = "FM_SearchCar";
            this.Text = "자동차조회";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chbBRV;
        private System.Windows.Forms.CheckBox chbMS;
        private System.Windows.Forms.CheckBox chbBSUV;
        private System.Windows.Forms.CheckBox chbMSUV;
        private System.Windows.Forms.CheckBox chbSSUV;
        private System.Windows.Forms.CheckBox chbSS;
        private System.Windows.Forms.CheckBox chbSL;
        private System.Windows.Forms.CheckBox chbOil;
        private System.Windows.Forms.CheckBox chbHybrid;
        private System.Windows.Forms.CheckBox chbLpg;
        private System.Windows.Forms.TextBox txtLastPrice;
        private System.Windows.Forms.TextBox txtFirstPrice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbBS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbGas;
        private System.Windows.Forms.CheckBox chbElect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaker;
    }
}