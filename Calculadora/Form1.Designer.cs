namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblOperacao = new Label();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnLimpar = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnVirgula = new Button();
            button0 = new Button();
            btnIgual = new Button();
            btnAdicao = new Button();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.BackColor = Color.White;
            lblOperacao.Location = new Point(12, 15);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 15);
            lblOperacao.TabIndex = 1;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Location = new Point(5, 122);
            button7.Name = "button7";
            button7.Size = new Size(51, 42);
            button7.TabIndex = 2;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Location = new Point(73, 122);
            button8.Name = "button8";
            button8.Size = new Size(51, 42);
            button8.TabIndex = 3;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Location = new Point(139, 122);
            button9.Name = "button9";
            button9.Size = new Size(51, 42);
            button9.TabIndex = 4;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.White;
            btnLimpar.Location = new Point(205, 69);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(51, 42);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Location = new Point(5, 170);
            button4.Name = "button4";
            button4.Size = new Size(51, 42);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Location = new Point(73, 170);
            button5.Name = "button5";
            button5.Size = new Size(51, 42);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Location = new Point(139, 170);
            button6.Name = "button6";
            button6.Size = new Size(51, 42);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(5, 218);
            button1.Name = "button1";
            button1.Size = new Size(51, 42);
            button1.TabIndex = 9;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(73, 218);
            button2.Name = "button2";
            button2.Size = new Size(51, 42);
            button2.TabIndex = 10;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(139, 218);
            button3.Name = "button3";
            button3.Size = new Size(51, 42);
            button3.TabIndex = 11;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.White;
            btnVirgula.Location = new Point(5, 266);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(51, 42);
            btnVirgula.TabIndex = 12;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.White;
            button0.Location = new Point(73, 266);
            button0.Name = "button0";
            button0.Size = new Size(51, 42);
            button0.TabIndex = 13;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.White;
            btnIgual.Location = new Point(139, 266);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(51, 42);
            btnIgual.TabIndex = 14;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.BackColor = Color.White;
            btnAdicao.Location = new Point(205, 266);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(51, 42);
            btnAdicao.TabIndex = 15;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = false;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.White;
            btnSubtracao.Location = new Point(205, 218);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(51, 42);
            btnSubtracao.TabIndex = 16;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.White;
            btnMultiplicacao.Location = new Point(205, 170);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(51, 42);
            btnMultiplicacao.TabIndex = 17;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.White;
            btnDivisao.Location = new Point(205, 122);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(51, 42);
            btnDivisao.TabIndex = 18;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.ButtonHighlight;
            txtResultado.ForeColor = SystemColors.WindowText;
            txtResultado.Location = new Point(5, 12);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(251, 23);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(263, 392);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnAdicao);
            Controls.Add(btnIgual);
            Controls.Add(button0);
            Controls.Add(btnVirgula);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnLimpar);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(lblOperacao);
            Controls.Add(txtResultado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            TransparencyKey = Color.Red;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblOperacao;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnLimpar;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnVirgula;
        private Button button0;
        private Button btnIgual;
        private Button btnAdicao;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private TextBox txtResultado;
    }
}