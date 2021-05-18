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
    public partial class LoginFrom : Form
    {
        DBConect dBCon = new DBConect();
        public static string sellerName;
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor=Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Crimson;
        }

        private void label_exit_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void LoginFrom_Load(object sender, EventArgs e)
        {

        }

        private void Button_login_Click(object sender, EventArgs e)


        {

            if (TextBox_username.Text == "" || TextBox_password.Text == "")
            {


                MessageBox.Show("Please Enter username and password", "Missing infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {






                if (ComboBox_role.SelectedIndex > -1)
                {



                    if (ComboBox_role.SelectedItem.ToString() == "ADMIN")
                    {
                        if (TextBox_username.Text == "ADMIN" && TextBox_password.Text == "1234567")
                        {
                            ProductFrom product = new ProductFrom();
                            product.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are ADMIN", "Please Enter the corect ID and Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {

                        string selectQuery = "SELECT * FROM Seller WHERE SellerName= '" + TextBox_username.Text + "'AND SellerPass='" + TextBox_password.Text + "'";
                        DataTable table = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dBCon.Getcon());

                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            sellerName = TextBox_username.Text;
                            SellingForm selling = new SellingForm();
                            selling.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong User or Password", "Wrong infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Plese Select Role", "Wrong Infomation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
     

        private void TextBox_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
