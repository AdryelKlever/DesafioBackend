# Desafio Backend
Construir uma aplicação SAAS. Sua tarefa é construir uma aplicação SAAS. A aplicação é um simples repositório para gerenciar médicos com seus respectivos nomes, CPF's, crm's e especialidades.

# Diagrama Lógico Desafio Backend
<img src="/imagens/DiagramaLogicoDesafioBackend.png"/>

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

