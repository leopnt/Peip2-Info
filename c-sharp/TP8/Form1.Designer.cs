namespace TP8
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pointsDinterêtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewPOIs = new System.Windows.Forms.ListView();
            this.Latitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Longitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreDePOIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointsDinterêtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pointsDinterêtToolStripMenuItem
            // 
            this.pointsDinterêtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.nombreDePOIToolStripMenuItem});
            this.pointsDinterêtToolStripMenuItem.Name = "pointsDinterêtToolStripMenuItem";
            this.pointsDinterêtToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.pointsDinterêtToolStripMenuItem.Text = "Points D\'intérêt";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // listViewPOIs
            // 
            this.listViewPOIs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Latitude,
            this.Longitude});
            this.listViewPOIs.HideSelection = false;
            this.listViewPOIs.Location = new System.Drawing.Point(12, 37);
            this.listViewPOIs.Name = "listViewPOIs";
            this.listViewPOIs.Size = new System.Drawing.Size(519, 187);
            this.listViewPOIs.TabIndex = 1;
            this.listViewPOIs.UseCompatibleStateImageBehavior = false;
            this.listViewPOIs.View = System.Windows.Forms.View.Details;
            this.listViewPOIs.SelectedIndexChanged += new System.EventHandler(this.listViewPOIs_SelectedIndexChanged);
            // 
            // Latitude
            // 
            this.Latitude.Text = "Latitude";
            // 
            // Longitude
            // 
            this.Longitude.Text = "Longitude";
            // 
            // nombreDePOIToolStripMenuItem
            // 
            this.nombreDePOIToolStripMenuItem.Name = "nombreDePOIToolStripMenuItem";
            this.nombreDePOIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nombreDePOIToolStripMenuItem.Text = "Nombre de POI";
            this.nombreDePOIToolStripMenuItem.Click += new System.EventHandler(this.nombreDePOIToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewPOIs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Coordonnées";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pointsDinterêtToolStripMenuItem;
        private System.Windows.Forms.ListView listViewPOIs;
        private System.Windows.Forms.ColumnHeader Latitude;
        private System.Windows.Forms.ColumnHeader Longitude;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDePOIToolStripMenuItem;
    }
}

