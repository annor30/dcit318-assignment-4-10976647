using System;
using System.Windows.Forms;

namespace Address_book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;

            string contactInfo = $"Name: {name}, Email: {email}, Phone: {phone}";
            

            MessageBox.Show("Contact saved!");
        }
    }
}
