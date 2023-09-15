using NUnit.Framework;
using System;

namespace CRM
{
    public class TestAddressBook
    {
        #region private attributes
        private AddressBook _addressBook;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _addressBook = new AddressBook();
        }

        [Test]
        public void Contacts_AddOneContact_GetContact()
        {
            //given
            Contact gauthier = new Contact("Gauthier", "Jean-Paul", new DateTime(2020, 12, 16),"espagnole", "jp@gauthier.com");

            //when
            _addressBook.AddContact(gauthier);

            //then
            Assert.AreEqual(1, _addressBook.Contacts.Count());

        }
    }
}