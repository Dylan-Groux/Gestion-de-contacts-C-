using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContact.View
{
    public partial class RemoveGroupesWindows : Form
    {
        public RemoveGroupesWindows()
        {
            InitializeComponent();
            LoadGroups();
        }

        //Variables 
        public Groupes GroupesToRemove{ get; private set; }


        private void LoadGroups()
        {
            this.CB_REMOVE_GROUPES.Items.Clear();

            this.CB_REMOVE_GROUPES.Items.AddRange(Global.suiviGroupes.ToArray());

            if (CB_REMOVE_GROUPES.Items.Count > 0)
            {
                CB_REMOVE_GROUPES.SelectedIndex = 0;
            }

        }

        private void LB_NAME_ADD_GROUPES_Click(object sender, EventArgs e)
        {

        }

        private void CB_REMOVE_GROUPES_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BT_REMOVE_NEW_GROUPES_Click(object sender, EventArgs e)
        {
            string groupName = this.CB_REMOVE_GROUPES.Text;

            if (groupName.Length > 0)
            {
                this.GroupesToRemove = new Groupes(groupName, "");
                DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce groupe ?",
                "MyContacts", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
                {
                    if (dr == DialogResult.Yes)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        dr = DialogResult.Cancel;
                    }
                }
            }

        }

        private void RemoveGroupesWindows_Load(object sender, EventArgs e)
        {

        }
    }
}
