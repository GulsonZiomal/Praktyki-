namespace Literki
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StatusLabel = new System.Windows.Forms.StatusStrip();
            this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.missedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.accuracyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dificultyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 135;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(854, 123);
            this.listBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StatusLabel
            // 
            this.StatusLabel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusLabel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctLabel,
            this.missedLabel,
            this.totalLabel,
            this.accuracyLabel,
            this.toolStripStatusLabel1,
            this.dificultyProgressBar});
            this.StatusLabel.Location = new System.Drawing.Point(0, 97);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(854, 26);
            this.StatusLabel.SizingGrip = false;
            this.StatusLabel.TabIndex = 0;
            // 
            // correctLabel
            // 
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // missedLabel
            // 
            this.missedLabel.Name = "missedLabel";
            this.missedLabel.Size = new System.Drawing.Size(74, 20);
            this.missedLabel.Text = "Błędów: 0";
            // 
            // totalLabel
            // 
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(91, 20);
            this.totalLabel.Text = "Wszytskich:0";
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(114, 20);
            this.accuracyLabel.Text = "Dokładność: 0%";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(458, 20);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Poziom trudności";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dificultyProgressBar
            // 
            this.dificultyProgressBar.Name = "dificultyProgressBar";
            this.dificultyProgressBar.Size = new System.Drawing.Size(100, 18);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 123);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(876, 174);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(876, 174);
            this.Name = "Form1";
            this.Text = "Gra w Literki";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.StatusLabel.ResumeLayout(false);
            this.StatusLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel correctLabel;
        private System.Windows.Forms.ToolStripStatusLabel missedLabel;
        private System.Windows.Forms.ToolStripStatusLabel totalLabel;
        private System.Windows.Forms.ToolStripStatusLabel accuracyLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar dificultyProgressBar;
    }
}

