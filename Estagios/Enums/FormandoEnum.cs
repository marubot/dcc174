using System.ComponentModel.DataAnnotations;

namespace Estagios.Enums
{
    public enum FormandoEnum
    {
        Sim = 0,
        [Display(Name = "Não")]
        Nao = 1
    }
}
