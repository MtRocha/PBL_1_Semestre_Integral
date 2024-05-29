namespace PBL_1_Semestre_Integral
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpcaoDeCalculo = new System.Windows.Forms.ComboBox();
            this.CoeficienteSegundGrau1 = new System.Windows.Forms.TextBox();
            this.CoeficienteSegundGrau2 = new System.Windows.Forms.TextBox();
            this.CoeficienteSegundGrau3 = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(365, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 626);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // OpcaoDeCalculo
            // 
            this.OpcaoDeCalculo.FormattingEnabled = true;
            this.OpcaoDeCalculo.Items.AddRange(new object[] {
            "Segundo grau",
            "Seno",
            "Cosseno",
            "Tangente",
            "Logaritmo Natural",
            "Logaritmo Base 10"});
            this.OpcaoDeCalculo.Location = new System.Drawing.Point(41, 59);
            this.OpcaoDeCalculo.Name = "OpcaoDeCalculo";
            this.OpcaoDeCalculo.Size = new System.Drawing.Size(301, 21);
            this.OpcaoDeCalculo.TabIndex = 1;
            // 
            // CoeficienteSegundGrau1
            // 
            this.CoeficienteSegundGrau1.Location = new System.Drawing.Point(41, 162);
            this.CoeficienteSegundGrau1.Name = "CoeficienteSegundGrau1";
            this.CoeficienteSegundGrau1.Size = new System.Drawing.Size(264, 20);
            this.CoeficienteSegundGrau1.TabIndex = 2;
            // 
            // CoeficienteSegundGrau2
            // 
            this.CoeficienteSegundGrau2.Location = new System.Drawing.Point(41, 208);
            this.CoeficienteSegundGrau2.Name = "CoeficienteSegundGrau2";
            this.CoeficienteSegundGrau2.Size = new System.Drawing.Size(263, 20);
            this.CoeficienteSegundGrau2.TabIndex = 3;
            // 
            // CoeficienteSegundGrau3
            // 
            this.CoeficienteSegundGrau3.Location = new System.Drawing.Point(41, 255);
            this.CoeficienteSegundGrau3.Name = "CoeficienteSegundGrau3";
            this.CoeficienteSegundGrau3.Size = new System.Drawing.Size(261, 20);
            this.CoeficienteSegundGrau3.TabIndex = 4;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(46, 301);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(94, 30);
            this.Calcular.TabIndex = 5;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1003, 645);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.CoeficienteSegundGrau3);
            this.Controls.Add(this.CoeficienteSegundGrau2);
            this.Controls.Add(this.CoeficienteSegundGrau1);
            this.Controls.Add(this.OpcaoDeCalculo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora Integral";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox OpcaoDeCalculo;
        private System.Windows.Forms.TextBox CoeficienteSegundGrau1;
        private System.Windows.Forms.TextBox CoeficienteSegundGrau2;
        private System.Windows.Forms.TextBox CoeficienteSegundGrau3;
        private System.Windows.Forms.Button Calcular;
    }
}

