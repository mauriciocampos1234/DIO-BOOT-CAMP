🚀 Desafio: Protótipo de Análise de Extrato Bancário
Bem-vindo ao seu primeiro grande desafio no Banco InovaTech! Como desenvolvedor(a) júnior na GFT, sua missão é criar um sistema de linha de comando (console) para processar transações bancárias e gerar um relatório analítico. Este projeto é a sua oportunidade de brilhar, demonstrando suas habilidades em Programação Orientada a Objetos (POO) e manipulação de dados.

cenário
Você acaba de ser alocado(a) em um projeto crucial para o "Banco InovaTech". Sua primeira tarefa é desenvolver um protótipo funcional que sirva como a base para futuras análises financeiras. O objetivo é claro: construir um sistema robusto, limpo e eficiente que processe uma lista de transações e apresente um extrato detalhado. Vamos começar!

📋 Requisitos do Projeto
Parte 1: Modelagem de Classes (Programação Orientada a Objetos)
A base de um sistema sólido começa com uma modelagem de classes bem-estruturada.

🏦 Classe Transacao
Esta classe representará cada movimentação individual na conta.

Atributos:

data (String): A data da transação (ex: "20/08/2025").

descricao (String): Uma breve descrição (ex: "Pagamento Fatura Cartão").

valor (Double/Float): O montante da transação.

Importante: Valores negativos para débitos/saques e positivos para créditos/depósitos.

💳 Classe ContaBancaria
Esta classe será o coração do sistema, gerenciando as informações do cliente e seu histórico de transações.

Atributos:

nomeTitular (String): Nome completo do titular da conta.

numeroConta (String): Número de identificação da conta.

transacoes (List<Transacao>): Uma lista para armazenar todos os objetos Transacao.

Métodos:

ContaBancaria(String nomeTitular, String numeroConta): Construtor para inicializar os dados da conta.

adicionarTransacao(Transacao transacao): Adiciona uma nova transação ao extrato da conta.

Parte 2: Lógica e Processamento (Estrutura de Repetição e Laços)
Com a estrutura modelada, é hora de adicionar a inteligência ao sistema dentro da classe ContaBancaria.

🧠 Métodos a Implementar:
calcularSaldoFinal():

Este método deve iterar sobre a lista de transações.

Utilizando um laço, some todos os valores (valor) para obter o saldo consolidado da conta.

listarTransacoesPorTipo(String tipo):

Recebe um parâmetro tipo ("credito" ou "debito").

Deve percorrer a lista e imprimir no console apenas as transações que correspondem ao tipo solicitado (valores > 0 para crédito, < 0 para débito).

gerarRelatorio():

O grande final! Este método deve orquestrar a apresentação dos dados.

Imprima um relatório bem formatado no console contendo:

Nome do titular e número da conta.

Uma lista detalhada com todas as transações (data, descrição e valor).

O Saldo Final, calculado através da chamada ao método calcularSaldoFinal().
