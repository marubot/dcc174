using System.ComponentModel.DataAnnotations;

namespace Estagios.Enums
{
    public enum TipoRemuneracaoEnum
    {
        Remunerado = 0,
        [Display(Name = "Não remunerado")]
        NaoRemunerado = 1
    }
}
