namespace ZadanieDomowe3._0
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.addFirstValue = new System.Windows.Forms.NumericUpDown();
            this.addLastValue = new System.Windows.Forms.NumericUpDown();
            this.GetNValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.addFirstValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLastValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetNValue)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add First";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Last";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Remove First";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Remove Last";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 224);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "Get n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // addFirstValue
            // 
            this.addFirstValue.Location = new System.Drawing.Point(219, 29);
            this.addFirstValue.Name = "addFirstValue";
            this.addFirstValue.Size = new System.Drawing.Size(120, 20);
            this.addFirstValue.TabIndex = 5;
            // 
            // addLastValue
            // 
            this.addLastValue.Location = new System.Drawing.Point(219, 83);
            this.addLastValue.Name = "addLastValue";
            this.addLastValue.Size = new System.Drawing.Size(120, 20);
            this.addLastValue.TabIndex = 6;
            // 
            // GetNValue
            // 
            this.GetNValue.Location = new System.Drawing.Point(219, 239);
            this.GetNValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GetNValue.Name = "GetNValue";
            this.GetNValue.Size = new System.Drawing.Size(120, 20);
            this.GetNValue.TabIndex = 7;
            this.GetNValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 282);
            this.Controls.Add(this.GetNValue);
            this.Controls.Add(this.addLastValue);
            this.Controls.Add(this.addFirstValue);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.addFirstValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLastValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetNValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown addFirstValue;
        private System.Windows.Forms.NumericUpDown addLastValue;
        private System.Windows.Forms.NumericUpDown GetNValue;
    }
}

