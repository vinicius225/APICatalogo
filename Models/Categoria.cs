using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace APICatalogo.Models
{
    public class Categoria
    {
        public Categoria()
        {
             Produtos = new Collection<Produto>();
        }

        [Key]
        public int CategoriaId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty ;

        public ICollection<Produto> Produtos { get; set; }
    }
}
