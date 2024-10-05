using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdotaPet.Models
{
    [Table("Animais")]
    public class Animal
    {
        [Required(ErrorMessage = "Obrigatório informar tipo!")]
        public int Tipo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar raça!")]
        public int Raca { get; set; }

        [Required(ErrorMessage = "Obrigatório informar idade!")]
        public double Idade { get; set; }

    }
}
