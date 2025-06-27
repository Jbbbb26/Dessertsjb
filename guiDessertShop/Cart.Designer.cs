namespace guiDessertShop
{
    partial class Cart
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
            btn_delete = new Button();
            btn_buy = new Button();
            dataGridView1 = new DataGridView();
            Flavors = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btn_back = new Button();
            btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.LightSalmon;
            btn_delete.FlatStyle = FlatStyle.Popup;
            btn_delete.Location = new Point(134, 333);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(96, 42);
            btn_delete.TabIndex = 1;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_buy
            // 
            btn_buy.BackColor = Color.LightSalmon;
            btn_buy.FlatStyle = FlatStyle.Popup;
            btn_buy.Location = new Point(28, 333);
            btn_buy.Name = "btn_buy";
            btn_buy.Size = new Size(96, 42);
            btn_buy.TabIndex = 2;
            btn_buy.Text = "Buy";
            btn_buy.UseVisualStyleBackColor = false;
            btn_buy.Click += btn_buy_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Flavors, Quantity, Subtotal });
            dataGridView1.Location = new Point(28, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(341, 208);
            dataGridView1.TabIndex = 3;
            // 
            // Flavors
            // 
            Flavors.HeaderText = "Flavors";
            Flavors.Name = "Flavors";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.LightSalmon;
            btn_back.FlatStyle = FlatStyle.Popup;
            btn_back.Location = new Point(454, 333);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(96, 42);
            btn_back.TabIndex = 6;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.LightSalmon;
            btn_exit.FlatStyle = FlatStyle.Popup;
            btn_exit.Location = new Point(568, 333);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(96, 42);
            btn_exit.TabIndex = 7;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.displayProdbg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(676, 415);
            Controls.Add(btn_exit);
            Controls.Add(btn_back);
            Controls.Add(dataGridView1);
            Controls.Add(btn_buy);
            Controls.Add(btn_delete);
            Name = "Cart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cart";
            Load += Cart_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_delete;
        private Button btn_buy;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Flavors;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Subtotal;
        private Button btn_back;
        private Button btn_exit;
    }
}