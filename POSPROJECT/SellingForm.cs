using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;
using DGVPrinterHelper;


namespace POSPROJECT
{
    public partial class SellingForm : Form
    {
        DBConect dBCon = new DBConect();
        DGVPrinter printer = new DGVPrinter();
        public SellingForm()
        {
            InitializeComponent();
        }
        private void getTable()
        {
            string selectQuerry = "SELECT ProdName,ProdPrice FROM PRODUCT";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;



        }
        private void getSellTable()
        {
            string selectQuerry = "SELECT * FROM BILL";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_sellist.DataSource = table;



        }
        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM CATEGORY";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            ComboBox_category.DataSource = table;
            ComboBox_category.ValueMember = "CatName";
          
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Today.ToShortDateString();
            label_sellername.Text = LoginFrom.sellerName;
            getTable();
            getCategory();
            getSellTable();
        }

        private void dataGridView_product_Click(object sender, EventArgs e)
        {
            TextBox_Name.Text = dataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_price.Text = dataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
        }
        int grandTotal = 0, n = 0;

        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO BILL VALUES(" + TextBox_ID.Text + ",'" + label_sellername.Text + "','" + label_date.Text + "'," + grandTotal.ToString()+")";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.Getcon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getSellTable();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_print_Click(object sender, EventArgs e)
        {
            //ใบรวมยอดขายในแต่ละวัน
            printer.Title = "COVID RESTUARANT SELL LISTS";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape= true;
            printer.PrintDataGridView(dataGridView_sellist);
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginFrom login = new LoginFrom();
            login.Show();
            this.Hide();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void ComboBox_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT ProdName,ProdPrice FROM PRODUCT WHERE ProdCat='" + ComboBox_category.SelectedValue.ToString() + "' ";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }

        private void Button_addorder_Click(object sender, EventArgs e)
        {
            if (TextBox_Name.Text == "" || TextBox_Qty.Text  == "") {
                MessageBox.Show("Missing Infomation", "Information Eror", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int Total = Convert.ToInt32(TextBox_price.Text) * Convert.ToInt32(TextBox_Qty.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(dataGridView_order);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value = TextBox_Name.Text;
                addRow.Cells[2].Value = TextBox_price.Text;
                addRow.Cells[3].Value = TextBox_Qty.Text;
                addRow.Cells[4].Value = Total;
                dataGridView_order.Rows.Add(addRow);
                grandTotal += Total;
                label_Amount.Text = grandTotal + " BATH";
            }
        }   
    }
}
