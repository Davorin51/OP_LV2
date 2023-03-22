
namespace WindowsFormsApp3
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
            this.gbObject = new System.Windows.Forms.GroupBox();
            this.rbElipsa = new System.Windows.Forms.RadioButton();
            this.rbKruznica = new System.Windows.Forms.RadioButton();
            this.rbLinija = new System.Windows.Forms.RadioButton();
            this.rbKvadrat = new System.Windows.Forms.RadioButton();
            this.rbPoligon = new System.Windows.Forms.RadioButton();
            this.gbBoja = new System.Windows.Forms.GroupBox();
            this.rbCrvena = new System.Windows.Forms.RadioButton();
            this.rbCrna = new System.Windows.Forms.RadioButton();
            this.rbPlava = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.gbObject.SuspendLayout();
            this.gbBoja.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbObject
            // 
            this.gbObject.Controls.Add(this.rbElipsa);
            this.gbObject.Controls.Add(this.rbKruznica);
            this.gbObject.Controls.Add(this.rbLinija);
            this.gbObject.Controls.Add(this.rbKvadrat);
            this.gbObject.Controls.Add(this.rbPoligon);
            this.gbObject.Location = new System.Drawing.Point(574, 24);
            this.gbObject.Name = "gbObject";
            this.gbObject.Size = new System.Drawing.Size(200, 205);
            this.gbObject.TabIndex = 0;
            this.gbObject.TabStop = false;
            this.gbObject.Text = "grafObject";
            this.gbObject.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbElipsa
            // 
            this.rbElipsa.AutoSize = true;
            this.rbElipsa.Location = new System.Drawing.Point(7, 130);
            this.rbElipsa.Name = "rbElipsa";
            this.rbElipsa.Size = new System.Drawing.Size(67, 21);
            this.rbElipsa.TabIndex = 4;
            this.rbElipsa.TabStop = true;
            this.rbElipsa.Text = "Elipsa";
            this.rbElipsa.UseVisualStyleBackColor = true;
            // 
            // rbKruznica
            // 
            this.rbKruznica.AutoSize = true;
            this.rbKruznica.Location = new System.Drawing.Point(7, 103);
            this.rbKruznica.Name = "rbKruznica";
            this.rbKruznica.Size = new System.Drawing.Size(84, 21);
            this.rbKruznica.TabIndex = 3;
            this.rbKruznica.TabStop = true;
            this.rbKruznica.Text = "Kruznica";
            this.rbKruznica.UseVisualStyleBackColor = true;
            // 
            // rbLinija
            // 
            this.rbLinija.AutoSize = true;
            this.rbLinija.Location = new System.Drawing.Point(7, 76);
            this.rbLinija.Name = "rbLinija";
            this.rbLinija.Size = new System.Drawing.Size(62, 21);
            this.rbLinija.TabIndex = 2;
            this.rbLinija.TabStop = true;
            this.rbLinija.Text = "Linija";
            this.rbLinija.UseVisualStyleBackColor = true;
            // 
            // rbKvadrat
            // 
            this.rbKvadrat.AutoSize = true;
            this.rbKvadrat.Location = new System.Drawing.Point(7, 49);
            this.rbKvadrat.Name = "rbKvadrat";
            this.rbKvadrat.Size = new System.Drawing.Size(78, 21);
            this.rbKvadrat.TabIndex = 1;
            this.rbKvadrat.TabStop = true;
            this.rbKvadrat.Text = "Kvadrat";
            this.rbKvadrat.UseVisualStyleBackColor = true;
            // 
            // rbPoligon
            // 
            this.rbPoligon.AutoSize = true;
            this.rbPoligon.Location = new System.Drawing.Point(7, 22);
            this.rbPoligon.Name = "rbPoligon";
            this.rbPoligon.Size = new System.Drawing.Size(76, 21);
            this.rbPoligon.TabIndex = 0;
            this.rbPoligon.TabStop = true;
            this.rbPoligon.Text = "Poligon";
            this.rbPoligon.UseVisualStyleBackColor = true;
            // 
            // gbBoja
            // 
            this.gbBoja.Controls.Add(this.rbCrvena);
            this.gbBoja.Controls.Add(this.rbCrna);
            this.gbBoja.Controls.Add(this.rbPlava);
            this.gbBoja.Location = new System.Drawing.Point(574, 235);
            this.gbBoja.Name = "gbBoja";
            this.gbBoja.Size = new System.Drawing.Size(200, 205);
            this.gbBoja.TabIndex = 1;
            this.gbBoja.TabStop = false;
            this.gbBoja.Text = "Boje";
            // 
            // rbCrvena
            // 
            this.rbCrvena.AutoSize = true;
            this.rbCrvena.Location = new System.Drawing.Point(7, 84);
            this.rbCrvena.Name = "rbCrvena";
            this.rbCrvena.Size = new System.Drawing.Size(74, 21);
            this.rbCrvena.TabIndex = 7;
            this.rbCrvena.TabStop = true;
            this.rbCrvena.Text = "Crvena";
            this.rbCrvena.UseVisualStyleBackColor = true;
            // 
            // rbCrna
            // 
            this.rbCrna.AutoSize = true;
            this.rbCrna.Location = new System.Drawing.Point(7, 111);
            this.rbCrna.Name = "rbCrna";
            this.rbCrna.Size = new System.Drawing.Size(59, 21);
            this.rbCrna.TabIndex = 6;
            this.rbCrna.TabStop = true;
            this.rbCrna.Text = "Crna";
            this.rbCrna.UseVisualStyleBackColor = true;
            // 
            // rbPlava
            // 
            this.rbPlava.AutoSize = true;
            this.rbPlava.Location = new System.Drawing.Point(7, 57);
            this.rbPlava.Name = "rbPlava";
            this.rbPlava.Size = new System.Drawing.Size(64, 21);
            this.rbPlava.TabIndex = 5;
            this.rbPlava.TabStop = true;
            this.rbPlava.Text = "Plava";
            this.rbPlava.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(273, 346);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(154, 345);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 96);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(37, 346);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(100, 96);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbBoja);
            this.Controls.Add(this.gbObject);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.gbObject.ResumeLayout(false);
            this.gbObject.PerformLayout();
            this.gbBoja.ResumeLayout(false);
            this.gbBoja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbObject;
        private System.Windows.Forms.RadioButton rbElipsa;
        private System.Windows.Forms.RadioButton rbKruznica;
        private System.Windows.Forms.RadioButton rbLinija;
        private System.Windows.Forms.RadioButton rbKvadrat;
        private System.Windows.Forms.RadioButton rbPoligon;
        private System.Windows.Forms.GroupBox gbBoja;
        private System.Windows.Forms.RadioButton rbCrvena;
        private System.Windows.Forms.RadioButton rbCrna;
        private System.Windows.Forms.RadioButton rbPlava;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}

