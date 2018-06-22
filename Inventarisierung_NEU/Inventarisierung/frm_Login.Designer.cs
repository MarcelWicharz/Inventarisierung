namespace Inventarisierung
{
    partial class frm_Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Anmelden = new System.Windows.Forms.Button();
            this.lb_Benutzername = new System.Windows.Forms.Label();
            this.lb_Kennwort = new System.Windows.Forms.Label();
            this.tb_Benutzername = new System.Windows.Forms.TextBox();
            this.tb_Kennwort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Anmelden
            // 
            this.btn_Anmelden.Location = new System.Drawing.Point(171, 72);
            this.btn_Anmelden.Name = "btn_Anmelden";
            this.btn_Anmelden.Size = new System.Drawing.Size(75, 23);
            this.btn_Anmelden.TabIndex = 1;
            this.btn_Anmelden.Text = "Anmelden";
            this.btn_Anmelden.UseVisualStyleBackColor = true;
            this.btn_Anmelden.Click += new System.EventHandler(this.btn_Anmelden_Click);
            // 
            // lb_Benutzername
            // 
            this.lb_Benutzername.AutoSize = true;
            this.lb_Benutzername.Location = new System.Drawing.Point(13, 12);
            this.lb_Benutzername.Name = "lb_Benutzername";
            this.lb_Benutzername.Size = new System.Drawing.Size(78, 13);
            this.lb_Benutzername.TabIndex = 2;
            this.lb_Benutzername.Text = "Benutzername:";
            // 
            // lb_Kennwort
            // 
            this.lb_Kennwort.AutoSize = true;
            this.lb_Kennwort.Location = new System.Drawing.Point(13, 39);
            this.lb_Kennwort.Name = "lb_Kennwort";
            this.lb_Kennwort.Size = new System.Drawing.Size(55, 13);
            this.lb_Kennwort.TabIndex = 3;
            this.lb_Kennwort.Text = "Kennwort:";
            // 
            // tb_Benutzername
            // 
            this.tb_Benutzername.Location = new System.Drawing.Point(97, 12);
            this.tb_Benutzername.Name = "tb_Benutzername";
            this.tb_Benutzername.Size = new System.Drawing.Size(149, 20);
            this.tb_Benutzername.TabIndex = 4;
            // 
            // tb_Kennwort
            // 
            this.tb_Kennwort.Location = new System.Drawing.Point(97, 39);
            this.tb_Kennwort.Name = "tb_Kennwort";
            this.tb_Kennwort.Size = new System.Drawing.Size(149, 20);
            this.tb_Kennwort.TabIndex = 5;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(255, 101);
            this.Controls.Add(this.tb_Kennwort);
            this.Controls.Add(this.tb_Benutzername);
            this.Controls.Add(this.lb_Kennwort);
            this.Controls.Add(this.lb_Benutzername);
            this.Controls.Add(this.btn_Anmelden);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frm_Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Anmelden;
        private System.Windows.Forms.Label lb_Benutzername;
        private System.Windows.Forms.Label lb_Kennwort;
        private System.Windows.Forms.TextBox tb_Benutzername;
        private System.Windows.Forms.TextBox tb_Kennwort;
    }
}

