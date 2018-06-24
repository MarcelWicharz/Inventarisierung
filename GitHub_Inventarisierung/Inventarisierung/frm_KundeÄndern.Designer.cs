namespace Inventarisierung
{
    partial class frm_KundeÄndern
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
            this.lb_KundenID = new System.Windows.Forms.Label();
            this.tb_KundenName = new System.Windows.Forms.TextBox();
            this.btn_Zurück = new System.Windows.Forms.Button();
            this.tb_KundenID = new System.Windows.Forms.TextBox();
            this.btn_KundenDatenÄndern = new System.Windows.Forms.Button();
            this.lb_KundenDaten = new System.Windows.Forms.Label();
            this.lb_KundenName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_KundenID
            // 
            this.lb_KundenID.AutoSize = true;
            this.lb_KundenID.Location = new System.Drawing.Point(9, 70);
            this.lb_KundenID.Name = "lb_KundenID";
            this.lb_KundenID.Size = new System.Drawing.Size(61, 13);
            this.lb_KundenID.TabIndex = 0;
            this.lb_KundenID.Text = "Kunden ID:";
            // 
            // tb_KundenName
            // 
            this.tb_KundenName.Location = new System.Drawing.Point(99, 96);
            this.tb_KundenName.Name = "tb_KundenName";
            this.tb_KundenName.Size = new System.Drawing.Size(100, 20);
            this.tb_KundenName.TabIndex = 1;
            // 
            // btn_Zurück
            // 
            this.btn_Zurück.Location = new System.Drawing.Point(14, 267);
            this.btn_Zurück.Name = "btn_Zurück";
            this.btn_Zurück.Size = new System.Drawing.Size(75, 23);
            this.btn_Zurück.TabIndex = 3;
            this.btn_Zurück.Text = "Zurück";
            this.btn_Zurück.UseVisualStyleBackColor = true;
            this.btn_Zurück.Click += new System.EventHandler(this.btn_Zurück_Click);
            // 
            // tb_KundenID
            // 
            this.tb_KundenID.Location = new System.Drawing.Point(99, 67);
            this.tb_KundenID.Name = "tb_KundenID";
            this.tb_KundenID.ReadOnly = true;
            this.tb_KundenID.Size = new System.Drawing.Size(35, 20);
            this.tb_KundenID.TabIndex = 4;
            // 
            // btn_KundenDatenÄndern
            // 
            this.btn_KundenDatenÄndern.Location = new System.Drawing.Point(126, 267);
            this.btn_KundenDatenÄndern.Name = "btn_KundenDatenÄndern";
            this.btn_KundenDatenÄndern.Size = new System.Drawing.Size(75, 23);
            this.btn_KundenDatenÄndern.TabIndex = 5;
            this.btn_KundenDatenÄndern.Text = "Ändern";
            this.btn_KundenDatenÄndern.UseVisualStyleBackColor = true;
            this.btn_KundenDatenÄndern.Click += new System.EventHandler(this.btn_KundenDatenÄndern_Click);
            // 
            // lb_KundenDaten
            // 
            this.lb_KundenDaten.AutoSize = true;
            this.lb_KundenDaten.Location = new System.Drawing.Point(9, 9);
            this.lb_KundenDaten.Name = "lb_KundenDaten";
            this.lb_KundenDaten.Size = new System.Drawing.Size(74, 13);
            this.lb_KundenDaten.TabIndex = 6;
            this.lb_KundenDaten.Text = "Kundendaten:";
            // 
            // lb_KundenName
            // 
            this.lb_KundenName.AutoSize = true;
            this.lb_KundenName.Location = new System.Drawing.Point(9, 99);
            this.lb_KundenName.Name = "lb_KundenName";
            this.lb_KundenName.Size = new System.Drawing.Size(73, 13);
            this.lb_KundenName.TabIndex = 7;
            this.lb_KundenName.Text = "Kundenname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Straße:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PLZ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ort:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "EMail:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 185);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(99, 220);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 16;
            // 
            // frm_KundeÄndern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 298);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_KundenName);
            this.Controls.Add(this.lb_KundenDaten);
            this.Controls.Add(this.btn_KundenDatenÄndern);
            this.Controls.Add(this.tb_KundenID);
            this.Controls.Add(this.btn_Zurück);
            this.Controls.Add(this.tb_KundenName);
            this.Controls.Add(this.lb_KundenID);
            this.Name = "frm_KundeÄndern";
            this.Text = "KundeÄndern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_KundenID;
        private System.Windows.Forms.TextBox tb_KundenName;
        private System.Windows.Forms.Button btn_Zurück;
        private System.Windows.Forms.TextBox tb_KundenID;
        private System.Windows.Forms.Button btn_KundenDatenÄndern;
        private System.Windows.Forms.Label lb_KundenDaten;
        private System.Windows.Forms.Label lb_KundenName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}