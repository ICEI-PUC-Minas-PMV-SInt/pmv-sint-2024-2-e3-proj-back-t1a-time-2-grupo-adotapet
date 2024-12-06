using Microsoft.EntityFrameworkCore;
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
        [DataType(DataType.Password)]
        public required string Senha {get;set;}

        [Required(ErrorMessage = "Perfil � necess�rio")]
        public required Perfil Perfil { get; set; }

        public required StatusUsuario Status { get; set; }

    }
    public enum Perfil 
    {
        Admin, User
    }

    public enum StatusUsuario
    {
        Ativo,
        Inativo
    }

}
