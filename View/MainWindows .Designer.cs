﻿namespace Gestion_de_contactss_C_
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LEFT_PANEL = new System.Windows.Forms.Panel();
            this.GB_SEARCH_CONTACT = new System.Windows.Forms.GroupBox();
            this.TB_SEARCH_CONTACT = new System.Windows.Forms.TextBox();
            this.BT_ADD_NEW_CONTACT = new System.Windows.Forms.Button();
            this.GB_CONTACT = new System.Windows.Forms.GroupBox();
            this.LB_CONTACTS = new System.Windows.Forms.ListBox();
            this.CB_CONTACTS = new System.Windows.Forms.ComboBox();
            this.RIGHT_PANEL = new System.Windows.Forms.Panel();
            this.DELETE_CONTACT = new System.Windows.Forms.Button();
            this.LABEL_REP_TEL_CONTACT = new System.Windows.Forms.Label();
            this.LABEL_REP_ADDRESS_CONTACT = new System.Windows.Forms.Label();
            this.LABEL_REP_EMAIL_CONTACT = new System.Windows.Forms.Label();
            this.LABEL_REP_FIRST_NAME_CONTACT = new System.Windows.Forms.Label();
            this.LABEL_REP_NAME_CONTACT = new System.Windows.Forms.Label();
            this.LABEL_TEL_CONTACT = new System.Windows.Forms.Label();
            this.LABEL_ADDRESS_CONTACT = new System.Windows.Forms.Label();
            this.LABEL_EMAIL_CONTACT = new System.Windows.Forms.Label();
            this.LABEL_FIRST_NAME_CONTACT = new System.Windows.Forms.Label();
            this.LABEL_NAME_CONTACT = new System.Windows.Forms.Label();
            this.LABEL_IMG_GP_CONTACT = new System.Windows.Forms.Label();
            this.PICB_IMG_CONTACT = new System.Windows.Forms.PictureBox();
            this.LEFT_PANEL.SuspendLayout();
            this.GB_SEARCH_CONTACT.SuspendLayout();
            this.GB_CONTACT.SuspendLayout();
            this.RIGHT_PANEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICB_IMG_CONTACT)).BeginInit();
            this.SuspendLayout();
            // 
            // LEFT_PANEL
            // 
            this.LEFT_PANEL.Controls.Add(this.GB_SEARCH_CONTACT);
            this.LEFT_PANEL.Controls.Add(this.BT_ADD_NEW_CONTACT);
            this.LEFT_PANEL.Controls.Add(this.GB_CONTACT);
            this.LEFT_PANEL.Location = new System.Drawing.Point(8, 6);
            this.LEFT_PANEL.Name = "LEFT_PANEL";
            this.LEFT_PANEL.Size = new System.Drawing.Size(315, 485);
            this.LEFT_PANEL.TabIndex = 1;
            // 
            // GB_SEARCH_CONTACT
            // 
            this.GB_SEARCH_CONTACT.Controls.Add(this.TB_SEARCH_CONTACT);
            this.GB_SEARCH_CONTACT.Location = new System.Drawing.Point(16, 399);
            this.GB_SEARCH_CONTACT.Name = "GB_SEARCH_CONTACT";
            this.GB_SEARCH_CONTACT.Size = new System.Drawing.Size(279, 72);
            this.GB_SEARCH_CONTACT.TabIndex = 3;
            this.GB_SEARCH_CONTACT.TabStop = false;
            this.GB_SEARCH_CONTACT.Text = "Rechercher : ";
            // 
            // TB_SEARCH_CONTACT
            // 
            this.TB_SEARCH_CONTACT.Location = new System.Drawing.Point(14, 29);
            this.TB_SEARCH_CONTACT.Name = "TB_SEARCH_CONTACT";
            this.TB_SEARCH_CONTACT.Size = new System.Drawing.Size(252, 20);
            this.TB_SEARCH_CONTACT.TabIndex = 0;
            // 
            // BT_ADD_NEW_CONTACT
            // 
            this.BT_ADD_NEW_CONTACT.Location = new System.Drawing.Point(25, 367);
            this.BT_ADD_NEW_CONTACT.Name = "BT_ADD_NEW_CONTACT";
            this.BT_ADD_NEW_CONTACT.Size = new System.Drawing.Size(257, 23);
            this.BT_ADD_NEW_CONTACT.TabIndex = 2;
            this.BT_ADD_NEW_CONTACT.Text = "Ajouter un nouveau contact";
            this.BT_ADD_NEW_CONTACT.UseVisualStyleBackColor = true;
            this.BT_ADD_NEW_CONTACT.Click += new System.EventHandler(this.BT_ADD_NEW_CONTACT_Click);
            // 
            // GB_CONTACT
            // 
            this.GB_CONTACT.Controls.Add(this.LB_CONTACTS);
            this.GB_CONTACT.Controls.Add(this.CB_CONTACTS);
            this.GB_CONTACT.Location = new System.Drawing.Point(16, 13);
            this.GB_CONTACT.Name = "GB_CONTACT";
            this.GB_CONTACT.Size = new System.Drawing.Size(280, 348);
            this.GB_CONTACT.TabIndex = 1;
            this.GB_CONTACT.TabStop = false;
            this.GB_CONTACT.Text = "Mes contacts";
            // 
            // LB_CONTACTS
            // 
            this.LB_CONTACTS.FormattingEnabled = true;
            this.LB_CONTACTS.Location = new System.Drawing.Point(9, 46);
            this.LB_CONTACTS.Name = "LB_CONTACTS";
            this.LB_CONTACTS.Size = new System.Drawing.Size(257, 290);
            this.LB_CONTACTS.TabIndex = 1;
            this.LB_CONTACTS.SelectedIndexChanged += new System.EventHandler(this.LB_CONTACTS_SelectedIndexChanged);
            // 
            // CB_CONTACTS
            // 
            this.CB_CONTACTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_CONTACTS.FormattingEnabled = true;
            this.CB_CONTACTS.Location = new System.Drawing.Point(9, 17);
            this.CB_CONTACTS.Name = "CB_CONTACTS";
            this.CB_CONTACTS.Size = new System.Drawing.Size(258, 21);
            this.CB_CONTACTS.TabIndex = 0;
            this.CB_CONTACTS.SelectedIndexChanged += new System.EventHandler(this.CB_CONTACTS_SelectedIndexChanged);
            // 
            // RIGHT_PANEL
            // 
            this.RIGHT_PANEL.Controls.Add(this.DELETE_CONTACT);
            this.RIGHT_PANEL.Controls.Add(this.LABEL_REP_TEL_CONTACT);
            this.RIGHT_PANEL.Controls.Add(this.LABEL_REP_ADDRESS_CONTACT);
            this.RIGHT_PANEL.Controls.Add(this.LABEL_REP_EMAIL_CONTACT);
            this.RIGHT_PANEL.Controls.Add(this.LABEL_REP_FIRST_NAME_CONTACT);
            this.RIGHT_PANEL.Controls.Add(this.LABEL_REP_NAME_CONTACT);
            this.RIGHT_PANEL.Controls.Add(this.LABEL_TEL_CONTACT);
            this.RIGHT_PANEL.Controls.Add(this.LABEL_ADDRESS_CONTACT);
            this.RIGHT_PANEL.Controls.Add(this.LABEL_EMAIL_CONTACT);
            this.RIGHT_PANEL.Controls.Add(this.LABEL_FIRST_NAME_CONTACT);
            this.RIGHT_PANEL.Controls.Add(this.LABEL_NAME_CONTACT);
            this.RIGHT_PANEL.Controls.Add(this.LABEL_IMG_GP_CONTACT);
            this.RIGHT_PANEL.Controls.Add(this.PICB_IMG_CONTACT);
            this.RIGHT_PANEL.Location = new System.Drawing.Point(337, 6);
            this.RIGHT_PANEL.Name = "RIGHT_PANEL";
            this.RIGHT_PANEL.Size = new System.Drawing.Size(453, 485);
            this.RIGHT_PANEL.TabIndex = 2;
            // 
            // DELETE_CONTACT
            // 
            this.DELETE_CONTACT.BackColor = System.Drawing.Color.Transparent;
            this.DELETE_CONTACT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DELETE_CONTACT.BackgroundImage")));
            this.DELETE_CONTACT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DELETE_CONTACT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DELETE_CONTACT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DELETE_CONTACT.ForeColor = System.Drawing.SystemColors.Control;
            this.DELETE_CONTACT.Location = new System.Drawing.Point(425, 0);
            this.DELETE_CONTACT.Name = "DELETE_CONTACT";
            this.DELETE_CONTACT.Size = new System.Drawing.Size(28, 28);
            this.DELETE_CONTACT.TabIndex = 12;
            this.DELETE_CONTACT.UseVisualStyleBackColor = false;
            // 
            // LABEL_REP_TEL_CONTACT
            // 
            this.LABEL_REP_TEL_CONTACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_REP_TEL_CONTACT.Location = new System.Drawing.Point(199, 382);
            this.LABEL_REP_TEL_CONTACT.Name = "LABEL_REP_TEL_CONTACT";
            this.LABEL_REP_TEL_CONTACT.Size = new System.Drawing.Size(217, 38);
            this.LABEL_REP_TEL_CONTACT.TabIndex = 11;
            this.LABEL_REP_TEL_CONTACT.Text = "06 14 25 14 85 ";
            this.LABEL_REP_TEL_CONTACT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LABEL_REP_TEL_CONTACT.UseMnemonic = false;
            // 
            // LABEL_REP_ADDRESS_CONTACT
            // 
            this.LABEL_REP_ADDRESS_CONTACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_REP_ADDRESS_CONTACT.Location = new System.Drawing.Point(199, 344);
            this.LABEL_REP_ADDRESS_CONTACT.Name = "LABEL_REP_ADDRESS_CONTACT";
            this.LABEL_REP_ADDRESS_CONTACT.Size = new System.Drawing.Size(217, 38);
            this.LABEL_REP_ADDRESS_CONTACT.TabIndex = 10;
            this.LABEL_REP_ADDRESS_CONTACT.Text = "4 rue du Default, DefaultCity";
            this.LABEL_REP_ADDRESS_CONTACT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LABEL_REP_ADDRESS_CONTACT.UseMnemonic = false;
            // 
            // LABEL_REP_EMAIL_CONTACT
            // 
            this.LABEL_REP_EMAIL_CONTACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_REP_EMAIL_CONTACT.Location = new System.Drawing.Point(199, 306);
            this.LABEL_REP_EMAIL_CONTACT.Name = "LABEL_REP_EMAIL_CONTACT";
            this.LABEL_REP_EMAIL_CONTACT.Size = new System.Drawing.Size(217, 38);
            this.LABEL_REP_EMAIL_CONTACT.TabIndex = 9;
            this.LABEL_REP_EMAIL_CONTACT.Text = "Default@gmail.com";
            this.LABEL_REP_EMAIL_CONTACT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LABEL_REP_EMAIL_CONTACT.UseMnemonic = false;
            // 
            // LABEL_REP_FIRST_NAME_CONTACT
            // 
            this.LABEL_REP_FIRST_NAME_CONTACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_REP_FIRST_NAME_CONTACT.Location = new System.Drawing.Point(199, 268);
            this.LABEL_REP_FIRST_NAME_CONTACT.Name = "LABEL_REP_FIRST_NAME_CONTACT";
            this.LABEL_REP_FIRST_NAME_CONTACT.Size = new System.Drawing.Size(217, 38);
            this.LABEL_REP_FIRST_NAME_CONTACT.TabIndex = 8;
            this.LABEL_REP_FIRST_NAME_CONTACT.Text = "Default";
            this.LABEL_REP_FIRST_NAME_CONTACT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LABEL_REP_FIRST_NAME_CONTACT.UseMnemonic = false;
            // 
            // LABEL_REP_NAME_CONTACT
            // 
            this.LABEL_REP_NAME_CONTACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_REP_NAME_CONTACT.Location = new System.Drawing.Point(199, 230);
            this.LABEL_REP_NAME_CONTACT.Name = "LABEL_REP_NAME_CONTACT";
            this.LABEL_REP_NAME_CONTACT.Size = new System.Drawing.Size(217, 38);
            this.LABEL_REP_NAME_CONTACT.TabIndex = 7;
            this.LABEL_REP_NAME_CONTACT.Text = "Default";
            this.LABEL_REP_NAME_CONTACT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LABEL_REP_NAME_CONTACT.UseMnemonic = false;
            // 
            // LABEL_TEL_CONTACT
            // 
            this.LABEL_TEL_CONTACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_TEL_CONTACT.Location = new System.Drawing.Point(30, 382);
            this.LABEL_TEL_CONTACT.Name = "LABEL_TEL_CONTACT";
            this.LABEL_TEL_CONTACT.Size = new System.Drawing.Size(197, 38);
            this.LABEL_TEL_CONTACT.TabIndex = 6;
            this.LABEL_TEL_CONTACT.Text = "N° de téléphone : ";
            this.LABEL_TEL_CONTACT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LABEL_TEL_CONTACT.UseMnemonic = false;
            // 
            // LABEL_ADDRESS_CONTACT
            // 
            this.LABEL_ADDRESS_CONTACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_ADDRESS_CONTACT.Location = new System.Drawing.Point(30, 344);
            this.LABEL_ADDRESS_CONTACT.Name = "LABEL_ADDRESS_CONTACT";
            this.LABEL_ADDRESS_CONTACT.Size = new System.Drawing.Size(197, 38);
            this.LABEL_ADDRESS_CONTACT.TabIndex = 5;
            this.LABEL_ADDRESS_CONTACT.Text = "Adresse : ";
            this.LABEL_ADDRESS_CONTACT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LABEL_ADDRESS_CONTACT.UseMnemonic = false;
            this.LABEL_ADDRESS_CONTACT.Click += new System.EventHandler(this.LABEL_ADDRESS_CONTACT_Click);
            // 
            // LABEL_EMAIL_CONTACT
            // 
            this.LABEL_EMAIL_CONTACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_EMAIL_CONTACT.Location = new System.Drawing.Point(30, 306);
            this.LABEL_EMAIL_CONTACT.Name = "LABEL_EMAIL_CONTACT";
            this.LABEL_EMAIL_CONTACT.Size = new System.Drawing.Size(197, 38);
            this.LABEL_EMAIL_CONTACT.TabIndex = 4;
            this.LABEL_EMAIL_CONTACT.Text = "E-mail :";
            this.LABEL_EMAIL_CONTACT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LABEL_EMAIL_CONTACT.UseMnemonic = false;
            // 
            // LABEL_FIRST_NAME_CONTACT
            // 
            this.LABEL_FIRST_NAME_CONTACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_FIRST_NAME_CONTACT.Location = new System.Drawing.Point(30, 268);
            this.LABEL_FIRST_NAME_CONTACT.Name = "LABEL_FIRST_NAME_CONTACT";
            this.LABEL_FIRST_NAME_CONTACT.Size = new System.Drawing.Size(197, 38);
            this.LABEL_FIRST_NAME_CONTACT.TabIndex = 3;
            this.LABEL_FIRST_NAME_CONTACT.Text = "Prénom :";
            this.LABEL_FIRST_NAME_CONTACT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LABEL_FIRST_NAME_CONTACT.UseMnemonic = false;
            this.LABEL_FIRST_NAME_CONTACT.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LABEL_NAME_CONTACT
            // 
            this.LABEL_NAME_CONTACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_NAME_CONTACT.Location = new System.Drawing.Point(30, 230);
            this.LABEL_NAME_CONTACT.Name = "LABEL_NAME_CONTACT";
            this.LABEL_NAME_CONTACT.Size = new System.Drawing.Size(197, 38);
            this.LABEL_NAME_CONTACT.TabIndex = 2;
            this.LABEL_NAME_CONTACT.Text = "Nom :";
            this.LABEL_NAME_CONTACT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LABEL_NAME_CONTACT.UseMnemonic = false;
            this.LABEL_NAME_CONTACT.Click += new System.EventHandler(this.label1_Click);
            // 
            // LABEL_IMG_GP_CONTACT
            // 
            this.LABEL_IMG_GP_CONTACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_IMG_GP_CONTACT.Location = new System.Drawing.Point(286, 189);
            this.LABEL_IMG_GP_CONTACT.Name = "LABEL_IMG_GP_CONTACT";
            this.LABEL_IMG_GP_CONTACT.Size = new System.Drawing.Size(127, 21);
            this.LABEL_IMG_GP_CONTACT.TabIndex = 1;
            this.LABEL_IMG_GP_CONTACT.Text = "Groupe";
            this.LABEL_IMG_GP_CONTACT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LABEL_IMG_GP_CONTACT.UseMnemonic = false;
            // 
            // PICB_IMG_CONTACT
            // 
            this.PICB_IMG_CONTACT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PICB_IMG_CONTACT.Image = ((System.Drawing.Image)(resources.GetObject("PICB_IMG_CONTACT.Image")));
            this.PICB_IMG_CONTACT.InitialImage = ((System.Drawing.Image)(resources.GetObject("PICB_IMG_CONTACT.InitialImage")));
            this.PICB_IMG_CONTACT.Location = new System.Drawing.Point(33, 13);
            this.PICB_IMG_CONTACT.Name = "PICB_IMG_CONTACT";
            this.PICB_IMG_CONTACT.Size = new System.Drawing.Size(383, 200);
            this.PICB_IMG_CONTACT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICB_IMG_CONTACT.TabIndex = 0;
            this.PICB_IMG_CONTACT.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.RIGHT_PANEL);
            this.Controls.Add(this.LEFT_PANEL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LEFT_PANEL.ResumeLayout(false);
            this.GB_SEARCH_CONTACT.ResumeLayout(false);
            this.GB_SEARCH_CONTACT.PerformLayout();
            this.GB_CONTACT.ResumeLayout(false);
            this.RIGHT_PANEL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PICB_IMG_CONTACT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //Gestion du panel gauche de la MainWindows
        private System.Windows.Forms.Panel LEFT_PANEL;
        #region listAndComboBoxAndButtonPanelLeft
        private System.Windows.Forms.GroupBox GB_CONTACT;
        private System.Windows.Forms.ListBox LB_CONTACTS;
        private System.Windows.Forms.ComboBox CB_CONTACTS;
        private System.Windows.Forms.Button BT_ADD_NEW_CONTACT;
        #endregion
        #region searchContactPanelLeft
        private System.Windows.Forms.GroupBox GB_SEARCH_CONTACT;
        private System.Windows.Forms.TextBox TB_SEARCH_CONTACT;
        #endregion

        //Gestion du panel droit de la MainWindows
        private System.Windows.Forms.Panel RIGHT_PANEL;
        #region labelAndImgPanelRight
        private System.Windows.Forms.Button DELETE_CONTACT;
        private System.Windows.Forms.PictureBox PICB_IMG_CONTACT;
        private System.Windows.Forms.Label LABEL_IMG_GP_CONTACT;
        private System.Windows.Forms.Label LABEL_NAME_CONTACT;
        private System.Windows.Forms.Label LABEL_FIRST_NAME_CONTACT;
        private System.Windows.Forms.Label LABEL_EMAIL_CONTACT;
        private System.Windows.Forms.Label LABEL_ADDRESS_CONTACT;
        private System.Windows.Forms.Label LABEL_TEL_CONTACT;
        #endregion
        #region reponseLabelPanelRight
        private System.Windows.Forms.Label LABEL_REP_TEL_CONTACT;
        private System.Windows.Forms.Label LABEL_REP_ADDRESS_CONTACT;
        private System.Windows.Forms.Label LABEL_REP_EMAIL_CONTACT;
        private System.Windows.Forms.Label LABEL_REP_FIRST_NAME_CONTACT;
        private System.Windows.Forms.Label LABEL_REP_NAME_CONTACT;
        #endregion

    }
}

