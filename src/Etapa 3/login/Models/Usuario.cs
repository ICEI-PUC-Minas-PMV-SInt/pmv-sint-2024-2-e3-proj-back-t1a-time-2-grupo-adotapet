// Importando o namespace do BCrypt.Net
using BCrypt.Net;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_adotapet.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o perfil")]
        public Perfil Perfil { get; set; }

        // Método para criar hash da senha
        public void SetSenha(string senha)
        {
            this.Senha = BCrypt.Net.BCrypt.HashPassword(senha); // Usando BCrypt para gerar o hash da senha
        }

        // Método para verificar a senha fornecida
        public bool VerificarSenha(string senha)
        {
            return BCrypt.Net.BCrypt.Verify(senha, this.Senha); // Verificando a senha com o hash
        }
    }

    public enum Perfil
    {
        Admin,
        User
    }
}
