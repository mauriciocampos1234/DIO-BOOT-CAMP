# 📡 Desafio Simulado: Sistema de Gerenciamento de Contas e Suporte Técnico em Telecom

## 📌 Cenário
Sua equipe na **X** está desenvolvendo um novo CRM (**Customer Relationship Management**) para a **GFT Telecom**, uma provedora de serviços de internet e telefonia.  

O seu papel é criar um **protótipo do módulo de conta do cliente**, que deve gerenciar:  
- O plano contratado  
- O histórico de chamados de suporte técnico  

---

## 🛠️ Requisitos do Projeto

### Parte 1: Modelagem de Classes (POO)

#### 🔹 Classe `ChamadoSuporte` (Support Ticket)
- **Atributos**:
  - `Protocolo` (long)
  - `DescricaoProblema` (string)
  - `DataAbertura` (DateTime)
  - `Status` (enum: `Aberto`, `EmAndamento`, `Resolvido`)

---

#### 🔹 Classe base abstrata `PlanoServico`
- **Atributos**:
  - `NomePlano` (string)
  - `VelocidadeContratadaMB` (int)
  - `CustoMensal` (decimal)
- **Método Abstrato**:
  - `VerificarStatusConexao()` → Cada tipo de plano terá uma forma diferente de verificar a conectividade.

---

#### 🔹 Classes filhas de `PlanoServico`

1. **`PlanoFibraOptica`**
   - **Atributo específico:** `LocalidadeInstalacao` (string)  
   - **Verificação de status:** simula teste na infraestrutura física.

2. **`PlanoMovel5G`**
   - **Atributo específico:** `NumeroTelefone` (string)  
   - **Verificação de status:** simula checagem de sinal na antena mais próxima.

---

### Parte 2: Lógica e Gerenciamento (Encapsulamento e Laços)

#### 🔹 Classe `ContaCliente`
- **Atributos**:
  - `IdCliente` (int)
  - `NomeCliente` (string)
  - `PlanoContratado` (objeto `PlanoServico`)  
  - Lista de `ChamadoSuporte`

- **Métodos**:
  1. `AbrirChamado(string descricaoProblema)`  
     → Cria um novo `ChamadoSuporte`, adiciona à lista e retorna o número do protocolo.
  2. `ProcessarChamadosAbertos()`  
     - Percorre a lista de chamados.  
     - Para cada chamado com status **Aberto**, simula a ação de um técnico:  
       - Muda status para **EmAndamento**  
       - Depois muda status para **Resolvido**
  3. `GerarRelatorioConta()`  
     → Exibe relatório completo da conta do cliente, incluindo:  
       - Detalhes do plano contratado  
       - Histórico de todos os chamados  

---

## ✅ Entrega Esperada
- Protótipo executável em **Console Application** (C# ou Java).  
- Demonstração de **POO (Herança, Abstração, Encapsulamento, Polimorfismo)**.  
- Funcionalidades: criação de clientes, planos, abertura e processamento de chamados, geração de relatório completo.

---

## 📂 Estrutura Sugerida
