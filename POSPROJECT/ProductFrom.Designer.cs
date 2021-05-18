
namespace POSPROJECT
{
    partial class ProductFrom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_logout = new System.Windows.Forms.Label();
            this.Button_Selling = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Category = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Seller = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Qty = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBox_category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Button_add = new Guna.UI2.WinForms.Guna2Button();
            this.Button_update = new Guna.UI2.WinForms.Guna2Button();
            this.Button_delete = new Guna.UI2.WinForms.Guna2Button();
            this.Combobox_Search = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Button_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label_logout);
            this.panel1.Controls.Add(this.Button_Selling);
            this.panel1.Controls.Add(this.Button_Category);
            this.panel1.Controls.Add(this.Button_Seller);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 720);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.BackColor = System.Drawing.Color.Crimson;
            this.label_logout.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_logout.Location = new System.Drawing.Point(12, 594);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(135, 32);
            this.label_logout.TabIndex = 34;
            this.label_logout.Text = "Logout";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
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
            // Button_Category
            // 
            this.Button_Category.BorderRadius = 15;
            this.Button_Category.CheckedState.Parent = this.Button_Category;
            this.Button_Category.CustomImages.Parent = this.Button_Category;
            this.Button_Category.FillColor = System.Drawing.Color.Pink;
            this.Button_Category.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Category.ForeColor = System.Drawing.Color.Tomato;
            this.Button_Category.HoverState.Parent = this.Button_Category;
            this.Button_Category.Location = new System.Drawing.Point(12, 170);
            this.Button_Category.Name = "Button_Category";
            this.Button_Category.ShadowDecoration.Parent = this.Button_Category;
            this.Button_Category.Size = new System.Drawing.Size(135, 53);
            this.Button_Category.TabIndex = 18;
            this.Button_Category.Text = "Category";
            this.Button_Category.Click += new System.EventHandler(this.Button_Category_Click);
            // 
            // Button_Seller
            // 
            this.Button_Seller.BorderRadius = 15;
            this.Button_Seller.CheckedState.Parent = this.Button_Seller;
            this.Button_Seller.CustomImages.Parent = this.Button_Seller;
            this.Button_Seller.FillColor = System.Drawing.Color.Pink;
            this.Button_Seller.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Seller.ForeColor = System.Drawing.Color.Tomato;
            this.Button_Seller.HoverState.Parent = this.Button_Seller;
            this.Button_Seller.Location = new System.Drawing.Point(12, 93);
            this.Button_Seller.Name = "Button_Seller";
            this.Button_Seller.ShadowDecoration.Parent = this.Button_Seller;
            this.Button_Seller.Size = new System.Drawing.Size(135, 50);
            this.Button_Seller.TabIndex = 17;
            this.Button_Seller.Text = "Seller";
            this.Button_Seller.Click += new System.EventHandler(this.Button_Seller_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 18;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 18;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(182, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(182, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(182, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(182, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(182, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Category";
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
            this.TextBox_ID.Location = new System.Drawing.Point(319, 93);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.PasswordChar = '\0';
            this.TextBox_ID.PlaceholderText = "";
            this.TextBox_ID.SelectedText = "";
            this.TextBox_ID.ShadowDecoration.Parent = this.TextBox_ID;
            this.TextBox_ID.Size = new System.Drawing.Size(200, 36);
            this.TextBox_ID.TabIndex = 6;
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
            this.TextBox_Name.Location = new System.Drawing.Point(319, 140);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.PasswordChar = '\0';
            this.TextBox_Name.PlaceholderText = "";
            this.TextBox_Name.SelectedText = "";
            this.TextBox_Name.ShadowDecoration.Parent = this.TextBox_Name;
            this.TextBox_Name.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Name.TabIndex = 7;
            // 
            // TextBox_price
            // 
            this.TextBox_price.BorderRadius = 16;
            this.TextBox_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_price.DefaultText = "";
            this.TextBox_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_price.DisabledState.Parent = this.TextBox_price;
            this.TextBox_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_price.FocusedState.Parent = this.TextBox_price;
            this.TextBox_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_price.HoverState.Parent = this.TextBox_price;
            this.TextBox_price.Location = new System.Drawing.Point(319, 188);
            this.TextBox_price.Name = "TextBox_price";
            this.TextBox_price.PasswordChar = '\0';
            this.TextBox_price.PlaceholderText = "";
            this.TextBox_price.SelectedText = "";
            this.TextBox_price.ShadowDecoration.Parent = this.TextBox_price;
            this.TextBox_price.Size = new System.Drawing.Size(200, 36);
            this.TextBox_price.TabIndex = 8;
            // 
            // TextBox_Qty
            // 
            this.TextBox_Qty.BorderRadius = 16;
            this.TextBox_Qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Qty.DefaultText = "";
            this.TextBox_Qty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Qty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Qty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Qty.DisabledState.Parent = this.TextBox_Qty;
            this.TextBox_Qty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Qty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Qty.FocusedState.Parent = this.TextBox_Qty;
            this.TextBox_Qty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Qty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Qty.HoverState.Parent = this.TextBox_Qty;
            this.TextBox_Qty.Location = new System.Drawing.Point(319, 236);
            this.TextBox_Qty.Name = "TextBox_Qty";
            this.TextBox_Qty.PasswordChar = '\0';
            this.TextBox_Qty.PlaceholderText = "";
            this.TextBox_Qty.SelectedText = "";
            this.TextBox_Qty.ShadowDecoration.Parent = this.TextBox_Qty;
            this.TextBox_Qty.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Qty.TabIndex = 9;
            // 
            // ComboBox_category
            // 
            this.ComboBox_category.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_category.BorderRadius = 10;
            this.ComboBox_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_category.FocusedState.Parent = this.ComboBox_category;
            this.ComboBox_category.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox_category.HoverState.Parent = this.ComboBox_category;
            this.ComboBox_category.ItemHeight = 30;
            this.ComboBox_category.ItemsAppearance.Parent = this.ComboBox_category;
            this.ComboBox_category.Location = new System.Drawing.Point(319, 288);
            this.ComboBox_category.Name = "ComboBox_category";
            this.ComboBox_category.ShadowDecoration.Parent = this.ComboBox_category;
            this.ComboBox_category.Size = new System.Drawing.Size(200, 36);
            this.ComboBox_category.TabIndex = 10;
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
            this.Button_add.Location = new System.Drawing.Point(174, 348);
            this.Button_add.Name = "Button_add";
            this.Button_add.ShadowDecoration.Parent = this.Button_add;
            this.Button_add.Size = new System.Drawing.Size(118, 41);
            this.Button_add.TabIndex = 11;
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
            this.Button_update.Location = new System.Drawing.Point(298, 348);
            this.Button_update.Name = "Button_update";
            this.Button_update.ShadowDecoration.Parent = this.Button_update;
            this.Button_update.Size = new System.Drawing.Size(118, 41);
            this.Button_update.TabIndex = 12;
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
            this.Button_delete.Location = new System.Drawing.Point(422, 348);
            this.Button_delete.Name = "Button_delete";
            this.Button_delete.ShadowDecoration.Parent = this.Button_delete;
            this.Button_delete.Size = new System.Drawing.Size(118, 41);
            this.Button_delete.TabIndex = 13;
            this.Button_delete.Text = "Delete";
            this.Button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // Combobox_Search
            // 
            this.Combobox_Search.BackColor = System.Drawing.Color.Transparent;
            this.Combobox_Search.BorderRadius = 10;
            this.Combobox_Search.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Combobox_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Search.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Combobox_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Combobox_Search.FocusedState.Parent = this.Combobox_Search;
            this.Combobox_Search.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Combobox_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Combobox_Search.HoverState.Parent = this.Combobox_Search;
            this.Combobox_Search.ItemHeight = 30;
            this.Combobox_Search.ItemsAppearance.Parent = this.Combobox_Search;
            this.Combobox_Search.Location = new System.Drawing.Point(756, 37);
            this.Combobox_Search.Name = "Combobox_Search";
            this.Combobox_Search.ShadowDecoration.Parent = this.Combobox_Search;
            this.Combobox_Search.Size = new System.Drawing.Size(200, 36);
            this.Combobox_Search.TabIndex = 15;
            this.Combobox_Search.SelectionChangeCommitted += new System.EventHandler(this.Combobox_Search_SelectionChangeCommitted);
            // 
            // Button_refresh
            // 
            this.Button_refresh.BorderRadius = 15;
            this.Button_refresh.CheckedState.Parent = this.Button_refresh;
            this.Button_refresh.CustomImages.Parent = this.Button_refresh;
            this.Button_refresh.FillColor = System.Drawing.Color.Pink;
            this.Button_refresh.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_refresh.ForeColor = System.Drawing.Color.Tomato;
            this.Button_refresh.HoverState.Parent = this.Button_refresh;
            this.Button_refresh.Location = new System.Drawing.Point(985, 32);
            this.Button_refresh.Name = "Button_refresh";
            this.Button_refresh.ShadowDecoration.Parent = this.Button_refresh;
            this.Button_refresh.Size = new System.Drawing.Size(118, 41);
            this.Button_refresh.TabIndex = 16;
            this.Button_refresh.Text = "Refresh";
            this.Button_refresh.Click += new System.EventHandler(this.Button_refresh_Click);
            // 
            // dataGridView_product
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_product.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_product.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_product.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_product.EnableHeadersVisualStyles = false;
            this.dataGridView_product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_product.Location = new System.Drawing.Point(587, 93);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.RowHeadersVisible = false;
            this.dataGridView_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_product.Size = new System.Drawing.Size(651, 497);
            this.dataGridView_product.TabIndex = 32;
            this.dataGridView_product.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridView_product.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_product.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_product.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_product.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_product.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_product.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_product.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_product.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_product.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_product.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_product.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_product.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_product.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_product.ThemeStyle.ReadOnly = false;
            this.dataGridView_product.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_product.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_product.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_product.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_product.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_product.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_product.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_product_CellContentClick);
            this.dataGridView_product.Click += new System.EventHandler(this.dataGridView_product_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Crimson;
            this.label_exit.Location = new System.Drawing.Point(1226, 9);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(28, 27);
            this.label_exit.TabIndex = 33;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // ProductFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.dataGridView_product);
            this.Controls.Add(this.Button_refresh);
            this.Controls.Add(this.Combobox_Search);
            this.Controls.Add(this.Button_delete);
            this.Controls.Add(this.Button_update);
            this.Controls.Add(this.Button_add);
            this.Controls.Add(this.ComboBox_category);
            this.Controls.Add(this.TextBox_Qty);
            this.Controls.Add(this.TextBox_price);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.TextBox_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductFrom";
            this.Load += new System.EventHandler(this.ProductFrom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Button Button_delete;
        private Guna.UI2.WinForms.Guna2Button Button_update;
        private Guna.UI2.WinForms.Guna2Button Button_add;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_category;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Qty;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_price;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button Button_Selling;
        private Guna.UI2.WinForms.Guna2Button Button_Category;
        private Guna.UI2.WinForms.Guna2Button Button_Seller;
        private Guna.UI2.WinForms.Guna2Button Button_refresh;
        private Guna.UI2.WinForms.Guna2ComboBox Combobox_Search;
        private System.Windows.Forms.Label label_logout;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_product;
        private System.Windows.Forms.Label label_exit;
    }
}