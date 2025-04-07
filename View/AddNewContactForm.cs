using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyContact.View;

namespace MyContact
{
    public partial class AddNewContactForm : Form
    {
        public AddNewContactForm()
        {
            InitializeComponent();
            LoadGroups();
        }

        private void LoadGroups()
        {   
            this.CB_GROUPES_ADD_NEWCONTACT.Items.Clear();

            this.CB_GROUPES_ADD_NEWCONTACT.Items.AddRange(Global.suiviGroupes.ToArray());

            if (CB_GROUPES_ADD_NEWCONTACT.Items.Count > 0)
            {
                CB_GROUPES_ADD_NEWCONTACT.SelectedIndex = 0; 
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void BT_ADD_NEWCONTACT_Click(object sender, EventArgs e)
        {
            //Récupération des informations
            string firstname = LABEL_REP_FIRST_NAME_NEWCONTACT.Text;
            string lastname = LABEL_REP_NAME_NEWCONTACT.Text;
            string email = LABEL_REP_EMAIL_NEWCONTACT.Text;
            string phone = LABEL_REP_TEL_NEWCONTACT.Text;
            string address = LABEL_REP_ADDRESS_NEWCONTACT.Text;
            Groupes groupes = (Groupes)this.CB_GROUPES_ADD_NEWCONTACT.SelectedItem;

            Image photo = this.PICB_IMG_NEWCONTACT.Image;

            //Vérification des champs
            if (checkInputs(firstname, lastname, email, phone, address, groupes, photo) == true)
            {
                //Création du contact
                Contacts contact = new Contacts(firstname, lastname, email, phone, address, photo);

                //Ajout d'un Contact dans un groupe
                if (groupes != null)
                {
                    groupes.Contacts.Add(contact);
                }

                this.DialogResult = DialogResult.OK; // Indique que l'ajout a été effectué avec succès
            }
        }


        private bool checkInputs(string firstname, string lastname, string email, string phone, string address, Groupes groupes, Image photo)
        {
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return false;
            }
            else
            {
               return !string.IsNullOrEmpty(firstname) && !string.IsNullOrEmpty(lastname) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(address);
            }
        }

        private void BT_ADD_NEW_PICTURE_NEWCONTACT_Click(object sender, EventArgs e)
        {
           DialogResult dr =  this.OFD_IMG_NEWCONTACT.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //La propriété ImageLocation permet d'afficher l'image dans le PictureBox
                this.PICB_IMG_NEWCONTACT.ImageLocation = this.OFD_IMG_NEWCONTACT.FileName;
            }

                MessageBox.Show(dr.ToString());

        }

        private void BT_ADD_GROUPES_NEW_CONTACT_Click(object sender, EventArgs e)
        {
            AddGroupesWindows agw = new AddGroupesWindows();
            if(agw.ShowDialog() == DialogResult.OK)
            {
                if (agw.GroupesToAdd != null)
                {
                    Global.AddGroupes(agw.GroupesToAdd);

                    this.CB_GROUPES_ADD_NEWCONTACT.Items.Add(agw.GroupesToAdd);
                    this.CB_GROUPES_ADD_NEWCONTACT.SelectedItem = agw.GroupesToAdd;
                }
            }
        }

        private void BT_REMOVE_GROUPES_NEW_CONTACT_Click(object sender, EventArgs e)
        {
            RemoveGroupesWindows rgw = new RemoveGroupesWindows();
            if(rgw.ShowDialog() == DialogResult.OK)
            {
                Global.RemoveGroupes(rgw.GroupesToRemove);

                this.CB_GROUPES_ADD_NEWCONTACT.Items.Remove(rgw.GroupesToRemove);
                this.CB_GROUPES_ADD_NEWCONTACT.SelectedIndex = 0;
            }
            
        }

        private void CB_GROUPES_ADD_NEWCONTACT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddNewContactForm_Load(object sender, EventArgs e)
        {

        }
    }
    }
