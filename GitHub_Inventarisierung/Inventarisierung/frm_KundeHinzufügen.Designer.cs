namespace Inventarisierung
{
    partial class frm_KundeHinzufügen
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
            this.lb_Kundenname = new System.Windows.Forms.Label();
            this.btn_KundeHinzufügen = new System.Windows.Forms.Button();
            this.tb_KundennameHinzufügen = new System.Windows.Forms.TextBox();
            this.btn_Zurück = new System.Windows.Forms.Button();
            this.lb_Straße = new System.Windows.Forms.Label();
            this.lb_PLZ = new System.Windows.Forms.Label();
            this.lb_Ort = new System.Windows.Forms.Label();
            this.lb_EMail = new System.Windows.Forms.Label();
            this.tb_Straße = new System.Windows.Forms.TextBox();
            this.tb_PLZ = new System.Windows.Forms.TextBox();
            this.tb_Ort = new System.Windows.Forms.TextBox();
            this.tb_EMail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Kundenname
            // 
            this.lb_Kundenname.AutoSize = true;
            this.lb_Kundenname.Location = new System.Drawing.Point(4, 12);
            this.lb_Kundenname.Name = "lb_Kundenname";
            this.lb_Kundenname.Size = new System.Drawing.Size(73, 13);
            this.lb_Kundenname.TabIndex = 0;
            this.lb_Kundenname.Text = "Kundenname:";
            // 
            // btn_KundeHinzufügen
            // 
            this.btn_KundeHinzufügen.Location = new System.Drawing.Point(150, 148);
            this.btn_KundeHinzufügen.Name = "btn_KundeHinzufügen";
            this.btn_KundeHinzufügen.Size = new System.Drawing.Size(75, 23);
            this.btn_KundeHinzufügen.TabIndex = 1;
            this.btn_KundeHinzufügen.Text = "Hinzufügen";
            this.btn_KundeHinzufügen.UseVisualStyleBackColor = true;
            this.btn_KundeHinzufügen.Click += new System.EventHandler(this.btn_KundeHinzufügen_Click);
            // 
            // tb_KundennameHinzufügen
            // 
            this.tb_KundennameHinzufügen.Location = new System.Drawing.Point(83, 9);
            this.tb_KundennameHinzufügen.Name = "tb_KundennameHinzufügen";
            this.tb_KundennameHinzufügen.Size = new System.Drawing.Size(142, 20);
            this.tb_KundennameHinzufügen.TabIndex = 2;
            // 
            // btn_Zurück
            // 
            this.btn_Zurück.Location = new System.Drawing.Point(13, 148);
            this.btn_Zurück.Name = "btn_Zurück";
            this.btn_Zurück.Size = new System.Drawing.Size(75, 23);
            this.btn_Zurück.TabIndex = 3;
            this.btn_Zurück.Text = "Zurück";
            this.btn_Zurück.UseVisualStyleBackColor = true;
            this.btn_Zurück.Click += new System.EventHandler(this.btn_Zurück_Click);
            // 
            // lb_Straße
            // 
            this.lb_Straße.AutoSize = true;
            this.lb_Straße.Location = new System.Drawing.Point(4, 38);
            this.lb_Straße.Name = "lb_Straße";
            this.lb_Straße.Size = new System.Drawing.Size(41, 13);
            this.lb_Straße.TabIndex = 4;
            this.lb_Straße.Text = "Straße:";
            // 
            // lb_PLZ
            // 
            this.lb_PLZ.AutoSize = true;
            this.lb_PLZ.Location = new System.Drawing.Point(4, 65);
            this.lb_PLZ.Name = "lb_PLZ";
            this.lb_PLZ.Size = new System.Drawing.Size(30, 13);
            this.lb_PLZ.TabIndex = 5;
            this.lb_PLZ.Text = "PLZ:";
            // 
            // lb_Ort
            // 
            this.lb_Ort.AutoSize = true;
            this.lb_Ort.Location = new System.Drawing.Point(4, 91);
            this.lb_Ort.Name = "lb_Ort";
            this.lb_Ort.Size = new System.Drawing.Size(24, 13);
            this.lb_Ort.TabIndex = 6;
            this.lb_Ort.Text = "Ort:";
            // 
            // lb_EMail
            // 
            this.lb_EMail.AutoSize = true;
            this.lb_EMail.Location = new System.Drawing.Point(4, 119);
            this.lb_EMail.Name = "lb_EMail";
            this.lb_EMail.Size = new System.Drawing.Size(36, 13);
            this.lb_EMail.TabIndex = 7;
            this.lb_EMail.Text = "E-Mail";
            // 
            // tb_Straße
            // 
            this.tb_Straße.Location = new System.Drawing.Point(83, 35);
            this.tb_Straße.Name = "tb_Straße";
            this.tb_Straße.Size = new System.Drawing.Size(100, 20);
            this.tb_Straße.TabIndex = 8;
            // 
            // tb_PLZ
            // 
            this.tb_PLZ.Location = new System.Drawing.Point(83, 62);
            this.tb_PLZ.Name = "tb_PLZ";
            this.tb_PLZ.Size = new System.Drawing.Size(100, 20);
            this.tb_PLZ.TabIndex = 9;
            // 
            // tb_Ort
            // 
            this.tb_Ort.Location = new System.Drawing.Point(83, 88);
            this.tb_Ort.Name = "tb_Ort";
            this.tb_Ort.Size = new System.Drawing.Size(100, 20);
            this.tb_Ort.TabIndex = 10;
            // 
            // tb_EMail
            // 
            this.tb_EMail.Location = new System.Drawing.Point(83, 116);
            this.tb_EMail.Name = "tb_EMail";
            this.tb_EMail.Size = new System.Drawing.Size(100, 20);
            this.tb_EMail.TabIndex = 11;
            // 
            // frm_KundeHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 176);
            this.Controls.Add(this.tb_EMail);
            this.Controls.Add(this.tb_Ort);
            this.Controls.Add(this.tb_PLZ);
            this.Controls.Add(this.tb_Straße);
            this.Controls.Add(this.lb_EMail);
            this.Controls.Add(this.lb_Ort);
            this.Controls.Add(this.lb_PLZ);
            this.Controls.Add(this.lb_Straße);
            this.Controls.Add(this.btn_Zurück);
            this.Controls.Add(this.tb_KundennameHinzufügen);
            this.Controls.Add(this.btn_KundeHinzufügen);
            this.Controls.Add(this.lb_Kundenname);
            this.Name = "frm_KundeHinzufügen";
            this.Text = "frm_KundeHinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Kundenname;
        private System.Windows.Forms.Button btn_KundeHinzufügen;
        private System.Windows.Forms.TextBox tb_KundennameHinzufügen;
        private System.Windows.Forms.Button btn_Zurück;
        private System.Windows.Forms.Label lb_Straße;
        private System.Windows.Forms.Label lb_PLZ;
        private System.Windows.Forms.Label lb_Ort;
        private System.Windows.Forms.Label lb_EMail;
        private System.Windows.Forms.TextBox tb_Straße;
        private System.Windows.Forms.TextBox tb_PLZ;
        private System.Windows.Forms.TextBox tb_Ort;
        private System.Windows.Forms.TextBox tb_EMail;
    }
}