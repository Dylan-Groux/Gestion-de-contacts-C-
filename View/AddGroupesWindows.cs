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
    public partial class AddGroupesWindows : Form
    {
        public AddGroupesWindows()
        {
            InitializeComponent();
        }

        //Properties
        public Groupes GroupesToAdd { get; private set; }

        //Constructor

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BT_ADD_NEW_GROUPES_Click(object sender, EventArgs e)
        {
            string groupName = this.TB_NAME_ADD_GROUPES.Text;
            string groupDesc = this.TB_DESC_ADD_GROUPES.Text;

            if (groupName.Length > 0 && groupDesc.Length > 0)
            {
                this.GroupesToAdd = new Groupes(groupName, groupDesc);
                this.DialogResult = DialogResult.OK;
            }

        }

        private void TB_NAME_ADD_GROUPES_TextChanged(object sender, EventArgs e)
        {

        }

        private void LB_NAME_ADD_GROUPES_Click(object sender, EventArgs e)
        {

        }
    }
}
