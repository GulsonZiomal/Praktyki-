namespace Ul
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.nextShift = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Location = new System.Drawing.Point(2, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przydział prac";
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Zbieranie nektaru",
            "Wytwarzanie miodu",
            "Pielęgnacja jaj",
            "Nauczanie pszczółek ",
            "Utrzymanie Ula",
            "Patrol z żądłami "});
            this.workerBeeJob.Location = new System.Drawing.Point(7, 22);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(250, 24);
            this.workerBeeJob.TabIndex = 0;
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(263, 23);
            this.shifts.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.shifts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(136, 22);
            this.shifts.TabIndex = 1;
            this.shifts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Przypisz tę pracę pszczole";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nextShift
            // 
            this.nextShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextShift.Location = new System.Drawing.Point(407, 13);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(136, 84);
            this.nextShift.TabIndex = 1;
            this.nextShift.Text = "Przepracuj następną zmiane";
            this.nextShift.UseVisualStyleBackColor = true;
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(2, 103);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(541, 211);
            this.report.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 326);
            this.Controls.Add(this.report);
            this.Controls.Add(this.nextShift);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.TextBox report;
    }
}

