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
            this.SuspendLayout();
            // 
            // lb_Kunde
            // 
            this.lb_Kunde.AutoSize = true;
            this.lb_Kunde.Location = new System.Drawing.Point(12, 18);
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
            this.cb_KundeAuswählen.Size = new System.Drawing.Size(168, 21);
            this.cb_KundeAuswählen.TabIndex = 1;
            this.cb_KundeAuswählen.SelectedIndexChanged += new System.EventHandler(this.cb_KundeAuswählen_SelectedIndexChanged);
            // 
            // btn_NeuerKunde
            // 
            this.btn_NeuerKunde.Location = new System.Drawing.Point(15, 66);
            this.btn_NeuerKunde.Name = "btn_NeuerKunde";
            this.btn_NeuerKunde.Size = new System.Drawing.Size(75, 23);
            this.btn_NeuerKunde.TabIndex = 2;
            this.btn_NeuerKunde.Text = "Hinzufügen";
            this.btn_NeuerKunde.UseVisualStyleBackColor = true;
            this.btn_NeuerKunde.Click += new System.EventHandler(this.btn_NeuerKunde_Click);
            // 
            // btn_KundeAuswählen
            // 
            this.btn_KundeAuswählen.Location = new System.Drawing.Point(164, 66);
            this.btn_KundeAuswählen.Name = "btn_KundeAuswählen";
            this.btn_KundeAuswählen.Size = new System.Drawing.Size(75, 23);
            this.btn_KundeAuswählen.TabIndex = 3;
            this.btn_KundeAuswählen.Text = "Auswählen";
            this.btn_KundeAuswählen.UseVisualStyleBackColor = true;
            this.btn_KundeAuswählen.Click += new System.EventHandler(this.btn_KundeAuswählen_Click);
            // 
            // frm_Kunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 106);
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
    }
}