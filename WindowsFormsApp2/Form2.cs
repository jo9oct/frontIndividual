using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(t1.Text.Trim(), out int borrowerId) || borrowerId <= 0)
            {
                MessageBox.Show("❌ Borrower ID must be a valid positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = t2.Text.Trim();
            string email = t3.Text.Trim();

            if (!long.TryParse(t4.Text.Trim(), out long phone) || phone <= 0 || t4.Text.Trim().Length != 10)
            {
                MessageBox.Show("❌ Phone number must be a 10-digit valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("❌ Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            Program.AddBorrower(borrowerId, name, email, phone);
            t1.Text = name;
            t2.Text = email;
            //t1. = phone;

            ClearBorrowerFields();
            //LoadData();
        }
        private void ClearBorrowerFields()
        {
            // Clears all input fields
            t1.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(t1.Text.Trim(), out int borrowerId) || borrowerId <= 0)
            {
                MessageBox.Show("❌ Borrower ID must be a valid positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = t2.Text.Trim();
            string email = t3.Text.Trim();

            if (!long.TryParse(t4.Text.Trim(), out long phone) || phone <= 0 || t4.Text.Trim().Length != 10)
            {
                MessageBox.Show("❌ Phone number must be a 10-digit valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("❌ Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.EditBorrower(borrowerId, name, email, phone);
            ClearBorrowerFields();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(t1.Text.Trim(), out int borrowerId) || borrowerId <= 0)
            {
                MessageBox.Show("❌ Borrower ID must be a valid positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.DeleteBorrower(borrowerId);
            t1.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox5.Text.Trim(), out int bookId) || bookId <= 0)
            {
                MessageBox.Show("❌ Please enter a valid BookID to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete the book with ID {bookId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Your delete method here
                Program.DeleteBook(bookId);

                MessageBox.Show("✅ Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearBookFields();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox5.Text.Trim(), out int bookId) || bookId <= 0)
            {
                MessageBox.Show("❌ BookID must be a valid positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string title = textBox1.Text.Trim();
            string author = textBox2.Text.Trim();
            string yearText = textBox3.Text.Trim();
            string copiesText = textBox4.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("❌ Title cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("❌ Author cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(yearText, out int year) || year < 0 || year > DateTime.Now.Year)
            {
                MessageBox.Show("❌ Year must be a valid number between 0 and the current year.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(copiesText, out int copies) || copies < 0)
            {
                MessageBox.Show("❌ Copies must be a valid non-negative integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Your method to add the book - replace this with your logic
            Program.AddBook(bookId, title, author, year, copies);

            MessageBox.Show("✅ Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearBookFields();
        }

        private void ClearBookFields()
        {
            textBox5.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox5.Text.Trim(), out int bookId) || bookId <= 0)
            {
                MessageBox.Show("❌ BookID must be a valid positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string title = textBox1.Text.Trim();
            string author = textBox2.Text.Trim();
            string yearText = textBox3.Text.Trim();
            string copiesText = textBox4.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("❌ Title cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("❌ Author cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(yearText, out int year) || year < 0 || year > DateTime.Now.Year)
            {
                MessageBox.Show("❌ Year must be a valid number between 0 and the current year.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(copiesText, out int copies) || copies < 0)
            {
                MessageBox.Show("❌ Copies must be a valid non-negative integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Your update method here
            Program.EditBook(bookId, title, author, year, copies);

            MessageBox.Show("✅ Book details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearBookFields();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ClearBookFields();
        }


        //private void LoadData()
        //{
        //    string connectionString = "server=localhost;user=root;password=Yuhu7326@;database=book;";

        //    using (MySqlConnection conn = new MySqlConnection(connectionString))
        //    {
        //        string query = "SELECT * FROM books";
        //        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        dataGridView1.DataSource = dt;
        //    }
        //}


    }
}
