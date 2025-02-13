namespace passwortgenerator_mit_oberfläche
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Passwörter = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Passwortlänge = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Passwortlänge)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Erzeuge Passwörter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(208, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Speichern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Passwörter
            // 
            this.Passwörter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Passwörter.FormattingEnabled = true;
            this.Passwörter.Location = new System.Drawing.Point(12, 285);
            this.Passwörter.Name = "Passwörter";
            this.Passwörter.Size = new System.Drawing.Size(383, 82);
            this.Passwörter.TabIndex = 2;
            this.Passwörter.SelectedIndexChanged += new System.EventHandler(this.Passwörter_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 168);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Sonderzeichen?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Passwortlänge
            // 
            this.Passwortlänge.Location = new System.Drawing.Point(12, 117);
            this.Passwortlänge.Maximum = 16;
            this.Passwortlänge.Minimum = 4;
            this.Passwortlänge.Name = "Passwortlänge";
            this.Passwortlänge.Size = new System.Drawing.Size(187, 45);
            this.Passwortlänge.TabIndex = 4;
            this.Passwortlänge.Value = 4;
            this.Passwortlänge.Scroll += new System.EventHandler(this.Passwortlänge_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Passwortlänge:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Passwortlänge);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Passwörter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Passwortlänge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox Passwörter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar Passwortlänge;
        private System.Windows.Forms.Label label1;
    }
}

