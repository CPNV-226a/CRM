using NUnit.Framework;
using System;

namespace CRM
{
    public class TestContact
    {
        #region private attributes
        private Contact? _expectedContact;
        private string? _expectedName;
        private string? _expectedFirstname;
        private DateTime _expectedDateOfBirth;
        private string? _expectedNationality;
        private string? _expectedEmail;
        private string? _expectedPathToImg;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _expectedName = "Ricard";
            _expectedFirstname = "Matthieu";
            _expectedDateOfBirth = new DateTime(1946, 02, 15);
            _expectedNationality = "France";
            _expectedEmail = "matthieu.ricard@monk.org";
            _expectedPathToImg = "ricard.png";
            _expectedContact = new Contact(_expectedName, _expectedFirstname, _expectedDateOfBirth, _expectedNationality, _expectedEmail, _expectedPathToImg);
        }

        [Test]
        public void AllProperties_JustAfterInstantiation_GetValues()
        {
            //given
            //refere to Setup method

            //when

            //then
            Assert.AreEqual(_expectedContact.Name, _expectedName);
            Assert.AreEqual(_expectedContact.Firstname, _expectedFirstname);
            Assert.AreEqual(_expectedContact.DateOfBirth, _expectedDateOfBirth);
            Assert.AreEqual(_expectedContact.Nationality, _expectedNationality);
            Assert.AreEqual(_expectedContact.Email, _expectedEmail);
            Assert.AreEqual(_expectedContact.PathToImg, _expectedPathToImg);
        }

        [Test]
        public void Name_UpdateValue_GetNewValue()
        {
            //given
            //refere to Setup method
            string expectedNewName = "My New Name";
            _expectedContact.Name = expectedNewName;

            //when
            string actualName = _expectedContact.Name;

            //then
            Assert.AreEqual(expectedNewName, actualName);
            Assert.AreNotEqual(_expectedContact.CreationDate, _expectedContact.LastUpdate);
        }

        [Test]
        public void Firstname_UpdateValue_GetNewValue()
        {
            //given
            //refere to Setup method
            string expectedNewFirstname = "My New Firstname";
            _expectedContact.Firstname = expectedNewFirstname;

            //when

            //then
            Assert.AreEqual(expectedNewFirstname, _expectedContact.Firstname);
            Assert.AreNotEqual(_expectedContact.CreationDate, _expectedContact.LastUpdate);
        }

        [Test]
        public void DateOfBirth_UpdateValue_GetNewValue()
        {
            //given
            //refere to Setup method
            DateTime expectedNewBirthday = new DateTime(2020, 12, 01);
            _expectedContact.DateOfBirth = expectedNewBirthday;

            //when

            //then
            Assert.AreEqual(expectedNewBirthday, _expectedContact.DateOfBirth);
            Assert.AreNotEqual(_expectedContact.CreationDate, _expectedContact.LastUpdate);
        }

        [Test]
        public void Nationality_UpdateValue_GetNewValue()
        {
            //given
            //refere to Setup method
            string expectedNewNationality = "My New Nationality";
            _expectedContact.Nationality = expectedNewNationality;

            //when

            //then
            Assert.AreEqual(expectedNewNationality, _expectedContact.Nationality);
            Assert.AreNotEqual(_expectedContact.CreationDate, _expectedContact.LastUpdate);
        }

        [Test]
        public void Email_UpdateValue_GetNewValue()
        {
            //given
            //refere to Setup method
            string expectedNewEmail = "My New Email";
            _expectedContact.Email = expectedNewEmail;

            //when

            //then
            Assert.AreEqual(expectedNewEmail, _expectedContact.Email);
            Assert.AreNotEqual(_expectedContact.CreationDate, _expectedContact.LastUpdate);
        }
    }
}
