namespace guiDessertShop
{
    partial class ff
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
            label_donut = new Label();
            lbl_BF = new Label();
            lbl_cake = new Label();
            lbl_PIS = new Label();
            lbl_RedVel = new Label();
            lbl_Bava = new Label();
            lbl_ChocoButternut = new Label();
            label1 = new Label();
            addDeletePanel = new Panel();
            btn_addHoneyG = new Button();
            btn_addChocoB = new Button();
            btn_addClassicB = new Button();
            btn_addRedV = new Button();
            btn_addPistacio = new Button();
            btn_addBlackF = new Button();
            counterHG = new Label();
            counterButt = new Label();
            counterCB = new Label();
            counterRV = new Label();
            counterPista = new Label();
            counterBF = new Label();
            btn_addtocart = new Button();
            btn_viewCart = new Button();
            btn_delHoneyG = new Button();
            btn_delChocoB = new Button();
            btn_delClassicB = new Button();
            btn_delRedV = new Button();
            btn_delpistacio = new Button();
            btn_del1BlackF = new Button();
            btn_EnterMoney = new Button();
            tb_EnterMoney = new TextBox();
            panelDisplayMoney = new Panel();
            lbl_entermoney = new Label();
            lbl_Balance = new Label();
            displayMoney = new Label();
            addDeletePanel.SuspendLayout();
            panelDisplayMoney.SuspendLayout();
            SuspendLayout();
            // 
            // label_donut
            // 
            label_donut.BackColor = Color.Transparent;
            label_donut.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_donut.Location = new Point(12, 190);
            label_donut.Name = "label_donut";
            label_donut.Size = new Size(88, 33);
            label_donut.TabIndex = 0;
            label_donut.Text = "Donut";
            // 
            // lbl_BF
            // 
            lbl_BF.BackColor = Color.Transparent;
            lbl_BF.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_BF.Location = new Point(12, 60);
            lbl_BF.Name = "lbl_BF";
            lbl_BF.Size = new Size(223, 33);
            lbl_BF.TabIndex = 1;
            lbl_BF.Text = "BlackForest : ₱45";
            // 
            // lbl_cake
            // 
            lbl_cake.BackColor = Color.Transparent;
            lbl_cake.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cake.Location = new Point(12, 10);
            lbl_cake.Name = "lbl_cake";
            lbl_cake.Size = new Size(88, 33);
            lbl_cake.TabIndex = 2;
            lbl_cake.Text = "Cake";
            // 
            // lbl_PIS
            // 
            lbl_PIS.BackColor = Color.Transparent;
            lbl_PIS.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PIS.Location = new Point(12, 100);
            lbl_PIS.Name = "lbl_PIS";
            lbl_PIS.Size = new Size(214, 33);
            lbl_PIS.TabIndex = 3;
            lbl_PIS.Text = "Pistachio : ₱60";
            // 
            // lbl_RedVel
            // 
            lbl_RedVel.BackColor = Color.Transparent;
            lbl_RedVel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_RedVel.Location = new Point(12, 140);
            lbl_RedVel.Name = "lbl_RedVel";
            lbl_RedVel.Size = new Size(223, 33);
            lbl_RedVel.TabIndex = 4;
            lbl_RedVel.Text = "Red Velvet : ₱60";
            // 
            // lbl_Bava
            // 
            lbl_Bava.BackColor = Color.Transparent;
            lbl_Bava.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Bava.Location = new Point(12, 240);
            lbl_Bava.Name = "lbl_Bava";
            lbl_Bava.Size = new Size(285, 33);
            lbl_Bava.TabIndex = 6;
            lbl_Bava.Text = "Classic Bavarian : ₱30";
            // 
            // lbl_ChocoButternut
            // 
            lbl_ChocoButternut.BackColor = Color.Transparent;
            lbl_ChocoButternut.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ChocoButternut.Location = new Point(12, 280);
            lbl_ChocoButternut.Name = "lbl_ChocoButternut";
            lbl_ChocoButternut.Size = new Size(273, 33);
            lbl_ChocoButternut.TabIndex = 7;
            lbl_ChocoButternut.Text = "Choco Butternut : ₱35";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 320);
            label1.Name = "label1";
            label1.Size = new Size(264, 33);
            label1.TabIndex = 8;
            label1.Text = "HoneyGlazed : ₱40";
            label1.Click += label1_Click;
            // 
            // addDeletePanel
            // 
            addDeletePanel.BackColor = Color.FromArgb(0, 0, 0, 0);
            addDeletePanel.BackgroundImageLayout = ImageLayout.Stretch;
            addDeletePanel.BorderStyle = BorderStyle.Fixed3D;
            addDeletePanel.Controls.Add(btn_addHoneyG);
            addDeletePanel.Controls.Add(btn_addChocoB);
            addDeletePanel.Controls.Add(btn_addClassicB);
            addDeletePanel.Controls.Add(btn_addRedV);
            addDeletePanel.Controls.Add(btn_addPistacio);
            addDeletePanel.Controls.Add(btn_addBlackF);
            addDeletePanel.Controls.Add(counterHG);
            addDeletePanel.Controls.Add(counterButt);
            addDeletePanel.Controls.Add(counterCB);
            addDeletePanel.Controls.Add(counterRV);
            addDeletePanel.Controls.Add(counterPista);
            addDeletePanel.Controls.Add(counterBF);
            addDeletePanel.Controls.Add(btn_addtocart);
            addDeletePanel.Controls.Add(btn_viewCart);
            addDeletePanel.Controls.Add(btn_delHoneyG);
            addDeletePanel.Controls.Add(btn_delChocoB);
            addDeletePanel.Controls.Add(btn_delClassicB);
            addDeletePanel.Controls.Add(btn_delRedV);
            addDeletePanel.Controls.Add(btn_delpistacio);
            addDeletePanel.Controls.Add(btn_del1BlackF);
            addDeletePanel.Location = new Point(322, 0);
            addDeletePanel.Name = "addDeletePanel";
            addDeletePanel.Size = new Size(309, 523);
            addDeletePanel.TabIndex = 12;
            addDeletePanel.Paint += addDeletePanel_Paint;
            // 
            // btn_addHoneyG
            // 
            btn_addHoneyG.BackColor = Color.LightSalmon;
            btn_addHoneyG.FlatStyle = FlatStyle.Popup;
            btn_addHoneyG.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addHoneyG.Location = new Point(3, 329);
            btn_addHoneyG.Name = "btn_addHoneyG";
            btn_addHoneyG.Size = new Size(68, 39);
            btn_addHoneyG.TabIndex = 26;
            btn_addHoneyG.Text = "+";
            btn_addHoneyG.UseVisualStyleBackColor = false;
            btn_addHoneyG.Click += btn_addHoneyG_Click;
            // 
            // btn_addChocoB
            // 
            btn_addChocoB.BackColor = Color.LightSalmon;
            btn_addChocoB.FlatStyle = FlatStyle.Popup;
            btn_addChocoB.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addChocoB.Location = new Point(3, 278);
            btn_addChocoB.Name = "btn_addChocoB";
            btn_addChocoB.Size = new Size(68, 39);
            btn_addChocoB.TabIndex = 25;
            btn_addChocoB.Text = "+";
            btn_addChocoB.UseVisualStyleBackColor = false;
            btn_addChocoB.Click += btn_addChocoB_Click;
            // 
            // btn_addClassicB
            // 
            btn_addClassicB.BackColor = Color.LightSalmon;
            btn_addClassicB.FlatStyle = FlatStyle.Popup;
            btn_addClassicB.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addClassicB.Location = new Point(3, 232);
            btn_addClassicB.Name = "btn_addClassicB";
            btn_addClassicB.Size = new Size(68, 39);
            btn_addClassicB.TabIndex = 24;
            btn_addClassicB.Text = "+";
            btn_addClassicB.UseVisualStyleBackColor = false;
            btn_addClassicB.Click += btn_addClassicB_Click;
            // 
            // btn_addRedV
            // 
            btn_addRedV.BackColor = Color.LightSalmon;
            btn_addRedV.FlatStyle = FlatStyle.Popup;
            btn_addRedV.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addRedV.Location = new Point(3, 149);
            btn_addRedV.Name = "btn_addRedV";
            btn_addRedV.Size = new Size(68, 39);
            btn_addRedV.TabIndex = 23;
            btn_addRedV.Text = "+";
            btn_addRedV.UseVisualStyleBackColor = false;
            btn_addRedV.Click += btn_addRedV_Click;
            // 
            // btn_addPistacio
            // 
            btn_addPistacio.BackColor = Color.LightSalmon;
            btn_addPistacio.FlatStyle = FlatStyle.Popup;
            btn_addPistacio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addPistacio.Location = new Point(3, 96);
            btn_addPistacio.Name = "btn_addPistacio";
            btn_addPistacio.Size = new Size(68, 39);
            btn_addPistacio.TabIndex = 22;
            btn_addPistacio.Text = "+";
            btn_addPistacio.UseVisualStyleBackColor = false;
            btn_addPistacio.Click += btn_addPistacio_Click;
            // 
            // btn_addBlackF
            // 
            btn_addBlackF.BackColor = Color.LightSalmon;
            btn_addBlackF.FlatStyle = FlatStyle.Popup;
            btn_addBlackF.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addBlackF.Location = new Point(-2, 46);
            btn_addBlackF.Name = "btn_addBlackF";
            btn_addBlackF.Size = new Size(68, 39);
            btn_addBlackF.TabIndex = 21;
            btn_addBlackF.Text = "+";
            btn_addBlackF.UseVisualStyleBackColor = false;
            btn_addBlackF.Click += btn_addBlackF_Click;
            // 
            // counterHG
            // 
            counterHG.BackColor = Color.LightSalmon;
            counterHG.Font = new Font("Microsoft Sans Serif", 11.25F);
            counterHG.Location = new Point(166, 329);
            counterHG.Name = "counterHG";
            counterHG.Size = new Size(44, 39);
            counterHG.TabIndex = 20;
            counterHG.TextAlign = ContentAlignment.MiddleCenter;
            counterHG.Click += counterHG_Click;
            // 
            // counterButt
            // 
            counterButt.BackColor = Color.LightSalmon;
            counterButt.Font = new Font("Microsoft Sans Serif", 11.25F);
            counterButt.Location = new Point(166, 278);
            counterButt.Name = "counterButt";
            counterButt.Size = new Size(44, 39);
            counterButt.TabIndex = 19;
            counterButt.TextAlign = ContentAlignment.MiddleCenter;
            counterButt.Click += counterButt_Click;
            // 
            // counterCB
            // 
            counterCB.BackColor = Color.LightSalmon;
            counterCB.Font = new Font("Microsoft Sans Serif", 11.25F);
            counterCB.Location = new Point(166, 232);
            counterCB.Name = "counterCB";
            counterCB.Size = new Size(44, 39);
            counterCB.TabIndex = 18;
            counterCB.TextAlign = ContentAlignment.MiddleCenter;
            counterCB.Click += counterCB_Click;
            // 
            // counterRV
            // 
            counterRV.BackColor = Color.LightSalmon;
            counterRV.Font = new Font("Microsoft Sans Serif", 11.25F);
            counterRV.Location = new Point(166, 149);
            counterRV.Name = "counterRV";
            counterRV.Size = new Size(44, 39);
            counterRV.TabIndex = 17;
            counterRV.TextAlign = ContentAlignment.MiddleCenter;
            counterRV.Click += counterRV_Click;
            // 
            // counterPista
            // 
            counterPista.BackColor = Color.LightSalmon;
            counterPista.Font = new Font("Microsoft Sans Serif", 11.25F);
            counterPista.Location = new Point(166, 96);
            counterPista.Name = "counterPista";
            counterPista.Size = new Size(44, 39);
            counterPista.TabIndex = 16;
            counterPista.TextAlign = ContentAlignment.MiddleCenter;
            counterPista.Click += counterPista_Click;
            // 
            // counterBF
            // 
            counterBF.BackColor = Color.LightSalmon;
            counterBF.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            counterBF.Location = new Point(166, 46);
            counterBF.Name = "counterBF";
            counterBF.Size = new Size(44, 39);
            counterBF.TabIndex = 15;
            counterBF.TextAlign = ContentAlignment.MiddleCenter;
            counterBF.Click += counterBF_Click;
            // 
            // btn_addtocart
            // 
            btn_addtocart.BackColor = Color.LightSalmon;
            btn_addtocart.FlatStyle = FlatStyle.Popup;
            btn_addtocart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addtocart.Location = new Point(3, 424);
            btn_addtocart.Name = "btn_addtocart";
            btn_addtocart.Size = new Size(118, 39);
            btn_addtocart.TabIndex = 14;
            btn_addtocart.Text = "Add to Cart";
            btn_addtocart.UseVisualStyleBackColor = false;
            btn_addtocart.Click += btn_addtocart_Click;
            // 
            // btn_viewCart
            // 
            btn_viewCart.BackColor = Color.LightSalmon;
            btn_viewCart.BackgroundImage = Properties.Resources.addcart_removebg_preview;
            btn_viewCart.BackgroundImageLayout = ImageLayout.Stretch;
            btn_viewCart.FlatStyle = FlatStyle.Popup;
            btn_viewCart.ForeColor = SystemColors.AppWorkspace;
            btn_viewCart.Location = new Point(250, 8);
            btn_viewCart.Name = "btn_viewCart";
            btn_viewCart.Size = new Size(47, 39);
            btn_viewCart.TabIndex = 13;
            btn_viewCart.UseVisualStyleBackColor = false;
            btn_viewCart.Click += button1_Click;
            // 
            // btn_delHoneyG
            // 
            btn_delHoneyG.BackColor = Color.LightSalmon;
            btn_delHoneyG.FlatStyle = FlatStyle.Popup;
            btn_delHoneyG.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delHoneyG.Location = new Point(77, 329);
            btn_delHoneyG.Name = "btn_delHoneyG";
            btn_delHoneyG.Size = new Size(68, 39);
            btn_delHoneyG.TabIndex = 11;
            btn_delHoneyG.Text = "-";
            btn_delHoneyG.UseVisualStyleBackColor = false;
            btn_delHoneyG.Click += btn_delHoneyG_Click;
            // 
            // btn_delChocoB
            // 
            btn_delChocoB.BackColor = Color.LightSalmon;
            btn_delChocoB.FlatStyle = FlatStyle.Popup;
            btn_delChocoB.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delChocoB.Location = new Point(77, 278);
            btn_delChocoB.Name = "btn_delChocoB";
            btn_delChocoB.Size = new Size(68, 39);
            btn_delChocoB.TabIndex = 10;
            btn_delChocoB.Text = "-";
            btn_delChocoB.UseVisualStyleBackColor = false;
            btn_delChocoB.Click += btn_delChocoB_Click;
            // 
            // btn_delClassicB
            // 
            btn_delClassicB.BackColor = Color.LightSalmon;
            btn_delClassicB.FlatStyle = FlatStyle.Popup;
            btn_delClassicB.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delClassicB.Location = new Point(77, 233);
            btn_delClassicB.Name = "btn_delClassicB";
            btn_delClassicB.Size = new Size(68, 39);
            btn_delClassicB.TabIndex = 7;
            btn_delClassicB.Text = "-";
            btn_delClassicB.UseVisualStyleBackColor = false;
            btn_delClassicB.Click += btn_delClassicB_Click;
            // 
            // btn_delRedV
            // 
            btn_delRedV.BackColor = Color.LightSalmon;
            btn_delRedV.FlatStyle = FlatStyle.Popup;
            btn_delRedV.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delRedV.Location = new Point(77, 148);
            btn_delRedV.Name = "btn_delRedV";
            btn_delRedV.Size = new Size(68, 39);
            btn_delRedV.TabIndex = 5;
            btn_delRedV.Text = "-";
            btn_delRedV.UseVisualStyleBackColor = false;
            btn_delRedV.Click += btn_delRedV_Click;
            // 
            // btn_delpistacio
            // 
            btn_delpistacio.BackColor = Color.LightSalmon;
            btn_delpistacio.FlatStyle = FlatStyle.Popup;
            btn_delpistacio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delpistacio.Location = new Point(77, 96);
            btn_delpistacio.Name = "btn_delpistacio";
            btn_delpistacio.Size = new Size(68, 39);
            btn_delpistacio.TabIndex = 2;
            btn_delpistacio.Text = "-";
            btn_delpistacio.UseVisualStyleBackColor = false;
            btn_delpistacio.Click += btn_delpistacio_Click;
            // 
            // btn_del1BlackF
            // 
            btn_del1BlackF.BackColor = Color.LightSalmon;
            btn_del1BlackF.FlatStyle = FlatStyle.Popup;
            btn_del1BlackF.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_del1BlackF.Location = new Point(77, 46);
            btn_del1BlackF.Name = "btn_del1BlackF";
            btn_del1BlackF.Size = new Size(68, 39);
            btn_del1BlackF.TabIndex = 1;
            btn_del1BlackF.Text = "-";
            btn_del1BlackF.UseVisualStyleBackColor = false;
            btn_del1BlackF.Click += btn_del1BlackF_Click;
            // 
            // btn_EnterMoney
            // 
            btn_EnterMoney.BackColor = Color.LightSalmon;
            btn_EnterMoney.FlatStyle = FlatStyle.Popup;
            btn_EnterMoney.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_EnterMoney.Location = new Point(218, 72);
            btn_EnterMoney.Name = "btn_EnterMoney";
            btn_EnterMoney.Size = new Size(95, 39);
            btn_EnterMoney.TabIndex = 17;
            btn_EnterMoney.Text = "Enter";
            btn_EnterMoney.UseVisualStyleBackColor = false;
            btn_EnterMoney.Click += btn_EnterMoney_Click;
            // 
            // tb_EnterMoney
            // 
            tb_EnterMoney.Location = new Point(0, 78);
            tb_EnterMoney.Multiline = true;
            tb_EnterMoney.Name = "tb_EnterMoney";
            tb_EnterMoney.Size = new Size(152, 31);
            tb_EnterMoney.TabIndex = 18;
            tb_EnterMoney.TextChanged += tb_EnterMoney_TextChanged;
            // 
            // panelDisplayMoney
            // 
            panelDisplayMoney.BackColor = Color.Transparent;
            panelDisplayMoney.Controls.Add(lbl_entermoney);
            panelDisplayMoney.Controls.Add(tb_EnterMoney);
            panelDisplayMoney.Controls.Add(btn_EnterMoney);
            panelDisplayMoney.Controls.Add(lbl_Balance);
            panelDisplayMoney.Controls.Add(displayMoney);
            panelDisplayMoney.Location = new Point(3, 356);
            panelDisplayMoney.Name = "panelDisplayMoney";
            panelDisplayMoney.Size = new Size(318, 132);
            panelDisplayMoney.TabIndex = 19;
            panelDisplayMoney.Paint += panelDisplayMoney_Paint;
            // 
            // lbl_entermoney
            // 
            lbl_entermoney.BackColor = Color.Transparent;
            lbl_entermoney.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_entermoney.Location = new Point(3, 43);
            lbl_entermoney.Name = "lbl_entermoney";
            lbl_entermoney.Size = new Size(118, 30);
            lbl_entermoney.TabIndex = 20;
            lbl_entermoney.Text = "Enter Money";
            // 
            // lbl_Balance
            // 
            lbl_Balance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Balance.Location = new Point(98, 78);
            lbl_Balance.Name = "lbl_Balance";
            lbl_Balance.Size = new Size(100, 35);
            lbl_Balance.TabIndex = 1;
            lbl_Balance.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Balance.Click += lbl_Balance_Click_1;
            // 
            // displayMoney
            // 
            displayMoney.BackColor = Color.LightSalmon;
            displayMoney.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displayMoney.Location = new Point(0, 80);
            displayMoney.Name = "displayMoney";
            displayMoney.Size = new Size(92, 25);
            displayMoney.TabIndex = 0;
            displayMoney.Text = "Balance :";
            // 
            // ff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.displayProdbg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(633, 519);
            Controls.Add(panelDisplayMoney);
            Controls.Add(label1);
            Controls.Add(lbl_ChocoButternut);
            Controls.Add(lbl_Bava);
            Controls.Add(lbl_RedVel);
            Controls.Add(lbl_PIS);
            Controls.Add(lbl_cake);
            Controls.Add(lbl_BF);
            Controls.Add(label_donut);
            Controls.Add(addDeletePanel);
            Name = "ff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            Load += ff_Load;
            addDeletePanel.ResumeLayout(false);
            panelDisplayMoney.ResumeLayout(false);
            panelDisplayMoney.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_donut;
        private Label lbl_BF;
        private Label lbl_cake;
        private Label lbl_PIS;
        private Label lbl_RedVel;
        private Label lbl_Bava;
        private Label lbl_ChocoButternut;
        private Label label1;
        private Panel addDeletePanel;
        private Button btn_del1BlackF;
        private Button btn_delpistacio;
        private Button btn_delRedV;
        private Button btn_delHoneyG;
        private Button btn_delChocoB;
        private Button btn_delClassicB;
        private Button btn_viewCart;
        private Button btn_EnterMoney;
        private TextBox tb_EnterMoney;
        private Button btn_addtocart;
        private Label counterBF;
        private Label counterHG;
        private Label counterButt;
        private Label counterCB;
        private Label counterRV;
        private Label counterPista;
        private Button btn_addBlackF;
        private Button btn_addPistacio;
        private Button btn_addRedV;
        private Button btn_addClassicB;
        private Button btn_addChocoB;
        private Button btn_addHoneyG;
        private Panel panelDisplayMoney;
        private Label displayMoney;
        public Label lbl_Balance;
        private Label lbl_entermoney;
    }
}