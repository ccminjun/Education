using System;
using System.Windows.Forms;
using System.Reflection;

namespace ApplicationDev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FM_LogIn FrmLogIn = new FM_LogIn();
            FrmLogIn.ShowDialog();
            if (FrmLogIn.Tag.ToString() == "FAIL")
            {
                // 로그인 실패 시 스레드 종료 및 어플리케이션 죵료
                Application.ExitThread();
                Environment.Exit(0);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            FormOpen("FM_Main");
        }

        private void FormOpen(string fName)
        {
            Assembly assembly = Assembly.LoadFrom(Application.StartupPath + @"\" + "DEV_FORM.DLL");
            Type typeForm = assembly.GetType("DEV_FORM." + fName, true);
            Form Test = (Form)Activator.CreateInstance(typeForm);


            //Test.MdiParent = this;
            // Test.WindowState = FormWindowState.Maximized;  // 화면 가득 채우기
            Test.TopLevel = false;
            panelMain.Controls.Add(Test);
            Test.Show();
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn = (Button)sender;
            FormOpen(btn.Name);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

