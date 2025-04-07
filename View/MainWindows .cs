using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Global.suiviGroupes = SaveManager.Open();
            LoadGroups();
        }


        private void LoadGroups()
        {
            this.CB_CONTACTS.Items.Clear();
            this.CB_CONTACTS.Items.Add("Tout");

            // Load the groups into the combo box
            foreach (Groupes group in Global.suiviGroupes)
            {
                CB_CONTACTS.Items.Add(group);
            }

            if (CB_CONTACTS.Items.Count > 0)
            {
                CB_CONTACTS.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LABEL_ADDRESS_CONTACT_Click(object sender, EventArgs e)
        {

        }

        private void UpdateContacts()
        {
            int selectedIndex = this.CB_CONTACTS.SelectedIndex;

            if (selectedIndex == 0)
            {
                // Afficher tous les concats 
                ShowAllContacts();
            }
            else if (selectedIndex > 0)
            {
                // Afficher les contacts du groupe sélectionné
                Groupes groupes = (Groupes)this.CB_CONTACTS.SelectedItem;
                ShowContactsOf(groupes);
            }
            if (this.LB_CONTACTS.Items.Count > 0)
            {
                this.LB_CONTACTS.SelectedIndex = 0;
            }
            else
            {
                ClearInfos();
            }
        }

        private void ShowContactsOf(Groupes groupes)
        {
            this.LB_CONTACTS.Items.Clear();

            this.LB_CONTACTS.Items.AddRange(groupes.Contacts.ToArray());
        }

        private void ShowAllContacts()
        {
            LB_CONTACTS.Items.Clear();

            foreach (Groupes groupes in Global.suiviGroupes)
            {
                LB_CONTACTS.Items.AddRange(groupes.Contacts.ToArray());
            }
        }

        private void BT_ADD_NEW_CONTACT_Click(object sender, EventArgs e)
        {
            AddNewContactForm addNewContactForm = new AddNewContactForm();
            DialogResult dr = addNewContactForm.ShowDialog();

            if(dr == DialogResult.OK)
            {
                //Mise à jour de la liste des contacts
                UpdateContacts();

                //Sauvegarde des données
                SaveManager.SaveData(Global.suiviGroupes);
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout du contact");
            }

            MessageBox.Show(dr.ToString());
        }

        private void CB_CONTACTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateContacts();
        }

        private void LB_CONTACTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contacts contact = (Contacts)this.LB_CONTACTS.SelectedItem;
            if (contact != null)
            {
                ShowInfosOf(contact);
            } 
        }

        private void ShowInfosOf(Contacts contact)
        {
            ClearInfos();

            this.LABEL_IMG_GP_CONTACT.Text = this.CB_CONTACTS.SelectedItem.ToString();
            this.LABEL_REP_NAME_CONTACT.Text = contact.LastName;
            this.LABEL_REP_FIRST_NAME_CONTACT.Text = contact.FirstName;
            this.LABEL_REP_EMAIL_CONTACT.Text = contact.Email;
            this.LABEL_REP_ADDRESS_CONTACT.Text = contact.Address;
            this.LABEL_REP_TEL_CONTACT.Text = contact.Phone;
            this.PICB_IMG_CONTACT.Image = contact.Photo;
        }

        // ClearInfos() method to clear the contact information labels and image
        private void ClearInfos()
        {
            this.LABEL_IMG_GP_CONTACT.Text = "";
            this.LABEL_REP_NAME_CONTACT.Text = "";
            this.LABEL_REP_FIRST_NAME_CONTACT.Text = "";
            this.LABEL_REP_EMAIL_CONTACT.Text = "";
            this.LABEL_REP_TEL_CONTACT.Text = "";
            this.LABEL_REP_ADDRESS_CONTACT.Text = "";
            this.PICB_IMG_CONTACT.Image = null;
        }
    }
}
