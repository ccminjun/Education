
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFirstPrice = new System.Windows.Forms.TextBox();
            this.txtLastPrice = new System.Windows.Forms.TextBox();
            this.txtMaker = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbLPG = new System.Windows.Forms.RadioButton();
            this.rdbOil = new System.Windows.Forms.RadioButton();
            this.rdbHybrid = new System.Windows.Forms.RadioButton();
            this.rdbGas = new System.Windows.Forms.RadioButton();
            this.rdbElect = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbBRV = new System.Windows.Forms.RadioButton();
            this.rdbBSUV = new System.Windows.Forms.RadioButton();
            this.rdbMSUV = new System.Windows.Forms.RadioButton();
            this.rdbMS = new System.Windows.Forms.RadioButton();
            this.rdbSSUV = new System.Windows.Forms.RadioButton();
            this.rdbSS = new System.Windows.Forms.RadioButton();
            this.rdbSL = new System.Windows.Forms.RadioButton();
            this.rdbBS = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(48, 306);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(310, 521);
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(400, 521);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtMaker);
            this.groupBox1.Controls.Add(this.txtLastPrice);
            this.groupBox1.Controls.Add(this.txtFirstPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Size = new System.Drawing.Size(439, 108);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "가격";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "~";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(366, 66);
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
            this.txtFirstPrice.Location = new System.Drawing.Point(64, 71);
            this.txtFirstPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstPrice.Name = "txtFirstPrice";
            this.txtFirstPrice.Size = new System.Drawing.Size(112, 25);
            this.txtFirstPrice.TabIndex = 14;
            // 
            // txtLastPrice
            // 
            this.txtLastPrice.Location = new System.Drawing.Point(206, 71);
            this.txtLastPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastPrice.Name = "txtLastPrice";
            this.txtLastPrice.Size = new System.Drawing.Size(112, 25);
            this.txtLastPrice.TabIndex = 15;
            // 
            // txtMaker
            // 
            this.txtMaker.Location = new System.Drawing.Point(280, 26);
            this.txtMaker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaker.Name = "txtMaker";
            this.txtMaker.Size = new System.Drawing.Size(148, 25);
            this.txtMaker.TabIndex = 28;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.rdbLPG);
            this.groupBox3.Controls.Add(this.rdbOil);
            this.groupBox3.Controls.Add(this.rdbHybrid);
            this.groupBox3.Controls.Add(this.rdbGas);
            this.groupBox3.Controls.Add(this.rdbElect);
            this.groupBox3.Location = new System.Drawing.Point(48, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 55);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "차연료";
            // 
            // rdbLPG
            // 
            this.rdbLPG.AutoSize = true;
            this.rdbLPG.Location = new System.Drawing.Point(237, 24);
            this.rdbLPG.Name = "rdbLPG";
            this.rdbLPG.Size = new System.Drawing.Size(57, 19);
            this.rdbLPG.TabIndex = 4;
            this.rdbLPG.TabStop = true;
            this.rdbLPG.Text = "LPG";
            this.rdbLPG.UseVisualStyleBackColor = true;
            // 
            // rdbOil
            // 
            this.rdbOil.AutoSize = true;
            this.rdbOil.Location = new System.Drawing.Point(300, 24);
            this.rdbOil.Name = "rdbOil";
            this.rdbOil.Size = new System.Drawing.Size(46, 19);
            this.rdbOil.TabIndex = 3;
            this.rdbOil.TabStop = true;
            this.rdbOil.Text = "Oil";
            this.rdbOil.UseVisualStyleBackColor = true;
            // 
            // rdbHybrid
            // 
            this.rdbHybrid.AutoSize = true;
            this.rdbHybrid.Location = new System.Drawing.Point(352, 24);
            this.rdbHybrid.Name = "rdbHybrid";
            this.rdbHybrid.Size = new System.Drawing.Size(69, 19);
            this.rdbHybrid.TabIndex = 2;
            this.rdbHybrid.TabStop = true;
            this.rdbHybrid.Text = "Hybrid";
            this.rdbHybrid.UseVisualStyleBackColor = true;
            // 
            // rdbGas
            // 
            this.rdbGas.AutoSize = true;
            this.rdbGas.Location = new System.Drawing.Point(158, 24);
            this.rdbGas.Name = "rdbGas";
            this.rdbGas.Size = new System.Drawing.Size(73, 19);
            this.rdbGas.TabIndex = 1;
            this.rdbGas.TabStop = true;
            this.rdbGas.Text = "휘발유";
            this.rdbGas.UseVisualStyleBackColor = true;
            // 
            // rdbElect
            // 
            this.rdbElect.AutoSize = true;
            this.rdbElect.Location = new System.Drawing.Point(94, 24);
            this.rdbElect.Name = "rdbElect";
            this.rdbElect.Size = new System.Drawing.Size(58, 19);
            this.rdbElect.TabIndex = 0;
            this.rdbElect.TabStop = true;
            this.rdbElect.Text = "전기";
            this.rdbElect.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.rdbBRV);
            this.groupBox4.Controls.Add(this.rdbBSUV);
            this.groupBox4.Controls.Add(this.rdbMSUV);
            this.groupBox4.Controls.Add(this.rdbMS);
            this.groupBox4.Controls.Add(this.rdbSSUV);
            this.groupBox4.Controls.Add(this.rdbSS);
            this.groupBox4.Controls.Add(this.rdbSL);
            this.groupBox4.Controls.Add(this.rdbBS);
            this.groupBox4.Location = new System.Drawing.Point(51, 207);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(436, 94);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "차사이즈";
            // 
            // rdbBRV
            // 
            this.rdbBRV.AutoSize = true;
            this.rdbBRV.Location = new System.Drawing.Point(329, 56);
            this.rdbBRV.Name = "rdbBRV";
            this.rdbBRV.Size = new System.Drawing.Size(81, 19);
            this.rdbBRV.TabIndex = 7;
            this.rdbBRV.TabStop = true;
            this.rdbBRV.Text = "대형 RV";
            this.rdbBRV.UseVisualStyleBackColor = true;
            // 
            // rdbBSUV
            // 
            this.rdbBSUV.AutoSize = true;
            this.rdbBSUV.Location = new System.Drawing.Point(224, 56);
            this.rdbBSUV.Name = "rdbBSUV";
            this.rdbBSUV.Size = new System.Drawing.Size(91, 19);
            this.rdbBSUV.TabIndex = 6;
            this.rdbBSUV.TabStop = true;
            this.rdbBSUV.Text = "대형 SUV";
            this.rdbBSUV.UseVisualStyleBackColor = true;
            // 
            // rdbMSUV
            // 
            this.rdbMSUV.AutoSize = true;
            this.rdbMSUV.Location = new System.Drawing.Point(122, 56);
            this.rdbMSUV.Name = "rdbMSUV";
            this.rdbMSUV.Size = new System.Drawing.Size(91, 19);
            this.rdbMSUV.TabIndex = 5;
            this.rdbMSUV.TabStop = true;
            this.rdbMSUV.Text = "중형 SUV";
            this.rdbMSUV.UseVisualStyleBackColor = true;
            // 
            // rdbMS
            // 
            this.rdbMS.AutoSize = true;
            this.rdbMS.Location = new System.Drawing.Point(349, 29);
            this.rdbMS.Name = "rdbMS";
            this.rdbMS.Size = new System.Drawing.Size(88, 19);
            this.rdbMS.TabIndex = 4;
            this.rdbMS.TabStop = true;
            this.rdbMS.Text = "중형승용";
            this.rdbMS.UseVisualStyleBackColor = true;
            // 
            // rdbSSUV
            // 
            this.rdbSSUV.AutoSize = true;
            this.rdbSSUV.Location = new System.Drawing.Point(19, 56);
            this.rdbSSUV.Name = "rdbSSUV";
            this.rdbSSUV.Size = new System.Drawing.Size(91, 19);
            this.rdbSSUV.TabIndex = 3;
            this.rdbSSUV.TabStop = true;
            this.rdbSSUV.Text = "소형 SUV";
            this.rdbSSUV.UseVisualStyleBackColor = true;
            // 
            // rdbSS
            // 
            this.rdbSS.AutoSize = true;
            this.rdbSS.Location = new System.Drawing.Point(259, 29);
            this.rdbSS.Name = "rdbSS";
            this.rdbSS.Size = new System.Drawing.Size(88, 19);
            this.rdbSS.TabIndex = 2;
            this.rdbSS.TabStop = true;
            this.rdbSS.Text = "소형승용";
            this.rdbSS.UseVisualStyleBackColor = true;
            // 
            // rdbSL
            // 
            this.rdbSL.AutoSize = true;
            this.rdbSL.Location = new System.Drawing.Point(165, 29);
            this.rdbSL.Name = "rdbSL";
            this.rdbSL.Size = new System.Drawing.Size(88, 19);
            this.rdbSL.TabIndex = 1;
            this.rdbSL.TabStop = true;
            this.rdbSL.Text = "소형경차";
            this.rdbSL.UseVisualStyleBackColor = true;
            // 
            // rdbBS
            // 
            this.rdbBS.AutoSize = true;
            this.rdbBS.Location = new System.Drawing.Point(70, 29);
            this.rdbBS.Name = "rdbBS";
            this.rdbBS.Size = new System.Drawing.Size(93, 19);
            this.rdbBS.TabIndex = 0;
            this.rdbBS.TabStop = true;
            this.rdbBS.Text = "대형 승용";
            this.rdbBS.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 19);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "전체";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 19);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "전체";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // FM_SearchCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 575);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "FM_SearchCar";
            this.Text = "자동차조회";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FM_SearchCar_FormClosing);
            this.Controls.SetChildIndex(this.btnSelect, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtLastPrice;
        private System.Windows.Forms.TextBox txtFirstPrice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaker;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbElect;
        private System.Windows.Forms.RadioButton rdbHybrid;
        private System.Windows.Forms.RadioButton rdbGas;
        private System.Windows.Forms.RadioButton rdbLPG;
        private System.Windows.Forms.RadioButton rdbOil;
        private System.Windows.Forms.RadioButton rdbBRV;
        private System.Windows.Forms.RadioButton rdbBSUV;
        private System.Windows.Forms.RadioButton rdbMSUV;
        private System.Windows.Forms.RadioButton rdbMS;
        private System.Windows.Forms.RadioButton rdbSSUV;
        private System.Windows.Forms.RadioButton rdbSS;
        private System.Windows.Forms.RadioButton rdbSL;
        private System.Windows.Forms.RadioButton rdbBS;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}