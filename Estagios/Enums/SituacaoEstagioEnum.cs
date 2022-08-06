using System.ComponentModel.DataAnnotations;

namespace Estagios.Enums
{
    public enum SituacaoEstagioEnum
    {
        [Display(Name = "Em andamento")]
        Andamento = 0,
        Finalizado = 1,
        Cancelado = 2
    }
}
