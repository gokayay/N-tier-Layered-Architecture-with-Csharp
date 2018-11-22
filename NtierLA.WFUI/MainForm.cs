using NtierLA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtierLA.WFUI
{
    public partial class MainForm : Form
    {
        NtierLA.BLL.BusinessLogicLayer BLL;

        public MainForm()
        {
            InitializeComponent();
            BLL = new NtierLA.BLL.BusinessLogicLayer();
        }

      
        private void button_newcontact_Click(object sender, EventArgs e)
        {
            int result = BLL.NewContact(Guid.NewGuid(), txt_name.Text, txt_surname.Text, txt_telephone1.Text, txt_telephone2.Text, txt_telephone3.Text,
                txt_email.Text, txt_website.Text, txt_address.Text, txt_definition.Text);

            if (result >= 0)
            {
                MessageBox.Show("Your contact has been added successfully!");
                Fill();
            }
            else if (result == -100)
            {
                MessageBox.Show("Missing Parameter Error! Please Fill Name,Surname,Telephone1 areas.");

            }
            else
            {
                MessageBox.Show("An error caused on adding!");
            }
        }

        private void Fill()
        {
            List<ContactsRegistration> contactRegistrations = BLL.BringContactsRegistrations();
            if(contactRegistrations!= null && contactRegistrations.Count > 0)
            {
                lst_list.DataSource = contactRegistrations;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void lst_list_DoubleClick(object sender, EventArgs e)
        {
            ListBox L = (ListBox)sender;
            ContactsRegistration ChosenValue=(ContactsRegistration)L.SelectedItem;
            txt_name.Text = ChosenValue.Name;
            txt_surname.Text = ChosenValue.Surname;
            txt_telephone1.Text = ChosenValue.Telephone1;
            txt_telephone2.Text = ChosenValue.Telephone2;
            txt_telephone3.Text = ChosenValue.Telephone3;
            txt_email.Text = ChosenValue.Email;
            txt_website.Text = ChosenValue.Website;
            txt_address.Text = ChosenValue.Adress;
            txt_definition.Text = ChosenValue.Definition;

            groupBox2.Text = "Update Contact";
        }

        private void button_updatecontact_Click(object sender, EventArgs e)
        {
            if (lst_list.SelectedItem != null)
            {
                ContactsRegistration k = (ContactsRegistration)lst_list.SelectedItem;
                int result = BLL.UpdateContact(k.ID, txt_name.Text, txt_surname.Text, txt_telephone1.Text, txt_telephone2.Text, txt_telephone3.Text,
                txt_email.Text, txt_website.Text, txt_address.Text, txt_definition.Text);

                if (result >= 0)
                {
                    MessageBox.Show("Successful Updating!");
                    Fill();
                }
                else if (result == -100)
                {
                    MessageBox.Show("Missing Parameter Error! Please Fill Name,Surname,Telephone1 areas.");

                }
                else
                {
                    MessageBox.Show("An error caused on updating!");
                }
            }
        }
    }
}
