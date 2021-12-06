namespace Wyścigi_Konne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackArea = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nrCharta = new System.Windows.Forms.NumericUpDown();
            this.stawka = new System.Windows.Forms.NumericUpDown();
            this.START = new System.Windows.Forms.Button();
            this.betButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.arekBet = new System.Windows.Forms.Label();
            this.bartekBet = new System.Windows.Forms.Label();
            this.janekBet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.arekRadio = new System.Windows.Forms.RadioButton();
            this.bartekRadio = new System.Windows.Forms.RadioButton();
            this.janekRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.alBet = new System.Windows.Forms.Label();
            this.bobBet = new System.Windows.Forms.Label();
            this.joeBet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackArea)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrCharta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stawka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            this.SuspendLayout();
            // 
            // trackArea
            // 
            this.trackArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trackArea.BackgroundImage")));
            this.trackArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackArea.Location = new System.Drawing.Point(11, 12);
            this.trackArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackArea.Name = "trackArea";
            this.trackArea.Size = new System.Drawing.Size(600, 199);
            this.trackArea.TabIndex = 0;
            this.trackArea.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nrCharta);
            this.panel1.Controls.Add(this.stawka);
            this.panel1.Controls.Add(this.START);
            this.panel1.Controls.Add(this.betButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.arekBet);
            this.panel1.Controls.Add(this.bartekBet);
            this.panel1.Controls.Add(this.janekBet);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.arekRadio);
            this.panel1.Controls.Add(this.bartekRadio);
            this.panel1.Controls.Add(this.janekRadio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 217);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 133);
            this.panel1.TabIndex = 6;
            // 
            // nrCharta
            // 
            this.nrCharta.Location = new System.Drawing.Point(271, 108);
            this.nrCharta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nrCharta.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nrCharta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrCharta.Name = "nrCharta";
            this.nrCharta.Size = new System.Drawing.Size(39, 22);
            this.nrCharta.TabIndex = 15;
            this.nrCharta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stawka
            // 
            this.stawka.Location = new System.Drawing.Point(101, 110);
            this.stawka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stawka.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.stawka.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.stawka.Name = "stawka";
            this.stawka.Size = new System.Drawing.Size(48, 22);
            this.stawka.TabIndex = 14;
            this.stawka.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(307, 11);
            this.START.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(291, 114);
            this.START.TabIndex = 13;
            this.START.Text = "START!";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(1, 108);
            this.betButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(93, 25);
            this.betButton.TabIndex = 12;
            this.betButton.Text = "Postaw";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "zł na charta nr:";
            // 
            // arekBet
            // 
            this.arekBet.AutoSize = true;
            this.arekBet.Location = new System.Drawing.Point(151, 87);
            this.arekBet.MaximumSize = new System.Drawing.Size(149, 16);
            this.arekBet.MinimumSize = new System.Drawing.Size(149, 16);
            this.arekBet.Name = "arekBet";
            this.arekBet.Size = new System.Drawing.Size(149, 16);
            this.arekBet.TabIndex = 7;
            this.arekBet.Text = "Arek stawia 0zł";
            // 
            // bartekBet
            // 
            this.bartekBet.AutoSize = true;
            this.bartekBet.Location = new System.Drawing.Point(151, 60);
            this.bartekBet.MaximumSize = new System.Drawing.Size(149, 16);
            this.bartekBet.MinimumSize = new System.Drawing.Size(149, 16);
            this.bartekBet.Name = "bartekBet";
            this.bartekBet.Size = new System.Drawing.Size(149, 16);
            this.bartekBet.TabIndex = 6;
            this.bartekBet.Text = "Bartek stawia 0zł";
            // 
            // janekBet
            // 
            this.janekBet.AutoSize = true;
            this.janekBet.Location = new System.Drawing.Point(151, 34);
            this.janekBet.MaximumSize = new System.Drawing.Size(149, 16);
            this.janekBet.MinimumSize = new System.Drawing.Size(149, 16);
            this.janekBet.Name = "janekBet";
            this.janekBet.Size = new System.Drawing.Size(149, 16);
            this.janekBet.TabIndex = 5;
            this.janekBet.Text = "Janek Stawia 0zł";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zakłady";
            // 
            // arekRadio
            // 
            this.arekRadio.AutoSize = true;
            this.arekRadio.Location = new System.Drawing.Point(5, 85);
            this.arekRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arekRadio.Name = "arekRadio";
            this.arekRadio.Size = new System.Drawing.Size(76, 20);
            this.arekRadio.TabIndex = 3;
            this.arekRadio.TabStop = true;
            this.arekRadio.Text = "Arek: 55";
            this.arekRadio.UseVisualStyleBackColor = true;
            // 
            // bartekRadio
            // 
            this.bartekRadio.AutoSize = true;
            this.bartekRadio.Location = new System.Drawing.Point(5, 58);
            this.bartekRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bartekRadio.Name = "bartekRadio";
            this.bartekRadio.Size = new System.Drawing.Size(87, 20);
            this.bartekRadio.TabIndex = 2;
            this.bartekRadio.TabStop = true;
            this.bartekRadio.Text = "Bartek: 45";
            this.bartekRadio.UseVisualStyleBackColor = true;
            // 
            // janekRadio
            // 
            this.janekRadio.AutoSize = true;
            this.janekRadio.Location = new System.Drawing.Point(5, 31);
            this.janekRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.janekRadio.Name = "janekRadio";
            this.janekRadio.Size = new System.Drawing.Size(85, 20);
            this.janekRadio.TabIndex = 1;
            this.janekRadio.TabStop = true;
            this.janekRadio.Text = "Janek: 50";
            this.janekRadio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Minimalny zakład: 5zł";
            // 
            // alBet
            // 
            this.alBet.AutoSize = true;
            this.alBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBet.Location = new System.Drawing.Point(150, 85);
            this.alBet.MaximumSize = new System.Drawing.Size(300, 20);
            this.alBet.MinimumSize = new System.Drawing.Size(300, 20);
            this.alBet.Name = "alBet";
            this.alBet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.alBet.Size = new System.Drawing.Size(300, 20);
            this.alBet.TabIndex = 7;
            this.alBet.Text = "Arek nie zawarł zakładu";
            // 
            // bobBet
            // 
            this.bobBet.AutoSize = true;
            this.bobBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBet.Location = new System.Drawing.Point(150, 58);
            this.bobBet.MaximumSize = new System.Drawing.Size(300, 20);
            this.bobBet.MinimumSize = new System.Drawing.Size(300, 20);
            this.bobBet.Name = "bobBet";
            this.bobBet.Size = new System.Drawing.Size(300, 20);
            this.bobBet.TabIndex = 6;
            this.bobBet.Text = "Bartek nie zawarł zakładu";
            // 
            // joeBet
            // 
            this.joeBet.AutoSize = true;
            this.joeBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBet.Location = new System.Drawing.Point(150, 31);
            this.joeBet.MaximumSize = new System.Drawing.Size(300, 20);
            this.joeBet.MinimumSize = new System.Drawing.Size(300, 20);
            this.joeBet.Name = "joeBet";
            this.joeBet.Size = new System.Drawing.Size(300, 20);
            this.joeBet.TabIndex = 5;
            this.joeBet.Text = "Janek nie zawarł zakładu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zakłady";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 83);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(107, 20);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Arek ma 45zł";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(118, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bartek ma 75zł";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 29);
            this.radioButton1.MaximumSize = new System.Drawing.Size(0, 20);
            this.radioButton1.MinimumSize = new System.Drawing.Size(0, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Janek 50zł";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Location = new System.Drawing.Point(3, 9);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(138, 16);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "Minimalny zakład: 5zł";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kto stawia zakład?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(231, 113);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(50, 22);
            this.domainUpDown1.TabIndex = 10;
            this.domainUpDown1.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "zł na charta numer";
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Location = new System.Drawing.Point(411, 113);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(39, 22);
            this.domainUpDown2.TabIndex = 12;
            this.domainUpDown2.Text = "1";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(0, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            // 
            // dog1
            // 
            this.dog1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog1.BackgroundImage")));
            this.dog1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog1.Location = new System.Drawing.Point(28, 26);
            this.dog1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(75, 20);
            this.dog1.TabIndex = 2;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.BackgroundImage = global::Wyścigi_Konne.Properties.Resources.dog;
            this.dog2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog2.Location = new System.Drawing.Point(28, 63);
            this.dog2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(75, 20);
            this.dog2.TabIndex = 3;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.BackgroundImage = global::Wyścigi_Konne.Properties.Resources.dog;
            this.dog3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog3.Location = new System.Drawing.Point(28, 119);
            this.dog3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(75, 20);
            this.dog3.TabIndex = 4;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.BackgroundImage = global::Wyścigi_Konne.Properties.Resources.dog;
            this.dog4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog4.Location = new System.Drawing.Point(28, 175);
            this.dog4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(75, 20);
            this.dog4.TabIndex = 5;
            this.dog4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 359);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackArea);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(735, 406);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(735, 406);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackArea)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrCharta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stawka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox trackArea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label alBet;
        private System.Windows.Forms.Label bobBet;
        private System.Windows.Forms.Label joeBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.RadioButton arekRadio;
        private System.Windows.Forms.RadioButton bartekRadio;
        private System.Windows.Forms.RadioButton janekRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label arekBet;
        private System.Windows.Forms.Label bartekBet;
        private System.Windows.Forms.Label janekBet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.NumericUpDown stawka;
        private System.Windows.Forms.NumericUpDown nrCharta;
    }
}

