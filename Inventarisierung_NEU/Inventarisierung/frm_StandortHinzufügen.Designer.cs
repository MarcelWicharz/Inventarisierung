namespace Inventarisierung
{
    partial class frm_StandortHinzufügen
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
            this.cb_KundeAuswählen = new System.Windows.Forms.ComboBox();
            this.lb_KundeAuswählen = new System.Windows.Forms.Label();
            this.lb_NeuerStandortName = new System.Windows.Forms.Label();
            this.tb_NeuerStandort = new System.Windows.Forms.TextBox();
            this.btn_StandortHinzufügen = new System.Windows.Forms.Button();
            this.btn_Zurück = new System.Windows.Forms.Button();
            this.lb_StandortAuswählen = new System.Windows.Forms.Label();
            this.cb_StandortAuswählen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb_KundeAuswählen
            // 
            this.cb_KundeAuswählen.FormattingEnabled = true;
            this.cb_KundeAuswählen.Location = new System.Drawing.Point(132, 14);
            this.cb_KundeAuswählen.Name = "cb_KundeAuswählen";
            this.cb_KundeAuswählen.Size = new System.Drawing.Size(157, 21);
            this.cb_KundeAuswählen.TabIndex = 0;
            // 
            // lb_KundeAuswählen
            // 
            this.lb_KundeAuswählen.AutoSize = true;
            this.lb_KundeAuswählen.Location = new System.Drawing.Point(12, 17);
            this.lb_KundeAuswählen.Name = "lb_KundeAuswählen";
            this.lb_KundeAuswählen.Size = new System.Drawing.Size(95, 13);
            this.lb_KundeAuswählen.TabIndex = 1;
            this.lb_KundeAuswählen.Text = "Kunde auswählen:";
            // 
            // lb_NeuerStandortName
            // 
            this.lb_NeuerStandortName.AutoSize = true;
            this.lb_NeuerStandortName.Location = new System.Drawing.Point(12, 85);
            this.lb_NeuerStandortName.Name = "lb_NeuerStandortName";
            this.lb_NeuerStandortName.Size = new System.Drawing.Size(82, 13);
            this.lb_NeuerStandortName.TabIndex = 2;
            this.lb_NeuerStandortName.Text = "Neuer Standort:";
            // 
            // tb_NeuerStandort
            // 
            this.tb_NeuerStandort.Location = new System.Drawing.Point(132, 82);
            this.tb_NeuerStandort.Name = "tb_NeuerStandort";
            this.tb_NeuerStandort.Size = new System.Drawing.Size(100, 20);
            this.tb_NeuerStandort.TabIndex = 3;
            // 
            // btn_StandortHinzufügen
            // 
            this.btn_StandortHinzufügen.Location = new System.Drawing.Point(214, 119);
            this.btn_StandortHinzufügen.Name = "btn_StandortHinzufügen";
            this.btn_StandortHinzufügen.Size = new System.Drawing.Size(75, 23);
            this.btn_StandortHinzufügen.TabIndex = 4;
            this.btn_StandortHinzufügen.Text = "Hinzufügen";
            this.btn_StandortHinzufügen.UseVisualStyleBackColor = true;
            this.btn_StandortHinzufügen.Click += new System.EventHandler(this.btn_StandortHinzufügen_Click);
            // 
            // btn_Zurück
            // 
            this.btn_Zurück.Location = new System.Drawing.Point(132, 119);
            this.btn_Zurück.Name = "btn_Zurück";
            this.btn_Zurück.Size = new System.Drawing.Size(75, 23);
            this.btn_Zurück.TabIndex = 5;
            this.btn_Zurück.Text = "Zurück";
            this.btn_Zurück.UseVisualStyleBackColor = true;
            this.btn_Zurück.Click += new System.EventHandler(this.btn_Zurück_Click);
            // 
            // lb_StandortAuswählen
            // 
            this.lb_StandortAuswählen.AutoSize = true;
            this.lb_StandortAuswählen.Location = new System.Drawing.Point(12, 50);
            this.lb_StandortAuswählen.Name = "lb_StandortAuswählen";
            this.lb_StandortAuswählen.Size = new System.Drawing.Size(104, 13);
            this.lb_StandortAuswählen.TabIndex = 6;
            this.lb_StandortAuswählen.Text = "Standort auswählen:";
            // 
            // cb_StandortAuswählen
            // 
            this.cb_StandortAuswählen.FormattingEnabled = true;
            this.cb_StandortAuswählen.Location = new System.Drawing.Point(132, 47);
            this.cb_StandortAuswählen.Name = "cb_StandortAuswählen";
            this.cb_StandortAuswählen.Size = new System.Drawing.Size(121, 21);
            this.cb_StandortAuswählen.TabIndex = 7;
            // 
            // frm_StandortHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 151);
            this.Controls.Add(this.cb_StandortAuswählen);
            this.Controls.Add(this.lb_StandortAuswählen);
            this.Controls.Add(this.btn_Zurück);
            this.Controls.Add(this.btn_StandortHinzufügen);
            this.Controls.Add(this.tb_NeuerStandort);
            this.Controls.Add(this.lb_NeuerStandortName);
            this.Controls.Add(this.lb_KundeAuswählen);
            this.Controls.Add(this.cb_KundeAuswählen);
            this.Name = "frm_StandortHinzufügen";
            this.Text = "StandortHinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_KundeAuswählen;
        private System.Windows.Forms.Label lb_KundeAuswählen;
        private System.Windows.Forms.Label lb_NeuerStandortName;
        private System.Windows.Forms.TextBox tb_NeuerStandort;
        private System.Windows.Forms.Button btn_StandortHinzufügen;
        private System.Windows.Forms.Button btn_Zurück;
        private System.Windows.Forms.Label lb_StandortAuswählen;
        private System.Windows.Forms.ComboBox cb_StandortAuswählen;
    }
}