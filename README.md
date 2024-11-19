# Demo .NET Core 8 Web API - CRUD de Pessoas e Endereços

Este projeto é uma demonstração das arquiteturas que utilizo no desenvolvimento de Web APIs. Ele foi criado utilizando .NET Core 8, EF Core e EF Core Designer e tem como objetivo implementar um CRUD para gerenciamento de pessoas e endereços.

## Tecnologias Utilizadas

- .NET Core 8
- Entity Framework Core (EF Core)
- EF Core Designer
- SQLite

## Pré-requisitos

Antes de rodar o projeto, você precisa ter as seguintes ferramentas instaladas:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [EF Core](https://learn.microsoft.com/pt-br/ef/core/get-started/overview/install)
- [SQLite](https://learn.microsoft.com/pt-br/ef/core/providers/sqlite/?tabs=dotnet-core-cli)
- [Visual Studio](https://visualstudio.microsoft.com/) ou outro editor de código de sua escolha

## Configurando o Projeto
Antes de rodar o projeto, você precisa ter as seguintes configurações:
### Passo 1: Adicionar as migrations
```bash
dotnet ef migrations add Inicial
```
### Passo 2: Criar/Atualizar o banco
```bash
dotnet ef database update
```

## Rodando o Projeto

### Passo 1: Clone o Repositório

Clone este repositório para sua máquina local:

```bash
git clone https://github.com/NickSan123/CRUD-MVC.git
```



### Passo 2: Navegue até a raiz
```bash
cd CRUD-MVC
```
### Passo 3: Execute o projeto.
```bash
dotnet run
```