
namespace DEV_FORM
{
    partial class FM_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Available = new System.Windows.Forms.Label();
            this.Using = new System.Windows.Forms.Label();
            this.Fixing = new System.Windows.Forms.Label();
            this.Disposal = new System.Windows.Forms.Label();
            this.Delay = new System.Windows.Forms.Label();
            this.picDelay = new System.Windows.Forms.PictureBox();
            this.picDisposal = new System.Windows.Forms.PictureBox();
            this.picFixing = new System.Windows.Forms.PictureBox();
            this.picUsing = new System.Windows.Forms.PictureBox();
            this.picAvailable = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisposal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFixing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Delay);
            this.groupBox1.Controls.Add(this.Disposal);
            this.groupBox1.Controls.Add(this.Fixing);
            this.groupBox1.Controls.Add(this.Using);
            this.groupBox1.Controls.Add(this.Available);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.picDelay);
            this.groupBox1.Controls.Add(this.picDisposal);
            this.groupBox1.Controls.Add(this.picFixing);
            this.groupBox1.Controls.Add(this.picUsing);
            this.groupBox1.Controls.Add(this.picAvailable);
            this.groupBox1.Size = new System.Drawing.Size(1601, 172);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 172);
            this.groupBox2.Size = new System.Drawing.Size(1601, 438);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용가능";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "사용중";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "정비중";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "폐기차량";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(833, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "연체차량";
            // 
            // Available
            // 
            this.Available.AutoSize = true;
            this.Available.Location = new System.Drawing.Point(194, 140);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(0, 15);
            this.Available.TabIndex = 9;
            // 
            // Using
            // 
            this.Using.AutoSize = true;
            this.Using.Location = new System.Drawing.Point(364, 140);
            this.Using.Name = "Using";
            this.Using.Size = new System.Drawing.Size(0, 15);
            this.Using.TabIndex = 10;
            // 
            // Fixing
            // 
            this.Fixing.AutoSize = true;
            this.Fixing.Location = new System.Drawing.Point(534, 140);
            this.Fixing.Name = "Fixing";
            this.Fixing.Size = new System.Drawing.Size(0, 15);
            this.Fixing.TabIndex = 11;
            // 
            // Disposal
            // 
            this.Disposal.AutoSize = true;
            this.Disposal.Location = new System.Drawing.Point(728, 140);
            this.Disposal.Name = "Disposal";
            this.Disposal.Size = new System.Drawing.Size(0, 15);
            this.Disposal.TabIndex = 12;
            // 
            // Delay
            // 
            this.Delay.AutoSize = true;
            this.Delay.Location = new System.Drawing.Point(906, 140);
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(0, 15);
            this.Delay.TabIndex = 13;
            // 
            // picDelay
            // 
            this.picDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDelay.Image = global::DEV_FORM.Properties.Resources.free_icon_calendar_3366047;
            this.picDelay.Location = new System.Drawing.Point(821, 29);
            this.picDelay.Name = "picDelay";
            this.picDelay.Size = new System.Drawing.Size(100, 100);
            this.picDelay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelay.TabIndex = 4;
            this.picDelay.TabStop = false;
            // 
            // picDisposal
            // 
            this.picDisposal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDisposal.Image = global::DEV_FORM.Properties.Resources.free_icon_crane_truck_3366263;
            this.picDisposal.Location = new System.Drawing.Point(643, 28);
            this.picDisposal.Name = "picDisposal";
            this.picDisposal.Size = new System.Drawing.Size(100, 100);
            this.picDisposal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDisposal.TabIndex = 3;
            this.picDisposal.TabStop = false;
            // 
            // picFixing
            // 
            this.picFixing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFixing.Image = global::DEV_FORM.Properties.Resources.free_icon_car_repair_3366454;
            this.picFixing.Location = new System.Drawing.Point(463, 28);
            this.picFixing.Name = "picFixing";
            this.picFixing.Size = new System.Drawing.Size(100, 100);
            this.picFixing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFixing.TabIndex = 2;
            this.picFixing.TabStop = false;
            // 
            // picUsing
            // 
            this.picUsing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUsing.Image = global::DEV_FORM.Properties.Resources.free_icon_car_3366098;
            this.picUsing.Location = new System.Drawing.Point(288, 28);
            this.picUsing.Name = "picUsing";
            this.picUsing.Size = new System.Drawing.Size(100, 100);
            this.picUsing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsing.TabIndex = 1;
            this.picUsing.TabStop = false;
            // 
            // picAvailable
            // 
            this.picAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvailable.Image = global::DEV_FORM.Properties.Resources.free_icon_car_insurance_3366403;
            this.picAvailable.Location = new System.Drawing.Point(113, 28);
            this.picAvailable.Name = "picAvailable";
            this.picAvailable.Size = new System.Drawing.Size(100, 100);
            this.picAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvailable.TabIndex = 0;
            this.picAvailable.TabStop = false;
            // 
            // FM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1601, 610);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FM_Main";
            this.Text = "메인화면";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.FM_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisposal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFixing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvailable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picDelay;
        private System.Windows.Forms.PictureBox picDisposal;
        private System.Windows.Forms.PictureBox picFixing;
        private System.Windows.Forms.PictureBox picUsing;
        private System.Windows.Forms.PictureBox picAvailable;
        private System.Windows.Forms.Label Delay;
        private System.Windows.Forms.Label Disposal;
        private System.Windows.Forms.Label Fixing;
        private System.Windows.Forms.Label Using;
        private System.Windows.Forms.Label Available;
    }
}
