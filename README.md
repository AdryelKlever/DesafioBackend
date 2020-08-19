# Desafio Backend
Construir uma aplicação SAAS. A tarefa é construir uma aplicação SAAS. A aplicação é um simples repositório para gerenciar médicos com seus respectivos nomes, CPF's, crm's e especialidades. A aplicação deve ser construída em .NET Core 3.1, utilizando EF Core com banco de dados PostgreSQL ou SQL SERVER, podendo utilizar qualquer lib disponível no NuGET. A API deverá ser documentada utilizando o formato OpenAPI (antigo Swagger).
<h2>O que será avaliado</h2>

# Guia Prático de Git sem complicação por Roger Dudler
Comandos para trabalhar com git:
https://rogerdudler.github.io/git-guide/index.pt_BR.html

# Diagrama Lógico Desafio Backend
<img src="/img/DiagramaLogicoDesafioBackend.png"/>

# Diagrama Físico Desafio Backend
CREATE TABLE [Medico] (
  [IdMedico] <type>,
  [NomeMedico] <type>,
  [CPF] <type>,
  [CMR] <type>
);

CREATE TABLE [Especialidade] (
  [IdEspecialidade] <type>,
  [NomeEspecialidade] <type>
);
  
# Instalação de lib's utilizadas
Abra o terminal no Visual Studio indo em: Ferramentas > Gerenciador de Pacotes do NuGet > Console do Gerenciador de Pacotes e execute os comandos abaixo:
- Install-Package Microsoft.EntityFrameworkCore.SqlServer
- Install-Package Microsoft.EntityFrameworkCore.Tools
- Install-Package Microsoft.AspNetCore.Authentication
- Install-Package Microsoft.AspNetCore.Authentication.JwtBearer

Artigo sobre ASP.NET Core - Autenticação e Autorização por balta.io:
https://balta.io/blog/aspnet-core-autenticacao-autorizacao

Projeto exemplo de utilização de Jwt feito por Adryel Klever: https://drive.google.com/file/d/1KXl7QC729iPYz9kOufCBct2g9N1vpxsL/view?usp=sharing
