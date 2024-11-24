using System.ComponentModel.DataAnnotations;

namespace AdotaPet.Models
{
    public class Interacao
    {
        [Key]
        public int Id { get; set; }

        public string DescricaoInteracao { get; set; }
    }
}
