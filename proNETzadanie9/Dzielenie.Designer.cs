namespace proNETzadanie9
{
    partial class Dzielenie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dzielnaText = new System.Windows.Forms.TextBox();
            this.dzielnikText = new System.Windows.Forms.TextBox();
            this.wynikText = new System.Windows.Forms.TextBox();
            this.wynikButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dzielnaText
            // 
            this.dzielnaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dzielnaText.Location = new System.Drawing.Point(25, 61);
            this.dzielnaText.Name = "dzielnaText";
            this.dzielnaText.Size = new System.Drawing.Size(96, 31);
            this.dzielnaText.TabIndex = 0;
            this.dzielnaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dzielnaText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dzielnikText
            // 
            this.dzielnikText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dzielnikText.Location = new System.Drawing.Point(183, 61);
            this.dzielnikText.Name = "dzielnikText";
            this.dzielnikText.Size = new System.Drawing.Size(95, 31);
            this.dzielnikText.TabIndex = 1;
            this.dzielnikText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dzielnikText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // wynikText
            // 
            this.wynikText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynikText.Location = new System.Drawing.Point(25, 223);
            this.wynikText.Name = "wynikText";
            this.wynikText.ReadOnly = true;
            this.wynikText.Size = new System.Drawing.Size(253, 38);
            this.wynikText.TabIndex = 2;
            this.wynikText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wynikButton
            // 
            this.wynikButton.ForeColor = System.Drawing.Color.Black;
            this.wynikButton.Location = new System.Drawing.Point(115, 127);
            this.wynikButton.Name = "wynikButton";
            this.wynikButton.Size = new System.Drawing.Size(73, 48);
            this.wynikButton.TabIndex = 3;
            this.wynikButton.Text = "=";
            this.wynikButton.UseVisualStyleBackColor = true;
            this.wynikButton.Click += new System.EventHandler(this.OnBtnOperationClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DZIELNA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(145, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DZIELNIK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "WYNIK";
            // 
            // Dzielenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 305);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wynikButton);
            this.Controls.Add(this.wynikText);
            this.Controls.Add(this.dzielnikText);
            this.Controls.Add(this.dzielnaText);
            this.Name = "Dzielenie";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dzielnaText;
        private System.Windows.Forms.TextBox dzielnikText;
        private System.Windows.Forms.TextBox wynikText;
        private System.Windows.Forms.Button wynikButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

