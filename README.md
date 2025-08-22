# 🚀 Desafio Simulado: Sistema de Ordens de Serviço para Manutenção de Máquinas

## 📌 Cenário
Você foi alocado em um projeto para um cliente **X** do setor de **manufatura**.  
A fábrica possui centenas de máquinas e precisa de um sistema mais inteligente para gerenciar as **ordens de serviço (OS)** de manutenção.  

O objetivo é criar um **protótipo de console** que modele máquinas, serviços de manutenção e processe as ordens de serviço de forma automatizada.

---

## 🎯 Requisitos do Projeto

### Parte 1: Modelagem de Classes (POO)

#### 🔹 Classe `Maquina`
- **Atributos**:
  - `IdMaquina` (string)
  - `Nome` (string)
  - `Status` (enum: *Operacional, EmManutencao, Inativa*)

---

#### 🔹 Classe Base Abstrata `Servico`
- **Atributos**:
  - `DescricaoServico` (string)
  - `CustoEstimado` (decimal)

- **Método Abstrato**:
  - `Executar(Maquina maquina)` → Força as classes filhas a implementar a lógica específica de cada serviço, podendo alterar o estado da máquina.

---

#### 🔹 Classes Filhas de `Servico`

- **`ServicoManutencaoPreventiva`**  
  - Representa uma checagem de rotina.  
  - **Atributo específico**: `IntervaloHorasRecomendado` (int).  
  - **Lógica `Executar`**: apenas registrar que a manutenção foi feita.

- **`ServicoReparoCorretivo`**  
  - Representa um conserto de algo que quebrou.  
  - **Atributo específico**: `PecaSubstituida` (string).  
  - **Lógica `Executar`**: alterar o status da máquina de *Inativa* para *Operacional*.

---

### Parte 2: Lógica e Gerenciamento (Encapsulamento e Laços)

#### 🔹 Classe `OrdemServico`
- **Atributos**:
  - `NumeroOS` (string)
  - `MaquinaAlvo` (objeto `Maquina`)
  - `DataAbertura` (DateTime)
  - Lista de **Servicos** a serem executados

- **Métodos**:
  - `AdicionarServico(Servico servico)` → adiciona um serviço na OS.  
  - `ProcessarOrdem()` → lógica principal:
    1. Mudar o status da `MaquinaAlvo` para **EmManutencao**.
    2. Percorrer a lista de serviços (usando laço).
    3. Executar o método polimórfico `Executar()` de cada serviço.
    4. Ao final, se a máquina não estiver mais *Inativa*, mudar seu status para **Operacional**.
  - `ExibirRelatorioOS()` → mostra detalhes da OS, da máquina e dos serviços listados.

---

## ✅ Entrega Esperada
- Protótipo em **C# Console Application**.
- Demonstração de **POO (Herança, Abstração, Polimorfismo e Encapsulamento)**.
- Uso de **Enums** e **laços de repetição**.
- Classe `Program` deve **simular a criação de máquinas, serviços e ordens de serviço**.

---

## 📂 Estrutura Sugerida
