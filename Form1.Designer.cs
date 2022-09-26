namespace KlasaArraylist
{
    partial class Form1
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
            this.btnNoviAutomobil = new System.Windows.Forms.Button();
            this.txtNoviAutomobil = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObrisiListu = new System.Windows.Forms.Button();
            this.rtbListaAuta = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNoviAutomobil
            // 
            this.btnNoviAutomobil.Location = new System.Drawing.Point(38, 27);
            this.btnNoviAutomobil.Name = "btnNoviAutomobil";
            this.btnNoviAutomobil.Size = new System.Drawing.Size(129, 23);
            this.btnNoviAutomobil.TabIndex = 0;
            this.btnNoviAutomobil.Text = "Novi automobil";
            this.btnNoviAutomobil.UseVisualStyleBackColor = true;
            this.btnNoviAutomobil.Click += new System.EventHandler(this.btnNoviAutomobil_Click);
            // 
            // txtNoviAutomobil
            // 
            this.txtNoviAutomobil.Enabled = false;
            this.txtNoviAutomobil.Location = new System.Drawing.Point(38, 65);
            this.txtNoviAutomobil.Name = "txtNoviAutomobil";
            this.txtNoviAutomobil.Size = new System.Drawing.Size(150, 20);
            this.txtNoviAutomobil.TabIndex = 1;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Enabled = false;
            this.btnUnesi.Location = new System.Drawing.Point(206, 65);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 2;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            // 
            // btnObrisiListu
            // 
            this.btnObrisiListu.Location = new System.Drawing.Point(38, 308);
            this.btnObrisiListu.Name = "btnObrisiListu";
            this.btnObrisiListu.Size = new System.Drawing.Size(129, 23);
            this.btnObrisiListu.TabIndex = 4;
            this.btnObrisiListu.Text = "Obriši listu";
            this.btnObrisiListu.UseVisualStyleBackColor = true;
            // 
            // rtbListaAuta
            // 
            this.rtbListaAuta.Location = new System.Drawing.Point(38, 103);
            this.rtbListaAuta.Name = "rtbListaAuta";
            this.rtbListaAuta.Size = new System.Drawing.Size(243, 190);
            this.rtbListaAuta.TabIndex = 5;
            this.rtbListaAuta.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 357);
            this.Controls.Add(this.rtbListaAuta);
            this.Controls.Add(this.btnObrisiListu);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtNoviAutomobil);
            this.Controls.Add(this.btnNoviAutomobil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNoviAutomobil;
        private System.Windows.Forms.TextBox txtNoviAutomobil;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObrisiListu;
        private System.Windows.Forms.RichTextBox rtbListaAuta;
    }
}

