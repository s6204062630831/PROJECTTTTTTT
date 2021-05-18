
namespace POSPROJECT
{
    partial class SellerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Product = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Selling = new Guna.UI2.WinForms.Guna2Button();
            this.label_logout = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label_age = new System.Windows.Forms.Label();
            this.TextBox_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_age = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_add = new Guna.UI2.WinForms.Guna2Button();
            this.Button_update = new Guna.UI2.WinForms.Guna2Button();
            this.Button_delete = new Guna.UI2.WinForms.Guna2Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.Button_Category = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.dataGridView_seller = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seller)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 18;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELLER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Button_Product
            // 
            this.Button_Product.BorderRadius = 15;
            this.Button_Product.CheckedState.Parent = this.Button_Product;
            this.Button_Product.CustomImages.Parent = this.Button_Product;
            this.Button_Product.FillColor = System.Drawing.Color.Pink;
            this.Button_Product.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Product.ForeColor = System.Drawing.Color.Tomato;
            this.Button_Product.HoverState.Parent = this.Button_Product;
            this.Button_Product.Location = new System.Drawing.Point(12, 93);
            this.Button_Product.Name = "Button_Product";
            this.Button_Product.ShadowDecoration.Parent = this.Button_Product;
            this.Button_Product.Size = new System.Drawing.Size(135, 53);
            this.Button_Product.TabIndex = 18;
            this.Button_Product.Text = "Product";
            this.Button_Product.Click += new System.EventHandler(this.Button_Product_Click);
            // 
            // Button_Selling
            // 
            this.Button_Selling.BorderRadius = 15;
            this.Button_Selling.CheckedState.Parent = this.Button_Selling;
            this.Button_Selling.CustomImages.Parent = this.Button_Selling;
            this.Button_Selling.FillColor = System.Drawing.Color.Pink;
            this.Button_Selling.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Selling.ForeColor = System.Drawing.Color.Tomato;
            this.Button_Selling.HoverState.Parent = this.Button_Selling;
            this.Button_Selling.Location = new System.Drawing.Point(12, 249);
            this.Button_Selling.Name = "Button_Selling";
            this.Button_Selling.ShadowDecoration.Parent = this.Button_Selling;
            this.Button_Selling.Size = new System.Drawing.Size(137, 49);
            this.Button_Selling.TabIndex = 19;
            this.Button_Selling.Text = "Selling";
            this.Button_Selling.Click += new System.EventHandler(this.Button_Selling_Click);
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.BackColor = System.Drawing.Color.Crimson;
            this.label_logout.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_logout.Location = new System.Drawing.Point(23, 545);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(135, 32);
            this.label_logout.TabIndex = 33;
            this.label_logout.Text = "Logout";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.Button_Category);
            this.panel1.Controls.Add(this.label_logout);
            this.panel1.Controls.Add(this.Button_Selling);
            this.panel1.Controls.Add(this.Button_Product);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 720);
            this.panel1.TabIndex = 33;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(210, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(210, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 18;
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_age.ForeColor = System.Drawing.Color.Tomato;
            this.label_age.Location = new System.Drawing.Point(210, 188);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(56, 29);
            this.label_age.TabIndex = 36;
            this.label_age.Text = "Age";
            this.label_age.Click += new System.EventHandler(this.label_age_Click);
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.BorderRadius = 16;
            this.TextBox_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_ID.DefaultText = "";
            this.TextBox_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_ID.DisabledState.Parent = this.TextBox_ID;
            this.TextBox_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_ID.FocusedState.Parent = this.TextBox_ID;
            this.TextBox_ID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_ID.HoverState.Parent = this.TextBox_ID;
            this.TextBox_ID.Location = new System.Drawing.Point(380, 93);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.PasswordChar = '\0';
            this.TextBox_ID.PlaceholderText = "";
            this.TextBox_ID.SelectedText = "";
            this.TextBox_ID.ShadowDecoration.Parent = this.TextBox_ID;
            this.TextBox_ID.Size = new System.Drawing.Size(200, 36);
            this.TextBox_ID.TabIndex = 37;
            this.TextBox_ID.TextChanged += new System.EventHandler(this.TextBox_ID_TextChanged);
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.BorderRadius = 16;
            this.TextBox_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Name.DefaultText = "";
            this.TextBox_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Name.DisabledState.Parent = this.TextBox_Name;
            this.TextBox_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Name.FocusedState.Parent = this.TextBox_Name;
            this.TextBox_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Name.HoverState.Parent = this.TextBox_Name;
            this.TextBox_Name.Location = new System.Drawing.Point(380, 140);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.PasswordChar = '\0';
            this.TextBox_Name.PlaceholderText = "";
            this.TextBox_Name.SelectedText = "";
            this.TextBox_Name.ShadowDecoration.Parent = this.TextBox_Name;
            this.TextBox_Name.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Name.TabIndex = 38;
            this.TextBox_Name.TextChanged += new System.EventHandler(this.TextBox_Name_TextChanged);
            // 
            // TextBox_age
            // 
            this.TextBox_age.BorderRadius = 16;
            this.TextBox_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_age.DefaultText = "";
            this.TextBox_age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_age.DisabledState.Parent = this.TextBox_age;
            this.TextBox_age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_age.FocusedState.Parent = this.TextBox_age;
            this.TextBox_age.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_age.HoverState.Parent = this.TextBox_age;
            this.TextBox_age.Location = new System.Drawing.Point(380, 188);
            this.TextBox_age.Name = "TextBox_age";
            this.TextBox_age.PasswordChar = '\0';
            this.TextBox_age.PlaceholderText = "";
            this.TextBox_age.SelectedText = "";
            this.TextBox_age.ShadowDecoration.Parent = this.TextBox_age;
            this.TextBox_age.Size = new System.Drawing.Size(200, 36);
            this.TextBox_age.TabIndex = 39;
            this.TextBox_age.TextChanged += new System.EventHandler(this.TextBox_age_TextChanged);
            // 
            // Button_add
            // 
            this.Button_add.BorderRadius = 15;
            this.Button_add.CheckedState.Parent = this.Button_add;
            this.Button_add.CustomImages.Parent = this.Button_add;
            this.Button_add.FillColor = System.Drawing.Color.Pink;
            this.Button_add.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_add.ForeColor = System.Drawing.Color.Tomato;
            this.Button_add.HoverState.Parent = this.Button_add;
            this.Button_add.Location = new System.Drawing.Point(256, 366);
            this.Button_add.Name = "Button_add";
            this.Button_add.ShadowDecoration.Parent = this.Button_add;
            this.Button_add.Size = new System.Drawing.Size(118, 41);
            this.Button_add.TabIndex = 40;
            this.Button_add.Text = "Add";
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // Button_update
            // 
            this.Button_update.BorderRadius = 15;
            this.Button_update.CheckedState.Parent = this.Button_update;
            this.Button_update.CustomImages.Parent = this.Button_update;
            this.Button_update.FillColor = System.Drawing.Color.Pink;
            this.Button_update.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_update.ForeColor = System.Drawing.Color.Tomato;
            this.Button_update.HoverState.Parent = this.Button_update;
            this.Button_update.Location = new System.Drawing.Point(380, 366);
            this.Button_update.Name = "Button_update";
            this.Button_update.ShadowDecoration.Parent = this.Button_update;
            this.Button_update.Size = new System.Drawing.Size(118, 41);
            this.Button_update.TabIndex = 41;
            this.Button_update.Text = "Upedate";
            this.Button_update.Click += new System.EventHandler(this.Button_update_Click);
            // 
            // Button_delete
            // 
            this.Button_delete.BorderRadius = 15;
            this.Button_delete.CheckedState.Parent = this.Button_delete;
            this.Button_delete.CustomImages.Parent = this.Button_delete;
            this.Button_delete.FillColor = System.Drawing.Color.Pink;
            this.Button_delete.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_delete.ForeColor = System.Drawing.Color.Tomato;
            this.Button_delete.HoverState.Parent = this.Button_delete;
            this.Button_delete.Location = new System.Drawing.Point(504, 366);
            this.Button_delete.Name = "Button_delete";
            this.Button_delete.ShadowDecoration.Parent = this.Button_delete;
            this.Button_delete.Size = new System.Drawing.Size(118, 41);
            this.Button_delete.TabIndex = 42;
            this.Button_delete.Text = "Delete";
            this.Button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Crimson;
            this.label_exit.Location = new System.Drawing.Point(1220, 9);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(28, 27);
            this.label_exit.TabIndex = 44;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // Button_Category
            // 
            this.Button_Category.BorderRadius = 15;
            this.Button_Category.CheckedState.Parent = this.Button_Category;
            this.Button_Category.CustomImages.Parent = this.Button_Category;
            this.Button_Category.FillColor = System.Drawing.Color.Pink;
            this.Button_Category.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Category.ForeColor = System.Drawing.Color.Tomato;
            this.Button_Category.HoverState.Parent = this.Button_Category;
            this.Button_Category.Location = new System.Drawing.Point(12, 171);
            this.Button_Category.Name = "Button_Category";
            this.Button_Category.ShadowDecoration.Parent = this.Button_Category;
            this.Button_Category.Size = new System.Drawing.Size(135, 53);
            this.Button_Category.TabIndex = 34;
            this.Button_Category.Text = "Category";
            this.Button_Category.Click += new System.EventHandler(this.Button_Category_Click);
            // 
            // TextBox_password
            // 
            this.TextBox_password.BorderRadius = 16;
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
            this.TextBox_password.Location = new System.Drawing.Point(380, 285);
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.PasswordChar = '\0';
            this.TextBox_password.PlaceholderText = "";
            this.TextBox_password.SelectedText = "";
            this.TextBox_password.ShadowDecoration.Parent = this.TextBox_password;
            this.TextBox_password.Size = new System.Drawing.Size(200, 36);
            this.TextBox_password.TabIndex = 46;
            this.TextBox_password.UseSystemPasswordChar = true;
            this.TextBox_password.TextChanged += new System.EventHandler(this.TextBox_password_TextChanged);
            // 
            // TextBox_Phone
            // 
            this.TextBox_Phone.BorderRadius = 16;
            this.TextBox_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Phone.DefaultText = "";
            this.TextBox_Phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Phone.DisabledState.Parent = this.TextBox_Phone;
            this.TextBox_Phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Phone.FocusedState.Parent = this.TextBox_Phone;
            this.TextBox_Phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Phone.HoverState.Parent = this.TextBox_Phone;
            this.TextBox_Phone.Location = new System.Drawing.Point(380, 237);
            this.TextBox_Phone.Name = "TextBox_Phone";
            this.TextBox_Phone.PasswordChar = '\0';
            this.TextBox_Phone.PlaceholderText = "";
            this.TextBox_Phone.SelectedText = "";
            this.TextBox_Phone.ShadowDecoration.Parent = this.TextBox_Phone;
            this.TextBox_Phone.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Phone.TabIndex = 45;
            this.TextBox_Phone.TextChanged += new System.EventHandler(this.TextBox_Phone_TextChanged);
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_Phone.ForeColor = System.Drawing.Color.Tomato;
            this.label_Phone.Location = new System.Drawing.Point(210, 237);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(165, 29);
            this.label_Phone.TabIndex = 47;
            this.label_Phone.Text = "Phonenumber";
            this.label_Phone.Click += new System.EventHandler(this.label_Phone_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_password.ForeColor = System.Drawing.Color.Tomato;
            this.label_password.Location = new System.Drawing.Point(209, 285);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(120, 29);
            this.label_password.TabIndex = 48;
            this.label_password.Text = "Password";
            this.label_password.Click += new System.EventHandler(this.label_password_Click);
            // 
            // dataGridView_seller
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_seller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_seller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_seller.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_seller.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_seller.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_seller.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_seller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_seller.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_seller.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_seller.EnableHeadersVisualStyles = false;
            this.dataGridView_seller.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_seller.Location = new System.Drawing.Point(638, 93);
            this.dataGridView_seller.Name = "dataGridView_seller";
            this.dataGridView_seller.RowHeadersVisible = false;
            this.dataGridView_seller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_seller.Size = new System.Drawing.Size(610, 484);
            this.dataGridView_seller.TabIndex = 49;
            this.dataGridView_seller.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridView_seller.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_seller.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_seller.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_seller.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_seller.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_seller.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_seller.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_seller.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_seller.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_seller.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_seller.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_seller.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_seller.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_seller.ThemeStyle.ReadOnly = false;
            this.dataGridView_seller.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_seller.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_seller.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_seller.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_seller.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_seller.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_seller.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_seller.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_seller_CellContentClick);
            this.dataGridView_seller.Click += new System.EventHandler(this.dataGridView_seller_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.dataGridView_seller);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.TextBox_password);
            this.Controls.Add(this.TextBox_Phone);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.Button_delete);
            this.Controls.Add(this.Button_update);
            this.Controls.Add(this.Button_add);
            this.Controls.Add(this.TextBox_age);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.TextBox_ID);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label_exit;
        private Guna.UI2.WinForms.Guna2Button Button_delete;
        private Guna.UI2.WinForms.Guna2Button Button_update;
        private Guna.UI2.WinForms.Guna2Button Button_add;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_age;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_ID;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_logout;
        private Guna.UI2.WinForms.Guna2Button Button_Selling;
        private Guna.UI2.WinForms.Guna2Button Button_Product;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_Phone;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_password;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Phone;
        private Guna.UI2.WinForms.Guna2Button Button_Category;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_seller;
    }
}