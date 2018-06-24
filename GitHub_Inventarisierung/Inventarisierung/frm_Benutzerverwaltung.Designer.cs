namespace Inventarisierung
{
    partial class frm_Benutzerverwaltung
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
            this.btn_Anlegen = new System.Windows.Forms.Button();
            this.lb_NeuerBenutzername = new System.Windows.Forms.Label();
            this.lb_NeuesKennwort = new System.Windows.Forms.Label();
            this.tb_NeuerBenutzername = new System.Windows.Forms.TextBox();
            this.tb_NeuesKennwort = new System.Windows.Forms.TextBox();
            this.btn_Zurück = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Anlegen
            // 
            this.btn_Anlegen.Location = new System.Drawing.Point(134, 62);
            this.btn_Anlegen.Name = "btn_Anlegen";
            this.btn_Anlegen.Size = new System.Drawing.Size(75, 23);
            this.btn_Anlegen.TabIndex = 0;
            this.btn_Anlegen.Text = "Anlegen";
            this.btn_Anlegen.UseVisualStyleBackColor = true;
            this.btn_Anlegen.Click += new System.EventHandler(this.btn_Anlegen_Click);
            // 
            // lb_NeuerBenutzername
            // 
            this.lb_NeuerBenutzername.AutoSize = true;
            this.lb_NeuerBenutzername.Location = new System.Drawing.Point(13, 13);
            this.lb_NeuerBenutzername.Name = "lb_NeuerBenutzername";
            this.lb_NeuerBenutzername.Size = new System.Drawing.Size(78, 13);
            this.lb_NeuerBenutzername.TabIndex = 1;
            this.lb_NeuerBenutzername.Text = "Benutzername:";
            // 
            // lb_NeuesKennwort
            // 
            this.lb_NeuesKennwort.AutoSize = true;
            this.lb_NeuesKennwort.Location = new System.Drawing.Point(12, 39);
            this.lb_NeuesKennwort.Name = "lb_NeuesKennwort";
            this.lb_NeuesKennwort.Size = new System.Drawing.Size(55, 13);
            this.lb_NeuesKennwort.TabIndex = 2;
            this.lb_NeuesKennwort.Text = "Kennwort:";
            // 
            // tb_NeuerBenutzername
            // 
            this.tb_NeuerBenutzername.Location = new System.Drawing.Point(109, 10);
            this.tb_NeuerBenutzername.Name = "tb_NeuerBenutzername";
            this.tb_NeuerBenutzername.Size = new System.Drawing.Size(100, 20);
            this.tb_NeuerBenutzername.TabIndex = 3;
            // 
            // tb_NeuesKennwort
            // 
            this.tb_NeuesKennwort.Location = new System.Drawing.Point(109, 36);
            this.tb_NeuesKennwort.Name = "tb_NeuesKennwort";
            this.tb_NeuesKennwort.Size = new System.Drawing.Size(100, 20);
            this.tb_NeuesKennwort.TabIndex = 4;
            // 
            // btn_Zurück
            // 
            this.btn_Zurück.Location = new System.Drawing.Point(15, 62);
            this.btn_Zurück.Name = "btn_Zurück";
            this.btn_Zurück.Size = new System.Drawing.Size(75, 23);
            this.btn_Zurück.TabIndex = 5;
            this.btn_Zurück.Text = "Zurück";
            this.btn_Zurück.UseVisualStyleBackColor = true;
            this.btn_Zurück.Click += new System.EventHandler(this.btn_Zurück_Click);
            // 
            // frm_Benutzerverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 97);
            this.Controls.Add(this.btn_Zurück);
            this.Controls.Add(this.tb_NeuesKennwort);
            this.Controls.Add(this.tb_NeuerBenutzername);
            this.Controls.Add(this.lb_NeuesKennwort);
            this.Controls.Add(this.lb_NeuerBenutzername);
            this.Controls.Add(this.btn_Anlegen);
            this.Name = "frm_Benutzerverwaltung";
            this.Text = "Benutzerverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Anlegen;
        private System.Windows.Forms.Label lb_NeuerBenutzername;
        private System.Windows.Forms.Label lb_NeuesKennwort;
        private System.Windows.Forms.TextBox tb_NeuerBenutzername;
        private System.Windows.Forms.TextBox tb_NeuesKennwort;
        private System.Windows.Forms.Button btn_Zurück;
    }
}