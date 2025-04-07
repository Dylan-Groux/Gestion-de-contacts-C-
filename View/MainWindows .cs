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
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();

            Global.suiviGroupes = SaveManager.Open();
            LoadGroups();
        }


        public void LoadGroups()
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

        private void MainWindows_Load(object sender, EventArgs e)
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

        private void BT_DELETE_CONTACT_Click(object sender, EventArgs e)
        {
            Contacts contact = (Contacts)this.LB_CONTACTS.SelectedItem;
            Groupes groupes = GetGroupOf(contact);

            if (groupes != null && contact != null)
            {
                DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce contact ?",
                                "MyContacts", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    groupes.Contacts.Remove(contact);
                    UpdateContacts();
                    SaveManager.SaveData(Global.suiviGroupes);
                }
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

            Image imageToShow;
            if (contact.Photo != null)
            {
                imageToShow = contact.Photo;
            }
            else
            {
                imageToShow = Properties.Resources.ic_profile;
            }

            this.LABEL_IMG_GP_CONTACT.Text = GetGroupOf(contact).Name ;
            this.LABEL_REP_NAME_CONTACT.Text = contact.LastName;
            this.LABEL_REP_FIRST_NAME_CONTACT.Text = contact.FirstName;
            this.LABEL_REP_EMAIL_CONTACT.Text = contact.Email;
            this.LABEL_REP_ADDRESS_CONTACT.Text = contact.Address;
            this.LABEL_REP_TEL_CONTACT.Text = contact.Phone;
            this.PICB_IMG_CONTACT.Image = imageToShow;
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
            this.PICB_IMG_CONTACT.Image = MyContact.Properties.Resources.ic_profile;
        }

        //Méthode pour récupérer un groupe spécifique
        private Groupes GetGroupOf(Contacts contact)
        {
            return Global.suiviGroupes.Find(groupes => groupes.Contacts.Contains(contact));
        }

        private void PICB_IMG_CONTACT_Click(object sender, EventArgs e)
        {
        }
    }
}
