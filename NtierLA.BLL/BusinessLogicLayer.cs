using NtierLA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierLA.BLL
{
    public class BusinessLogicLayer
    {
        NtierLA.Core.DatabaseLogicLayer DLL;

        public BusinessLogicLayer()
        {
            DLL = new Core.DatabaseLogicLayer();
        }

        public int UserControl(string UserName,string Password)
        {
            int result = 0;


            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
            {
                User user = new User();
                user.UserName = UserName;
                user.Password = Password;
                result = DLL.UserControl(user);
            }
            else
            {
                result = -100; //missing parameter error
            }
             
            return result;
        }



        public int NewContact(Guid ID, string Name, string Surname, 
            string Telephone1, string Telephone2, string Telephone3,
            string Adress,string Email, string Website, string Definition)
        {
            int result = 0;
            
            if(ID!=Guid.Empty && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Surname) && !string.IsNullOrEmpty(Telephone1))
            {
                ContactsRegistration Contact = new ContactsRegistration();
                Contact.ID=ID;
                Contact.Name = Name;
                Contact.Surname = Surname;
                Contact.Telephone1 = Telephone1;
                Contact.Telephone2 = Telephone2;
                Contact.Telephone3 = Telephone3;
                Contact.Adress = Adress;
                Contact.Email = Email;
                Contact.Website = Website;
                Contact.Definition = Definition;

                result = DLL.NewContact(Contact);
            }
            else
            {
                result = -100; //missing parameter error
            }
            return result;
        }

        public int UpdateContact(Guid ID, string Name, string Surname,
           string Telephone1, string Telephone2, string Telephone3,
           string Adress, string Email, string Website, string Definition)
        {
            int result = 0;
            if (ID != Guid.Empty && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Surname) && !string.IsNullOrEmpty(Telephone1))
            {
                ContactsRegistration Contact = new ContactsRegistration();
                Contact.ID = ID;
                Contact.Name = Name;
                Contact.Surname = Surname;
                Contact.Telephone1 = Telephone1;
                Contact.Telephone2 = Telephone2;
                Contact.Telephone3 = Telephone3;
                Contact.Adress = Adress;
                Contact.Email = Email;
                Contact.Website = Website;
                Contact.Definition = Definition;

                result = DLL.UpdateContact(Contact);
            }
            return result;
        }



        public List<ContactsRegistration> BringContactsRegistrations()
        {
            return DLL.BringContactsRegistrations();
        }

    }
}
