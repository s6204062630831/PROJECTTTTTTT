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
    public partial class CategoryForm : Form
    {
        DBConect dBCon = new DBConect();
        public CategoryForm()
        {
            InitializeComponent();
        }
        //แอดข้อมูลอาหารลง datagrid
        private void getTable() 
        {
            string selectQuerry = "SELECT * FROM CATEGORY";
            SqlCommand command = new SqlCommand(selectQuerry,dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_category.DataSource = table;
        }
        //แอดสินค้า
        private void Button_add_Click(object sender, EventArgs e)
        {
            try 
            { 
                string insertQuery="INSERT INTO CATEGORY VALUES(" +TextBox_ID.Text+",'" + TextBox_Name.Text + "','" + TextBox_description.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery,dBCon.Getcon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully","Add Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            try 
            {
                if (TextBox_ID.Text == "" || TextBox_Name.Text == "" || TextBox_description.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE CATEGORY SET CatName='" + TextBox_Name.Text + "', Catdes ='" + TextBox_description.Text + "'WHERE CatId =" + TextBox_ID.Text + " ";

                    SqlCommand command = new SqlCommand(updateQuery, dBCon.Getcon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_category_Click(object sender, EventArgs e)
        {
            TextBox_ID.Text = dataGridView_category.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_Name.Text = dataGridView_category.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_description.Text = dataGridView_category.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void clear()
        {
            TextBox_ID.Clear();
            TextBox_Name.Clear();
            TextBox_description.Clear();
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            try 
            {
                string deleteQuery = "DELETE FROM CATEGORY WHERE CatId=" + TextBox_ID.Text + "";

                SqlCommand command = new SqlCommand(deleteQuery, dBCon.Getcon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Orange;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Crimson;
        }

        private void label_logout_MouseEnter(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Red;
        }

        private void label_logout_MouseLeave(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Tomato;
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginFrom login = new LoginFrom();
            login.Show();
            this.Hide();
        }

        private void Button_Product_Click(object sender, EventArgs e)
        {
            ProductFrom product = new ProductFrom();
            product.Show();
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
    