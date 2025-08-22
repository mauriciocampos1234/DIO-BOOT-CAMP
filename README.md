
# 🏭 Desafio Simulado: Sistema de Gestão de Estoque e Pedidos

## 📌 Cenário
Você está em um projeto de transformação digital para um grande cliente da **X** que atua tanto na fabricação quanto na venda de produtos (Indústria e Varejo).  
O desafio é criar um protótipo de um sistema de console para **gerenciar o estoque** de diferentes tipos de produtos e **processar pedidos de clientes**, automatizando e otimizando o processo.

---

## 🚀 Requisitos do Projeto

### 🔹 Parte 1: Modelagem de Classes (POO com Foco em Polimorfismo)

- **Classe `PedidoItem`**
  - Atributos:
    - `SkuProduto` (string) → Identificador do produto
    - `Quantidade` (int)

- **Classe Base Abstrata `Produto`**
  - Atributos:
    - `Sku` (string - Stock Keeping Unit)
    - `Nome` (string)
    - `Preco` (decimal)
  - Métodos Abstratos:
    - `BaixarEstoque(int quantidade)` → Força as classes filhas a implementarem sua própria lógica de baixa de estoque.
    - `VerificarDisponibilidade(int quantidade)` → Força a verificação de disponibilidade.

- **Classes Filhas**:
  - **`ProdutoFisico`**
    - Atributo específico: `QuantidadeEmEstoque` (int)
    - Métodos sobrescritos:
      - `BaixarEstoque` → Subtrai do estoque.
      - `VerificarDisponibilidade` → Checa se há quantidade suficiente.
  - **`ProdutoDigital`** (Ex: Licença de Software, E-book)
    - Atributo específico: `Ativo` (bool)
    - Características:
      - Não possui contagem de estoque.
      - A baixa de estoque é apenas um log.
      - Disponibilidade depende do status **Ativo/Inativo**.

---

### 🔹 Parte 2: Lógica e Processamento (Gerenciamento e Laços)

- **Classe `GerenciadorEstoque`**
  - Atributos:
    - Lista de `Produto`
  - Métodos:
    - `AdicionarProduto(Produto produto)`
    - `BuscarProdutoPorSku(string sku)` → Auxiliar para localizar produtos.
    - `ProcessarListaDePedidos(List<PedidoItem> pedidos)`
      - Percorrer pedidos com **laço de repetição**.
      - Buscar produto correspondente.
      - Usar métodos polimórficos (`VerificarDisponibilidade` e `BaixarEstoque`).
      - Imprimir no console se o pedido foi **aprovado** ou **rejeitado**.
    - `GerarRelatorioDeEstoque()` → Exibir relatório do estado atual do estoque.

---

## ✅ Entrega Esperada
- Código **autocontido**.
- Executável via classe `Program`.
- Demonstração da criação e gestão de produtos e pedidos.
