# 🚗 Desafio Simulado: Sistema de Gerenciamento de Ordens de Serviço de Oficina Automotiva  

## 📌 Cenário  
Você faz parte de uma equipe da **X** que está desenvolvendo um novo sistema de gerenciamento para uma rede de concessionárias e oficinas de alto padrão.  
O sistema precisa controlar:  
- A entrada de veículos  
- Os serviços a serem realizados  
- O status de cada ordem de serviço  

Seu **protótipo de console** irá modelar esse fluxo.  

---

## 🛠️ Requisitos do Projeto  

### **Parte 1: Modelagem de Classes (POO)**  

#### Classe `Veiculo`  
- **Atributos:**  
  - `Placa` (string)  
  - `Modelo` (string)  
  - `Ano` (int)  
  - `NomeCliente` (string)  

---

#### Classe base abstrata `ServicoAutomotivo`  
- **Atributos:**  
  - `Codigo` (string)  
  - `Descricao` (string)  
  - `Custo` (decimal)  

- **Método Abstrato:**  
  - `ExecutarServico()` → Cada serviço terá uma implementação específica de sua execução.  

---

#### Classes filhas que **herdam de ServicoAutomotivo**  

1. **TrocaDeOleo**  
   - **Atributo específico:** `TipoOleo` (string).  
   - **Execução:** imprime mensagem específica sobre a troca de óleo e filtro.  

2. **AlinhamentoBalanceamento**  
   - **Atributo específico:** `GeometriaAplicada` (string, ex: `"3D a Laser"`).  
   - **Execução:** detalha a verificação e ajuste dos ângulos das rodas.  

3. **DiagnosticoEletronico**  
   - **Atributo específico:** `SistemaVerificado` (string, ex: `"Injeção Eletrônica"`).  
   - **Execução:** simula a conexão de um scanner e a leitura de códigos de falha.  

---

### **Parte 2: Lógica e Gerenciamento (Encapsulamento e Laços)**  

#### Classe `OrdemDeServico`  
- **Atributos:**  
  - `NumeroOS` (int)  
  - `VeiculoAtendido` (objeto Veiculo)  
  - `Status` (enum: `AguardandoAprovacao`, `EmExecucao`, `Finalizada`, `Cancelada`)  
  - Lista de `ServicoAutomotivo`  

- **Métodos:**  
  1. `AdicionarServico(ServicoAutomotivo servico)` → adiciona serviços à ordem.  
  2. `CalcularCustoTotal()` → percorre a lista de serviços e soma os custos.  
  3. `ProcessarOrdem()`  
     - Altera status para **EmExecucao**  
     - Percorre lista de serviços executando `ExecutarServico()`  
     - Altera status para **Finalizada**  
  4. `GerarRelatorioFinal()` → exibe relatório completo com:  
     - Dados do veículo  
     - Serviços executados  
     - Custo total  

---

## 🎯 Entrega Esperada  

- O código deve ser **autocontido** e executado na classe `Program`.  
- Deve demonstrar:  
  - Criação de veículos  
  - Criação de serviços  
  - Criação e processamento de ordens de serviço  
  - Geração de relatório final para o cliente  

---
