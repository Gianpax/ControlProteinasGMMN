
namespace ControlProteinasClient
{
    partial class ControlProteinasForm
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
            this.lbSelectUser = new System.Windows.Forms.Label();
            this.cbSelectUser = new System.Windows.Forms.ComboBox();
            this.gbNewUser = new System.Windows.Forms.GroupBox();
            this.btnNewUserAdd = new System.Windows.Forms.Button();
            this.tbNewUserMeta = new System.Windows.Forms.TextBox();
            this.tbNewUserName = new System.Windows.Forms.TextBox();
            this.lbNewUserMeta = new System.Windows.Forms.Label();
            this.lbNewUserName = new System.Windows.Forms.Label();
            this.gbAddProtein = new System.Windows.Forms.GroupBox();
            this.lbMetaQuantity = new System.Windows.Forms.Label();
            this.lbTotalQuantity = new System.Windows.Forms.Label();
            this.tbAgregarProteina = new System.Windows.Forms.TextBox();
            this.btnAddProteina = new System.Windows.Forms.Button();
            this.lbMetaProteinas = new System.Windows.Forms.Label();
            this.lbTotalProteinas = new System.Windows.Forms.Label();
            this.lbAddProteina = new System.Windows.Forms.Label();
            this.gbNewUser.SuspendLayout();
            this.gbAddProtein.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSelectUser
            // 
            this.lbSelectUser.AutoSize = true;
            this.lbSelectUser.Location = new System.Drawing.Point(12, 9);
            this.lbSelectUser.Name = "lbSelectUser";
            this.lbSelectUser.Size = new System.Drawing.Size(105, 15);
            this.lbSelectUser.TabIndex = 0;
            this.lbSelectUser.Text = "Seleccione usuario";
            // 
            // cbSelectUser
            // 
            this.cbSelectUser.FormattingEnabled = true;
            this.cbSelectUser.Location = new System.Drawing.Point(12, 27);
            this.cbSelectUser.Name = "cbSelectUser";
            this.cbSelectUser.Size = new System.Drawing.Size(142, 23);
            this.cbSelectUser.TabIndex = 1;
            this.cbSelectUser.SelectedIndexChanged += new System.EventHandler(this.OnUserChanged);
            // 
            // gbNewUser
            // 
            this.gbNewUser.Controls.Add(this.btnNewUserAdd);
            this.gbNewUser.Controls.Add(this.tbNewUserMeta);
            this.gbNewUser.Controls.Add(this.tbNewUserName);
            this.gbNewUser.Controls.Add(this.lbNewUserMeta);
            this.gbNewUser.Controls.Add(this.lbNewUserName);
            this.gbNewUser.Location = new System.Drawing.Point(12, 70);
            this.gbNewUser.Name = "gbNewUser";
            this.gbNewUser.Size = new System.Drawing.Size(235, 106);
            this.gbNewUser.TabIndex = 2;
            this.gbNewUser.TabStop = false;
            this.gbNewUser.Text = "Agregar nuevo usuario";
            // 
            // btnNewUserAdd
            // 
            this.btnNewUserAdd.Location = new System.Drawing.Point(80, 73);
            this.btnNewUserAdd.Name = "btnNewUserAdd";
            this.btnNewUserAdd.Size = new System.Drawing.Size(75, 23);
            this.btnNewUserAdd.TabIndex = 4;
            this.btnNewUserAdd.Text = "Agregar";
            this.btnNewUserAdd.UseVisualStyleBackColor = true;
            this.btnNewUserAdd.Click += new System.EventHandler(this.btnNewUserAdd_Click);
            // 
            // tbNewUserMeta
            // 
            this.tbNewUserMeta.Location = new System.Drawing.Point(66, 44);
            this.tbNewUserMeta.Name = "tbNewUserMeta";
            this.tbNewUserMeta.Size = new System.Drawing.Size(151, 23);
            this.tbNewUserMeta.TabIndex = 3;
            // 
            // tbNewUserName
            // 
            this.tbNewUserName.Location = new System.Drawing.Point(66, 16);
            this.tbNewUserName.Name = "tbNewUserName";
            this.tbNewUserName.Size = new System.Drawing.Size(151, 23);
            this.tbNewUserName.TabIndex = 2;
            // 
            // lbNewUserMeta
            // 
            this.lbNewUserMeta.AutoSize = true;
            this.lbNewUserMeta.Location = new System.Drawing.Point(23, 47);
            this.lbNewUserMeta.Name = "lbNewUserMeta";
            this.lbNewUserMeta.Size = new System.Drawing.Size(37, 15);
            this.lbNewUserMeta.TabIndex = 1;
            this.lbNewUserMeta.Text = "Meta:";
            // 
            // lbNewUserName
            // 
            this.lbNewUserName.AutoSize = true;
            this.lbNewUserName.Location = new System.Drawing.Point(6, 19);
            this.lbNewUserName.Name = "lbNewUserName";
            this.lbNewUserName.Size = new System.Drawing.Size(54, 15);
            this.lbNewUserName.TabIndex = 0;
            this.lbNewUserName.Text = "Nombre:";
            // 
            // gbAddProtein
            // 
            this.gbAddProtein.Controls.Add(this.lbMetaQuantity);
            this.gbAddProtein.Controls.Add(this.lbTotalQuantity);
            this.gbAddProtein.Controls.Add(this.tbAgregarProteina);
            this.gbAddProtein.Controls.Add(this.btnAddProteina);
            this.gbAddProtein.Controls.Add(this.lbMetaProteinas);
            this.gbAddProtein.Controls.Add(this.lbTotalProteinas);
            this.gbAddProtein.Controls.Add(this.lbAddProteina);
            this.gbAddProtein.Location = new System.Drawing.Point(253, 9);
            this.gbAddProtein.Name = "gbAddProtein";
            this.gbAddProtein.Size = new System.Drawing.Size(207, 167);
            this.gbAddProtein.TabIndex = 5;
            this.gbAddProtein.TabStop = false;
            this.gbAddProtein.Text = "Sumar proteina";
            // 
            // lbMetaQuantity
            // 
            this.lbMetaQuantity.AutoSize = true;
            this.lbMetaQuantity.Location = new System.Drawing.Point(64, 105);
            this.lbMetaQuantity.Name = "lbMetaQuantity";
            this.lbMetaQuantity.Size = new System.Drawing.Size(13, 15);
            this.lbMetaQuantity.TabIndex = 6;
            this.lbMetaQuantity.Text = "0";
            // 
            // lbTotalQuantity
            // 
            this.lbTotalQuantity.AutoSize = true;
            this.lbTotalQuantity.Location = new System.Drawing.Point(64, 80);
            this.lbTotalQuantity.Name = "lbTotalQuantity";
            this.lbTotalQuantity.Size = new System.Drawing.Size(13, 15);
            this.lbTotalQuantity.TabIndex = 5;
            this.lbTotalQuantity.Text = "0";
            // 
            // tbAgregarProteina
            // 
            this.tbAgregarProteina.Location = new System.Drawing.Point(64, 16);
            this.tbAgregarProteina.Name = "tbAgregarProteina";
            this.tbAgregarProteina.Size = new System.Drawing.Size(130, 23);
            this.tbAgregarProteina.TabIndex = 4;
            // 
            // btnAddProteina
            // 
            this.btnAddProteina.Location = new System.Drawing.Point(64, 45);
            this.btnAddProteina.Name = "btnAddProteina";
            this.btnAddProteina.Size = new System.Drawing.Size(75, 23);
            this.btnAddProteina.TabIndex = 3;
            this.btnAddProteina.Text = "Agregar";
            this.btnAddProteina.UseVisualStyleBackColor = true;
            this.btnAddProteina.Click += new System.EventHandler(this.btnAddProteina_Click);
            // 
            // lbMetaProteinas
            // 
            this.lbMetaProteinas.AutoSize = true;
            this.lbMetaProteinas.Location = new System.Drawing.Point(11, 105);
            this.lbMetaProteinas.Name = "lbMetaProteinas";
            this.lbMetaProteinas.Size = new System.Drawing.Size(37, 15);
            this.lbMetaProteinas.TabIndex = 2;
            this.lbMetaProteinas.Text = "Meta:";
            // 
            // lbTotalProteinas
            // 
            this.lbTotalProteinas.AutoSize = true;
            this.lbTotalProteinas.Location = new System.Drawing.Point(11, 80);
            this.lbTotalProteinas.Name = "lbTotalProteinas";
            this.lbTotalProteinas.Size = new System.Drawing.Size(35, 15);
            this.lbTotalProteinas.TabIndex = 1;
            this.lbTotalProteinas.Text = "Total:";
            // 
            // lbAddProteina
            // 
            this.lbAddProteina.AutoSize = true;
            this.lbAddProteina.Location = new System.Drawing.Point(6, 19);
            this.lbAddProteina.Name = "lbAddProteina";
            this.lbAddProteina.Size = new System.Drawing.Size(52, 15);
            this.lbAddProteina.TabIndex = 0;
            this.lbAddProteina.Text = "Agregar:";
            // 
            // ControlProteinasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 189);
            this.Controls.Add(this.gbAddProtein);
            this.Controls.Add(this.gbNewUser);
            this.Controls.Add(this.cbSelectUser);
            this.Controls.Add(this.lbSelectUser);
            this.Name = "ControlProteinasForm";
            this.Text = "ControlProteinasForm";
            this.Load += new System.EventHandler(this.OnLoad);
            this.gbNewUser.ResumeLayout(false);
            this.gbNewUser.PerformLayout();
            this.gbAddProtein.ResumeLayout(false);
            this.gbAddProtein.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSelectUser;
        private System.Windows.Forms.ComboBox cbSelectUser;
        private System.Windows.Forms.GroupBox gbNewUser;
        private System.Windows.Forms.Label lbNewUserMeta;
        private System.Windows.Forms.Label lbNewUserName;
        private System.Windows.Forms.Button btnNewUserAdd;
        private System.Windows.Forms.TextBox tbNewUserMeta;
        private System.Windows.Forms.TextBox tbNewUserName;
        private System.Windows.Forms.GroupBox gbAddProtein;
        private System.Windows.Forms.Label lbMetaQuantity;
        private System.Windows.Forms.Label lbTotalQuantity;
        private System.Windows.Forms.TextBox tbAgregarProteina;
        private System.Windows.Forms.Button btnAddProteina;
        private System.Windows.Forms.Label lbMetaProteinas;
        private System.Windows.Forms.Label lbTotalProteinas;
        private System.Windows.Forms.Label lbAddProteina;
    }
}

