namespace TP4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelVect1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opérationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitScalaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitVectorielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxZ1 = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelZ1 = new System.Windows.Forms.Label();
            this.labelVect2 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.labelZ2 = new System.Windows.Forms.Label();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxZ2 = new System.Windows.Forms.TextBox();
            this.labelResultat = new System.Windows.Forms.Label();
            this.labelX3 = new System.Windows.Forms.Label();
            this.labelY3 = new System.Windows.Forms.Label();
            this.labelZ3 = new System.Windows.Forms.Label();
            this.textBoxX3 = new System.Windows.Forms.TextBox();
            this.textBoxY3 = new System.Windows.Forms.TextBox();
            this.textBoxZ3 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelVect1
            // 
            this.labelVect1.AutoSize = true;
            this.labelVect1.Location = new System.Drawing.Point(66, 61);
            this.labelVect1.Name = "labelVect1";
            this.labelVect1.Size = new System.Drawing.Size(50, 13);
            this.labelVect1.TabIndex = 0;
            this.labelVect1.Text = "Vecteur1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opérationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opérationsToolStripMenuItem
            // 
            this.opérationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produitScalaireToolStripMenuItem,
            this.produitVectorielToolStripMenuItem});
            this.opérationsToolStripMenuItem.Name = "opérationsToolStripMenuItem";
            this.opérationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.opérationsToolStripMenuItem.Text = "Opérations";
            // 
            // produitScalaireToolStripMenuItem
            // 
            this.produitScalaireToolStripMenuItem.Name = "produitScalaireToolStripMenuItem";
            this.produitScalaireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produitScalaireToolStripMenuItem.Text = "Produit scalaire";
            this.produitScalaireToolStripMenuItem.Click += new System.EventHandler(this.produitScalaireToolStripMenuItem_Click);
            // 
            // produitVectorielToolStripMenuItem
            // 
            this.produitVectorielToolStripMenuItem.Name = "produitVectorielToolStripMenuItem";
            this.produitVectorielToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produitVectorielToolStripMenuItem.Text = "Produit vectoriel";
            this.produitVectorielToolStripMenuItem.Click += new System.EventHandler(this.produitVectorielToolStripMenuItem_Click);
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(69, 101);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(100, 20);
            this.textBoxX1.TabIndex = 1;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(69, 149);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(100, 20);
            this.textBoxY1.TabIndex = 2;
            // 
            // textBoxZ1
            // 
            this.textBoxZ1.Location = new System.Drawing.Point(69, 200);
            this.textBoxZ1.Name = "textBoxZ1";
            this.textBoxZ1.Size = new System.Drawing.Size(100, 20);
            this.textBoxZ1.TabIndex = 3;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(28, 104);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(17, 13);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "X:";
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(28, 152);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(17, 13);
            this.labelY1.TabIndex = 0;
            this.labelY1.Text = "Y:";
            // 
            // labelZ1
            // 
            this.labelZ1.AutoSize = true;
            this.labelZ1.Location = new System.Drawing.Point(28, 203);
            this.labelZ1.Name = "labelZ1";
            this.labelZ1.Size = new System.Drawing.Size(17, 13);
            this.labelZ1.TabIndex = 0;
            this.labelZ1.Text = "Z:";
            // 
            // labelVect2
            // 
            this.labelVect2.AutoSize = true;
            this.labelVect2.Location = new System.Drawing.Point(235, 61);
            this.labelVect2.Name = "labelVect2";
            this.labelVect2.Size = new System.Drawing.Size(50, 13);
            this.labelVect2.TabIndex = 0;
            this.labelVect2.Text = "Vecteur2";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(197, 104);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(17, 13);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "X:";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(197, 152);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(17, 13);
            this.labelY2.TabIndex = 0;
            this.labelY2.Text = "Y:";
            // 
            // labelZ2
            // 
            this.labelZ2.AutoSize = true;
            this.labelZ2.Location = new System.Drawing.Point(197, 203);
            this.labelZ2.Name = "labelZ2";
            this.labelZ2.Size = new System.Drawing.Size(17, 13);
            this.labelZ2.TabIndex = 0;
            this.labelZ2.Text = "Z:";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(238, 101);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(100, 20);
            this.textBoxX2.TabIndex = 4;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(238, 149);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(100, 20);
            this.textBoxY2.TabIndex = 5;
            // 
            // textBoxZ2
            // 
            this.textBoxZ2.Location = new System.Drawing.Point(238, 200);
            this.textBoxZ2.Name = "textBoxZ2";
            this.textBoxZ2.Size = new System.Drawing.Size(100, 20);
            this.textBoxZ2.TabIndex = 6;
            // 
            // labelResultat
            // 
            this.labelResultat.AutoSize = true;
            this.labelResultat.Location = new System.Drawing.Point(405, 61);
            this.labelResultat.Name = "labelResultat";
            this.labelResultat.Size = new System.Drawing.Size(46, 13);
            this.labelResultat.TabIndex = 0;
            this.labelResultat.Text = "Résultat";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(367, 104);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(17, 13);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "X:";
            // 
            // labelY3
            // 
            this.labelY3.AutoSize = true;
            this.labelY3.Location = new System.Drawing.Point(367, 152);
            this.labelY3.Name = "labelY3";
            this.labelY3.Size = new System.Drawing.Size(17, 13);
            this.labelY3.TabIndex = 0;
            this.labelY3.Text = "Y:";
            // 
            // labelZ3
            // 
            this.labelZ3.AutoSize = true;
            this.labelZ3.Location = new System.Drawing.Point(367, 203);
            this.labelZ3.Name = "labelZ3";
            this.labelZ3.Size = new System.Drawing.Size(17, 13);
            this.labelZ3.TabIndex = 0;
            this.labelZ3.Text = "Z:";
            // 
            // textBoxX3
            // 
            this.textBoxX3.Location = new System.Drawing.Point(408, 101);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(100, 20);
            this.textBoxX3.TabIndex = 7;
            // 
            // textBoxY3
            // 
            this.textBoxY3.Location = new System.Drawing.Point(408, 149);
            this.textBoxY3.Name = "textBoxY3";
            this.textBoxY3.Size = new System.Drawing.Size(100, 20);
            this.textBoxY3.TabIndex = 8;
            // 
            // textBoxZ3
            // 
            this.textBoxZ3.Location = new System.Drawing.Point(408, 200);
            this.textBoxZ3.Name = "textBoxZ3";
            this.textBoxZ3.Size = new System.Drawing.Size(100, 20);
            this.textBoxZ3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 277);
            this.Controls.Add(this.textBoxZ3);
            this.Controls.Add(this.textBoxZ2);
            this.Controls.Add(this.textBoxZ1);
            this.Controls.Add(this.textBoxY3);
            this.Controls.Add(this.textBoxX3);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.labelZ3);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.labelZ2);
            this.Controls.Add(this.labelY3);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelZ1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelResultat);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelVect2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelVect1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Vecteur";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVect1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opérationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitScalaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitVectorielToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxZ1;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label labelZ1;
        private System.Windows.Forms.Label labelVect2;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Label labelZ2;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxZ2;
        private System.Windows.Forms.Label labelResultat;
        private System.Windows.Forms.Label labelX3;
        private System.Windows.Forms.Label labelY3;
        private System.Windows.Forms.Label labelZ3;
        private System.Windows.Forms.TextBox textBoxX3;
        private System.Windows.Forms.TextBox textBoxY3;
        private System.Windows.Forms.TextBox textBoxZ3;
    }
}

