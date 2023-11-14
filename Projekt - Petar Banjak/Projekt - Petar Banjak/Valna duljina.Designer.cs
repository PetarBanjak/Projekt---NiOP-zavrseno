namespace Projekt___Petar_Banjak
{
    partial class Valna_duljina
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back2 = new System.Windows.Forms.Button();
            this.izracunajValnu = new System.Windows.Forms.Button();
            this.rezultatValna = new System.Windows.Forms.Label();
            this.frekvencija = new System.Windows.Forms.TextBox();
            this.brzina2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Unesi frekvenciju";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Unesi brzinu";
            // 
            // back2
            // 
            this.back2.BackColor = System.Drawing.Color.White;
            this.back2.Location = new System.Drawing.Point(311, 340);
            this.back2.Name = "back2";
            this.back2.Size = new System.Drawing.Size(90, 30);
            this.back2.TabIndex = 11;
            this.back2.Text = "Natrag";
            this.back2.UseVisualStyleBackColor = false;
            this.back2.Click += new System.EventHandler(this.back2_Click);
            // 
            // izracunajValnu
            // 
            this.izracunajValnu.BackColor = System.Drawing.Color.White;
            this.izracunajValnu.Location = new System.Drawing.Point(311, 258);
            this.izracunajValnu.Name = "izracunajValnu";
            this.izracunajValnu.Size = new System.Drawing.Size(90, 30);
            this.izracunajValnu.TabIndex = 10;
            this.izracunajValnu.Text = "Izračunaj";
            this.izracunajValnu.UseVisualStyleBackColor = false;
            this.izracunajValnu.Click += new System.EventHandler(this.izracunajValnu_Click);
            // 
            // rezultatValna
            // 
            this.rezultatValna.AutoSize = true;
            this.rezultatValna.Location = new System.Drawing.Point(310, 189);
            this.rezultatValna.Name = "rezultatValna";
            this.rezultatValna.Size = new System.Drawing.Size(91, 13);
            this.rezultatValna.TabIndex = 9;
            this.rezultatValna.Text = "______________";
            // 
            // frekvencija
            // 
            this.frekvencija.Location = new System.Drawing.Point(398, 135);
            this.frekvencija.Name = "frekvencija";
            this.frekvencija.Size = new System.Drawing.Size(100, 20);
            this.frekvencija.TabIndex = 8;
            // 
            // brzina2
            // 
            this.brzina2.Location = new System.Drawing.Point(205, 135);
            this.brzina2.Name = "brzina2";
            this.brzina2.Size = new System.Drawing.Size(100, 20);
            this.brzina2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Valna duljina i frekvencija";
            // 
            // Valna_duljina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back2);
            this.Controls.Add(this.izracunajValnu);
            this.Controls.Add(this.rezultatValna);
            this.Controls.Add(this.frekvencija);
            this.Controls.Add(this.brzina2);
            this.Name = "Valna_duljina";
            this.Text = "Valna_duljina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back2;
        private System.Windows.Forms.Button izracunajValnu;
        private System.Windows.Forms.Label rezultatValna;
        private System.Windows.Forms.TextBox frekvencija;
        private System.Windows.Forms.TextBox brzina2;
        private System.Windows.Forms.Label label3;
    }
}