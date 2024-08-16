

# Calculadora Windows Forms em C# (.NET 6)

Este projeto é uma aplicação de calculadora simples desenvolvida em Windows Forms usando a linguagem C# e o framework .NET 6. A calculadora permite realizar operações básicas de adição, subtração, multiplicação e divisão entre números decimais.


## Estrutura do Projeto

O projeto consiste em um único formulário chamado "Form1" que contém os elementos visuais da calculadora, como botões para números, operações e uma caixa de texto para exibir o resultado. A estrutura do código é dividida da seguinte forma:

### Classe Principal (Form1)

- `private decimal Resultado { get; set; }`: Armazena o resultado da operação atual.
- `private decimal Valor { get; set; }`: Armazena o valor que está sendo usado na operação.
- `private Operacao OperacaoSelecionada { get; set; }`: Armazena a operação selecionada.
- `private enum Operacao { ... }`: Enumeração que define os tipos de operações possíveis.

### Métodos Principais

- `public Form1()`: Construtor da classe Form1. Inicializa os componentes visuais e define a operação inicial como "Nenhuma".
- `private void NumeroButtonClick(object sender, EventArgs e)`: Manipula o evento de clique em um botão numérico e exibe o número correspondente na caixa de texto.
- `private void BotaoOperacaoClick(Operacao operacao, char operador)`: Define a operação selecionada, armazena o valor atual e exibe o operador na tela.
- `private void btnIgual_Click(object sender, EventArgs e)`: Realiza a operação matemática correspondente quando o botão de igual é pressionado.
- `private void btnVirgula_Click(object sender, EventArgs e)`: Adiciona uma vírgula à caixa de texto se ainda não houver uma presente.
- `private void btnLimpar_Click(object sender, EventArgs e)`: Limpa a caixa de texto e reinicia as variáveis relacionadas à operação.
- Métodos de clique para botões de adição, subtração, multiplicação e divisão: Chamam o método `BotaoOperacaoClick` com a operação e o operador correspondentes.

### Métodos de Clique dos Números

- Métodos de clique para os botões numéricos de 0 a 9: Chamam o método `NumeroButtonClick` para exibir o número correspondente na caixa de texto.

## Funcionamento da Calculadora

- Os botões numéricos adicionam o número correspondente à caixa de texto.
- Os botões de operação (adição, subtração, multiplicação e divisão) selecionam a operação e exibem o operador na tela.
- O botão "Igual" realiza a operação matemática selecionada e exibe o resultado na caixa de texto.
- O botão de vírgula permite a inserção de números decimais.
- O botão "Limpar" reinicia a calculadora para uma nova operação.

## Executando o Projeto

Certifique-se de ter o .NET 6 SDK instalado em sua máquina. Para executar o projeto, siga os passos abaixo:

1. Clone ou baixe o repositório para sua máquina.
2. Abra o projeto usando um IDE compatível com .NET 6, como o Visual Studio 2022 ou o Visual Studio Code.
3. Certifique-se de que o projeto esteja configurado como o projeto de inicialização.
4. Execute o projeto pressionando F5 ou usando o comando de execução do IDE.

Isso abrirá a calculadora Windows Forms, onde você poderá realizar operações matemáticas básicas.
