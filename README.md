Enunciado:

Projeto: Sistema de Gestão de Inscrição em Cursos Online
Descrição Geral
Este projeto tem como objetivo desenvolver um Sistema de Gestão de Inscrição em Cursos Online, permitindo o registo de cursos e a inscrição de alunos nesses cursos.
A solução será composta por uma base de dados SQL Server com três tabelas, onde a relação N para N será implementada entre Cursos e Alunos, possibilitando que um aluno esteja inscrito em vários cursos e que um curso tenha vários alunos inscritos.
Uma aplicação WinForms em C# será desenvolvida para interagir com esta base de dados, implementando as operações CRUD (Create, Read, Update, Delete) e utilizando Stored Procedures para a manipulação dos dados.

Requisitos do Projeto
1. Base de Dados (SQL Server)
A base de dados conterá as seguintes tabelas:
• Curso (IdCurso, Nome, Descrição, CargaHoraria, DataInicio)
• Aluno (IdAluno, Nome, Email, DataNascimento, Telefone)
• Curso_Aluno (IdCurso (FK), IdAluno (FK), DataInscricao)
A tabela Curso_Aluno será responsável pelo relacionamento N para N, permitindo registar quais alunos estão inscritos em quais cursos e a data da inscrição.

Stored Procedures a serem implementadas:
• spAdicionarCurso (Registo de um novo curso)
• spAtualizarCurso (Edição dos detalhes de um curso)
• spRemoverCurso (Remoção de cursos)
• spListarCursos (Consulta de cursos disponíveis)
• spAdicionarAluno (Registo de um novo aluno)
• spAtualizarAluno (Edição dos detalhes de um aluno)
• spRemoverAluno (Remoção de alunos da base de dados)
• spAssociarAlunoCurso (Inscrição de um aluno num curso)
• spRemoverAlunoCurso (Remoção da inscrição de um aluno num curso)
• spListarAlunosPorCurso (Consulta de alunos inscritos num curso específico)

3. Aplicação WinForms em C#
A interface gráfica permitirá:
 Gestão de Cursos (CRUD de cursos)
 Gestão de Alunos (CRUD de alunos)
 Gestão de Inscrições (Gestão da relação N para N entre alunos e cursos)
 Consulta de Alunos por Curso (Listagem de alunos inscritos num curso específico)

Objetivo Final
O projeto resultará num sistema funcional que permitirá gerir eficazmente as inscrições em cursos online, garantindo um registo adequado dos alunos e facilitando a organização dos cursos oferecidos.

Parâmetros de Avaliação
• Modelo e implementação da base de dados
• Implementação das stored procedures
• Código eficiente e modular. (funções, procedimentos, variáveis com nomes percetíveis)
• Organização do código
• Funcionalidades implementadas
• Vídeo com som e câmara ligada explicando todas as funcionalidades implementadas.

• Para valores iguais ou superiores a 17 deverão os dados ser guardados também em ficheiros de texto.
• Será descontado 1 valor por cada dia depois do prazo de entrega.

Calendarização
• 1ª Entrega – CRUD Completo de uma tabela – 22/01/2026
• Entrega Final com vídeo explicativo da aplicação – 05/02/2026
