
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPodziel = new System.Windows.Forms.RadioButton();
            this.cbPomnoz = new System.Windows.Forms.RadioButton();
            this.cbOdejmij = new System.Windows.Forms.RadioButton();
            this.cbDodaj = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 23);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liczba1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liczba2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPodziel);
            this.groupBox1.Controls.Add(this.cbPomnoz);
            this.groupBox1.Controls.Add(this.cbOdejmij);
            this.groupBox1.Controls.Add(this.cbDodaj);
            this.groupBox1.Location = new System.Drawing.Point(139, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 147);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Działanie:";
            // 
            // cbPodziel
            // 
            this.cbPodziel.AutoSize = true;
            this.cbPodziel.Location = new System.Drawing.Point(7, 100);
            this.cbPodziel.Name = "cbPodziel";
            this.cbPodziel.Size = new System.Drawing.Size(63, 19);
            this.cbPodziel.TabIndex = 3;
            this.cbPodziel.Text = "Podziel";
            this.cbPodziel.UseVisualStyleBackColor = true;
            // 
            // cbPomnoz
            // 
            this.cbPomnoz.AutoSize = true;
            this.cbPomnoz.Location = new System.Drawing.Point(7, 75);
            this.cbPomnoz.Name = "cbPomnoz";
            this.cbPomnoz.Size = new System.Drawing.Size(69, 19);
            this.cbPomnoz.TabIndex = 2;
            this.cbPomnoz.Text = "Pomnóż";
            this.cbPomnoz.UseVisualStyleBackColor = true;
            // 
            // cbOdejmij
            // 
            this.cbOdejmij.AutoSize = true;
            this.cbOdejmij.Location = new System.Drawing.Point(7, 49);
            this.cbOdejmij.Name = "cbOdejmij";
            this.cbOdejmij.Size = new System.Drawing.Size(67, 19);
            this.cbOdejmij.TabIndex = 1;
            this.cbOdejmij.Text = "Odejmij";
            this.cbOdejmij.UseVisualStyleBackColor = true;
            // 
            // cbDodaj
            // 
            this.cbDodaj.AutoSize = true;
            this.cbDodaj.Checked = true;
            this.cbDodaj.Location = new System.Drawing.Point(7, 23);
            this.cbDodaj.Name = "cbDodaj";
            this.cbDodaj.Size = new System.Drawing.Size(56, 19);
            this.cbDodaj.TabIndex = 0;
            this.cbDodaj.TabStop = true;
            this.cbDodaj.Text = "Dodaj";
            this.cbDodaj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 286);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kamil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cbPodziel;
        private System.Windows.Forms.RadioButton cbPomnoz;
        private System.Windows.Forms.RadioButton cbOdejmij;
        private System.Windows.Forms.RadioButton cbDodaj;
    }
}

