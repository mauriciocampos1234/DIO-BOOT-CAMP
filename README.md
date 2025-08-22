# 💳 Protótipo de Análise de Extrato Bancário

## 🏦 Cenário

Você é um desenvolvedor(a) júnior na **GFT**, alocado em um projeto para o **Banco InovaTech**.  
Sua primeira tarefa é desenvolver um **sistema de linha de comando (console)** para processar uma lista de transações bancárias e gerar um relatório simples.  

🎯 O objetivo é **validar conhecimentos em modelagem de objetos e manipulação de dados**.

---

## 📋 Requisitos do Projeto

### Parte 1: Modelagem de Classes (POO)

### 🔹 Classe `Transacao`
**Atributos:**
- `data` *(string)* – Ex: `"20/08/2025"`
- `descricao` *(string)* – Ex: `"Pagamento Fatura Cartão"`
- `valor` *(float/double)*  
  > Observação:  
  > - Valores **negativos** → débitos/saques  
  > - Valores **positivos** → créditos/depósitos  

---

### 🔹 Classe `ContaBancaria`
**Atributos:**
- `nomeTitular` *(string)*
- `numeroConta` *(string)*
- Lista (ou array) de objetos `Transacao` para armazenar o extrato  

**Métodos:**
- **Construtor** → inicializa titular e número da conta  
- **adicionarTransacao(Transacao transacao)** → adiciona uma nova transação ao extrato  

---

### Parte 2: Lógica e Processamento

Na classe `ContaBancaria`, implemente:

#### 🔹 `calcularSaldoFinal()`
- Percorre a lista de transações  
- Soma todos os valores  
- Retorna o **saldo final** da conta  

#### 🔹 `listarTransacoesPorTipo(string tipo)`
- Recebe `"credito"` ou `"debito"`  
- Percorre a lista de transações  
- Exibe somente os registros do tipo solicitado  

#### 🔹 `gerarRelatorio()`
Imprime no console:  
- Nome do titular e número da conta  
- Todas as transações (data, descrição, valor)  
- O **Saldo Final** calculado  

---

## 🧩 Exemplo de Uso (pseudocódigo)

```java
ContaBancaria conta = new ContaBancaria("Maurício Campos", "12345-6");

conta.adicionarTransacao(new Transacao("20/08/2025", "Depósito inicial", 1000.0));
conta.adicionarTransacao(new Transacao("21/08/2025", "Pagamento Fatura Cartão", -350.0));
conta.adicionarTransacao(new Transacao("22/08/2025", "Transferência recebida", 200.0));

conta.gerarRelatorio();

🖥️ Saída esperada:

--- Extrato Bancário ---
Titular: Maurício Campos
Conta: 12345-6

20/08/2025 | Depósito inicial         | +1000.00
21/08/2025 | Pagamento Fatura Cartão  |  -350.00
22/08/2025 | Transferência recebida   |  +200.00

Saldo Final: 850.00
