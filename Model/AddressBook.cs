using System.Collections.Generic;
using System;

namespace CRM
{
    public class AddressBook
    {
        #region private attributes
        private List<Contact> _contacts = new List<Contact>();
        #endregion private attibutes

        #region public methods
        public void AddContact(Contact contactToAdd)
        {
            _contacts.Add(contactToAdd);
        }

        public List<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
        }
        #endregion public methods
    }
}
