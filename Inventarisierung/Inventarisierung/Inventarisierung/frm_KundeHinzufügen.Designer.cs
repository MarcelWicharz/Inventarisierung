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
            this.SuspendLayout();
            // 
            // lb_Kundenname
            // 
            this.lb_Kundenname.AutoSize = true;
            this.lb_Kundenname.Location = new System.Drawing.Point(4, 28);
            this.lb_Kundenname.Name = "lb_Kundenname";
            this.lb_Kundenname.Size = new System.Drawing.Size(73, 13);
            this.lb_Kundenname.TabIndex = 0;
            this.lb_Kundenname.Text = "Kundenname:";
            // 
            // btn_KundeHinzufügen
            // 
            this.btn_KundeHinzufügen.Location = new System.Drawing.Point(150, 70);
            this.btn_KundeHinzufügen.Name = "btn_KundeHinzufügen";
            this.btn_KundeHinzufügen.Size = new System.Drawing.Size(75, 23);
            this.btn_KundeHinzufügen.TabIndex = 1;
            this.btn_KundeHinzufügen.Text = "Hinzufügen";
            this.btn_KundeHinzufügen.UseVisualStyleBackColor = true;
            this.btn_KundeHinzufügen.Click += new System.EventHandler(this.btn_KundeHinzufügen_Click);
            // 
            // tb_KundennameHinzufügen
            // 
            this.tb_KundennameHinzufügen.Location = new System.Drawing.Point(83, 28);
            this.tb_KundennameHinzufügen.Name = "tb_KundennameHinzufügen";
            this.tb_KundennameHinzufügen.Size = new System.Drawing.Size(142, 20);
            this.tb_KundennameHinzufügen.TabIndex = 2;
            // 
            // btn_Zurück
            // 
            this.btn_Zurück.Location = new System.Drawing.Point(13, 70);
            this.btn_Zurück.Name = "btn_Zurück";
            this.btn_Zurück.Size = new System.Drawing.Size(75, 23);
            this.btn_Zurück.TabIndex = 3;
            this.btn_Zurück.Text = "Zurück";
            this.btn_Zurück.UseVisualStyleBackColor = true;
            this.btn_Zurück.Click += new System.EventHandler(this.btn_Zurück_Click);
            // 
            // frm_KundeHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 105);
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
    }
}