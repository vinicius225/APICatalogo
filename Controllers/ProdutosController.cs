using APICatalogo.Models;
using APICatalogo.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProdutosController(IProdutoRepository produtoRepository, ICategoryRepository categoryRepository)
        {
            _produtoRepository = produtoRepository;
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produtos = _produtoRepository.GetAll();
            if (produtos.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(produtos);
            }
        }
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Produto>> Get(int id)
        {
            var produtos = _produtoRepository.GetById(id);
            if (produtos == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(produtos);
            }
        }

        [HttpPost]
        public ActionResult Post(Produto produto)
        {
            if (produto is null)
                return BadRequest();

            _produtoRepository.Add(produto);

            return new CreatedAtRouteResult("ObterProduto",
                new { id = produto.ProdutoId }, produto);
        }
    }
}
