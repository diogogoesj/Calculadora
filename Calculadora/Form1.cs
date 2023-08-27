namespace Calculadora
{
    public partial class Form1 : Form
    {
        private decimal Resultado { get; set; }
        private decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Nenhuma,
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
            OperacaoSelecionada = Operacao.Nenhuma;
        }

        private void NumeroButtonClick(object sender, EventArgs e)
        {
            var botao = (Button)sender;
            txtResultado.Text += botao.Text;
        }

        private void BotaoOperacaoClick(Operacao operacao, char operador)
        {
            if (decimal.TryParse(txtResultado.Text, out decimal numero))
            {
                Valor = numero;
                OperacaoSelecionada = operacao;
                txtResultado.Text = "";
                lblOperacao.Text = operador.ToString();
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtResultado.Text, out decimal numero))
            {
                switch (OperacaoSelecionada)
                {
                    case Operacao.Adicao:
                        Resultado = Valor + numero;
                        break;

                    case Operacao.Subtracao:
                        Resultado = Valor - numero;
                        break;

                    case Operacao.Multiplicacao:
                        Resultado = Valor * numero;
                        break;

                    case Operacao.Divisao:
                        Resultado = Valor / numero;
                        break;
                }

                txtResultado.Text = Resultado.ToString();
                lblOperacao.Text = "=";
                OperacaoSelecionada = Operacao.Nenhuma;
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(','))
            {
                txtResultado.Text += ",";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
            OperacaoSelecionada = Operacao.Nenhuma;
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            BotaoOperacaoClick(Operacao.Adicao, '+');
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            BotaoOperacaoClick(Operacao.Subtracao, '-');
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            BotaoOperacaoClick(Operacao.Multiplicacao, 'x');
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            BotaoOperacaoClick(Operacao.Divisao, '/');
        }

        private void button0_Click(object sender, EventArgs e)
        {
            NumeroButtonClick(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumeroButtonClick(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumeroButtonClick(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumeroButtonClick(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumeroButtonClick(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumeroButtonClick(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumeroButtonClick(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumeroButtonClick(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumeroButtonClick(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumeroButtonClick(sender, e);
        }
    }
}