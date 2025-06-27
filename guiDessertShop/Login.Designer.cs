namespace guiDessertShop
{
    partial class lbl_Shop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_username = new TextBox();
            tb_pass = new TextBox();
            lbl_username = new Label();
            lbl_pass = new Label();
            btn_login = new Button();
            label1 = new Label();
            btn_hide = new Button();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.Location = new Point(131, 243);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(162, 23);
            tb_username.TabIndex = 1;
            tb_username.TextChanged += tb_username_TextChanged;
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(131, 322);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(162, 23);
            tb_pass.TabIndex = 2;
            tb_pass.UseSystemPasswordChar = true;
            tb_pass.TextChanged += tb_pass_TextChanged;
            // 
            // lbl_username
            // 
            lbl_username.BackColor = Color.Transparent;
            lbl_username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_username.Location = new Point(160, 216);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(100, 24);
            lbl_username.TabIndex = 4;
            lbl_username.Text = "Username";
            lbl_username.Click += label2_Click;
            // 
            // lbl_pass
            // 
            lbl_pass.BackColor = Color.Transparent;
            lbl_pass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_pass.Location = new Point(160, 286);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(100, 24);
            lbl_pass.TabIndex = 5;
            lbl_pass.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.LightSalmon;
            btn_login.FlatStyle = FlatStyle.Popup;
            btn_login.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(160, 366);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(93, 34);
            btn_login.TabIndex = 6;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bodoni MT", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 131);
            label1.Name = "label1";
            label1.Size = new Size(364, 40);
            label1.TabIndex = 7;
            label1.Text = "ARISE DESSERT SHOP";
            label1.Click += label1_Click;
            // 
            // btn_hide
            // 
            btn_hide.BackColor = Color.LightSalmon;
            btn_hide.BackgroundImage = Properties.Resources.unhide_removebg_preview;
            btn_hide.BackgroundImageLayout = ImageLayout.Stretch;
            btn_hide.FlatStyle = FlatStyle.Popup;
            btn_hide.Location = new Point(296, 320);
            btn_hide.Name = "btn_hide";
            btn_hide.Size = new Size(26, 25);
            btn_hide.TabIndex = 8;
            btn_hide.UseVisualStyleBackColor = false;
            btn_hide.Click += btn_hide_Click;
            // 
            // lbl_Shop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            BackgroundImage = Properties.Resources.login_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(418, 522);
            Controls.Add(btn_hide);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Controls.Add(lbl_pass);
            Controls.Add(lbl_username);
            Controls.Add(tb_pass);
            Controls.Add(tb_username);
            Name = "lbl_Shop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dessert Shop";
            Load += lbl_Shop_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_username;
        private TextBox tb_pass;
        private Label lbl_username;
        private Label lbl_pass;
        private Button btn_login;
        private Label label1;
        private Button btn_hide;
    }
}
