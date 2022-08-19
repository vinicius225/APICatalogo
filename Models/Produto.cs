using System.ComponentModel.DataAnnotations;

namespace APICatalogo.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public double Preco { get; set; }
        public float Estoque { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
    }
}
