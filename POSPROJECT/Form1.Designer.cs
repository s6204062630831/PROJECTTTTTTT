
namespace POSPROJECT
{
    partial class LoginFrom
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.TextBox_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_login = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ComboBox_role = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 591);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(477, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Crimson;
            this.label_exit.Location = new System.Drawing.Point(748, 9);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(28, 27);
            this.label_exit.TabIndex = 2;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label2_Click);
            this.label_exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_exit_MouseClick);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.Crimson;
            this.label_password.Location = new System.Drawing.Point(293, 306);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(140, 27);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "PASSWORD";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.Crimson;
            this.label_username.Location = new System.Drawing.Point(293, 239);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(140, 27);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "USERNAME";
            // 
            // TextBox_username
            // 
            this.TextBox_username.BorderRadius = 18;
            this.TextBox_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_username.DefaultText = "";
            this.TextBox_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_username.DisabledState.Parent = this.TextBox_username;
            this.TextBox_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_username.FocusedState.Parent = this.TextBox_username;
            this.TextBox_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_username.HoverState.Parent = this.TextBox_username;
            this.TextBox_username.Location = new System.Drawing.Point(524, 230);
            this.TextBox_username.Name = "TextBox_username";
            this.TextBox_username.PasswordChar = '\0';
            this.TextBox_username.PlaceholderText = "";
            this.TextBox_username.SelectedText = "";
            this.TextBox_username.ShadowDecoration.Parent = this.TextBox_username;
            this.TextBox_username.Size = new System.Drawing.Size(200, 36);
            this.TextBox_username.TabIndex = 5;
            this.TextBox_username.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // TextBox_password
            // 
            this.TextBox_password.BorderRadius = 18;
            this.TextBox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_password.DefaultText = "";
            this.TextBox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_password.DisabledState.Parent = this.TextBox_password;
            this.TextBox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.FocusedState.Parent = this.TextBox_password;
            this.TextBox_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.HoverState.Parent = this.TextBox_password;
            this.TextBox_password.Location = new System.Drawing.Point(524, 297);
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.PasswordChar = '\0';
            this.TextBox_password.PlaceholderText = "";
            this.TextBox_password.SelectedText = "";
            this.TextBox_password.ShadowDecoration.Parent = this.TextBox_password;
            this.TextBox_password.Size = new System.Drawing.Size(200, 36);
            this.TextBox_password.TabIndex = 6;
            this.TextBox_password.TextChanged += new System.EventHandler(this.TextBox_password_TextChanged);
            // 
            // Button_login
            // 
            this.Button_login.BorderRadius = 18;
            this.Button_login.CheckedState.Parent = this.Button_login;
            this.Button_login.CustomImages.Parent = this.Button_login;
            this.Button_login.FillColor = System.Drawing.Color.Crimson;
            this.Button_login.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_login.ForeColor = System.Drawing.Color.White;
            this.Button_login.HoverState.Parent = this.Button_login;
            this.Button_login.Location = new System.Drawing.Point(444, 380);
            this.Button_login.Name = "Button_login";
            this.Button_login.ShadowDecoration.Parent = this.Button_login;
            this.Button_login.Size = new System.Drawing.Size(180, 45);
            this.Button_login.TabIndex = 7;
            this.Button_login.Text = "LOGIN";
            this.Button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 18;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ComboBox_role
            // 
            this.ComboBox_role.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_role.BorderRadius = 18;
            this.ComboBox_role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_role.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_role.FocusedState.Parent = this.ComboBox_role;
            this.ComboBox_role.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_role.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_role.HoverState.Parent = this.ComboBox_role;
            this.ComboBox_role.ItemHeight = 30;
            this.ComboBox_role.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.ComboBox_role.ItemsAppearance.Parent = this.ComboBox_role;
            this.ComboBox_role.Location = new System.Drawing.Point(517, 140);
            this.ComboBox_role.Name = "ComboBox_role";
            this.ComboBox_role.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboBox_role.ShadowDecoration.Parent = this.ComboBox_role;
            this.ComboBox_role.Size = new System.Drawing.Size(207, 36);
            this.ComboBox_role.TabIndex = 8;
            this.ComboBox_role.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(280, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "SELECT ROLE";
            // 
            // LoginFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(788, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBox_role);
            this.Controls.Add(this.Button_login);
            this.Controls.Add(this.TextBox_password);
            this.Controls.Add(this.TextBox_username);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFrom";
            this.Load += new System.EventHandler(this.LoginFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_username;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_password;
        private Guna.UI2.WinForms.Guna2Button Button_login;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_role;
        private System.Windows.Forms.Label label2;
    }
}

