namespace WindowsFormsApp3
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
            this.Start = new System.Windows.Forms.NumericUpDown();
            this.koniec = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koniec)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(257, 10);
            this.Start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Start.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(133, 20);
            this.Start.TabIndex = 0;
            this.Start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // koniec
            // 
            this.koniec.Location = new System.Drawing.Point(257, 41);
            this.koniec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.koniec.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.koniec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.koniec.Name = "koniec";
            this.koniec.Size = new System.Drawing.Size(133, 20);
            this.koniec.TabIndex = 1;
            this.koniec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pocątkowy stan licznika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Końcowy satn licznika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Oblicz!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Pokaż odległość";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 165);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.koniec);
            this.Controls.Add(this.Start);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator Odletłości";
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koniec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Start;
        private System.Windows.Forms.NumericUpDown koniec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

