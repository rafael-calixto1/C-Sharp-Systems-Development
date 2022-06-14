
namespace CalcSimples
{
    partial class frmCalculadora
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
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnsubtracao = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.BackColor = System.Drawing.Color.DarkOrange;
            this.txtVisor.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.Location = new System.Drawing.Point(30, 12);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.ReadOnly = true;
            this.txtVisor.Size = new System.Drawing.Size(354, 56);
            this.txtVisor.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Image = global::CalcSimples.Properties.Resources._1;
            this.btn1.Location = new System.Drawing.Point(30, 95);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(73, 71);
            this.btn1.TabIndex = 2;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Image = global::CalcSimples.Properties.Resources._2;
            this.btn2.Location = new System.Drawing.Point(123, 95);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(72, 73);
            this.btn2.TabIndex = 3;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Image = global::CalcSimples.Properties.Resources._3;
            this.btn3.Location = new System.Drawing.Point(221, 95);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 70);
            this.btn3.TabIndex = 4;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.AutoSize = true;
            this.btnSoma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSoma.FlatAppearance.BorderSize = 0;
            this.btnSoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoma.Image = global::CalcSimples.Properties.Resources.soma;
            this.btnSoma.Location = new System.Drawing.Point(313, 95);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(70, 70);
            this.btnSoma.TabIndex = 5;
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnsubtracao
            // 
            this.btnsubtracao.AutoSize = true;
            this.btnsubtracao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsubtracao.FlatAppearance.BorderSize = 0;
            this.btnsubtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubtracao.Image = global::CalcSimples.Properties.Resources.subtração;
            this.btnsubtracao.Location = new System.Drawing.Point(313, 184);
            this.btnsubtracao.Name = "btnsubtracao";
            this.btnsubtracao.Size = new System.Drawing.Size(71, 69);
            this.btnsubtracao.TabIndex = 9;
            this.btnsubtracao.UseVisualStyleBackColor = false;
            this.btnsubtracao.Click += new System.EventHandler(this.btnsubtracao_Click);
            // 
            // btn6
            // 
            this.btn6.AutoSize = true;
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Image = global::CalcSimples.Properties.Resources._6;
            this.btn6.Location = new System.Drawing.Point(221, 184);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(72, 69);
            this.btn6.TabIndex = 8;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Image = global::CalcSimples.Properties.Resources._5;
            this.btn5.Location = new System.Drawing.Point(123, 184);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 72);
            this.btn5.TabIndex = 7;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Image = global::CalcSimples.Properties.Resources._4;
            this.btn4.Location = new System.Drawing.Point(30, 184);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 69);
            this.btn4.TabIndex = 6;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.AutoSize = true;
            this.btnMultiplicacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMultiplicacao.FlatAppearance.BorderSize = 0;
            this.btnMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicacao.Image = global::CalcSimples.Properties.Resources.multiplicação;
            this.btnMultiplicacao.Location = new System.Drawing.Point(313, 268);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(74, 70);
            this.btnMultiplicacao.TabIndex = 13;
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btn9
            // 
            this.btn9.AutoSize = true;
            this.btn9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Image = global::CalcSimples.Properties.Resources._9;
            this.btn9.Location = new System.Drawing.Point(221, 268);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(69, 69);
            this.btn9.TabIndex = 12;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.AutoSize = true;
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Image = global::CalcSimples.Properties.Resources._8;
            this.btn8.Location = new System.Drawing.Point(123, 268);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(72, 70);
            this.btn8.TabIndex = 11;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Image = global::CalcSimples.Properties.Resources._7;
            this.btn7.Location = new System.Drawing.Point(30, 268);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(71, 70);
            this.btn7.TabIndex = 10;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.AutoSize = true;
            this.btnDivisao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDivisao.FlatAppearance.BorderSize = 0;
            this.btnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivisao.Image = global::CalcSimples.Properties.Resources.barra;
            this.btnDivisao.Location = new System.Drawing.Point(313, 349);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(70, 70);
            this.btnDivisao.TabIndex = 17;
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnigual
            // 
            this.btnigual.AutoSize = true;
            this.btnigual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnigual.FlatAppearance.BorderSize = 0;
            this.btnigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnigual.Image = global::CalcSimples.Properties.Resources.igual;
            this.btnigual.Location = new System.Drawing.Point(221, 349);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(75, 70);
            this.btnigual.TabIndex = 16;
            this.btnigual.UseVisualStyleBackColor = false;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btn0
            // 
            this.btn0.AutoSize = true;
            this.btn0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Image = global::CalcSimples.Properties.Resources._0;
            this.btn0.Location = new System.Drawing.Point(123, 349);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(73, 71);
            this.btn0.TabIndex = 15;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnc
            // 
            this.btnc.AutoSize = true;
            this.btnc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnc.FlatAppearance.BorderSize = 0;
            this.btnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnc.Image = global::CalcSimples.Properties.Resources.C;
            this.btnc.Location = new System.Drawing.Point(30, 349);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(70, 70);
            this.btnc.TabIndex = 14;
            this.btnc.UseVisualStyleBackColor = false;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnsubtracao);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtVisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EtecCalc";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnsubtracao;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnc;
    }
}

