# Sistema de Gerenciamento de Estágios - [DCC174] IHC
## Objetivo
O objetivo deste projeto é produzir uma aplicação com base nos wireframes confeccionados 
durante a parte 2 do trabalho da disciplina de DCC174 - Interação Humano Computador.

## Tecnologias utilizadas
- **Front-end:** Razor pages & Bootstrap
- **Back-end**
    - **Linguagem:** C# 
    - **Framework:** ASP .NET MVC 5 
    - **SGBD:** SQL Server
    - **ORM:** Entity Framework Core
- **Version control:** Git

# Instalação
>  [.NET SDK](https://dotnet.microsoft.com/en-us/download) é necessário para rodar o projeto.
 Clone o repositório para os passos a seguir.

## 1 - Como configurar o banco de dados
>  Estarei utilizando o SSMS para o guia, porém pode ser realizado pelo cli.

1. Tenha o  SQL Server instalado na máquina 
2. Abra o SSMS e crie um novo banco de dados com o nome Estagios
3. Abra o arquivo appsettings.json do projeto, que se encontra em Estagios/Estagios
4. Pegue a connection string do banco que acabou de criar e cole-a na linha 9, substituindo o valor existente.
5. Abra o terminal
6. Execute os comandos
```sh
cd Estagios/Estagios
dotnet ef database update
```

## 2 - Como registrar um usuário para login
1. Execute, no banco criado, as queries que se encontram no diretório abaixo
```sh
cd Estagios/Estagios/Data/Queries
```

## 3 - Como rodar o projeto
1. Abra o terminal no diretório raiz onde o repo foi clonado
2. Digite:
```sh
cd Estagios/Estagios
```
4. Utilize o comando abaixo para rodar o projeto
```sh
dotnet run
```
