using System.ComponentModel.DataAnnotations;

namespace Estagios.Enums
{
    public enum TipoEstagioEnum
    {
        [Display(Name = "Obrigatório")]
        Obrigatorio = 0,
        [Display(Name = "Não obrigatório")]
        NaoObrigatorio = 1
    }
}
