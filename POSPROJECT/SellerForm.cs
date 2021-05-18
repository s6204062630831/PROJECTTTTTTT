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
    public partial class SellerForm : Form
    {
        DBConect dBCon = new DBConect();
        public SellerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginFrom login = new LoginFrom();
            login.Show();
            this.Hide();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO SELLER VALUES(" + TextBox_ID.Text + ",'" + TextBox_Name.Text + "','" + TextBox_age.Text + "','" + TextBox_Phone.Text + "','" + TextBox_password.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.Getcon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void Button_Product_Click(object sender, EventArgs e)
        {
            ProductFrom product= new ProductFrom();
            product.Show();
            this.Hide();
        }
        private void getTable()
        {
            string selectQuerry = "SELECT * FROM SELLER";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_seller.DataSource = table;



        }
        private void clear()
        {
            TextBox_ID.Clear();
            TextBox_Name.Clear();
            TextBox_age.Clear();
            TextBox_Phone.Clear();
            TextBox_password.Clear();
        }
        private void SellerForm_Load(object sender, EventArgs e)
        {
            getTable();
            
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_ID.Text == "" || TextBox_Name.Text == "" || TextBox_age.Text == "" || TextBox_Phone.Text == "" || TextBox_password.Text=="") 
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Seller SET SellerName='" + TextBox_Name.Text + "', SellerAge ='" + TextBox_age.Text + "',SellerPhone='" + TextBox_Phone.Text + "',SellerPass='" +TextBox_password.Text + "'WHERE SellerId =" + TextBox_ID.Text + "";

                    SqlCommand command = new SqlCommand(updateQuery, dBCon.Getcon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView_seller_Click(object sender, EventArgs e)
        {
            TextBox_ID.Text =dataGridView_seller.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_Name.Text = dataGridView_seller.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_age.Text = dataGridView_seller.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_Phone.Text = dataGridView_seller.SelectedRows[0].Cells[3].Value.ToString();
            TextBox_password.Text = dataGridView_seller.SelectedRows[0].Cells[4].Value.ToString();



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
                    if ((MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        string deleteQuery = "DELETE FROM SELLER WHERE SellerId=" + TextBox_ID.Text + "";

                        SqlCommand command = new SqlCommand(deleteQuery, dBCon.Getcon());
                        dBCon.OpenCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Seller Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dBCon.CloseCon();
                        getTable();
                        clear();
                    }
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Selling_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_age_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Phone_Click(object sender, EventArgs e)
        {

        }

        private void label_password_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_seller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
