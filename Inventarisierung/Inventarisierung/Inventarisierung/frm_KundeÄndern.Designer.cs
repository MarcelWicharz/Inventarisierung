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
            this.SuspendLayout();
            // 
            // lb_KundenID
            // 
            this.lb_KundenID.AutoSize = true;
            this.lb_KundenID.Location = new System.Drawing.Point(9, 36);
            this.lb_KundenID.Name = "lb_KundenID";
            this.lb_KundenID.Size = new System.Drawing.Size(61, 13);
            this.lb_KundenID.TabIndex = 0;
            this.lb_KundenID.Text = "Kunden ID:";
            // 
            // tb_KundenName
            // 
            this.tb_KundenName.Location = new System.Drawing.Point(99, 62);
            this.tb_KundenName.Name = "tb_KundenName";
            this.tb_KundenName.Size = new System.Drawing.Size(100, 20);
            this.tb_KundenName.TabIndex = 1;
            // 
            // btn_Zurück
            // 
            this.btn_Zurück.Location = new System.Drawing.Point(12, 95);
            this.btn_Zurück.Name = "btn_Zurück";
            this.btn_Zurück.Size = new System.Drawing.Size(75, 23);
            this.btn_Zurück.TabIndex = 3;
            this.btn_Zurück.Text = "Zurück";
            this.btn_Zurück.UseVisualStyleBackColor = true;
            this.btn_Zurück.Click += new System.EventHandler(this.btn_Zurück_Click);
            // 
            // tb_KundenID
            // 
            this.tb_KundenID.Location = new System.Drawing.Point(99, 33);
            this.tb_KundenID.Name = "tb_KundenID";
            this.tb_KundenID.ReadOnly = true;
            this.tb_KundenID.Size = new System.Drawing.Size(35, 20);
            this.tb_KundenID.TabIndex = 4;
            // 
            // btn_KundenDatenÄndern
            // 
            this.btn_KundenDatenÄndern.Location = new System.Drawing.Point(124, 95);
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
            this.lb_KundenName.Location = new System.Drawing.Point(9, 65);
            this.lb_KundenName.Name = "lb_KundenName";
            this.lb_KundenName.Size = new System.Drawing.Size(73, 13);
            this.lb_KundenName.TabIndex = 7;
            this.lb_KundenName.Text = "Kundenname:";
            // 
            // frm_KundeÄndern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 124);
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
    }
}