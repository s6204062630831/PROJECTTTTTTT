
namespace POSPROJECT
{
    partial class CategoryForm
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
            this.Button_Product = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Seller = new Guna.UI2.WinForms.Guna2Button();
            this.Button_delete = new Guna.UI2.WinForms.Guna2Button();
            this.Button_update = new Guna.UI2.WinForms.Guna2Button();
            this.Button_add = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox_description = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Button_Selling = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_category = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_logout = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).BeginInit();
            this.SuspendLayout();
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
            this.Button_Product.Location = new System.Drawing.Point(12, 170);
            this.Button_Product.Name = "Button_Product";
            this.Button_Product.ShadowDecoration.Parent = this.Button_Product;
            this.Button_Product.Size = new System.Drawing.Size(135, 53);
            this.Button_Product.TabIndex = 18;
            this.Button_Product.Text = "Product";
            this.Button_Product.Click += new System.EventHandler(this.Button_Product_Click);
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
            // Button_delete
            // 
            this.Button_delete.BorderRadius = 15;
            this.Button_delete.CheckedState.Parent = this.Button_delete;
            this.Button_delete.CustomImages.Parent = this.Button_delete;
            this.Button_delete.FillColor = System.Drawing.Color.Pink;
            this.Button_delete.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_delete.ForeColor = System.Drawing.Color.Tomato;
            this.Button_delete.HoverState.Parent = this.Button_delete;
            this.Button_delete.Location = new System.Drawing.Point(442, 257);
            this.Button_delete.Name = "Button_delete";
            this.Button_delete.ShadowDecoration.Parent = this.Button_delete;
            this.Button_delete.Size = new System.Drawing.Size(118, 41);
            this.Button_delete.TabIndex = 30;
            this.Button_delete.Text = "Delete";
            this.Button_delete.Click += new System.EventHandler(this.Button_delete_Click);
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
            this.Button_update.Location = new System.Drawing.Point(318, 257);
            this.Button_update.Name = "Button_update";
            this.Button_update.ShadowDecoration.Parent = this.Button_update;
            this.Button_update.Size = new System.Drawing.Size(118, 41);
            this.Button_update.TabIndex = 29;
            this.Button_update.Text = "Upedate";
            this.Button_update.Click += new System.EventHandler(this.Button_update_Click);
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
            this.Button_add.Location = new System.Drawing.Point(194, 257);
            this.Button_add.Name = "Button_add";
            this.Button_add.ShadowDecoration.Parent = this.Button_add;
            this.Button_add.Size = new System.Drawing.Size(118, 41);
            this.Button_add.TabIndex = 28;
            this.Button_add.Text = "Add";
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // TextBox_description
            // 
            this.TextBox_description.BorderRadius = 16;
            this.TextBox_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_description.DefaultText = "";
            this.TextBox_description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_description.DisabledState.Parent = this.TextBox_description;
            this.TextBox_description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_description.FocusedState.Parent = this.TextBox_description;
            this.TextBox_description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_description.HoverState.Parent = this.TextBox_description;
            this.TextBox_description.Location = new System.Drawing.Point(334, 188);
            this.TextBox_description.Name = "TextBox_description";
            this.TextBox_description.PasswordChar = '\0';
            this.TextBox_description.PlaceholderText = "";
            this.TextBox_description.SelectedText = "";
            this.TextBox_description.ShadowDecoration.Parent = this.TextBox_description;
            this.TextBox_description.Size = new System.Drawing.Size(200, 36);
            this.TextBox_description.TabIndex = 25;
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
            this.TextBox_Name.Location = new System.Drawing.Point(334, 140);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.PasswordChar = '\0';
            this.TextBox_Name.PlaceholderText = "";
            this.TextBox_Name.SelectedText = "";
            this.TextBox_Name.ShadowDecoration.Parent = this.TextBox_Name;
            this.TextBox_Name.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Name.TabIndex = 24;
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
            this.TextBox_ID.Location = new System.Drawing.Point(334, 93);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.PasswordChar = '\0';
            this.TextBox_ID.PlaceholderText = "";
            this.TextBox_ID.SelectedText = "";
            this.TextBox_ID.ShadowDecoration.Parent = this.TextBox_ID;
            this.TextBox_ID.Size = new System.Drawing.Size(200, 36);
            this.TextBox_ID.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(197, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(197, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(197, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 18;
            this.bunifuElipse1.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 18;
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label_logout);
            this.panel1.Controls.Add(this.Button_Selling);
            this.panel1.Controls.Add(this.Button_Product);
            this.panel1.Controls.Add(this.Button_Seller);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 720);
            this.panel1.TabIndex = 17;
            // 
            // dataGridView_category
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_category.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_category.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_category.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_category.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_category.EnableHeadersVisualStyles = false;
            this.dataGridView_category.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_category.Location = new System.Drawing.Point(601, 80);
            this.dataGridView_category.Name = "dataGridView_category";
            this.dataGridView_category.RowHeadersVisible = false;
            this.dataGridView_category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_category.Size = new System.Drawing.Size(651, 497);
            this.dataGridView_category.TabIndex = 31;
            this.dataGridView_category.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridView_category.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_category.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_category.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_category.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_category.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_category.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_category.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_category.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_category.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_category.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_category.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_category.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_category.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_category.ThemeStyle.ReadOnly = false;
            this.dataGridView_category.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_category.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_category.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_category.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_category.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_category.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_category.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_category.Click += new System.EventHandler(this.dataGridView_category_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Crimson;
            this.label_exit.Location = new System.Drawing.Point(1224, 9);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(28, 27);
            this.label_exit.TabIndex = 32;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
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
            this.label_logout.MouseEnter += new System.EventHandler(this.label_logout_MouseEnter);
            this.label_logout.MouseLeave += new System.EventHandler(this.label_logout_MouseLeave);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.dataGridView_category);
            this.Controls.Add(this.Button_delete);
            this.Controls.Add(this.Button_update);
            this.Controls.Add(this.Button_add);
            this.Controls.Add(this.TextBox_description);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.TextBox_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button Button_Product;
        private Guna.UI2.WinForms.Guna2Button Button_Seller;
        private Guna.UI2.WinForms.Guna2Button Button_delete;
        private Guna.UI2.WinForms.Guna2Button Button_update;
        private Guna.UI2.WinForms.Guna2Button Button_add;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_description;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Button_Selling;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_category;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label_logout;
    }
}