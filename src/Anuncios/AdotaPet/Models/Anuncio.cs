using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdotaPet.Models
{
    [Table("Anuncios")]
    public class Anuncio
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar título!")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
       
        [Required(ErrorMessage = "Obrigatório informar descrição!")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar tipo!")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar raça!")]
        [Display(Name = "Raça")]
        public string Raca { get; set; }

        [Required(ErrorMessage = "Obrigatório informar idade!")]
        public double Idade { get; set; }
    }
}
