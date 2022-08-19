using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [StringLength(80)]
        [Required]
        public string Nome { get; set; } = string.Empty;
        [StringLength(300)]
        public string Descricao { get; set; } = string.Empty;
        [Column(TypeName = "decimal(10,2")]
        public double Preco { get; set; }
        public float Estoque { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
    }
}
