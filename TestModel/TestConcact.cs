using NUnit.Framework;
using System;

namespace CRM
{
    public class Tests
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
        }

        [Test]
        public void LastUpdate_UpdateName_GetNewValue()
        {
            //given
            //refere to Setup method
            string expectedNewName = "My New Name";
            _expectedContact.Name = expectedNewName;

            //when

            //then
            Assert.AreNotEqual(_expectedContact.CreationDate, _expectedContact.LastUpdate);
        }
    }
}