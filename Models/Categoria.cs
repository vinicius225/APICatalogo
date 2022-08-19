using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        public Categoria()
        {
             Produtos = new Collection<Produto>();
        }

        [Key]
        public int CategoriaId { get; set; }
        [Required]
        [StringLength(0)]
        public string Nome { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty ;

        public ICollection<Produto> Produtos { get; set; }
    }
}
