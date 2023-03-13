
namespace calculadora
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.btt7 = new System.Windows.Forms.Button();
            this.btt8 = new System.Windows.Forms.Button();
            this.btt9 = new System.Windows.Forms.Button();
            this.btt_add = new System.Windows.Forms.Button();
            this.btt_CE = new System.Windows.Forms.Button();
            this.btt_sub = new System.Windows.Forms.Button();
            this.btt6 = new System.Windows.Forms.Button();
            this.btt5 = new System.Windows.Forms.Button();
            this.btt4 = new System.Windows.Forms.Button();
            this.btt_mult = new System.Windows.Forms.Button();
            this.btt3 = new System.Windows.Forms.Button();
            this.btt2 = new System.Windows.Forms.Button();
            this.btt1 = new System.Windows.Forms.Button();
            this.btt_Igual = new System.Windows.Forms.Button();
            this.btt_divi = new System.Windows.Forms.Button();
            this.btt_point = new System.Windows.Forms.Button();
            this.btt0 = new System.Windows.Forms.Button();
            this.btt_C = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(23, 8);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(314, 22);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(36, 11);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 17);
            this.lblOperacao.TabIndex = 1;
            // 
            // btt7
            // 
            this.btt7.Location = new System.Drawing.Point(23, 40);
            this.btt7.Name = "btt7";
            this.btt7.Size = new System.Drawing.Size(58, 53);
            this.btt7.TabIndex = 2;
            this.btt7.Text = "7";
            this.btt7.UseVisualStyleBackColor = true;
            this.btt7.Click += new System.EventHandler(this.btt7_Click);
            // 
            // btt8
            // 
            this.btt8.Location = new System.Drawing.Point(87, 40);
            this.btt8.Name = "btt8";
            this.btt8.Size = new System.Drawing.Size(58, 53);
            this.btt8.TabIndex = 3;
            this.btt8.Text = "8";
            this.btt8.UseVisualStyleBackColor = true;
            this.btt8.Click += new System.EventHandler(this.btt8_Click);
            // 
            // btt9
            // 
            this.btt9.Location = new System.Drawing.Point(151, 40);
            this.btt9.Name = "btt9";
            this.btt9.Size = new System.Drawing.Size(58, 53);
            this.btt9.TabIndex = 4;
            this.btt9.Text = "9";
            this.btt9.UseVisualStyleBackColor = true;
            this.btt9.Click += new System.EventHandler(this.btt9_Click);
            // 
            // btt_add
            // 
            this.btt_add.Location = new System.Drawing.Point(215, 40);
            this.btt_add.Name = "btt_add";
            this.btt_add.Size = new System.Drawing.Size(58, 53);
            this.btt_add.TabIndex = 5;
            this.btt_add.Text = "+";
            this.btt_add.UseVisualStyleBackColor = true;
            this.btt_add.Click += new System.EventHandler(this.btt_add_Click);
            // 
            // btt_CE
            // 
            this.btt_CE.Location = new System.Drawing.Point(279, 40);
            this.btt_CE.Name = "btt_CE";
            this.btt_CE.Size = new System.Drawing.Size(58, 53);
            this.btt_CE.TabIndex = 6;
            this.btt_CE.Text = "CE";
            this.btt_CE.UseVisualStyleBackColor = true;
            this.btt_CE.Click += new System.EventHandler(this.btt_CE_Click);
            // 
            // btt_sub
            // 
            this.btt_sub.Location = new System.Drawing.Point(215, 99);
            this.btt_sub.Name = "btt_sub";
            this.btt_sub.Size = new System.Drawing.Size(58, 53);
            this.btt_sub.TabIndex = 10;
            this.btt_sub.Text = "-";
            this.btt_sub.UseVisualStyleBackColor = true;
            this.btt_sub.Click += new System.EventHandler(this.btt_sub_Click);
            // 
            // btt6
            // 
            this.btt6.Location = new System.Drawing.Point(151, 99);
            this.btt6.Name = "btt6";
            this.btt6.Size = new System.Drawing.Size(58, 53);
            this.btt6.TabIndex = 9;
            this.btt6.Text = "6";
            this.btt6.UseVisualStyleBackColor = true;
            this.btt6.Click += new System.EventHandler(this.btt6_Click);
            // 
            // btt5
            // 
            this.btt5.Location = new System.Drawing.Point(87, 99);
            this.btt5.Name = "btt5";
            this.btt5.Size = new System.Drawing.Size(58, 53);
            this.btt5.TabIndex = 8;
            this.btt5.Text = "5";
            this.btt5.UseVisualStyleBackColor = true;
            this.btt5.Click += new System.EventHandler(this.btt5_Click);
            // 
            // btt4
            // 
            this.btt4.Location = new System.Drawing.Point(23, 99);
            this.btt4.Name = "btt4";
            this.btt4.Size = new System.Drawing.Size(58, 53);
            this.btt4.TabIndex = 7;
            this.btt4.Text = "4";
            this.btt4.UseVisualStyleBackColor = true;
            this.btt4.Click += new System.EventHandler(this.btt4_Click);
            // 
            // btt_mult
            // 
            this.btt_mult.Location = new System.Drawing.Point(215, 158);
            this.btt_mult.Name = "btt_mult";
            this.btt_mult.Size = new System.Drawing.Size(58, 53);
            this.btt_mult.TabIndex = 15;
            this.btt_mult.Text = "x";
            this.btt_mult.UseVisualStyleBackColor = true;
            this.btt_mult.Click += new System.EventHandler(this.btt_mult_Click);
            // 
            // btt3
            // 
            this.btt3.Location = new System.Drawing.Point(151, 158);
            this.btt3.Name = "btt3";
            this.btt3.Size = new System.Drawing.Size(58, 53);
            this.btt3.TabIndex = 14;
            this.btt3.Text = "3";
            this.btt3.UseVisualStyleBackColor = true;
            this.btt3.Click += new System.EventHandler(this.btt3_Click);
            // 
            // btt2
            // 
            this.btt2.Location = new System.Drawing.Point(87, 158);
            this.btt2.Name = "btt2";
            this.btt2.Size = new System.Drawing.Size(58, 53);
            this.btt2.TabIndex = 13;
            this.btt2.Text = "2";
            this.btt2.UseVisualStyleBackColor = true;
            this.btt2.Click += new System.EventHandler(this.btt2_Click);
            // 
            // btt1
            // 
            this.btt1.Location = new System.Drawing.Point(23, 158);
            this.btt1.Name = "btt1";
            this.btt1.Size = new System.Drawing.Size(58, 53);
            this.btt1.TabIndex = 12;
            this.btt1.Text = "1";
            this.btt1.UseVisualStyleBackColor = true;
            this.btt1.Click += new System.EventHandler(this.btt1_Click);
            // 
            // btt_Igual
            // 
            this.btt_Igual.Location = new System.Drawing.Point(279, 158);
            this.btt_Igual.Name = "btt_Igual";
            this.btt_Igual.Size = new System.Drawing.Size(58, 112);
            this.btt_Igual.TabIndex = 21;
            this.btt_Igual.Text = "=";
            this.btt_Igual.UseVisualStyleBackColor = true;
            this.btt_Igual.Click += new System.EventHandler(this.btt_Igual_Click);
            // 
            // btt_divi
            // 
            this.btt_divi.Location = new System.Drawing.Point(215, 217);
            this.btt_divi.Name = "btt_divi";
            this.btt_divi.Size = new System.Drawing.Size(58, 53);
            this.btt_divi.TabIndex = 20;
            this.btt_divi.Text = "/";
            this.btt_divi.UseVisualStyleBackColor = true;
            this.btt_divi.Click += new System.EventHandler(this.btt_divi_Click);
            // 
            // btt_point
            // 
            this.btt_point.Location = new System.Drawing.Point(151, 217);
            this.btt_point.Name = "btt_point";
            this.btt_point.Size = new System.Drawing.Size(58, 53);
            this.btt_point.TabIndex = 19;
            this.btt_point.Text = ".";
            this.btt_point.UseVisualStyleBackColor = true;
            this.btt_point.Click += new System.EventHandler(this.btt_point_Click);
            // 
            // btt0
            // 
            this.btt0.Location = new System.Drawing.Point(23, 217);
            this.btt0.Name = "btt0";
            this.btt0.Size = new System.Drawing.Size(122, 53);
            this.btt0.TabIndex = 17;
            this.btt0.Text = "0";
            this.btt0.UseVisualStyleBackColor = true;
            this.btt0.Click += new System.EventHandler(this.btt0_Click);
            // 
            // btt_C
            // 
            this.btt_C.Location = new System.Drawing.Point(279, 99);
            this.btt_C.Name = "btt_C";
            this.btt_C.Size = new System.Drawing.Size(58, 53);
            this.btt_C.TabIndex = 11;
            this.btt_C.Text = "C";
            this.btt_C.UseVisualStyleBackColor = true;
            this.btt_C.Click += new System.EventHandler(this.btt_C_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 284);
            this.Controls.Add(this.btt_Igual);
            this.Controls.Add(this.btt_divi);
            this.Controls.Add(this.btt_point);
            this.Controls.Add(this.btt0);
            this.Controls.Add(this.btt_mult);
            this.Controls.Add(this.btt3);
            this.Controls.Add(this.btt2);
            this.Controls.Add(this.btt1);
            this.Controls.Add(this.btt_C);
            this.Controls.Add(this.btt_sub);
            this.Controls.Add(this.btt6);
            this.Controls.Add(this.btt5);
            this.Controls.Add(this.btt4);
            this.Controls.Add(this.btt_CE);
            this.Controls.Add(this.btt_add);
            this.Controls.Add(this.btt9);
            this.Controls.Add(this.btt8);
            this.Controls.Add(this.btt7);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button btt7;
        private System.Windows.Forms.Button btt8;
        private System.Windows.Forms.Button btt9;
        private System.Windows.Forms.Button btt_add;
        private System.Windows.Forms.Button btt_CE;
        private System.Windows.Forms.Button btt_sub;
        private System.Windows.Forms.Button btt6;
        private System.Windows.Forms.Button btt5;
        private System.Windows.Forms.Button btt4;
        private System.Windows.Forms.Button btt_mult;
        private System.Windows.Forms.Button btt3;
        private System.Windows.Forms.Button btt2;
        private System.Windows.Forms.Button btt1;
        private System.Windows.Forms.Button btt_Igual;
        private System.Windows.Forms.Button btt_divi;
        private System.Windows.Forms.Button btt_point;
        private System.Windows.Forms.Button btt0;
        private System.Windows.Forms.Button btt_C;
    }
}

