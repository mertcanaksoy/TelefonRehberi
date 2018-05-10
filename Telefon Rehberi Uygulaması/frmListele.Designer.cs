namespace Telefon_Rehberi_Uygulaması
{
    partial class frmListele
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
            this.txtListe = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtListe
            // 
            this.txtListe.Location = new System.Drawing.Point(14, 17);
            this.txtListe.Name = "txtListe";
            this.txtListe.Size = new System.Drawing.Size(288, 230);
            this.txtListe.TabIndex = 1;
            this.txtListe.Text = "";
            // 
            // frmListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 264);
            this.Controls.Add(this.txtListe);
            this.Name = "frmListele";
            this.Text = "frmListele";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListele_FormClosed);
            this.Load += new System.EventHandler(this.frmListele_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtListe;
    }
}