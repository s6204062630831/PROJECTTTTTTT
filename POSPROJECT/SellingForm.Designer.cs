
namespace POSPROJECT
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_order = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Qty = new System.Windows.Forms.Label();
            this.TextBox_Qty = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_exit = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Button_print = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Add = new Guna.UI2.WinForms.Guna2Button();
            this.Button_addorder = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_age = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_logout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label_sellername = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.ComboBox_category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Button_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_sellist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Amount = new System.Windows.Forms.Label();
            this.label_Bill = new System.Windows.Forms.Label();
            this.TextBox_ID = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sellist)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_order
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_order.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_order.ColumnHeadersHeight = 24;
            this.dataGridView_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdPrice,
            this.ProdQty,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_order.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_order.EnableHeadersVisualStyles = false;
            this.dataGridView_order.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_order.Location = new System.Drawing.Point(632, 75);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.RowHeadersVisible = false;
            this.dataGridView_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_order.Size = new System.Drawing.Size(610, 180);
            this.dataGridView_order.TabIndex = 65;
            this.dataGridView_order.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridView_order.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_order.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_order.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_order.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_order.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_order.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_order.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_order.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_order.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_order.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_order.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_order.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_order.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_order.ThemeStyle.ReadOnly = false;
            this.dataGridView_order.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_order.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_order.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_order.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_order.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_order.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_order.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.Name = "ProdId";
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.Name = "ProdName";
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "ProdPrice";
            this.ProdPrice.Name = "ProdPrice";
            // 
            // ProdQty
            // 
            this.ProdQty.HeaderText = "ProdQty";
            this.ProdQty.Name = "ProdQty";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label_Qty
            // 
            this.label_Qty.AutoSize = true;
            this.label_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_Qty.ForeColor = System.Drawing.Color.Tomato;
            this.label_Qty.Location = new System.Drawing.Point(210, 172);
            this.label_Qty.Name = "label_Qty";
            this.label_Qty.Size = new System.Drawing.Size(100, 29);
            this.label_Qty.TabIndex = 63;
            this.label_Qty.Text = "Quantity";
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
            this.TextBox_Qty.Location = new System.Drawing.Point(380, 172);
            this.TextBox_Qty.Name = "TextBox_Qty";
            this.TextBox_Qty.PasswordChar = '\0';
            this.TextBox_Qty.PlaceholderText = "";
            this.TextBox_Qty.SelectedText = "";
            this.TextBox_Qty.ShadowDecoration.Parent = this.TextBox_Qty;
            this.TextBox_Qty.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Qty.TabIndex = 61;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Crimson;
            this.label_exit.Location = new System.Drawing.Point(1228, 9);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(28, 27);
            this.label_exit.TabIndex = 60;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 18;
            // 
            // Button_print
            // 
            this.Button_print.BorderRadius = 15;
            this.Button_print.CheckedState.Parent = this.Button_print;
            this.Button_print.CustomImages.Parent = this.Button_print;
            this.Button_print.FillColor = System.Drawing.Color.Pink;
            this.Button_print.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_print.ForeColor = System.Drawing.Color.Tomato;
            this.Button_print.HoverState.Parent = this.Button_print;
            this.Button_print.Location = new System.Drawing.Point(1138, 590);
            this.Button_print.Name = "Button_print";
            this.Button_print.ShadowDecoration.Parent = this.Button_print;
            this.Button_print.Size = new System.Drawing.Size(118, 41);
            this.Button_print.TabIndex = 59;
            this.Button_print.Text = "Print";
            this.Button_print.Click += new System.EventHandler(this.Button_print_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.BorderRadius = 15;
            this.Button_Add.CheckedState.Parent = this.Button_Add;
            this.Button_Add.CustomImages.Parent = this.Button_Add;
            this.Button_Add.FillColor = System.Drawing.Color.Pink;
            this.Button_Add.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.ForeColor = System.Drawing.Color.Tomato;
            this.Button_Add.HoverState.Parent = this.Button_Add;
            this.Button_Add.Location = new System.Drawing.Point(1138, 333);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.ShadowDecoration.Parent = this.Button_Add;
            this.Button_Add.Size = new System.Drawing.Size(118, 41);
            this.Button_Add.TabIndex = 58;
            this.Button_Add.Text = "Add";
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_addorder
            // 
            this.Button_addorder.BorderRadius = 15;
            this.Button_addorder.CheckedState.Parent = this.Button_addorder;
            this.Button_addorder.CustomImages.Parent = this.Button_addorder;
            this.Button_addorder.FillColor = System.Drawing.Color.Pink;
            this.Button_addorder.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_addorder.ForeColor = System.Drawing.Color.Tomato;
            this.Button_addorder.HoverState.Parent = this.Button_addorder;
            this.Button_addorder.Location = new System.Drawing.Point(258, 279);
            this.Button_addorder.Name = "Button_addorder";
            this.Button_addorder.ShadowDecoration.Parent = this.Button_addorder;
            this.Button_addorder.Size = new System.Drawing.Size(175, 41);
            this.Button_addorder.TabIndex = 57;
            this.Button_addorder.Text = "Add Order";
            this.Button_addorder.Click += new System.EventHandler(this.Button_addorder_Click);
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
            this.TextBox_price.Location = new System.Drawing.Point(380, 123);
            this.TextBox_price.Name = "TextBox_price";
            this.TextBox_price.PasswordChar = '\0';
            this.TextBox_price.PlaceholderText = "";
            this.TextBox_price.ReadOnly = true;
            this.TextBox_price.SelectedText = "";
            this.TextBox_price.ShadowDecoration.Parent = this.TextBox_price;
            this.TextBox_price.Size = new System.Drawing.Size(200, 36);
            this.TextBox_price.TabIndex = 56;
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
            this.TextBox_Name.Location = new System.Drawing.Point(380, 75);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.PasswordChar = '\0';
            this.TextBox_Name.PlaceholderText = "";
            this.TextBox_Name.ReadOnly = true;
            this.TextBox_Name.SelectedText = "";
            this.TextBox_Name.ShadowDecoration.Parent = this.TextBox_Name;
            this.TextBox_Name.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Name.TabIndex = 55;
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_age.ForeColor = System.Drawing.Color.Tomato;
            this.label_age.Location = new System.Drawing.Point(210, 123);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(69, 29);
            this.label_age.TabIndex = 53;
            this.label_age.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label_logout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 681);
            this.panel1.TabIndex = 50;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELLING";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 18;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(210, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 52;
            this.label3.Text = "Name";
            // 
            // dataGridView_product
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridView_product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_product.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_product.ColumnHeadersHeight = 24;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_product.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_product.EnableHeadersVisualStyles = false;
            this.dataGridView_product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_product.Location = new System.Drawing.Point(228, 384);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.RowHeadersVisible = false;
            this.dataGridView_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_product.Size = new System.Drawing.Size(352, 272);
            this.dataGridView_product.TabIndex = 66;
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
            this.dataGridView_product.Click += new System.EventHandler(this.dataGridView_product_Click);
            // 
            // label_sellername
            // 
            this.label_sellername.AutoSize = true;
            this.label_sellername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_sellername.ForeColor = System.Drawing.Color.Tomato;
            this.label_sellername.Location = new System.Drawing.Point(212, 27);
            this.label_sellername.Name = "label_sellername";
            this.label_sellername.Size = new System.Drawing.Size(142, 29);
            this.label_sellername.TabIndex = 67;
            this.label_sellername.Text = "SellerName";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_date.ForeColor = System.Drawing.Color.Tomato;
            this.label_date.Location = new System.Drawing.Point(1033, 27);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(81, 29);
            this.label_date.TabIndex = 68;
            this.label_date.Text = "Date : ";
            // 
            // ComboBox_category
            // 
            this.ComboBox_category.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_category.FocusedState.Parent = this.ComboBox_category;
            this.ComboBox_category.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_category.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_category.FormattingEnabled = true;
            this.ComboBox_category.HoverState.Parent = this.ComboBox_category;
            this.ComboBox_category.ItemHeight = 30;
            this.ComboBox_category.ItemsAppearance.Parent = this.ComboBox_category;
            this.ComboBox_category.Location = new System.Drawing.Point(228, 326);
            this.ComboBox_category.Name = "ComboBox_category";
            this.ComboBox_category.ShadowDecoration.Parent = this.ComboBox_category;
            this.ComboBox_category.Size = new System.Drawing.Size(218, 36);
            this.ComboBox_category.TabIndex = 69;
            this.ComboBox_category.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_category_SelectionChangeCommitted);
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
            this.Button_refresh.Location = new System.Drawing.Point(462, 326);
            this.Button_refresh.Name = "Button_refresh";
            this.Button_refresh.ShadowDecoration.Parent = this.Button_refresh;
            this.Button_refresh.Size = new System.Drawing.Size(118, 41);
            this.Button_refresh.TabIndex = 70;
            this.Button_refresh.Text = "Refresh";
            this.Button_refresh.Click += new System.EventHandler(this.Button_refresh_Click);
            // 
            // dataGridView_sellist
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView_sellist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_sellist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_sellist.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_sellist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_sellist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_sellist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_sellist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_sellist.ColumnHeadersHeight = 24;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_sellist.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_sellist.EnableHeadersVisualStyles = false;
            this.dataGridView_sellist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_sellist.Location = new System.Drawing.Point(642, 384);
            this.dataGridView_sellist.Name = "dataGridView_sellist";
            this.dataGridView_sellist.RowHeadersVisible = false;
            this.dataGridView_sellist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_sellist.Size = new System.Drawing.Size(610, 180);
            this.dataGridView_sellist.TabIndex = 71;
            this.dataGridView_sellist.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridView_sellist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_sellist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_sellist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_sellist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_sellist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_sellist.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_sellist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_sellist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_sellist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_sellist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_sellist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_sellist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_sellist.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_sellist.ThemeStyle.ReadOnly = false;
            this.dataGridView_sellist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_sellist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_sellist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_sellist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_sellist.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_sellist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_sellist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(637, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 29);
            this.label4.TabIndex = 72;
            this.label4.Text = "Sell list";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(713, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 73;
            this.label5.Text = "Amount";
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_Amount.ForeColor = System.Drawing.Color.Tomato;
            this.label_Amount.Location = new System.Drawing.Point(986, 279);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(61, 29);
            this.label_Amount.TabIndex = 74;
            this.label_Amount.Text = "Bath";
            // 
            // label_Bill
            // 
            this.label_Bill.AutoSize = true;
            this.label_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_Bill.ForeColor = System.Drawing.Color.Tomato;
            this.label_Bill.Location = new System.Drawing.Point(921, 338);
            this.label_Bill.Name = "label_Bill";
            this.label_Bill.Size = new System.Drawing.Size(47, 29);
            this.label_Bill.TabIndex = 75;
            this.label_Bill.Text = "Bill";
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
            this.TextBox_ID.Location = new System.Drawing.Point(998, 338);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.PasswordChar = '\0';
            this.TextBox_ID.PlaceholderText = "";
            this.TextBox_ID.SelectedText = "";
            this.TextBox_ID.ShadowDecoration.Parent = this.TextBox_ID;
            this.TextBox_ID.Size = new System.Drawing.Size(116, 36);
            this.TextBox_ID.TabIndex = 76;
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label_Bill);
            this.Controls.Add(this.TextBox_ID);
            this.Controls.Add(this.label_Amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_sellist);
            this.Controls.Add(this.Button_refresh);
            this.Controls.Add(this.ComboBox_category);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_sellername);
            this.Controls.Add(this.dataGridView_product);
            this.Controls.Add(this.dataGridView_order);
            this.Controls.Add(this.label_Qty);
            this.Controls.Add(this.TextBox_Qty);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.Button_print);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Button_addorder);
            this.Controls.Add(this.TextBox_price);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sellist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_order;
        private System.Windows.Forms.Label label_Qty;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Qty;
        private System.Windows.Forms.Label label_exit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button Button_Add;
        private Guna.UI2.WinForms.Guna2Button Button_addorder;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_price;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_sellername;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_product;
        private Guna.UI2.WinForms.Guna2Button Button_refresh;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_sellist;
        private Guna.UI2.WinForms.Guna2Button Button_print;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.Label label_Bill;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_ID;
    }
}