using DessertPurchasingLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace guiDessertShop
{
    public partial class Cart : Form
    {
        private PurchasingProcess process;
        string currentUser;
        private int balance;
        private ff f;

        public Cart(PurchasingProcess incomingProcess, int userBalance, ff mainFormReference, string username)
        {
            InitializeComponent();
            process = incomingProcess;
            LoadCartToGrid();
            balance = userBalance;
            f = mainFormReference;

            currentUser = username;
        }

        private void Cart_Load(object sender, EventArgs e)
        {

            LoadCartToGrid();
        }
        private void LoadCartToGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in process.getCartDetails())
            {
                dataGridView1.Rows.Add(item.flavor, item.quantity, item.subTotal);
            }
        }

        private void DisplayBalance_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                bool removed = process.removeItem(rowIndex + 1); // +1 since logic expects 1-based

                if (removed)
                {
                    MessageBox.Show("Item removed from cart.");
                    LoadCartToGrid();
                }
                else
                {
                    MessageBox.Show("Failed to remove item.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

            this.Hide();

            f.Show();
            f.ShowAddDeletePanel();
        }

        private void btn_buy_Click(object sender, EventArgs e)

        {
            int totalCost = process.TotalCost();

            if (balance >= totalCost)
            {
                process.ProcessPurchase(currentUser);
                balance -= totalCost;

                f.lbl_Balance.Text = $"PHP {balance}";
                f.updateBalance(balance);

                MessageBox.Show("Purchase complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Insufficient balance to complete the purchase.");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



