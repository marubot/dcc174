using Estagios.Enums;
using System.ComponentModel.DataAnnotations;

namespace Estagios.Models
{
    public class Estagio
    {
        public int Id { get; set; }

        #region Estágio
        public TipoEstagioEnum TipoEstagio { get; set; }

        public TipoConcedenteEnum TipoConcedente { get; set; }

        public TipoRemuneracaoEnum TipoRemuneracao { get; set; }

        public string? AgenteIntegracao { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataInicioEstagio { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataTerminoEstagio { get; set; }

        public SituacaoEstagioEnum SituacaoEstagio { get; set; }
        #endregion

        #region Discente
        public string? NomeDiscente { get; set; }

        public string? CPF { get; set; }

        public string? Endereco { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public string? Matricula { get; set; }

        public string? Curso { get; set; }

        public FormandoEnum Formando { get; set; }

        public string? Ira { get; set; }

        public string? Email { get; set; }
        #endregion

        #region Concedente
        public string? Setor { get; set; }

        public string? NomeEmpresa { get; set; }

        public string? NomeResponsavelEmpresa { get; set; }
        #endregion

        #region Supervisor
        public string? NomeSupervisor { get; set; }

        public string? FuncaoSupervisor { get; set; }

        public string? FormacaoSupervisor { get; set; }

        public string? EmailSupervisor { get; set; }
        #endregion

        #region Orientador
        public string? Disciplina { get; set; }

        public string? Orientador { get; set; }
        #endregion

        #region Atividades
        public string? AtividadeText { get; set; }
        #endregion
    }
}
