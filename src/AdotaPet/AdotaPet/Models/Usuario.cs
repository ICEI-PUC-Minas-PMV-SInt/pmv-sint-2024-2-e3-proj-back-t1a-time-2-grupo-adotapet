using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdotaPet.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Email é necessário")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Senha é necessária")]
        public required string Senha { get; set; }

        [Required(ErrorMessage = "Nome é necessário")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "CPF é necessário")]
        public required string CPF { get; set; }
    }
}
