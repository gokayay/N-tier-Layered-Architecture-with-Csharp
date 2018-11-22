using NtierLA.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierLA.Core
{
    public class DatabaseLogicLayer
    {
        List<ContactsRegistration> MyContacts;

        public DatabaseLogicLayer()
        {
            MyContacts = new List<ContactsRegistration>();
            DatabaseControl();
        }

        private void DatabaseControl()
        {
            bool fileControl = Directory.Exists(@"C:\Users\Gökay\");

            if (!fileControl)
            {
                Directory.CreateDirectory(@"C:\Users\Gökay\");

                User Demo = new User();
                Demo.ID = Guid.NewGuid();
                Demo.UserName = "Demo";
                Demo.Password = "Demo";

                string JsonUserText = Newtonsoft.Json.JsonConvert.SerializeObject(Demo);
                File.WriteAllText(@"C:\Users\Gökay\User.json",JsonUserText);

            }
        }

        public int NewContact(ContactsRegistration k)
        {
            int result = 0;
            try
            {
                BringContactsRegistrations(); //
                MyContacts.Add(k); // We add our new contact in collection(list)
                JsonDBUpdate(); // if there is a JsonDB, this method reads current json; if there isnt a JsonDB, this method creates new one.
                result = 1;
            }
            catch(Exception ex)
            {
                //logs
                result = 0;
            }

            return result;
        }

        public int UpdateContact(ContactsRegistration k)
        {
            int result = 0;
            try
            {
                BringContactsRegistrations();
                int Index = MyContacts.FindIndex(I => I.ID == k.ID);
                if (Index > -1)
                {
                    MyContacts[Index].Name = k.Name;
                    MyContacts[Index].Surname = k.Surname;
                    MyContacts[Index].Telephone1 = k.Telephone1;
                    MyContacts[Index].Telephone2 = k.Telephone2;
                    MyContacts[Index].Telephone3 = k.Telephone3;
                    MyContacts[Index].Email = k.Email;
                    MyContacts[Index].Website = k.Website;
                    MyContacts[Index].Adress = k.Adress;
                    MyContacts[Index].Definition = k.Definition;
                }
                JsonDBUpdate();
                result = 1;
            }
            catch (Exception ex)
            {
                //logs
                result = 0;
            }

            return result;
        }

        public List<ContactsRegistration> BringContactsRegistrations()
        {
            if (File.Exists(@"C:\Users\Gökay\Contact.json"))
            {
                string JsonDBText = File.ReadAllText(@"C:\Users\Gökay\Contact.json");
                MyContacts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ContactsRegistration>>(JsonDBText);
            }

            return MyContacts;
        }

        public int UserControl(User user)
        {
            int userResult = 0;

            if (File.Exists(@"C:\Users\Gökay\User.json"))
            {
                string JsonUserText = File.ReadAllText(@"C:\Users\Gökay\User.json");
                List<User> Users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(JsonUserText);

                Users.FindAll(I => I.UserName == user.UserName && I.Password == user.Password).ToList().Count();
            }
            return userResult;
        }


        #region Helper Methods

        private void JsonDBUpdate()
        {
            if (MyContacts != null && MyContacts.Count > 0)
            {
                string JsonDB = Newtonsoft.Json.JsonConvert.SerializeObject(MyContacts);
                File.WriteAllText(@"C:\Users\Gökay\Contact.json", JsonDB);
            }
        }
        #endregion

    }
}



