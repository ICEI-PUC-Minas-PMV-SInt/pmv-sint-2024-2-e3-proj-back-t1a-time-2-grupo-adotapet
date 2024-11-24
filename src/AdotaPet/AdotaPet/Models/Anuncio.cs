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

        public StatusAnuncio Status { get; set; }

        public DateTime DataPostagem { get; set; }

        [Required(ErrorMessage = "Obrigatório informar categoria!")]
        [Display(Name = "Categoria")]
        public Categoria CategoriaAnimal { get; set; }

        [Required(ErrorMessage = "Obrigatório informar raça!")]
        [Display(Name = "Raça")]
        public string RacaAnimal { get; set; }

        [Required(ErrorMessage = "Obrigatório informar idade!")]
        [Display(Name = "Idade")]
        public double IdadeAnimal { get; set; }

        [Display(Name = "Usuário")]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }

    public enum StatusAnuncio
    {
        Publicado,
        Deletado
    }

    public enum Categoria
    {
        Ave,
        Felino,
        Canino
    }
}
