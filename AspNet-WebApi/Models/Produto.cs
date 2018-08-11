using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNet_WebApi.Models
{
    [Table("produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Nome { get; set; }

        [MaxLength(100)]
        [Required]
        public string Marca { get; set; }

        [MaxLength(100)]
        [Required]
        public string Modelo { get; set; }

        [MaxLength(80)]
        public string Cor { get; set; }

        [MaxLength(2300)]
        public string Descricao { get; set; }

        [Required]
        [Column("numero_de_serie")]
        public string Codigo { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        [Range(-999999999999.99, 999999999999.99)]
        public double Preco { get; set; }
    }
}