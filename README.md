# Desafio Backend
Construir uma aplicação SAAS. A tarefa é construir uma aplicação SAAS. A aplicação é um simples repositório para gerenciar médicos com seus respectivos nomes, CPF's, crm's e especialidades. A aplicação deve ser construída em .NET Core 3.1, utilizando EF Core com banco de dados PostgreSQL ou SQL SERVER, podendo utilizar qualquer lib disponível no NuGET. A API deverá ser documentada utilizando o formato OpenAPI (antigo Swagger).

<h2>O que será avaliado</h2>

- Código bem escrito e limpo;
- Quais libs foram usadas, como e porquê, além do conhecimento das mesmas;
- Conhecimento em banco de dados, requisições HTTP, APIs REST, etc;
- Capacidade de documentação da sua parte da aplicação.
- Organização do repositório

<h2>O mínimo necessário</h2>

- Uma aplicação contendo uma API real simples, sem autenticação, que atenda os requisitos descritos abaixo, fazendo requisições à um banco de dados para persistência;
- README.md contendo informações básicas do projeto e como executá-lo;
- OpenAPI da aplicação

# Guia Prático de Git sem complicação por Roger Dudler
Comandos para trabalhar com git:
https://rogerdudler.github.io/git-guide/index.pt_BR.html

# Instalação de lib's utilizadas
Abra o terminal no Visual Studio indo em: Ferramentas > Gerenciador de Pacotes do NuGet > Gerenciar Pacotes do NuGet para a Solução... e cole os nomes abaixo na opção "Procurar":
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.Extensions.Configuration.FileExtensions
- Microsoft.Extensions.Configuration.Json
- Microsoft.AspNetCore.Authentication
- Microsoft.AspNetCore.Authentication.JwtBearer
- Swashbuckle.AspNetCore

Artigo sobre ASP.NET Core - Autenticação e Autorização por balta.io:
https://balta.io/blog/aspnet-core-autenticacao-autorizacao

Projeto exemplo de utilização de Jwt feito por Adryel Klever: https://drive.google.com/file/d/1KXl7QC729iPYz9kOufCBct2g9N1vpxsL/view?usp=sharing

# Execução do Projeto
- 1.Clone o repositório em sua maquina e abra-o no Visual Studio
