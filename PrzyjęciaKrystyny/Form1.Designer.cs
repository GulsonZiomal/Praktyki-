namespace PrzyjęciaKrystyny
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
            this.label1 = new System.Windows.Forms.Label();
            this.ileOsob = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.decoration = new System.Windows.Forms.CheckBox();
            this.foodOption = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.ileOsobBday = new System.Windows.Forms.NumericUpDown();
            this.decorationBday = new System.Windows.Forms.CheckBox();
            this.cake = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceBday = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ileOsob)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ileOsobBday)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ilość osób:";
            // 
            // ileOsob
            // 
            this.ileOsob.Location = new System.Drawing.Point(9, 23);
            this.ileOsob.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ileOsob.Name = "ileOsob";
            this.ileOsob.Size = new System.Drawing.Size(69, 22);
            this.ileOsob.TabIndex = 1;
            this.ileOsob.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ileOsob.ValueChanged += new System.EventHandler(this.ileOsob_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // decoration
            // 
            this.decoration.AutoSize = true;
            this.decoration.Location = new System.Drawing.Point(9, 51);
            this.decoration.Name = "decoration";
            this.decoration.Size = new System.Drawing.Size(153, 20);
            this.decoration.TabIndex = 2;
            this.decoration.Text = "dekoracje fantazyjne";
            this.decoration.UseVisualStyleBackColor = true;
            this.decoration.CheckedChanged += new System.EventHandler(this.decoration_CheckedChanged);
            // 
            // foodOption
            // 
            this.foodOption.AutoSize = true;
            this.foodOption.Location = new System.Drawing.Point(9, 77);
            this.foodOption.Name = "foodOption";
            this.foodOption.Size = new System.Drawing.Size(111, 20);
            this.foodOption.TabIndex = 3;
            this.foodOption.Text = "Opcja zdrowa";
            this.foodOption.UseVisualStyleBackColor = true;
            this.foodOption.CheckedChanged += new System.EventHandler(this.foodOption_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Koszt:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(60, 100);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(50, 16);
            this.price.TabIndex = 5;
            this.price.Text = "77,50zł";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 148);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ileOsob);
            this.tabPage1.Controls.Add(this.price);
            this.tabPage1.Controls.Add(this.foodOption);
            this.tabPage1.Controls.Add(this.decoration);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 119);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Przyjęcie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.priceBday);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cake);
            this.tabPage2.Controls.Add(this.decorationBday);
            this.tabPage2.Controls.Add(this.ileOsobBday);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 119);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Urodziny";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ilość osób";
            // 
            // ileOsobBday
            // 
            this.ileOsobBday.Location = new System.Drawing.Point(10, 19);
            this.ileOsobBday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ileOsobBday.Name = "ileOsobBday";
            this.ileOsobBday.Size = new System.Drawing.Size(66, 22);
            this.ileOsobBday.TabIndex = 1;
            this.ileOsobBday.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ileOsobBday.ValueChanged += new System.EventHandler(this.ileOsobBday_ValueChanged);
            // 
            // decorationBday
            // 
            this.decorationBday.AutoSize = true;
            this.decorationBday.Location = new System.Drawing.Point(10, 47);
            this.decorationBday.Name = "decorationBday";
            this.decorationBday.Size = new System.Drawing.Size(160, 20);
            this.decorationBday.TabIndex = 2;
            this.decorationBday.Text = "Dekoracje Fantazyjne";
            this.decorationBday.UseVisualStyleBackColor = true;
            this.decorationBday.CheckedChanged += new System.EventHandler(this.decorationBday_CheckedChanged);
            // 
            // cake
            // 
            this.cake.Location = new System.Drawing.Point(10, 73);
            this.cake.Name = "cake";
            this.cake.Size = new System.Drawing.Size(160, 22);
            this.cake.TabIndex = 3;
            this.cake.TextChanged += new System.EventHandler(this.cake_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(7, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Koszt: ";
            // 
            // priceBday
            // 
            this.priceBday.AutoSize = true;
            this.priceBday.Location = new System.Drawing.Point(65, 100);
            this.priceBday.Name = "priceBday";
            this.priceBday.Size = new System.Drawing.Size(26, 16);
            this.priceBday.TabIndex = 5;
            this.priceBday.Text = "0zł";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 144);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ileOsob)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ileOsobBday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ileOsob;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox decoration;
        private System.Windows.Forms.CheckBox foodOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label priceBday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cake;
        private System.Windows.Forms.CheckBox decorationBday;
        private System.Windows.Forms.NumericUpDown ileOsobBday;
        private System.Windows.Forms.Label label3;
    }
}

