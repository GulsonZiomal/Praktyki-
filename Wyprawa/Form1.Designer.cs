namespace Wyprawa
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
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.moveRight = new System.Windows.Forms.Button();
            this.attackRight = new System.Windows.Forms.Button();
            this.attackUp = new System.Windows.Forms.Button();
            this.attackDown = new System.Windows.Forms.Button();
            this.attackLeft = new System.Windows.Forms.Button();
            this.mace = new System.Windows.Forms.PictureBox();
            this.batleaxe = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.rangePotion = new System.Windows.Forms.PictureBox();
            this.hpPotion = new System.Windows.Forms.PictureBox();
            this.wizard = new System.Windows.Forms.PictureBox();
            this.ghoul = new System.Windows.Forms.PictureBox();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.PictureBox();
            this.quiver = new System.Windows.Forms.PictureBox();
            this.shield = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batleaxe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shield)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(809, 219);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(54, 55);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(115, 495);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(221, 495);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(356, 495);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // moveUp
            // 
            this.moveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveUp.Location = new System.Drawing.Point(520, 515);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(100, 40);
            this.moveUp.TabIndex = 4;
            this.moveUp.Text = "^";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveDown
            // 
            this.moveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveDown.Location = new System.Drawing.Point(520, 555);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(100, 40);
            this.moveDown.TabIndex = 5;
            this.moveDown.Text = "v";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // moveLeft
            // 
            this.moveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveLeft.Location = new System.Drawing.Point(464, 515);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(50, 80);
            this.moveLeft.TabIndex = 6;
            this.moveLeft.Text = "<";
            this.moveLeft.UseVisualStyleBackColor = true;
            this.moveLeft.Click += new System.EventHandler(this.moveLeft_Click);
            // 
            // moveRight
            // 
            this.moveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveRight.Location = new System.Drawing.Point(626, 515);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(50, 80);
            this.moveRight.TabIndex = 7;
            this.moveRight.Text = ">";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // attackRight
            // 
            this.attackRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackRight.Location = new System.Drawing.Point(682, 515);
            this.attackRight.Name = "attackRight";
            this.attackRight.Size = new System.Drawing.Size(50, 80);
            this.attackRight.TabIndex = 8;
            this.attackRight.Text = "<";
            this.attackRight.UseVisualStyleBackColor = true;
            this.attackRight.Click += new System.EventHandler(this.attackRight_Click);
            // 
            // attackUp
            // 
            this.attackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackUp.Location = new System.Drawing.Point(738, 515);
            this.attackUp.Name = "attackUp";
            this.attackUp.Size = new System.Drawing.Size(100, 40);
            this.attackUp.TabIndex = 9;
            this.attackUp.Text = "^";
            this.attackUp.UseVisualStyleBackColor = true;
            this.attackUp.Click += new System.EventHandler(this.attackUp_Click);
            // 
            // attackDown
            // 
            this.attackDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackDown.Location = new System.Drawing.Point(738, 555);
            this.attackDown.Name = "attackDown";
            this.attackDown.Size = new System.Drawing.Size(100, 40);
            this.attackDown.TabIndex = 10;
            this.attackDown.Text = "v";
            this.attackDown.UseVisualStyleBackColor = true;
            this.attackDown.Click += new System.EventHandler(this.attackDown_Click);
            // 
            // attackLeft
            // 
            this.attackLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackLeft.Location = new System.Drawing.Point(844, 515);
            this.attackLeft.Name = "attackLeft";
            this.attackLeft.Size = new System.Drawing.Size(50, 80);
            this.attackLeft.TabIndex = 11;
            this.attackLeft.Text = ">";
            this.attackLeft.UseVisualStyleBackColor = true;
            this.attackLeft.Click += new System.EventHandler(this.attackLeft_Click);
            // 
            // mace
            // 
            this.mace.BackColor = System.Drawing.Color.Transparent;
            this.mace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mace.BackgroundImage")));
            this.mace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mace.Location = new System.Drawing.Point(612, 12);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(54, 55);
            this.mace.TabIndex = 12;
            this.mace.TabStop = false;
            // 
            // batleaxe
            // 
            this.batleaxe.BackColor = System.Drawing.Color.Transparent;
            this.batleaxe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("batleaxe.BackgroundImage")));
            this.batleaxe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.batleaxe.Location = new System.Drawing.Point(552, 12);
            this.batleaxe.Name = "batleaxe";
            this.batleaxe.Size = new System.Drawing.Size(54, 55);
            this.batleaxe.TabIndex = 13;
            this.batleaxe.TabStop = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bow.BackgroundImage")));
            this.bow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bow.Location = new System.Drawing.Point(492, 12);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(54, 55);
            this.bow.TabIndex = 14;
            this.bow.TabStop = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sword.BackgroundImage")));
            this.sword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sword.Location = new System.Drawing.Point(432, 12);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(54, 55);
            this.sword.TabIndex = 15;
            this.sword.TabStop = false;
            // 
            // rangePotion
            // 
            this.rangePotion.BackColor = System.Drawing.Color.Transparent;
            this.rangePotion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rangePotion.BackgroundImage")));
            this.rangePotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rangePotion.Location = new System.Drawing.Point(372, 12);
            this.rangePotion.Name = "rangePotion";
            this.rangePotion.Size = new System.Drawing.Size(54, 55);
            this.rangePotion.TabIndex = 16;
            this.rangePotion.TabStop = false;
            // 
            // hpPotion
            // 
            this.hpPotion.BackColor = System.Drawing.Color.Transparent;
            this.hpPotion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hpPotion.BackgroundImage")));
            this.hpPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hpPotion.Location = new System.Drawing.Point(312, 12);
            this.hpPotion.Name = "hpPotion";
            this.hpPotion.Size = new System.Drawing.Size(54, 55);
            this.hpPotion.TabIndex = 17;
            this.hpPotion.TabStop = false;
            // 
            // wizard
            // 
            this.wizard.BackColor = System.Drawing.Color.Transparent;
            this.wizard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wizard.BackgroundImage")));
            this.wizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wizard.Location = new System.Drawing.Point(252, 12);
            this.wizard.Name = "wizard";
            this.wizard.Size = new System.Drawing.Size(54, 55);
            this.wizard.TabIndex = 18;
            this.wizard.TabStop = false;
            // 
            // ghoul
            // 
            this.ghoul.BackColor = System.Drawing.Color.Transparent;
            this.ghoul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ghoul.BackgroundImage")));
            this.ghoul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghoul.Location = new System.Drawing.Point(192, 12);
            this.ghoul.Name = "ghoul";
            this.ghoul.Size = new System.Drawing.Size(54, 55);
            this.ghoul.TabIndex = 19;
            this.ghoul.TabStop = false;
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.Transparent;
            this.ghost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ghost.BackgroundImage")));
            this.ghost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghost.Location = new System.Drawing.Point(132, 12);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(54, 55);
            this.ghost.TabIndex = 20;
            this.ghost.TabStop = false;
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bat.BackgroundImage")));
            this.bat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bat.Location = new System.Drawing.Point(72, 12);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(54, 55);
            this.bat.TabIndex = 21;
            this.bat.TabStop = false;
            // 
            // quiver
            // 
            this.quiver.BackColor = System.Drawing.Color.Transparent;
            this.quiver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quiver.BackgroundImage")));
            this.quiver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quiver.Location = new System.Drawing.Point(678, 12);
            this.quiver.Name = "quiver";
            this.quiver.Size = new System.Drawing.Size(54, 55);
            this.quiver.TabIndex = 22;
            this.quiver.TabStop = false;
            // 
            // shield
            // 
            this.shield.BackColor = System.Drawing.Color.Transparent;
            this.shield.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shield.BackgroundImage")));
            this.shield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shield.Location = new System.Drawing.Point(738, 12);
            this.shield.Name = "shield";
            this.shield.Size = new System.Drawing.Size(54, 55);
            this.shield.TabIndex = 23;
            this.shield.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(465, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "MOVE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(683, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "ATACK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 635);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shield);
            this.Controls.Add(this.quiver);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.ghoul);
            this.Controls.Add(this.wizard);
            this.Controls.Add(this.hpPotion);
            this.Controls.Add(this.rangePotion);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.batleaxe);
            this.Controls.Add(this.mace);
            this.Controls.Add(this.attackLeft);
            this.Controls.Add(this.attackDown);
            this.Controls.Add(this.attackUp);
            this.Controls.Add(this.attackRight);
            this.Controls.Add(this.moveRight);
            this.Controls.Add(this.moveLeft);
            this.Controls.Add(this.moveDown);
            this.Controls.Add(this.moveUp);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batleaxe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shield)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Button attackRight;
        private System.Windows.Forms.Button attackUp;
        private System.Windows.Forms.Button attackDown;
        private System.Windows.Forms.Button attackLeft;
        private System.Windows.Forms.PictureBox mace;
        private System.Windows.Forms.PictureBox batleaxe;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox rangePotion;
        private System.Windows.Forms.PictureBox hpPotion;
        private System.Windows.Forms.PictureBox wizard;
        private System.Windows.Forms.PictureBox ghoul;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox quiver;
        private System.Windows.Forms.PictureBox shield;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}

