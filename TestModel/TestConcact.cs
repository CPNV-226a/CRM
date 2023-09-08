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
        public void Name_JustAfterInstantiation_GetValue()
        {
            //given
            //refere to Setup method

            //when
            string actualName = _expectedContact.Name;

            //then
            Assert.AreEqual(_expectedName, actualName);
        }
    }
}