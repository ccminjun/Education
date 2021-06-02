using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEV_FORM
{
    public partial class FM_ClientAdd : Form
    {
        public FM_ClientAdd(string clientCode)
        {
            InitializeComponent();
            this.Tag = "NONE";
        }

        private void FM_ClientAdd_Load(object sender, EventArgs e)
        {
            string sGender = cboGender.Text;
            cboGender.Items.Add("남자");
            cboGender.Items.Add("여자");
            cboGender.DisplayMember = "";
            cboGender.ValueMember = "";
            cboGender.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Car.sCustName = txtName.Text.ToString();
            Car.sAge = txtAge.Text.ToString();
            Car.sGender = cboGender.Text.ToString();
            Car.sCAddress = txtAddress.Text.ToString();
            Car.sPhoneNum = txtPhone.Text.ToString();

            if (this.txtName.Text == "" || this.txtAge.Text == "" || this.cboGender.Text == "" || this.txtAddress.Text == "" || this.txtPhone.Text == "")
            {
                MessageBox.Show("모든 값을 입력해야 추가가 가능합니다.");
                return;
            }
            this.Tag = "OK";
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("해당 화면을 닫으시겠습니까?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            this.Close();
        }
        private void FM_ClientAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("해당 화면을 닫으시겠습니까?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No)
            //{ 
            //    return;
            //}
            //txtName.Refresh();
        }

    }
}

