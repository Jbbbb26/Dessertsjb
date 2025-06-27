using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics;

using DesssertDataLogic;
using DessertPurchasingLogic;
using DessertCommon;
namespace guiDessertShop
{

    public partial class lbl_Shop : Form
    {
        private PurchasingProcess process = new PurchasingProcess();
        public lbl_Shop()
        {
            InitializeComponent();
            tb_pass.UseSystemPasswordChar = true;
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Shop_Load(object sender, EventArgs e)
        {
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = tb_username.Text.Trim();
            string userPass = tb_pass.Text.Trim();


            if (process.ValidateAccountLogin(userName, userPass))
            {
                MessageBox.Show($"Success! Welcome to Arise Dessert Shop {userName}");

                ff f = new ff(userName);
                f.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Invalid");
            }

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            if(tb_pass.UseSystemPasswordChar == true)
            {
                tb_pass.UseSystemPasswordChar = false;
            }
            else
            {
                tb_pass.UseSystemPasswordChar = true;
            }
        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
