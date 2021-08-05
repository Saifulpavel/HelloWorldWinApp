using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWinApp
{
    public partial class HelloAppUi : Form
    {
        public HelloAppUi()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text.Trim()=="")
            {
                MessageBox.Show("Please enter First Name","Information");
                firstNameTextBox.Focus();
                return;
            }
            else
            {
                string firstName = firstNameTextBox.Text;
                string middleName = middleNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string fullName = firstName + " " + middleName + " " + lastName;
                fullNameTextBox.Text = fullName;
                MessageBox.Show("Data Inserted Successfully","Information");
                firstNameTextBox.Clear();
                middleNameTextBox.Clear();
                lastNameTextBox.Clear();
            }
            
        }

        private void HelloAppUi_Load(object sender, EventArgs e)
        {

        }
    }
}
