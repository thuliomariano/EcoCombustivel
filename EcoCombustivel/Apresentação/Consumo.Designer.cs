namespace EcoCombustivel
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblRodagem = new System.Windows.Forms.Label();
            this.txbKmTotal = new System.Windows.Forms.TextBox();
            this.txbDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblGasolina = new System.Windows.Forms.Label();
            this.lblEconomia = new System.Windows.Forms.Label();
            this.lblAlcool = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPreco2 = new System.Windows.Forms.Label();
            this.lblKm2 = new System.Windows.Forms.Label();
            this.lblPrecoGasolina = new System.Windows.Forms.Label();
            this.txbKmPorLitroGasolina = new System.Windows.Forms.TextBox();
            this.lblKmGasolina = new System.Windows.Forms.Label();
            this.txbPrecoGasolina = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKm1 = new System.Windows.Forms.Label();
            this.lblPreco1 = new System.Windows.Forms.Label();
            this.lblPrecoEtanol = new System.Windows.Forms.Label();
            this.txbKmPorLitroAlcool = new System.Windows.Forms.TextBox();
            this.txbPrecoAlcool = new System.Windows.Forms.TextBox();
            this.lblKmEtanol = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCalcular.FlatAppearance.BorderSize = 300;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(413, 419);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 33);
            this.btnCalcular.TabIndex = 28;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblKm);
            this.groupBox4.Controls.Add(this.lblRodagem);
            this.groupBox4.Controls.Add(this.txbKmTotal);
            this.groupBox4.Controls.Add(this.txbDias);
            this.groupBox4.Controls.Add(this.lblDias);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(65, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(453, 95);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rodagem diaria ou mensal";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKm.Location = new System.Drawing.Point(394, 33);
            this.lblKm.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(30, 20);
            this.lblKm.TabIndex = 13;
            this.lblKm.Text = "Km";
            // 
            // lblRodagem
            // 
            this.lblRodagem.AutoSize = true;
            this.lblRodagem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRodagem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRodagem.Location = new System.Drawing.Point(21, 33);
            this.lblRodagem.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblRodagem.Name = "lblRodagem";
            this.lblRodagem.Size = new System.Drawing.Size(72, 20);
            this.lblRodagem.TabIndex = 17;
            this.lblRodagem.Text = "Rodagem:";
            // 
            // txbKmTotal
            // 
            this.txbKmTotal.Location = new System.Drawing.Point(169, 24);
            this.txbKmTotal.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.txbKmTotal.Name = "txbKmTotal";
            this.txbKmTotal.Size = new System.Drawing.Size(220, 26);
            this.txbKmTotal.TabIndex = 19;
            // 
            // txbDias
            // 
            this.txbDias.Location = new System.Drawing.Point(169, 59);
            this.txbDias.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.txbDias.Name = "txbDias";
            this.txbDias.Size = new System.Drawing.Size(109, 26);
            this.txbDias.TabIndex = 25;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDias.Location = new System.Drawing.Point(21, 62);
            this.lblDias.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(40, 20);
            this.lblDias.TabIndex = 24;
            this.lblDias.Text = "Dias:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.lblResultado);
            this.groupBox3.Controls.Add(this.lblGasolina);
            this.groupBox3.Controls.Add(this.lblEconomia);
            this.groupBox3.Controls.Add(this.lblAlcool);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(65, 456);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.groupBox3.Size = new System.Drawing.Size(453, 86);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(10, 52);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(71, 20);
            this.lblResultado.TabIndex = 14;
            this.lblResultado.Text = "Resultado";
            // 
            // lblGasolina
            // 
            this.lblGasolina.AutoSize = true;
            this.lblGasolina.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasolina.Location = new System.Drawing.Point(290, 21);
            this.lblGasolina.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblGasolina.Name = "lblGasolina";
            this.lblGasolina.Size = new System.Drawing.Size(137, 20);
            this.lblGasolina.TabIndex = 13;
            this.lblGasolina.Text = "Custo com gasolina:";
            // 
            // lblEconomia
            // 
            this.lblEconomia.AutoSize = true;
            this.lblEconomia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEconomia.Location = new System.Drawing.Point(11, 23);
            this.lblEconomia.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblEconomia.Name = "lblEconomia";
            this.lblEconomia.Size = new System.Drawing.Size(76, 20);
            this.lblEconomia.TabIndex = 11;
            this.lblEconomia.Text = "Ecônomia:";
            // 
            // lblAlcool
            // 
            this.lblAlcool.AutoSize = true;
            this.lblAlcool.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlcool.Location = new System.Drawing.Point(127, 21);
            this.lblAlcool.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAlcool.Name = "lblAlcool";
            this.lblAlcool.Size = new System.Drawing.Size(122, 20);
            this.lblAlcool.TabIndex = 12;
            this.lblAlcool.Text = "Custo com alcool:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblPreco2);
            this.groupBox2.Controls.Add(this.lblKm2);
            this.groupBox2.Controls.Add(this.lblPrecoGasolina);
            this.groupBox2.Controls.Add(this.txbKmPorLitroGasolina);
            this.groupBox2.Controls.Add(this.lblKmGasolina);
            this.groupBox2.Controls.Add(this.txbPrecoGasolina);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(65, 202);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.groupBox2.Size = new System.Drawing.Size(453, 91);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gasolina";
            // 
            // lblPreco2
            // 
            this.lblPreco2.AutoSize = true;
            this.lblPreco2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco2.Location = new System.Drawing.Point(398, 23);
            this.lblPreco2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPreco2.Name = "lblPreco2";
            this.lblPreco2.Size = new System.Drawing.Size(25, 20);
            this.lblPreco2.TabIndex = 11;
            this.lblPreco2.Text = "R$";
            // 
            // lblKm2
            // 
            this.lblKm2.AutoSize = true;
            this.lblKm2.BackColor = System.Drawing.Color.Transparent;
            this.lblKm2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm2.Location = new System.Drawing.Point(279, 59);
            this.lblKm2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblKm2.Name = "lblKm2";
            this.lblKm2.Size = new System.Drawing.Size(30, 20);
            this.lblKm2.TabIndex = 8;
            this.lblKm2.Text = "Km";
            // 
            // lblPrecoGasolina
            // 
            this.lblPrecoGasolina.AutoSize = true;
            this.lblPrecoGasolina.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoGasolina.Location = new System.Drawing.Point(11, 26);
            this.lblPrecoGasolina.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPrecoGasolina.Name = "lblPrecoGasolina";
            this.lblPrecoGasolina.Size = new System.Drawing.Size(121, 20);
            this.lblPrecoGasolina.TabIndex = 1;
            this.lblPrecoGasolina.Text = "Preço da gasolina";
            // 
            // txbKmPorLitroGasolina
            // 
            this.txbKmPorLitroGasolina.Location = new System.Drawing.Point(176, 53);
            this.txbKmPorLitroGasolina.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.txbKmPorLitroGasolina.Name = "txbKmPorLitroGasolina";
            this.txbKmPorLitroGasolina.Size = new System.Drawing.Size(102, 26);
            this.txbKmPorLitroGasolina.TabIndex = 7;
            // 
            // lblKmGasolina
            // 
            this.lblKmGasolina.AutoSize = true;
            this.lblKmGasolina.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmGasolina.Location = new System.Drawing.Point(18, 56);
            this.lblKmGasolina.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblKmGasolina.Name = "lblKmGasolina";
            this.lblKmGasolina.Size = new System.Drawing.Size(41, 20);
            this.lblKmGasolina.TabIndex = 5;
            this.lblKmGasolina.Text = "KM/L";
            // 
            // txbPrecoGasolina
            // 
            this.txbPrecoGasolina.Location = new System.Drawing.Point(176, 17);
            this.txbPrecoGasolina.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.txbPrecoGasolina.Name = "txbPrecoGasolina";
            this.txbPrecoGasolina.Size = new System.Drawing.Size(213, 26);
            this.txbPrecoGasolina.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblKm1);
            this.groupBox1.Controls.Add(this.lblPreco1);
            this.groupBox1.Controls.Add(this.lblPrecoEtanol);
            this.groupBox1.Controls.Add(this.txbKmPorLitroAlcool);
            this.groupBox1.Controls.Add(this.txbPrecoAlcool);
            this.groupBox1.Controls.Add(this.lblKmEtanol);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(65, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.groupBox1.Size = new System.Drawing.Size(453, 91);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etanol";
            // 
            // lblKm1
            // 
            this.lblKm1.AutoSize = true;
            this.lblKm1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm1.Location = new System.Drawing.Point(290, 60);
            this.lblKm1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblKm1.Name = "lblKm1";
            this.lblKm1.Size = new System.Drawing.Size(30, 20);
            this.lblKm1.TabIndex = 12;
            this.lblKm1.Text = "Km";
            // 
            // lblPreco1
            // 
            this.lblPreco1.AutoSize = true;
            this.lblPreco1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco1.Location = new System.Drawing.Point(398, 20);
            this.lblPreco1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPreco1.Name = "lblPreco1";
            this.lblPreco1.Size = new System.Drawing.Size(25, 20);
            this.lblPreco1.TabIndex = 10;
            this.lblPreco1.Text = "R$";
            // 
            // lblPrecoEtanol
            // 
            this.lblPrecoEtanol.AutoSize = true;
            this.lblPrecoEtanol.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoEtanol.Location = new System.Drawing.Point(18, 26);
            this.lblPrecoEtanol.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPrecoEtanol.Name = "lblPrecoEtanol";
            this.lblPrecoEtanol.Size = new System.Drawing.Size(107, 20);
            this.lblPrecoEtanol.TabIndex = 1;
            this.lblPrecoEtanol.Text = "Preço do alcool";
            // 
            // txbKmPorLitroAlcool
            // 
            this.txbKmPorLitroAlcool.Location = new System.Drawing.Point(176, 54);
            this.txbKmPorLitroAlcool.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.txbKmPorLitroAlcool.Name = "txbKmPorLitroAlcool";
            this.txbKmPorLitroAlcool.Size = new System.Drawing.Size(102, 26);
            this.txbKmPorLitroAlcool.TabIndex = 7;
            // 
            // txbPrecoAlcool
            // 
            this.txbPrecoAlcool.Location = new System.Drawing.Point(176, 18);
            this.txbPrecoAlcool.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.txbPrecoAlcool.Name = "txbPrecoAlcool";
            this.txbPrecoAlcool.Size = new System.Drawing.Size(213, 26);
            this.txbPrecoAlcool.TabIndex = 4;
            // 
            // lblKmEtanol
            // 
            this.lblKmEtanol.AutoSize = true;
            this.lblKmEtanol.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmEtanol.Location = new System.Drawing.Point(18, 56);
            this.lblKmEtanol.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblKmEtanol.Name = "lblKmEtanol";
            this.lblKmEtanol.Size = new System.Drawing.Size(41, 20);
            this.lblKmEtanol.TabIndex = 5;
            this.lblKmEtanol.Text = "KM/L";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 90);
            this.panel1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calcular econômia de combustivel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EcoCombustivel.Properties.Resources.gestao_de_combustivel_como_escolher_o_melhor_sistema_para_a_sua_frota;
            this.pictureBox1.Location = new System.Drawing.Point(49, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::EcoCombustivel.Properties.Resources.exit_97636_960_720;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.BorderSize = 300;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(434, 546);
            this.btnSair.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(84, 66);
            this.btnSair.TabIndex = 34;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 619);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Consumo";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblRodagem;
        private System.Windows.Forms.TextBox txbKmTotal;
        private System.Windows.Forms.TextBox txbDias;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblGasolina;
        private System.Windows.Forms.Label lblEconomia;
        private System.Windows.Forms.Label lblAlcool;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPreco2;
        private System.Windows.Forms.Label lblKm2;
        private System.Windows.Forms.Label lblPrecoGasolina;
        private System.Windows.Forms.TextBox txbKmPorLitroGasolina;
        private System.Windows.Forms.Label lblKmGasolina;
        private System.Windows.Forms.TextBox txbPrecoGasolina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKm1;
        private System.Windows.Forms.Label lblPreco1;
        private System.Windows.Forms.Label lblPrecoEtanol;
        private System.Windows.Forms.TextBox txbKmPorLitroAlcool;
        private System.Windows.Forms.TextBox txbPrecoAlcool;
        private System.Windows.Forms.Label lblKmEtanol;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

