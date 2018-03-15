using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddEditForm : Form
    {
        public string CategoryName
        {
            get { return textBoxname.Text; }
        }
        public AddEditForm()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxname.Text))
            {
                MessageBox.Show("Вкажіть ім'я категорії!", "Повідомлення",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show(textBoxname.Text);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
