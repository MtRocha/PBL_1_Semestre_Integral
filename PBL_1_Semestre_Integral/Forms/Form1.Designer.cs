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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(391, 12);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(600, 600);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(600, 600);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
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
            this.OpcaoDeCalculo.Location = new System.Drawing.Point(28, 44);
            this.OpcaoDeCalculo.Name = "OpcaoDeCalculo";
            this.OpcaoDeCalculo.Size = new System.Drawing.Size(301, 21);
            this.OpcaoDeCalculo.TabIndex = 1;
            this.OpcaoDeCalculo.SelectedIndexChanged += new System.EventHandler(this.OpcaoDeCalculo_SelectedIndexChanged);
            // 
            // CoeficienteSegundGrau1
            // 
            this.CoeficienteSegundGrau1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoeficienteSegundGrau1.Location = new System.Drawing.Point(255, 161);
            this.CoeficienteSegundGrau1.Name = "CoeficienteSegundGrau1";
            this.CoeficienteSegundGrau1.Size = new System.Drawing.Size(56, 26);
            this.CoeficienteSegundGrau1.TabIndex = 2;
            // 
            // CoeficienteSegundGrau2
            // 
            this.CoeficienteSegundGrau2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoeficienteSegundGrau2.Location = new System.Drawing.Point(152, 161);
            this.CoeficienteSegundGrau2.Name = "CoeficienteSegundGrau2";
            this.CoeficienteSegundGrau2.Size = new System.Drawing.Size(60, 26);
            this.CoeficienteSegundGrau2.TabIndex = 3;
            // 
            // CoeficienteSegundGrau3
            // 
            this.CoeficienteSegundGrau3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoeficienteSegundGrau3.Location = new System.Drawing.Point(50, 161);
            this.CoeficienteSegundGrau3.Name = "CoeficienteSegundGrau3";
            this.CoeficienteSegundGrau3.Size = new System.Drawing.Size(55, 26);
            this.CoeficienteSegundGrau3.TabIndex = 4;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(50, 515);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(261, 56);
            this.Calcular.TabIndex = 5;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione o Tipo de Função";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PBL_1_Semestre_Integral.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(50, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 54);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1003, 645);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

