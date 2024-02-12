using System.ComponentModel.DataAnnotations;
using System.Data;

namespace RazorPagesFilmes.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        [Display(Name ="Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        [Display(Name = "Gênero")]
        public string Genero { get; set; } = string.Empty;
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        [Display(Name = "Avaliação")]
        public int Avaliacao { get; set; } = 0;
    }
}
