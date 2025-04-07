namespace MyContact.View
{
    partial class RemoveGroupesWindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_REMOVE_NEW_GROUPES = new System.Windows.Forms.Button();
            this.LB_NAME_ADD_GROUPES = new System.Windows.Forms.Label();
            this.CB_REMOVE_GROUPES = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BT_REMOVE_NEW_GROUPES
            // 
            this.BT_REMOVE_NEW_GROUPES.Location = new System.Drawing.Point(358, 71);
            this.BT_REMOVE_NEW_GROUPES.Name = "BT_REMOVE_NEW_GROUPES";
            this.BT_REMOVE_NEW_GROUPES.Size = new System.Drawing.Size(185, 26);
            this.BT_REMOVE_NEW_GROUPES.TabIndex = 9;
            this.BT_REMOVE_NEW_GROUPES.Text = "Supprimer un groupe";
            this.BT_REMOVE_NEW_GROUPES.UseVisualStyleBackColor = true;
            this.BT_REMOVE_NEW_GROUPES.Click += new System.EventHandler(this.BT_REMOVE_NEW_GROUPES_Click);
            // 
            // LB_NAME_ADD_GROUPES
            // 
            this.LB_NAME_ADD_GROUPES.AutoSize = true;
            this.LB_NAME_ADD_GROUPES.Location = new System.Drawing.Point(12, 10);
            this.LB_NAME_ADD_GROUPES.Name = "LB_NAME_ADD_GROUPES";
            this.LB_NAME_ADD_GROUPES.Size = new System.Drawing.Size(148, 13);
            this.LB_NAME_ADD_GROUPES.TabIndex = 5;
            this.LB_NAME_ADD_GROUPES.Text = "Choisir le groupe à supprimer :";
            this.LB_NAME_ADD_GROUPES.Click += new System.EventHandler(this.LB_NAME_ADD_GROUPES_Click);
            // 
            // CB_REMOVE_GROUPES
            // 
            this.CB_REMOVE_GROUPES.FormattingEnabled = true;
            this.CB_REMOVE_GROUPES.Location = new System.Drawing.Point(16, 30);
            this.CB_REMOVE_GROUPES.Name = "CB_REMOVE_GROUPES";
            this.CB_REMOVE_GROUPES.Size = new System.Drawing.Size(527, 21);
            this.CB_REMOVE_GROUPES.TabIndex = 10;
            this.CB_REMOVE_GROUPES.SelectedIndexChanged += new System.EventHandler(this.CB_REMOVE_GROUPES_SelectedIndexChanged);
            // 
            // RemoveGroupesWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 119);
            this.Controls.Add(this.CB_REMOVE_GROUPES);
            this.Controls.Add(this.BT_REMOVE_NEW_GROUPES);
            this.Controls.Add(this.LB_NAME_ADD_GROUPES);
            this.Name = "RemoveGroupesWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supprimer un groupe ";
            this.Load += new System.EventHandler(this.RemoveGroupesWindows_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_REMOVE_NEW_GROUPES;
        private System.Windows.Forms.Label LB_NAME_ADD_GROUPES;
        private System.Windows.Forms.ComboBox CB_REMOVE_GROUPES;
    }
}