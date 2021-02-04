namespace TP3
{
    partial class Devise
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
            this.label_taux = new System.Windows.Forms.Label();
            this.textBox_taux = new System.Windows.Forms.TextBox();
            this.label_devise_1 = new System.Windows.Forms.Label();
            this.textBox_devise1 = new System.Windows.Forms.TextBox();
            this.button_convertir = new System.Windows.Forms.Button();
            this.label_devise_2 = new System.Windows.Forms.Label();
            this.label_resultat_devise2 = new System.Windows.Forms.Label();
            this.radioButtonEuros_Dollars = new System.Windows.Forms.RadioButton();
            this.radioButtonDollars_Euros = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label_taux
            // 
            this.label_taux.AutoSize = true;
            this.label_taux.Location = new System.Drawing.Point(49, 44);
            this.label_taux.Name = "label_taux";
            this.label_taux.Size = new System.Drawing.Size(107, 13);
            this.label_taux.TabIndex = 0;
            this.label_taux.Text = "Taux de conversion :";
            this.label_taux.Click += new System.EventHandler(this.label_taux_Click);
            // 
            // textBox_taux
            // 
            this.textBox_taux.Location = new System.Drawing.Point(162, 41);
            this.textBox_taux.Name = "textBox_taux";
            this.textBox_taux.Size = new System.Drawing.Size(155, 20);
            this.textBox_taux.TabIndex = 1;
            // 
            // label_devise_1
            // 
            this.label_devise_1.AutoSize = true;
            this.label_devise_1.Location = new System.Drawing.Point(49, 103);
            this.label_devise_1.Name = "label_devise_1";
            this.label_devise_1.Size = new System.Drawing.Size(34, 13);
            this.label_devise_1.TabIndex = 2;
            this.label_devise_1.Text = "Euros";
            // 
            // textBox_devise1
            // 
            this.textBox_devise1.Location = new System.Drawing.Point(52, 120);
            this.textBox_devise1.Name = "textBox_devise1";
            this.textBox_devise1.Size = new System.Drawing.Size(104, 20);
            this.textBox_devise1.TabIndex = 3;
            // 
            // button_convertir
            // 
            this.button_convertir.Location = new System.Drawing.Point(162, 118);
            this.button_convertir.Name = "button_convertir";
            this.button_convertir.Size = new System.Drawing.Size(110, 23);
            this.button_convertir.TabIndex = 4;
            this.button_convertir.Text = "->";
            this.button_convertir.UseVisualStyleBackColor = true;
            this.button_convertir.Click += new System.EventHandler(this.button_convertir_Click);
            // 
            // label_devise_2
            // 
            this.label_devise_2.AutoSize = true;
            this.label_devise_2.Location = new System.Drawing.Point(278, 103);
            this.label_devise_2.Name = "label_devise_2";
            this.label_devise_2.Size = new System.Drawing.Size(39, 13);
            this.label_devise_2.TabIndex = 5;
            this.label_devise_2.Text = "Dollars";
            // 
            // label_resultat_devise2
            // 
            this.label_resultat_devise2.AutoSize = true;
            this.label_resultat_devise2.Location = new System.Drawing.Point(278, 123);
            this.label_resultat_devise2.Name = "label_resultat_devise2";
            this.label_resultat_devise2.Size = new System.Drawing.Size(35, 13);
            this.label_resultat_devise2.TabIndex = 6;
            this.label_resultat_devise2.Text = "label1";
            // 
            // radioButtonEuros_Dollars
            // 
            this.radioButtonEuros_Dollars.AutoSize = true;
            this.radioButtonEuros_Dollars.Checked = true;
            this.radioButtonEuros_Dollars.Location = new System.Drawing.Point(52, 172);
            this.radioButtonEuros_Dollars.Name = "radioButtonEuros_Dollars";
            this.radioButtonEuros_Dollars.Size = new System.Drawing.Size(99, 17);
            this.radioButtonEuros_Dollars.TabIndex = 7;
            this.radioButtonEuros_Dollars.TabStop = true;
            this.radioButtonEuros_Dollars.Text = "Euros -> Dollars";
            this.radioButtonEuros_Dollars.UseVisualStyleBackColor = true;
            this.radioButtonEuros_Dollars.CheckedChanged += new System.EventHandler(this.radioButtonEuros_Dollars_CheckedChanged);
            // 
            // radioButtonDollars_Euros
            // 
            this.radioButtonDollars_Euros.AutoSize = true;
            this.radioButtonDollars_Euros.Location = new System.Drawing.Point(52, 195);
            this.radioButtonDollars_Euros.Name = "radioButtonDollars_Euros";
            this.radioButtonDollars_Euros.Size = new System.Drawing.Size(99, 17);
            this.radioButtonDollars_Euros.TabIndex = 8;
            this.radioButtonDollars_Euros.Text = "Dollars -> Euros";
            this.radioButtonDollars_Euros.UseVisualStyleBackColor = true;
            this.radioButtonDollars_Euros.CheckedChanged += new System.EventHandler(this.radioButtonDollars_Euros_CheckedChanged);
            // 
            // Devise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 242);
            this.Controls.Add(this.radioButtonDollars_Euros);
            this.Controls.Add(this.radioButtonEuros_Dollars);
            this.Controls.Add(this.label_resultat_devise2);
            this.Controls.Add(this.label_devise_2);
            this.Controls.Add(this.button_convertir);
            this.Controls.Add(this.textBox_devise1);
            this.Controls.Add(this.label_devise_1);
            this.Controls.Add(this.textBox_taux);
            this.Controls.Add(this.label_taux);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Devise";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_taux;
        private System.Windows.Forms.TextBox textBox_taux;
        private System.Windows.Forms.Label label_devise_1;
        private System.Windows.Forms.TextBox textBox_devise1;
        private System.Windows.Forms.Button button_convertir;
        private System.Windows.Forms.Label label_devise_2;
        private System.Windows.Forms.Label label_resultat_devise2;
        private System.Windows.Forms.RadioButton radioButtonEuros_Dollars;
        private System.Windows.Forms.RadioButton radioButtonDollars_Euros;
    }
}

