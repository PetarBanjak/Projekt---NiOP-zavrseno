namespace Projekt___Petar_Banjak
{
    partial class Impuls
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
            this.brzina = new System.Windows.Forms.TextBox();
            this.masa = new System.Windows.Forms.TextBox();
            this.rezultatImpuls = new System.Windows.Forms.Label();
            this.izracunajImpuls = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // brzina
            // 
            this.brzina.Location = new System.Drawing.Point(205, 135);
            this.brzina.Name = "brzina";
            this.brzina.Size = new System.Drawing.Size(100, 20);
            this.brzina.TabIndex = 0;
            // 
            // masa
            // 
            this.masa.Location = new System.Drawing.Point(398, 135);
            this.masa.Name = "masa";
            this.masa.Size = new System.Drawing.Size(100, 20);
            this.masa.TabIndex = 1;
            // 
            // rezultatImpuls
            // 
            this.rezultatImpuls.AutoSize = true;
            this.rezultatImpuls.Location = new System.Drawing.Point(310, 189);
            this.rezultatImpuls.Name = "rezultatImpuls";
            this.rezultatImpuls.Size = new System.Drawing.Size(91, 13);
            this.rezultatImpuls.TabIndex = 2;
            this.rezultatImpuls.Text = "______________";
            // 
            // izracunajImpuls
            // 
            this.izracunajImpuls.BackColor = System.Drawing.Color.White;
            this.izracunajImpuls.Location = new System.Drawing.Point(311, 258);
            this.izracunajImpuls.Name = "izracunajImpuls";
            this.izracunajImpuls.Size = new System.Drawing.Size(90, 30);
            this.izracunajImpuls.TabIndex = 3;
            this.izracunajImpuls.Text = "Izračunaj";
            this.izracunajImpuls.UseVisualStyleBackColor = false;
            this.izracunajImpuls.Click += new System.EventHandler(this.izracunajImpuls_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(311, 340);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(90, 30);
            this.back.TabIndex = 4;
            this.back.Text = "Natrag";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unesi brzinu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Unesi masu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Zakon očuvanja impulsa";
            // 
            // Impuls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.izracunajImpuls);
            this.Controls.Add(this.rezultatImpuls);
            this.Controls.Add(this.masa);
            this.Controls.Add(this.brzina);
            this.Name = "Impuls";
            this.Text = "Impuls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox brzina;
        private System.Windows.Forms.TextBox masa;
        private System.Windows.Forms.Label rezultatImpuls;
        private System.Windows.Forms.Button izracunajImpuls;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}