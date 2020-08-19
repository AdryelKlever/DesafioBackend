# Desafio Backend
Construir uma aplicação SAAS. Sua tarefa é construir uma aplicação SAAS. A aplicação é um simples repositório para gerenciar médicos com seus respectivos nomes, CPF's, crm's e especialidades.

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
