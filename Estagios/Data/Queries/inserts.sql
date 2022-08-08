-- Insere um estagio dummy no banco
insert into Estagios(TipoEstagio, TipoConcedente, TipoRemuneracao, AgenteIntegracao, DataInicioEstagio, DataTerminoEstagio, SituacaoEstagio, 
NomeDiscente,CPF, Endereco, DataNascimento, Matricula, Curso, Formando, Ira, Email, Setor, NomeEmpresa, NomeResponsavelEmpresa, NomeSupervisor, 
FuncaoSupervisor, FormacaoSupervisor, EmailSupervisor,Disciplina,Orientador, AtividadeText)
values(1, 0, 0, 'CIEESP', '13/09/2021', '', 0, 'Pedrinho', '4444444', 'Rua das Galinhas', '17/05/2000', '2018356332', 'Ciência da Computação', 0, '90'
, 'pedro@email.com', 'Teste de Software', 'Globo', 'Boninho', 'Ana Maria Braga', 'Supervisor', 'Analista de Sistemas / Apresentadora', 'ana@globo.com',
'DCCXXXX', 'Professor Xavier', 'Atividades de teste de software bla bla bla');


-- Insere um user dummy no banco
insert into Users(Username, Password) values ('admin', 'admin');