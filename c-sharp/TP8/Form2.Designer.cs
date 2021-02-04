namespace TP8
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelLat = new System.Windows.Forms.Label();
            this.textBoxLatDeg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLatMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLatSec = new System.Windows.Forms.TextBox();
            this.labelLong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLongDeg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLongMin = new System.Windows.Forms.TextBox();
            this.textBoxLongSec = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Coordonnées";
            this.notifyIcon1.Visible = true;
            // 
            // labelLat
            // 
            this.labelLat.AutoSize = true;
            this.labelLat.Location = new System.Drawing.Point(12, 9);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(45, 13);
            this.labelLat.TabIndex = 0;
            this.labelLat.Text = "Latitude";
            // 
            // textBoxLatDeg
            // 
            this.textBoxLatDeg.Location = new System.Drawing.Point(15, 46);
            this.textBoxLatDeg.Name = "textBoxLatDeg";
            this.textBoxLatDeg.Size = new System.Drawing.Size(100, 20);
            this.textBoxLatDeg.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "°";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "\'";
            // 
            // textBoxLatMin
            // 
            this.textBoxLatMin.Location = new System.Drawing.Point(186, 46);
            this.textBoxLatMin.Name = "textBoxLatMin";
            this.textBoxLatMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLatMin.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "\"";
            // 
            // textBoxLatSec
            // 
            this.textBoxLatSec.Location = new System.Drawing.Point(348, 46);
            this.textBoxLatSec.Name = "textBoxLatSec";
            this.textBoxLatSec.Size = new System.Drawing.Size(100, 20);
            this.textBoxLatSec.TabIndex = 2;
            // 
            // labelLong
            // 
            this.labelLong.AutoSize = true;
            this.labelLong.Location = new System.Drawing.Point(12, 100);
            this.labelLong.Name = "labelLong";
            this.labelLong.Size = new System.Drawing.Size(54, 13);
            this.labelLong.TabIndex = 0;
            this.labelLong.Text = "Longitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "°";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(9, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "\'";
            // 
            // textBoxLongDeg
            // 
            this.textBoxLongDeg.Location = new System.Drawing.Point(15, 137);
            this.textBoxLongDeg.Name = "textBoxLongDeg";
            this.textBoxLongDeg.Size = new System.Drawing.Size(100, 20);
            this.textBoxLongDeg.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "\"";
            // 
            // textBoxLongMin
            // 
            this.textBoxLongMin.Location = new System.Drawing.Point(186, 137);
            this.textBoxLongMin.Name = "textBoxLongMin";
            this.textBoxLongMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLongMin.TabIndex = 4;
            // 
            // textBoxLongSec
            // 
            this.textBoxLongSec.Location = new System.Drawing.Point(348, 137);
            this.textBoxLongSec.Name = "textBoxLongSec";
            this.textBoxLongSec.Size = new System.Drawing.Size(100, 20);
            this.textBoxLongSec.TabIndex = 5;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(295, 196);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(391, 196);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 7;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 236);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxLongSec);
            this.Controls.Add(this.textBoxLatSec);
            this.Controls.Add(this.textBoxLongMin);
            this.Controls.Add(this.textBoxLatMin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLongDeg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxLatDeg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelLong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLat);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.TextBox textBoxLatDeg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLatMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLatSec;
        private System.Windows.Forms.Label labelLong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLongDeg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLongMin;
        private System.Windows.Forms.TextBox textBoxLongSec;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}