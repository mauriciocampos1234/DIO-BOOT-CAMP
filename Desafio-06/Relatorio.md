# Relatório Técnico de Implementação de Serviços AWS

**Data:** 10/07/2025  
**Empresa:** Abstergo Industries  
**Responsável:** Maurício Campos  

---

## Introdução

Este documento descreve o processo de implementação de serviços na AWS realizado na empresa **Abstergo Industries**, com foco em **redução imediata de custos operacionais**. A iniciativa foi conduzida por **Maurício Campos** e teve como objetivo a adoção de três serviços-chave da AWS.

---

## Descrição do Projeto

A implementação foi estruturada em **três etapas**, cada uma com metas específicas voltadas à eficiência e economia de recursos em nuvem.

### Etapa 1 — AWS Lambda

**Objetivo:**  
Reduzir custos com infraestrutura e execução de código sob demanda.

**Implementação:**  
Utilização de **funções serverless (AWS Lambda)** para processamento em lote de dados, eliminando a dependência de servidores dedicados.  
Resultados esperados incluem:
- Diminuição de instâncias EC2 ociosas
- Pagamento apenas pelo tempo de execução do código

---

### Etapa 2 — Amazon S3 (Simple Storage Service)

**Objetivo:**  
Oferecer armazenamento escalável e com melhor custo-benefício.

**Implementação:**  
Migração de arquivos estáticos e backups para o **Amazon S3**, utilizando:
- Classes como **S3 Standard** para arquivos acessados com frequência
- **S3 Glacier** para arquivos de acesso esporádico

**Benefícios:**
- Redução de custos com armazenamento local (on-premises)
- Facilidade de escalabilidade

---

### Etapa 3 — AWS Cost Explorer

**Objetivo:**  
Monitoramento e análise de gastos para identificar oportunidades de economia.

**Implementação:**  
Configuração do **AWS Cost Explorer** para:
- Identificação de recursos subutilizados ou inativos
- Desativação de instâncias EC2 desnecessárias
- Otimização de políticas de armazenamento

---

## Conclusão

A implementação das soluções AWS trouxe **redução significativa dos custos operacionais**, aliada a **melhorias na eficiência dos processos de TI** e **maior controle sobre os recursos em nuvem**.  

Recomenda-se:
- Manutenção e monitoramento contínuo das soluções adotadas
- Avaliação constante de novos serviços e ferramentas da AWS para otimização contínua

---

## Justificativa Técnica das Escolhas

- **AWS Lambda:** Serviço serverless que elimina a necessidade de infraestrutura dedicada e fatura apenas pelo uso efetivo.
- **Amazon S3:** Armazenamento flexível, econômico e escalável, com opções de classes para diferentes necessidades de acesso.
- **AWS Cost Explorer:** Ferramenta essencial para monitoramento financeiro, oferecendo visibilidade detalhada para decisões baseadas em dados.

Essas escolhas alinham-se diretamente ao objetivo central do projeto: **reduzir custos imediatos na infraestrutura AWS da empresa**.

---

**Assinatura do Responsável:**  
Maurício Campos
