
namespace CRM
{
    partial class FrmContact
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxPicture = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxPersonnalData = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNationality = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxDates = new System.Windows.Forms.GroupBox();
            this.labelLastUpdate = new System.Windows.Forms.Label();
            this.labelCreationDate = new System.Windows.Forms.Label();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.groupBoxPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxPersonnalData.SuspendLayout();
            this.groupBoxDates.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPicture
            // 
            this.groupBoxPicture.Controls.Add(this.pictureBox1);
            this.groupBoxPicture.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPicture.Name = "groupBoxPicture";
            this.groupBoxPicture.Size = new System.Drawing.Size(134, 178);
            this.groupBoxPicture.TabIndex = 0;
            this.groupBoxPicture.TabStop = false;
            this.groupBoxPicture.Text = "Photo de profile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxPersonnalData
            // 
            this.groupBoxPersonnalData.Controls.Add(this.textBoxEmail);
            this.groupBoxPersonnalData.Controls.Add(this.label4);
            this.groupBoxPersonnalData.Controls.Add(this.textBoxNationality);
            this.groupBoxPersonnalData.Controls.Add(this.label3);
            this.groupBoxPersonnalData.Controls.Add(this.textBoxDateOfBirth);
            this.groupBoxPersonnalData.Controls.Add(this.label2);
            this.groupBoxPersonnalData.Controls.Add(this.textBoxFirstname);
            this.groupBoxPersonnalData.Controls.Add(this.label1);
            this.groupBoxPersonnalData.Controls.Add(this.textBoxName);
            this.groupBoxPersonnalData.Controls.Add(this.labelName);
            this.groupBoxPersonnalData.Location = new System.Drawing.Point(155, 12);
            this.groupBoxPersonnalData.Name = "groupBoxPersonnalData";
            this.groupBoxPersonnalData.Size = new System.Drawing.Size(296, 178);
            this.groupBoxPersonnalData.TabIndex = 1;
            this.groupBoxPersonnalData.TabStop = false;
            this.groupBoxPersonnalData.Text = "Données personnelles";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Location = new System.Drawing.Point(106, 137);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(165, 23);
            this.textBoxEmail.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // textBoxNationality
            // 
            this.textBoxNationality.Enabled = false;
            this.textBoxNationality.Location = new System.Drawing.Point(106, 111);
            this.textBoxNationality.Name = "textBoxNationality";
            this.textBoxNationality.Size = new System.Drawing.Size(165, 23);
            this.textBoxNationality.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nationalité";
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Enabled = false;
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(106, 85);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(165, 23);
            this.textBoxDateOfBirth.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date de naiss.";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Enabled = false;
            this.textBoxFirstname.Location = new System.Drawing.Point(106, 59);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(165, 23);
            this.textBoxFirstname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prénom";
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(106, 33);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(165, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(17, 36);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(34, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nom";
            // 
            // groupBoxDates
            // 
            this.groupBoxDates.Controls.Add(this.labelLastUpdate);
            this.groupBoxDates.Controls.Add(this.labelCreationDate);
            this.groupBoxDates.Location = new System.Drawing.Point(33, 259);
            this.groupBoxDates.Name = "groupBoxDates";
            this.groupBoxDates.Size = new System.Drawing.Size(418, 34);
            this.groupBoxDates.TabIndex = 2;
            this.groupBoxDates.TabStop = false;
            // 
            // labelLastUpdate
            // 
            this.labelLastUpdate.AutoSize = true;
            this.labelLastUpdate.Location = new System.Drawing.Point(202, 13);
            this.labelLastUpdate.Name = "labelLastUpdate";
            this.labelLastUpdate.Size = new System.Drawing.Size(80, 15);
            this.labelLastUpdate.TabIndex = 1;
            this.labelLastUpdate.Text = "Mis à jour le : ";
            // 
            // labelCreationDate
            // 
            this.labelCreationDate.AutoSize = true;
            this.labelCreationDate.Location = new System.Drawing.Point(10, 13);
            this.labelCreationDate.Name = "labelCreationDate";
            this.labelCreationDate.Size = new System.Drawing.Size(52, 15);
            this.labelCreationDate.TabIndex = 0;
            this.labelCreationDate.Text = "Créé le : ";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.button3);
            this.groupBoxActions.Controls.Add(this.button2);
            this.groupBoxActions.Controls.Add(this.buttonModify);
            this.groupBoxActions.Location = new System.Drawing.Point(12, 196);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(439, 63);
            this.groupBoxActions.TabIndex = 3;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(259, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(164, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Enregister";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Enabled = false;
            this.buttonModify.Location = new System.Drawing.Point(66, 25);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 0;
            this.buttonModify.Text = "Modifier";
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // FrmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 302);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxDates);
            this.Controls.Add(this.groupBoxPersonnalData);
            this.Controls.Add(this.groupBoxPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact : ";
            this.Load += new System.EventHandler(this.FrmContact_Load);
            this.groupBoxPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxPersonnalData.ResumeLayout(false);
            this.groupBoxPersonnalData.PerformLayout();
            this.groupBoxDates.ResumeLayout(false);
            this.groupBoxDates.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxPersonnalData;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNationality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxDates;
        private System.Windows.Forms.Label labelLastUpdate;
        private System.Windows.Forms.Label labelCreationDate;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonModify;
    }
}

