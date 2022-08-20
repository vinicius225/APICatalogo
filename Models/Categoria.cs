using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICatalogo.Models
{
    [Table("Categorias")]
    public class Categoria
    {


        [Key]
        public int CategoriaId { get; set; }
        [Required]
        [StringLength(30)]
        public string Nome { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty ;

        [JsonIgnore]
        public ICollection<Produto> Produtos { get; set; }
    }
}
