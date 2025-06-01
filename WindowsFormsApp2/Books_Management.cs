using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Books_Management : System.Windows.Forms.Form
    {
        public Books_Management()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(t1.Text, out int id) || id <= 0)
            {
                MessageBox.Show("❌ Book ID must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string title = t2.Text.Trim();
            string author = t3.Text.Trim();

            if (!int.TryParse(t4.Text, out int year))
            {
                MessageBox.Show("❌ Year must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(t5.Text, out int copies) || copies < 0)
            {
                MessageBox.Show("❌ Available copies must be a non-negative integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.AddBook(id, title, author, year, copies);
            ClearTextFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(t1.Text, out int id) || id <= 0)
            {
                MessageBox.Show("❌ Book ID must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string title = t2.Text.Trim();
            string author = t3.Text.Trim();

            if (!int.TryParse(t4.Text, out int year))
            {
                MessageBox.Show("❌ Year must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(t5.Text, out int copies) || copies < 0)
            {
                MessageBox.Show("❌ Available copies must be a non-negative integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.EditBook(id, title, author, year, copies);
            ClearTextFields();
        }

        private void ClearTextFields()
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";
        }


        private void button3_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(t1.Text.Trim(), out int id) || id <= 0)
            {
                MessageBox.Show("❌ Book ID must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.DeleteBook(id);


            t1.Text = "";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 manu = new Form2();
            manu.Show();
            this.Hide();
        }
    }
}
