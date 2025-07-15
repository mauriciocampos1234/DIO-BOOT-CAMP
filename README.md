# Descrição

Neste LAB, vamos criar uma API utilizando a técnica de **Minimal APIs** para o registro de veículos, ampliando suas funcionalidades ao incorporar administradores com regras **JWT**. Ao explorarmos o funcionamento da API, nos familiarizaremos com o uso do **Swagger**, além de trabalharmos com **testes**, garantindo a robustez e confiabilidade do sistema que estaremos desenvolvendo.

---

## Pacotes usados para a API

- `"Microsoft.AspNetCore.Authentication.JwtBearer" Version="9.0.3`  
  _Autenticação via JWT em APIs ASP.NET Core_

- `"Microsoft.EntityFrameworkCore" Version="9.0.3"`  
  _Funcionalidade principal do Entity Framework Core para ORM_

- `"Microsoft.EntityFrameworkCore.Design" Version="9.0.3"`  
  _Ferramentas de design-time para EF Core, como migrações_

- `"Microsoft.EntityFrameworkCore.Tools" Version="9.0.3"`  
  _Ferramentas CLI para EF Core, como gerenciamento de migrações_

- `"Pomelo.EntityFrameworkCore.MySql" Version="9.0.0-preview.3.efcore.9.0.0"`  
  _Provedor MySQL para EF Core_

- `"Swashbuckle.AspNetCore" Version="9.0.3"`  
  _Geração de documentação Swagger/OpenAPI para APIs ASP.NET Core_

> **Tecnologias:** dotnet versão 9 | C# | MySQL (CRUD)

---

## Pacotes usados para Testes

- `"coverlet.collector" Version="6.0.4"`  
  _Coleta de cobertura de código durante testes_

- `"Microsoft.NET.Test.Sdk" Version="17.12.0"`  
  _SDK para executar testes no .NET_

- `"MSTest" Version="3.6.4"`  
  _Framework de teste MSTest para .NET_

- `"MSTest.Analyzers" Version="4.0.0-preview.25358.7"`  
  _Análises estáticas para melhorar testes MSTest_

- `"MSTest.TestAdapter" Version="4.0.0-preview.25358.7"`  
  _Adaptador para executar testes MSTest no Visual Studio/Test Explorer_

- `"MSTest.TestFramework" Version="4.0.0-preview.25358.7"`  
  _Framework principal para escrever testes MSTest_

- `"Microsoft.VisualStudio.TestTools.UnitTesting"`  
  _Namespace com atributos e métodos para testes unitários no MSTest_

---

## Imagens

### Diagrama da Arquitetura
![Diagrama da Arquitetura](caminho/para/diagrama-arquitetura.png)

### Fluxo de Autenticação JWT
![Fluxo JWT](caminho/para/fluxo-jwt.png)
