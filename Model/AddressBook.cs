using System.Collections.Generic;
using System;

namespace CRM
{
    public class AddressBook
    {
        #region private attributes
        private List<Contact> _contacts = new List<Contact>();
        private string _addresseBook;
        #endregion private attibutes

        #region public methods
        public void AddContact(Contact contactToAdd)
        {
            _contacts.Add(contactToAdd);
        }

        public void AddContacts(List<Contact> contacts)
        {
            throw new NotImplementedException();
        }

        public bool? DoesExist(Contact astier)
        {
            throw new NotImplementedException();
        }

        public bool? Remove(Contact gauthier)
        {
            throw new NotImplementedException();
        }

        public List<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
        }
        #endregion public methods

        public class ContactAlreadyExist : Exception { };
    }
}
