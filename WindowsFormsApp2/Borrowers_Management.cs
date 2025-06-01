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
    public partial class Borrowers_Management : System.Windows.Forms.Form
    {
        public Borrowers_Management()
        {
            InitializeComponent();
        }

         private void button1_Click(object sender, EventArgs e)
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
            ClearBorrowerFields();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(t1.Text.Trim(), out int borrowerId) || borrowerId <= 0)
            {
                MessageBox.Show("❌ Borrower ID must be a valid positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.DeleteBorrower(borrowerId);
            t1.Text = "";
        }

        private void ClearBorrowerFields()
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
