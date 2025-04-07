namespace MyContact
{
    partial class AddGroupesWindows
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
            this.LB_NAME_ADD_GROUPES = new System.Windows.Forms.Label();
            this.TB_NAME_ADD_GROUPES = new System.Windows.Forms.TextBox();
            this.TB_DESC_ADD_GROUPES = new System.Windows.Forms.TextBox();
            this.LB_DESC_ADD_GROUPES = new System.Windows.Forms.Label();
            this.BT_ADD_NEW_GROUPES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_NAME_ADD_GROUPES
            // 
            this.LB_NAME_ADD_GROUPES.AutoSize = true;
            this.LB_NAME_ADD_GROUPES.Location = new System.Drawing.Point(12, 9);
            this.LB_NAME_ADD_GROUPES.Name = "LB_NAME_ADD_GROUPES";
            this.LB_NAME_ADD_GROUPES.Size = new System.Drawing.Size(126, 13);
            this.LB_NAME_ADD_GROUPES.TabIndex = 0;
            this.LB_NAME_ADD_GROUPES.Text = "Choisir le nom du groupe ";
            this.LB_NAME_ADD_GROUPES.Click += new System.EventHandler(this.LB_NAME_ADD_GROUPES_Click);
            // 
            // TB_NAME_ADD_GROUPES
            // 
            this.TB_NAME_ADD_GROUPES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NAME_ADD_GROUPES.Location = new System.Drawing.Point(15, 25);
            this.TB_NAME_ADD_GROUPES.Name = "TB_NAME_ADD_GROUPES";
            this.TB_NAME_ADD_GROUPES.Size = new System.Drawing.Size(529, 26);
            this.TB_NAME_ADD_GROUPES.TabIndex = 1;
            this.TB_NAME_ADD_GROUPES.TextChanged += new System.EventHandler(this.TB_NAME_ADD_GROUPES_TextChanged);
            // 
            // TB_DESC_ADD_GROUPES
            // 
            this.TB_DESC_ADD_GROUPES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DESC_ADD_GROUPES.Location = new System.Drawing.Point(15, 78);
            this.TB_DESC_ADD_GROUPES.Name = "TB_DESC_ADD_GROUPES";
            this.TB_DESC_ADD_GROUPES.Size = new System.Drawing.Size(529, 26);
            this.TB_DESC_ADD_GROUPES.TabIndex = 3;
            this.TB_DESC_ADD_GROUPES.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LB_DESC_ADD_GROUPES
            // 
            this.LB_DESC_ADD_GROUPES.AutoSize = true;
            this.LB_DESC_ADD_GROUPES.Location = new System.Drawing.Point(12, 62);
            this.LB_DESC_ADD_GROUPES.Name = "LB_DESC_ADD_GROUPES";
            this.LB_DESC_ADD_GROUPES.Size = new System.Drawing.Size(153, 13);
            this.LB_DESC_ADD_GROUPES.TabIndex = 2;
            this.LB_DESC_ADD_GROUPES.Text = "Mettre la description du groupe";
            this.LB_DESC_ADD_GROUPES.Click += new System.EventHandler(this.label2_Click);
            // 
            // BT_ADD_NEW_GROUPES
            // 
            this.BT_ADD_NEW_GROUPES.Location = new System.Drawing.Point(359, 113);
            this.BT_ADD_NEW_GROUPES.Name = "BT_ADD_NEW_GROUPES";
            this.BT_ADD_NEW_GROUPES.Size = new System.Drawing.Size(185, 26);
            this.BT_ADD_NEW_GROUPES.TabIndex = 4;
            this.BT_ADD_NEW_GROUPES.Text = "Ajouter un groupe";
            this.BT_ADD_NEW_GROUPES.UseVisualStyleBackColor = true;
            this.BT_ADD_NEW_GROUPES.Click += new System.EventHandler(this.BT_ADD_NEW_GROUPES_Click);
            // 
            // AddGroupesWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 151);
            this.Controls.Add(this.BT_ADD_NEW_GROUPES);
            this.Controls.Add(this.TB_DESC_ADD_GROUPES);
            this.Controls.Add(this.LB_DESC_ADD_GROUPES);
            this.Controls.Add(this.TB_NAME_ADD_GROUPES);
            this.Controls.Add(this.LB_NAME_ADD_GROUPES);
            this.Name = "AddGroupesWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un groupe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_NAME_ADD_GROUPES;
        private System.Windows.Forms.TextBox TB_NAME_ADD_GROUPES;
        private System.Windows.Forms.TextBox TB_DESC_ADD_GROUPES;
        private System.Windows.Forms.Label LB_DESC_ADD_GROUPES;
        private System.Windows.Forms.Button BT_ADD_NEW_GROUPES;
    }
}