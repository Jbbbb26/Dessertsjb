using DessertPurchasingLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Numerics;

namespace guiDessertShop
{
    public partial class ff : Form

    {
        private PurchasingProcess process = new PurchasingProcess();
        private SoundPlayer player;
        private bool isPlaying = false;
        string currentUser;
        int userbalance = 0;
        int countBlackForest = 0;
        int countPistachio = 0;
        int countRedVelvet = 0;
        int countClassicBavarian = 0;
        int countChocoButter = 0;
        int countHoneyGlazed = 0;
        public int balance = 0;
        public ff(string username)
        {
            InitializeComponent();
            currentUser = username;
            addDeletePanel.Hide();
          
        }

        private void ff_Load(object sender, EventArgs e)
        {
           
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Cart cartForm = new Cart(process, userbalance, this, currentUser);

            cartForm.Show();
            this.Hide();
        }

        private void btn_addCart_Click(object sender, EventArgs e)
        {

        }

        private void btn_EnterMoney_Click(object sender, EventArgs e)
        {

            int value;
            if (int.TryParse(tb_EnterMoney.Text, out value))
            {
                userbalance = value;
                MessageBox.Show("Success");
                addDeletePanel.Show();
                panelDisplayMoney.Show();
                lbl_Balance.Text = "PHP" + tb_EnterMoney.Text;
                tb_EnterMoney.Clear();
                tb_EnterMoney.Hide();
                btn_EnterMoney.Hide();

            }
            else
            {
                MessageBox.Show("Invalid, PLease Enter Money Only");
            }

        }


        private void tb_EnterMoney_TextChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btn_addBlackF_Click(object sender, EventArgs e)
        {
            countBlackForest++;
            counterBF.Text = countBlackForest.ToString();


        }



        private void btn_addPistacio_Click(object sender, EventArgs e)
        {
            countPistachio++;
            counterPista.Text = countPistachio.ToString();


        }

        private void btn_addRedV_Click(object sender, EventArgs e)
        {

            countRedVelvet++;
            counterRV.Text = countRedVelvet.ToString();
        }


        private void btn_addClassicB_Click(object sender, EventArgs e)
        {

            countClassicBavarian++;
            counterCB.Text = countClassicBavarian.ToString();

        }

        private void btn_addChocoB_Click(object sender, EventArgs e)
        {

            countChocoButter++;
            counterButt.Text = countChocoButter.ToString();

        }

        private void btn_addHoneyG_Click(object sender, EventArgs e)
        {

            countHoneyGlazed++;
            counterHG.Text = countHoneyGlazed.ToString();

        }

        private void btn_del1BlackF_Click(object sender, EventArgs e)
        {
            if (countBlackForest > 0)
            {
                countBlackForest--;
                counterBF.Text = countBlackForest.ToString();
            }
        }

        private void btn_delpistacio_Click(object sender, EventArgs e)
        {
            if (countPistachio > 0)
            {
                countPistachio--;
                counterPista.Text = countPistachio.ToString();
            }
        }

        private void btn_delRedV_Click(object sender, EventArgs e)
        {
            if (countRedVelvet > 0)
            {
                countRedVelvet--;
                counterRV.Text = countRedVelvet.ToString();
            }
        }

        private void btn_delClassicB_Click(object sender, EventArgs e)
        {
            if (countClassicBavarian > 0)
            {
                countClassicBavarian--;
                counterCB.Text = countClassicBavarian.ToString();
            }
        }

        private void btn_delChocoB_Click(object sender, EventArgs e)
        {
            if (countChocoButter > 0)
            {
                countChocoButter--;
                counterButt.Text = countChocoButter.ToString();
            }

        }

        private void btn_delHoneyG_Click(object sender, EventArgs e)
        {
            if (countHoneyGlazed > 0)
            {
                countHoneyGlazed--;
                counterHG.Text = countHoneyGlazed.ToString();
            }
        }

        private void counterBF_Click(object sender, EventArgs e)
        {

        }

        private void counterPista_Click(object sender, EventArgs e)
        {

        }

        private void counterRV_Click(object sender, EventArgs e)
        {

        }

        private void counterCB_Click(object sender, EventArgs e)
        {

        }

        private void counterButt_Click(object sender, EventArgs e)
        {

        }

        private void counterHG_Click(object sender, EventArgs e)
        {

        }

        private void addDeletePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDisplayMoney_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_totalPrice_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Balance_Click(object sender, EventArgs e)
        {

        }

        private void btn_addtocart_Click(object sender, EventArgs e)
        {
            process.clearCart();
            RebuildCart();
            ResetCounters();

            MessageBox.Show("Items Add Successfully!");
        }
        private void RebuildCart()
        {
            process.clearCart();

            if (countBlackForest > 0) process.addItem(1, countBlackForest);
            if (countPistachio > 0) process.addItem(2, countPistachio);
            if (countRedVelvet > 0) process.addItem(3, countRedVelvet);
            if (countClassicBavarian > 0) process.addItem(4, countClassicBavarian);
            if (countChocoButter > 0) process.addItem(5, countChocoButter);
            if (countHoneyGlazed > 0) process.addItem(6, countHoneyGlazed);
        }

        private void lbl_Balance_Click_1(object sender, EventArgs e)
        {

        }
        public void ShowAddDeletePanel()
        {
            addDeletePanel.Show();
        }
        public void updateBalance(int newBalance)
        {
            userbalance = newBalance;
        }
        private void ResetCounters()
        {
            countBlackForest = 0;
            countPistachio = 0;
            countRedVelvet = 0;
            countClassicBavarian = 0;
            countChocoButter = 0;
            countHoneyGlazed = 0;

            counterBF.Text = "0";
            counterPista.Text = "0";
            counterRV.Text = "0";
            counterCB.Text = "0";
            counterButt.Text = "0";
            counterHG.Text = "0";
        }



    }

}
