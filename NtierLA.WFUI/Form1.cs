using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NtierLA.BLL;

namespace NtierLA.WFUI
{
    public partial class Form1 : Form
    {
        private readonly BusinessLogicLayer BLL;

        public Form1()
        {
            InitializeComponent();
            BLL = new NtierLA.BLL.BusinessLogicLayer();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            int result = BLL.UserControl(textBox1.Text, textBox2.Text);

            if (result >= 0)
            {
                MainForm form = new MainForm();
                form.Show();
            }
            else if (result == -100)
            {
                MessageBox.Show("Please fill the form area completely!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
