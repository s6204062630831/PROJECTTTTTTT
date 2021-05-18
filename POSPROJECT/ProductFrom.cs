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

namespace POSPROJECT
{
    public partial class ProductFrom : Form
    {
        DBConect dBCon = new DBConect();
        public ProductFrom()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginFrom login = new LoginFrom();
            login.Show();
            this.Hide();
        }

        private void Button_Category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void ProductFrom_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
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
            Combobox_Search.DataSource = table;
            Combobox_Search.ValueMember = "CatName";
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void getTable()
        {
            string selectQuerry = "SELECT * FROM PRODUCT";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;



        }
        private void clear()
        {
            TextBox_ID.Clear();
            TextBox_Name.Clear();
            TextBox_price.Clear();
            TextBox_Qty.Clear();
            ComboBox_category.SelectedIndex = 0;
        }
        private void Button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Product VALUES("+ TextBox_ID.Text + ",'" + TextBox_Name.Text + "','" + TextBox_price.Text + "','" + TextBox_Qty.Text + "','"+ComboBox_category.Text+"')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.Getcon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_ID.Text == "" || TextBox_Name.Text == "" || TextBox_price.Text == "" || TextBox_Qty.Text =="")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Product SET ProdName='" + TextBox_Name.Text + "', ProdPrice ='" + TextBox_price.Text + "',ProdQty='" + TextBox_Qty.Text + "',ProdCat='" + ComboBox_category.Text + "'WHERE ProdId =" + TextBox_ID.Text +  "";

                    SqlCommand command = new SqlCommand(updateQuery, dBCon.Getcon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_product_Click(object sender, EventArgs e)
        {
            TextBox_ID.Text = dataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_Name.Text = dataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_price.Text = dataGridView_product.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_Qty.Text = dataGridView_product.SelectedRows[0].Cells[3].Value.ToString();
            ComboBox_category.Text = dataGridView_product.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_ID.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "DELETE FROM Product WHERE ProdId=" + TextBox_ID.Text + "";

                    SqlCommand command = new SqlCommand(deleteQuery, dBCon.Getcon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void Combobox_Search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT * FROM PRODUCT WHERE ProdCat='"+Combobox_Search.SelectedValue.ToString()+"' ";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }

        private void Button_Selling_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }

        private void Button_Seller_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }
    }
}
