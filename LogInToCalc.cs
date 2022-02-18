using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class LogInToCalc : Form
    {
        public object MessageBoxIcons { get; private set; }

        public LogInToCalc()
        {
            InitializeComponent();
        }
        private bool IsLoggedIn()
        {
            var name = txt_UserName.Text;
            var pass = txt_PassWord.Text;
            var output = false;
            if (name == "isaac" && pass == "12345")
            {
                output = (check_Male.Checked == true || check_Female.Checked == true);
            }
            return output;
        }
        private void btn_LogIn_Click(object sender, EventArgs e)
        {

            if (IsLoggedIn())
            {
                Hide();
                new Form1().ShowDialog();
            }
            else
            {
                FireErrorMessage();
            }
        }
        private static void FireErrorMessage()
        {
            MessageBox.Show("complete essential fields", "Error",
           MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void check_Male_CheckedChanged(object sender, EventArgs e)
        {
            check_Female.Checked = false;
        }

        private void check_Female_CheckedChanged(object sender, EventArgs e)
        {
            check_Male.Checked = false;
        }
        private void ResetControls()
        {
            txt_UserName.Text = "";
            txt_PassWord.Text = "";
            check_Male.Checked = false;
            check_Female.Checked = false;
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }
    }
}
