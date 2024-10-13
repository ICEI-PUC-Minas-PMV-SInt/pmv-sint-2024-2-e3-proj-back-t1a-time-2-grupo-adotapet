using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdotaPet.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id {get;set;}

        [Required(ErrorMessage = "Email � necess�rio")]
        public required string Email {get;set;}

        [Required(ErrorMessage = "Senha � necess�ria")]
        public required string Senha {get;set;}

        [Required(ErrorMessage = "Nome � necess�rio")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "CPF � necess�rio")]
        public required string CPF { get; set; }
    }
}
