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
            if (this.txtName.Text == "") return;
            Car.sCustName = txtName.Text.ToString();
            
            if (this.txtAge.Text == "") return;
            Car.sAge = txtAge.Text.ToString();

            if (this.cboGender.Text == "") return;
            Car.sGender = cboGender.Text.ToString();

            if (this.txtAddress.Text == "") return;
            Car.sCAddress = txtAddress.Text.ToString();
            
            if (this.txtPhone.Text == "") return;
            Car.sPhoneNum = txtPhone.Text.ToString();

            this.Close();
        }
    }
}

