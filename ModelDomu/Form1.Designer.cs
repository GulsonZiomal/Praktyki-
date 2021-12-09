namespace ModelDomu
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
            this.description = new System.Windows.Forms.TextBox();
            this.goHere = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.ComboBox();
            this.goThoughtTheDoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(13, 13);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(452, 213);
            this.description.TabIndex = 0;
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(13, 229);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(94, 26);
            this.goHere.TabIndex = 1;
            this.goHere.Text = "Idź Tutaj:";
            this.goHere.UseVisualStyleBackColor = true;
            // 
            // exits
            // 
            this.exits.FormattingEnabled = true;
            this.exits.Items.AddRange(new object[] {
            "Salon",
            "Jadalnia",
            "Kuchnia",
            "Podwórko przed domem",
            "Podwórko za domem ",
            "Ogród"});
            this.exits.Location = new System.Drawing.Point(113, 231);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(352, 24);
            this.exits.TabIndex = 2;
            // 
            // goThoughtTheDoor
            // 
            this.goThoughtTheDoor.Location = new System.Drawing.Point(13, 263);
            this.goThoughtTheDoor.Name = "goThoughtTheDoor";
            this.goThoughtTheDoor.Size = new System.Drawing.Size(452, 31);
            this.goThoughtTheDoor.TabIndex = 3;
            this.goThoughtTheDoor.Text = "Przejdź przez drzwi";
            this.goThoughtTheDoor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 306);
            this.Controls.Add(this.goThoughtTheDoor);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.description);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Zbadaj Dom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button goThoughtTheDoor;
    }
}

