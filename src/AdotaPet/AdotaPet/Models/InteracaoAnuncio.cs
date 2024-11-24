using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdotaPet.Models
{
    public class InteracaoAnuncio
    {
        [Key]
        public int Id { get; set; }

        public int InteracaoId { get; set; }

        [ForeignKey("InteracaoId")]
        public Interacao Interacao { get; set; }

        public int AnuncioId { get; set; }

        [ForeignKey("AnuncioId")]
        public Anuncio Anuncio { get; set; }

        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

    }
}
