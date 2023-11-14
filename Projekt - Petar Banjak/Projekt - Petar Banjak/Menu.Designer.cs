namespace Projekt___Petar_Banjak
{
    partial class Menu
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
            this.impuls = new System.Windows.Forms.Button();
            this.valnaDuljina = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // impuls
            // 
            this.impuls.BackColor = System.Drawing.Color.White;
            this.impuls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impuls.ForeColor = System.Drawing.Color.Black;
            this.impuls.Location = new System.Drawing.Point(187, 120);
            this.impuls.Name = "impuls";
            this.impuls.Size = new System.Drawing.Size(120, 60);
            this.impuls.TabIndex = 0;
            this.impuls.Text = "Zakon očuvanja impulsa";
            this.impuls.UseVisualStyleBackColor = false;
            this.impuls.Click += new System.EventHandler(this.impuls_Click);
            // 
            // valnaDuljina
            // 
            this.valnaDuljina.BackColor = System.Drawing.Color.White;
            this.valnaDuljina.ForeColor = System.Drawing.Color.Black;
            this.valnaDuljina.Location = new System.Drawing.Point(432, 120);
            this.valnaDuljina.Name = "valnaDuljina";
            this.valnaDuljina.Size = new System.Drawing.Size(120, 60);
            this.valnaDuljina.TabIndex = 1;
            this.valnaDuljina.Text = "Valna duljina i frekvencija";
            this.valnaDuljina.UseVisualStyleBackColor = false;
            this.valnaDuljina.Click += new System.EventHandler(this.valnaDuljina_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(307, 241);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(120, 60);
            this.exit.TabIndex = 2;
            this.exit.Text = "Izlaz";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odaberi što želiš izračunati";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.valnaDuljina);
            this.Controls.Add(this.impuls);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button impuls;
        private System.Windows.Forms.Button valnaDuljina;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
    }
}

