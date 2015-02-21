namespace Utility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.temp = new System.Windows.Forms.TabPage();
            this.canc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fahrenheit = new System.Windows.Forms.TextBox();
            this.kelvin = new System.Windows.Forms.TextBox();
            this.celsius = new System.Windows.Forms.TextBox();
            this.Ok1 = new System.Windows.Forms.Button();
            this.numbers = new System.Windows.Forms.TabPage();
            this.risultato = new System.Windows.Forms.Label();
            this.nOrigine = new System.Windows.Forms.TextBox();
            this.Ok2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.baseCust = new System.Windows.Forms.NumericUpDown();
            this.vectors = new System.Windows.Forms.TabPage();
            this.k = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.risultatoVett = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.B2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.A2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Ok3 = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.TextBox();
            this.molt = new System.Windows.Forms.RadioButton();
            this.Addition = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.temp.SuspendLayout();
            this.numbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseCust)).BeginInit();
            this.vectors.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.temp);
            this.tabControl1.Controls.Add(this.numbers);
            this.tabControl1.Controls.Add(this.vectors);
            this.tabControl1.Location = new System.Drawing.Point(14, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(491, 281);
            this.tabControl1.TabIndex = 0;
            // 
            // temp
            // 
            this.temp.Controls.Add(this.canc);
            this.temp.Controls.Add(this.label3);
            this.temp.Controls.Add(this.label2);
            this.temp.Controls.Add(this.label1);
            this.temp.Controls.Add(this.fahrenheit);
            this.temp.Controls.Add(this.kelvin);
            this.temp.Controls.Add(this.celsius);
            this.temp.Controls.Add(this.Ok1);
            this.temp.Location = new System.Drawing.Point(4, 23);
            this.temp.Name = "temp";
            this.temp.Padding = new System.Windows.Forms.Padding(3);
            this.temp.Size = new System.Drawing.Size(483, 254);
            this.temp.TabIndex = 0;
            this.temp.Text = "Temperature";
            this.temp.UseVisualStyleBackColor = true;
            // 
            // canc
            // 
            this.canc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.canc.Location = new System.Drawing.Point(294, 221);
            this.canc.Name = "canc";
            this.canc.Size = new System.Drawing.Size(87, 25);
            this.canc.TabIndex = 8;
            this.canc.Text = "CANC";
            this.canc.UseVisualStyleBackColor = true;
            this.canc.Click += new System.EventHandler(this.canc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "C° Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "C° Kelvin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "C° Celsius";
            // 
            // fahrenheit
            // 
            this.fahrenheit.Location = new System.Drawing.Point(6, 60);
            this.fahrenheit.Name = "fahrenheit";
            this.fahrenheit.Size = new System.Drawing.Size(154, 22);
            this.fahrenheit.TabIndex = 3;
            // 
            // kelvin
            // 
            this.kelvin.Location = new System.Drawing.Point(6, 33);
            this.kelvin.Name = "kelvin";
            this.kelvin.Size = new System.Drawing.Size(154, 22);
            this.kelvin.TabIndex = 2;
            // 
            // celsius
            // 
            this.celsius.Location = new System.Drawing.Point(6, 6);
            this.celsius.Name = "celsius";
            this.celsius.Size = new System.Drawing.Size(154, 22);
            this.celsius.TabIndex = 1;
            // 
            // Ok1
            // 
            this.Ok1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok1.Location = new System.Drawing.Point(387, 221);
            this.Ok1.Name = "Ok1";
            this.Ok1.Size = new System.Drawing.Size(87, 25);
            this.Ok1.TabIndex = 0;
            this.Ok1.Text = "OK";
            this.Ok1.UseVisualStyleBackColor = true;
            this.Ok1.Click += new System.EventHandler(this.Ok1_Click);
            // 
            // numbers
            // 
            this.numbers.Controls.Add(this.risultato);
            this.numbers.Controls.Add(this.nOrigine);
            this.numbers.Controls.Add(this.Ok2);
            this.numbers.Controls.Add(this.label4);
            this.numbers.Controls.Add(this.baseCust);
            this.numbers.Location = new System.Drawing.Point(4, 23);
            this.numbers.Name = "numbers";
            this.numbers.Padding = new System.Windows.Forms.Padding(3);
            this.numbers.Size = new System.Drawing.Size(483, 254);
            this.numbers.TabIndex = 1;
            this.numbers.Text = "Numbers";
            this.numbers.UseVisualStyleBackColor = true;
            // 
            // risultato
            // 
            this.risultato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.risultato.Location = new System.Drawing.Point(6, 74);
            this.risultato.Name = "risultato";
            this.risultato.Size = new System.Drawing.Size(471, 23);
            this.risultato.TabIndex = 9;
            this.risultato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nOrigine
            // 
            this.nOrigine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nOrigine.Location = new System.Drawing.Point(6, 49);
            this.nOrigine.Name = "nOrigine";
            this.nOrigine.Size = new System.Drawing.Size(471, 22);
            this.nOrigine.TabIndex = 4;
            // 
            // Ok2
            // 
            this.Ok2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok2.Location = new System.Drawing.Point(402, 225);
            this.Ok2.Name = "Ok2";
            this.Ok2.Size = new System.Drawing.Size(75, 23);
            this.Ok2.TabIndex = 3;
            this.Ok2.Text = "OK";
            this.Ok2.UseVisualStyleBackColor = true;
            this.Ok2.Click += new System.EventHandler(this.Ok2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Which base?";
            // 
            // baseCust
            // 
            this.baseCust.AutoSize = true;
            this.baseCust.Location = new System.Drawing.Point(6, 21);
            this.baseCust.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.baseCust.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.baseCust.Name = "baseCust";
            this.baseCust.Size = new System.Drawing.Size(40, 22);
            this.baseCust.TabIndex = 0;
            this.baseCust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.baseCust.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // vectors
            // 
            this.vectors.Controls.Add(this.k);
            this.vectors.Controls.Add(this.label11);
            this.vectors.Controls.Add(this.risultatoVett);
            this.vectors.Controls.Add(this.label8);
            this.vectors.Controls.Add(this.B2);
            this.vectors.Controls.Add(this.label9);
            this.vectors.Controls.Add(this.label10);
            this.vectors.Controls.Add(this.B1);
            this.vectors.Controls.Add(this.label7);
            this.vectors.Controls.Add(this.A2);
            this.vectors.Controls.Add(this.label6);
            this.vectors.Controls.Add(this.label5);
            this.vectors.Controls.Add(this.Ok3);
            this.vectors.Controls.Add(this.A1);
            this.vectors.Controls.Add(this.molt);
            this.vectors.Controls.Add(this.Addition);
            this.vectors.Location = new System.Drawing.Point(4, 23);
            this.vectors.Name = "vectors";
            this.vectors.Size = new System.Drawing.Size(483, 254);
            this.vectors.TabIndex = 2;
            this.vectors.Text = "Vectors";
            this.vectors.UseVisualStyleBackColor = true;
            // 
            // k
            // 
            this.k.Enabled = false;
            this.k.Location = new System.Drawing.Point(219, 48);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(41, 22);
            this.k.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(170, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 14);
            this.label11.TabIndex = 15;
            this.label11.Text = " *    k =";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // risultatoVett
            // 
            this.risultatoVett.Location = new System.Drawing.Point(3, 101);
            this.risultatoVett.Name = "risultatoVett";
            this.risultatoVett.Size = new System.Drawing.Size(257, 24);
            this.risultatoVett.TabIndex = 14;
            this.risultatoVett.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = ")";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(106, 76);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(41, 22);
            this.B2.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 14);
            this.label9.TabIndex = 12;
            this.label9.Text = ";";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 22);
            this.label10.TabIndex = 11;
            this.label10.Text = "B = (";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(43, 76);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(41, 22);
            this.B1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = ")";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(106, 48);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(41, 22);
            this.A2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = ";";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "A = (";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ok3
            // 
            this.Ok3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok3.Location = new System.Drawing.Point(405, 228);
            this.Ok3.Name = "Ok3";
            this.Ok3.Size = new System.Drawing.Size(75, 23);
            this.Ok3.TabIndex = 6;
            this.Ok3.Text = "OK";
            this.Ok3.UseVisualStyleBackColor = true;
            this.Ok3.Click += new System.EventHandler(this.Ok3_Click);
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(43, 48);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(41, 22);
            this.A1.TabIndex = 3;
            // 
            // molt
            // 
            this.molt.AutoSize = true;
            this.molt.Location = new System.Drawing.Point(3, 27);
            this.molt.Name = "molt";
            this.molt.Size = new System.Drawing.Size(98, 18);
            this.molt.TabIndex = 2;
            this.molt.Text = "Multiplication";
            this.molt.UseVisualStyleBackColor = true;
            this.molt.CheckedChanged += new System.EventHandler(this.molt_CheckedChanged);
            // 
            // Addition
            // 
            this.Addition.AutoSize = true;
            this.Addition.Checked = true;
            this.Addition.Location = new System.Drawing.Point(3, 3);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(70, 18);
            this.Addition.TabIndex = 0;
            this.Addition.TabStop = true;
            this.Addition.Text = "Addition";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.CheckedChanged += new System.EventHandler(this.Addition_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 307);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Roboto Lt", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utility";
            this.tabControl1.ResumeLayout(false);
            this.temp.ResumeLayout(false);
            this.temp.PerformLayout();
            this.numbers.ResumeLayout(false);
            this.numbers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseCust)).EndInit();
            this.vectors.ResumeLayout(false);
            this.vectors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage temp;
        private System.Windows.Forms.Button Ok1;
        private System.Windows.Forms.TextBox fahrenheit;
        private System.Windows.Forms.TextBox kelvin;
        private System.Windows.Forms.TextBox celsius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button canc;
        private System.Windows.Forms.TabPage numbers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown baseCust;
        private System.Windows.Forms.Button Ok2;
        private System.Windows.Forms.TextBox nOrigine;
        private System.Windows.Forms.Label risultato;
        private System.Windows.Forms.TabPage vectors;
        private System.Windows.Forms.RadioButton molt;
        private System.Windows.Forms.RadioButton Addition;
        private System.Windows.Forms.TextBox A1;
        private System.Windows.Forms.Button Ok3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox A2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox B2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox B1;
        private System.Windows.Forms.Label risultatoVett;
        private System.Windows.Forms.TextBox k;
        private System.Windows.Forms.Label label11;
    }
}

