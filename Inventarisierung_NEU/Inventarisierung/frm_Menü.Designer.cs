namespace Inventarisierung
{
    partial class frm_Menü
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
            this.btn_NeueBenutzer = new System.Windows.Forms.Button();
            this.btn_KundenAuswahl = new System.Windows.Forms.Button();
            this.lb_NeuerBenutzerAnlegen = new System.Windows.Forms.Label();
            this.lb_ZurKundenAuswahl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_NeueBenutzer
            // 
            this.btn_NeueBenutzer.Location = new System.Drawing.Point(155, 12);
            this.btn_NeueBenutzer.Name = "btn_NeueBenutzer";
            this.btn_NeueBenutzer.Size = new System.Drawing.Size(75, 23);
            this.btn_NeueBenutzer.TabIndex = 0;
            this.btn_NeueBenutzer.Text = "Weiter";
            this.btn_NeueBenutzer.UseVisualStyleBackColor = true;
            this.btn_NeueBenutzer.Click += new System.EventHandler(this.btn_NeueBenutzer_Click);
            // 
            // btn_KundenAuswahl
            // 
            this.btn_KundenAuswahl.Location = new System.Drawing.Point(155, 48);
            this.btn_KundenAuswahl.Name = "btn_KundenAuswahl";
            this.btn_KundenAuswahl.Size = new System.Drawing.Size(75, 23);
            this.btn_KundenAuswahl.TabIndex = 1;
            this.btn_KundenAuswahl.Text = "Weiter";
            this.btn_KundenAuswahl.UseVisualStyleBackColor = true;
            this.btn_KundenAuswahl.Click += new System.EventHandler(this.btn_KundenAuswahl_Click);
            // 
            // lb_NeuerBenutzerAnlegen
            // 
            this.lb_NeuerBenutzerAnlegen.AutoSize = true;
            this.lb_NeuerBenutzerAnlegen.Location = new System.Drawing.Point(13, 17);
            this.lb_NeuerBenutzerAnlegen.Name = "lb_NeuerBenutzerAnlegen";
            this.lb_NeuerBenutzerAnlegen.Size = new System.Drawing.Size(122, 13);
            this.lb_NeuerBenutzerAnlegen.TabIndex = 2;
            this.lb_NeuerBenutzerAnlegen.Text = "Neue Benutzer anlegen:";
            // 
            // lb_ZurKundenAuswahl
            // 
            this.lb_ZurKundenAuswahl.AutoSize = true;
            this.lb_ZurKundenAuswahl.Location = new System.Drawing.Point(13, 53);
            this.lb_ZurKundenAuswahl.Name = "lb_ZurKundenAuswahl";
            this.lb_ZurKundenAuswahl.Size = new System.Drawing.Size(108, 13);
            this.lb_ZurKundenAuswahl.TabIndex = 3;
            this.lb_ZurKundenAuswahl.Text = "Zur Kunden auswahl:";
            // 
            // frm_Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 83);
            this.Controls.Add(this.lb_ZurKundenAuswahl);
            this.Controls.Add(this.lb_NeuerBenutzerAnlegen);
            this.Controls.Add(this.btn_KundenAuswahl);
            this.Controls.Add(this.btn_NeueBenutzer);
            this.Name = "frm_Menü";
            this.Text = "Menü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NeueBenutzer;
        private System.Windows.Forms.Button btn_KundenAuswahl;
        private System.Windows.Forms.Label lb_NeuerBenutzerAnlegen;
        private System.Windows.Forms.Label lb_ZurKundenAuswahl;
    }
}