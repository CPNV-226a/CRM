using System;
using System.Windows.Forms;

namespace CRM
{
    public partial class FrmContact : Form
    {
        #region private attributes
        private Contact _contact = null;
        #endregion private attributes
        public FrmContact()
        {
            InitializeComponent();
        }

        private void FrmContact_Load(object sender, EventArgs e)
        {
            this.CreateContact();
        }

        private void CreateContact()
        {
            _contact = new Contact("Ricard", "Mathieu", new DateTime(1946, 02, 15), "France", "mathieu.ricard@monk.org", "ricard.png");
        }

        private void UpdateGui()
        {
            this.Text += " " + _contact.Name;
            this.textBoxName.Text = _contact.Name;
            this.textBoxFirstname.Text = _contact.Firstname;
            this.textBoxDateOfBirth.Text = _contact.DateOfBirth.ToString();
            this.textBoxNationality.Text = _contact.Nationality;
            this.textBoxEmail.Text = _contact.Email;
            //TODO calculate resource name
            this.pictureBox1.Image = global::_226TestApp.Properties.Resources.MathieuRicard;
            this.labelCreationDate.Text = "Créé le :" + _contact.CreationDate;
            this.labelLastUpdate.Text = "Mis à jour le :" + _contact.LastUpdate;
        }
    }
}
