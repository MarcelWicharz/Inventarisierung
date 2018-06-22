namespace Inventarisierung
{
    partial class frm_Kunde
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
            this.lb_Kunde = new System.Windows.Forms.Label();
            this.cb_KundeAuswählen = new System.Windows.Forms.ComboBox();
            this.btn_NeuerKunde = new System.Windows.Forms.Button();
            this.btn_KundeAuswählen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_NeueStandorte = new System.Windows.Forms.Label();
            this.btn_NeuerStandort = new System.Windows.Forms.Button();
            this.btn_KundeÄndern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Kunde
            // 
            this.lb_Kunde.AutoSize = true;
            this.lb_Kunde.Location = new System.Drawing.Point(12, 21);
            this.lb_Kunde.Name = "lb_Kunde";
            this.lb_Kunde.Size = new System.Drawing.Size(41, 13);
            this.lb_Kunde.TabIndex = 0;
            this.lb_Kunde.Text = "Kunde:";
            // 
            // cb_KundeAuswählen
            // 
            this.cb_KundeAuswählen.FormattingEnabled = true;
            this.cb_KundeAuswählen.Location = new System.Drawing.Point(71, 18);
            this.cb_KundeAuswählen.Name = "cb_KundeAuswählen";
            this.cb_KundeAuswählen.Size = new System.Drawing.Size(162, 21);
            this.cb_KundeAuswählen.TabIndex = 1;
            this.cb_KundeAuswählen.SelectedIndexChanged += new System.EventHandler(this.cb_KundeAuswählen_SelectedIndexChanged);
            // 
            // btn_NeuerKunde
            // 
            this.btn_NeuerKunde.Location = new System.Drawing.Point(158, 68);
            this.btn_NeuerKunde.Name = "btn_NeuerKunde";
            this.btn_NeuerKunde.Size = new System.Drawing.Size(75, 23);
            this.btn_NeuerKunde.TabIndex = 2;
            this.btn_NeuerKunde.Text = "Weiter";
            this.btn_NeuerKunde.UseVisualStyleBackColor = true;
            this.btn_NeuerKunde.Click += new System.EventHandler(this.btn_NeuerKunde_Click);
            // 
            // btn_KundeAuswählen
            // 
            this.btn_KundeAuswählen.Location = new System.Drawing.Point(259, 8);
            this.btn_KundeAuswählen.Name = "btn_KundeAuswählen";
            this.btn_KundeAuswählen.Size = new System.Drawing.Size(99, 23);
            this.btn_KundeAuswählen.TabIndex = 3;
            this.btn_KundeAuswählen.Text = "Inventarisierung";
            this.btn_KundeAuswählen.UseVisualStyleBackColor = true;
            this.btn_KundeAuswählen.Click += new System.EventHandler(this.btn_KundeAuswählen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Neuen Kunden Anlegen:";
            // 
            // lb_NeueStandorte
            // 
            this.lb_NeueStandorte.AutoSize = true;
            this.lb_NeueStandorte.Location = new System.Drawing.Point(12, 117);
            this.lb_NeueStandorte.Name = "lb_NeueStandorte";
            this.lb_NeueStandorte.Size = new System.Drawing.Size(140, 13);
            this.lb_NeueStandorte.TabIndex = 5;
            this.lb_NeueStandorte.Text = "Neue Standorte hinzufügen:";
            // 
            // btn_NeuerStandort
            // 
            this.btn_NeuerStandort.Location = new System.Drawing.Point(158, 112);
            this.btn_NeuerStandort.Name = "btn_NeuerStandort";
            this.btn_NeuerStandort.Size = new System.Drawing.Size(75, 23);
            this.btn_NeuerStandort.TabIndex = 6;
            this.btn_NeuerStandort.Text = "Weiter";
            this.btn_NeuerStandort.UseVisualStyleBackColor = true;
            this.btn_NeuerStandort.Click += new System.EventHandler(this.btn_NeuerStandort_Click);
            // 
            // btn_KundeÄndern
            // 
            this.btn_KundeÄndern.Location = new System.Drawing.Point(272, 37);
            this.btn_KundeÄndern.Name = "btn_KundeÄndern";
            this.btn_KundeÄndern.Size = new System.Drawing.Size(75, 23);
            this.btn_KundeÄndern.TabIndex = 7;
            this.btn_KundeÄndern.Text = "Ändern";
            this.btn_KundeÄndern.UseVisualStyleBackColor = true;
            this.btn_KundeÄndern.Click += new System.EventHandler(this.btn_KundeÄndern_Click);
            // 
            // frm_Kunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 142);
            this.Controls.Add(this.btn_KundeÄndern);
            this.Controls.Add(this.btn_NeuerStandort);
            this.Controls.Add(this.lb_NeueStandorte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_KundeAuswählen);
            this.Controls.Add(this.btn_NeuerKunde);
            this.Controls.Add(this.cb_KundeAuswählen);
            this.Controls.Add(this.lb_Kunde);
            this.Name = "frm_Kunde";
            this.Text = "Kunde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Kunde;
        private System.Windows.Forms.ComboBox cb_KundeAuswählen;
        private System.Windows.Forms.Button btn_NeuerKunde;
        private System.Windows.Forms.Button btn_KundeAuswählen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_NeueStandorte;
        private System.Windows.Forms.Button btn_NeuerStandort;
        private System.Windows.Forms.Button btn_KundeÄndern;
    }
}