namespace Inventarisierung
{
    partial class frm_Inventarisierung
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
            this.btn_Zurück = new System.Windows.Forms.Button();
            this.tb_Kundenname = new System.Windows.Forms.TextBox();
            this.lb_Kundenname = new System.Windows.Forms.Label();
            this.btn_Anlegen = new System.Windows.Forms.Button();
            this.lb_Inventarnummer = new System.Windows.Forms.Label();
            this.lb_KundenID = new System.Windows.Forms.Label();
            this.lb_Standort = new System.Windows.Forms.Label();
            this.lb_Gerätetyp = new System.Windows.Forms.Label();
            this.lb_Bezeichnung = new System.Windows.Forms.Label();
            this.lb_Rechnungsnummer = new System.Windows.Forms.Label();
            this.lb_Anlagedatum = new System.Windows.Forms.Label();
            this.lb_Memo = new System.Windows.Forms.Label();
            this.lb_Inaktiv_seit = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Zurück
            // 
            this.btn_Zurück.Location = new System.Drawing.Point(550, 21);
            this.btn_Zurück.Name = "btn_Zurück";
            this.btn_Zurück.Size = new System.Drawing.Size(75, 23);
            this.btn_Zurück.TabIndex = 0;
            this.btn_Zurück.Text = "Zurück";
            this.btn_Zurück.UseVisualStyleBackColor = true;
            this.btn_Zurück.Click += new System.EventHandler(this.btn_Zurück_Click);
            // 
            // tb_Kundenname
            // 
            this.tb_Kundenname.Location = new System.Drawing.Point(91, 15);
            this.tb_Kundenname.Name = "tb_Kundenname";
            this.tb_Kundenname.ReadOnly = true;
            this.tb_Kundenname.Size = new System.Drawing.Size(134, 20);
            this.tb_Kundenname.TabIndex = 2;
            // 
            // lb_Kundenname
            // 
            this.lb_Kundenname.AutoSize = true;
            this.lb_Kundenname.Location = new System.Drawing.Point(12, 21);
            this.lb_Kundenname.Name = "lb_Kundenname";
            this.lb_Kundenname.Size = new System.Drawing.Size(73, 13);
            this.lb_Kundenname.TabIndex = 4;
            this.lb_Kundenname.Text = "Kundenname:";
            // 
            // btn_Anlegen
            // 
            this.btn_Anlegen.Location = new System.Drawing.Point(550, 233);
            this.btn_Anlegen.Name = "btn_Anlegen";
            this.btn_Anlegen.Size = new System.Drawing.Size(75, 23);
            this.btn_Anlegen.TabIndex = 5;
            this.btn_Anlegen.Text = "Anlegen";
            this.btn_Anlegen.UseVisualStyleBackColor = true;
            // 
            // lb_Inventarnummer
            // 
            this.lb_Inventarnummer.AutoSize = true;
            this.lb_Inventarnummer.Location = new System.Drawing.Point(12, 67);
            this.lb_Inventarnummer.Name = "lb_Inventarnummer";
            this.lb_Inventarnummer.Size = new System.Drawing.Size(83, 13);
            this.lb_Inventarnummer.TabIndex = 6;
            this.lb_Inventarnummer.Text = "Inventarnummer";
            // 
            // lb_KundenID
            // 
            this.lb_KundenID.AutoSize = true;
            this.lb_KundenID.Location = new System.Drawing.Point(125, 66);
            this.lb_KundenID.Name = "lb_KundenID";
            this.lb_KundenID.Size = new System.Drawing.Size(58, 13);
            this.lb_KundenID.TabIndex = 7;
            this.lb_KundenID.Text = "Kunden ID";
            // 
            // lb_Standort
            // 
            this.lb_Standort.AutoSize = true;
            this.lb_Standort.Location = new System.Drawing.Point(189, 66);
            this.lb_Standort.Name = "lb_Standort";
            this.lb_Standort.Size = new System.Drawing.Size(47, 13);
            this.lb_Standort.TabIndex = 8;
            this.lb_Standort.Text = "Standort";
            // 
            // lb_Gerätetyp
            // 
            this.lb_Gerätetyp.AutoSize = true;
            this.lb_Gerätetyp.Location = new System.Drawing.Point(318, 66);
            this.lb_Gerätetyp.Name = "lb_Gerätetyp";
            this.lb_Gerätetyp.Size = new System.Drawing.Size(53, 13);
            this.lb_Gerätetyp.TabIndex = 9;
            this.lb_Gerätetyp.Text = "Gerätetyp";
            // 
            // lb_Bezeichnung
            // 
            this.lb_Bezeichnung.AutoSize = true;
            this.lb_Bezeichnung.Location = new System.Drawing.Point(12, 144);
            this.lb_Bezeichnung.Name = "lb_Bezeichnung";
            this.lb_Bezeichnung.Size = new System.Drawing.Size(69, 13);
            this.lb_Bezeichnung.TabIndex = 10;
            this.lb_Bezeichnung.Text = "Bezeichnung";
            // 
            // lb_Rechnungsnummer
            // 
            this.lb_Rechnungsnummer.AutoSize = true;
            this.lb_Rechnungsnummer.Location = new System.Drawing.Point(125, 144);
            this.lb_Rechnungsnummer.Name = "lb_Rechnungsnummer";
            this.lb_Rechnungsnummer.Size = new System.Drawing.Size(99, 13);
            this.lb_Rechnungsnummer.TabIndex = 11;
            this.lb_Rechnungsnummer.Text = "Rechnungsnummer";
            // 
            // lb_Anlagedatum
            // 
            this.lb_Anlagedatum.AutoSize = true;
            this.lb_Anlagedatum.Location = new System.Drawing.Point(244, 144);
            this.lb_Anlagedatum.Name = "lb_Anlagedatum";
            this.lb_Anlagedatum.Size = new System.Drawing.Size(69, 13);
            this.lb_Anlagedatum.TabIndex = 12;
            this.lb_Anlagedatum.Text = "Anlagedatum";
            // 
            // lb_Memo
            // 
            this.lb_Memo.AutoSize = true;
            this.lb_Memo.Location = new System.Drawing.Point(362, 144);
            this.lb_Memo.Name = "lb_Memo";
            this.lb_Memo.Size = new System.Drawing.Size(36, 13);
            this.lb_Memo.TabIndex = 13;
            this.lb_Memo.Text = "Memo";
            // 
            // lb_Inaktiv_seit
            // 
            this.lb_Inaktiv_seit.AutoSize = true;
            this.lb_Inaktiv_seit.Location = new System.Drawing.Point(522, 144);
            this.lb_Inaktiv_seit.Name = "lb_Inaktiv_seit";
            this.lb_Inaktiv_seit.Size = new System.Drawing.Size(58, 13);
            this.lb_Inaktiv_seit.TabIndex = 14;
            this.lb_Inaktiv_seit.Text = "Inaktiv seit";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(321, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(192, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(128, 161);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 20;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 160);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(247, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(365, 161);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(148, 20);
            this.textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(525, 161);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 24;
            // 
            // frm_Inventarisierung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 267);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lb_Inaktiv_seit);
            this.Controls.Add(this.lb_Memo);
            this.Controls.Add(this.lb_Anlagedatum);
            this.Controls.Add(this.lb_Rechnungsnummer);
            this.Controls.Add(this.lb_Bezeichnung);
            this.Controls.Add(this.lb_Gerätetyp);
            this.Controls.Add(this.lb_Standort);
            this.Controls.Add(this.lb_KundenID);
            this.Controls.Add(this.lb_Inventarnummer);
            this.Controls.Add(this.btn_Anlegen);
            this.Controls.Add(this.lb_Kundenname);
            this.Controls.Add(this.tb_Kundenname);
            this.Controls.Add(this.btn_Zurück);
            this.Name = "frm_Inventarisierung";
            this.Text = "frm_Inventarisierung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Zurück;
        private System.Windows.Forms.TextBox tb_Kundenname;
        private System.Windows.Forms.Label lb_Kundenname;
        private System.Windows.Forms.Button btn_Anlegen;
        private System.Windows.Forms.Label lb_Inventarnummer;
        private System.Windows.Forms.Label lb_KundenID;
        private System.Windows.Forms.Label lb_Standort;
        private System.Windows.Forms.Label lb_Gerätetyp;
        private System.Windows.Forms.Label lb_Bezeichnung;
        private System.Windows.Forms.Label lb_Rechnungsnummer;
        private System.Windows.Forms.Label lb_Anlagedatum;
        private System.Windows.Forms.Label lb_Memo;
        private System.Windows.Forms.Label lb_Inaktiv_seit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}