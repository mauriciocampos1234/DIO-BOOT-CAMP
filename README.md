# 🛡️ Desafio Simulado: Gestão de Apólices de Seguro  

## 📌 Cenário  

Você agora faz parte da equipe de desenvolvimento da **GFT Seguros**.  
Sua missão é criar um **protótipo de sistema de console** capaz de gerenciar diferentes tipos de **apólices de seguro** e processar os **sinistros** (ocorrências) reportados pelos segurados.  

Este desafio avalia seu domínio em **Programação Orientada a Objetos (POO)**, com foco em **herança, abstração, enums** e **manipulação de listas**.  

---

## 🎯 Objetivos do Projeto  

1. Modelar as classes principais de apólices e sinistros.  
2. Implementar herança e polimorfismo no sistema.  
3. Criar métodos para processar e exibir informações.  
4. Demonstrar a execução do sistema em um programa principal (`Program`).  

---

## 🧩 Parte 1: Modelagem de Classes  

### 🔹 Classe `Sinistro`  
Representa um evento ocorrido em uma apólice.  

**Atributos:**  
- `DataOcorrencia (DateTime)`  
- `Descricao (string)`  
- `Status (enum: EmAnalise, Aprovado, Reprovado)`  

---

### 🔹 Classe base `Apolice` (ABSTRATA)  
Modelo genérico para qualquer tipo de apólice.  

**Atributos:**  
- `Numero (string)`  
- `NomeSegurado (string)`  
- `ValorPremio (decimal)`  
- `Status (enum: Ativa, Cancelada, Vencida)`  
- `Lista<Sinistro>` → para armazenar os sinistros relacionados.  

**Métodos:**  
- `AdicionarSinistro(Sinistro sinistro)` → adiciona ocorrências à apólice.  
- `ProcessarSinistrosEmAnalise()` → percorre todos os sinistros **EmAnalise** e altera o status para **Aprovado**.  
- `ExibirResumo()` → método **abstrato** (deve ser implementado pelas classes filhas).  

---

### 🔹 Classe `ApoliceAutomovel` (herda de Apolice)  
**Atributos específicos:**  
- `PlacaVeiculo (string)`  
- `ModeloVeiculo (string)`  

**Sobrescreve o método:**  
- `ExibirResumo()` → mostrando dados do veículo, segurado e sinistros.  

---

### 🔹 Classe `ApoliceResidencial` (herda de Apolice)  
**Atributos específicos:**  
- `EnderecoImovel (string)`  

**Sobrescreve o método:**  
- `ExibirResumo()` → mostrando dados do imóvel, segurado e sinistros.  

---

## 🔄 Parte 2: Lógica e Processamento  

### 🔹 Método `ProcessarSinistrosEmAnalise()`  
- Deve percorrer a lista de sinistros.  
- Para cada sinistro com status **EmAnalise**, alterar para **Aprovado**.  

---

## 🏁 Entrega  

O sistema deve conter uma classe principal **Program**, responsável por:  
- Criar apólices de automóvel e residencial.  
- Adicionar sinistros em diferentes status.  
- Processar sinistros em análise.  
- Exibir relatórios detalhados de cada apólice.  

---

## 🚀 Demonstração Esperada  

```csharp
// Exemplo de uso esperado no Program.cs
Apolice automovel = new ApoliceAutomovel("001", "Maurício Campos", 1200m, "ABC-1234", "Toyota Corolla");
automovel.AdicionarSinistro(new Sinistro(DateTime.Now, "Batida leve no para-choque", StatusSinistro.EmAnalise));

Apolice residencial = new ApoliceResidencial("002", "Maurício Campos", 800m, "Rua das Flores, 123");
residencial.AdicionarSinistro(new Sinistro(DateTime.Now, "Incêndio na cozinha", StatusSinistro.EmAnalise));

// Processar sinistros em análise
automovel.ProcessarSinistrosEmAnalise();
residencial.ProcessarSinistrosEmAnalise();

// Exibir relatórios
automovel.ExibirResumo();
residencial.ExibirResumo();
