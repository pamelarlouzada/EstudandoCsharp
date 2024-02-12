using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace RazorPagesFilmes.Models
{
    public class Filme
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength =3)]
        [MaxLength(100, ErrorMessage ="errou")]
        public string Titulo { get; set; } = string.Empty;

        [Display(Name ="Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage ="Digite o gênero do filme")]
        [StringLength(30, MinimumLength = 3)]
        [Display(Name = "Gênero")]
        public string Genero { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Preco { get; set; }

        [Display(Name = "Avaliação")]
        [Range(0,10)]
        public int Avaliacao { get; set; } = 0;
    }
}
