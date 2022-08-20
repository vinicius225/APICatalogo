using System.Data;
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

        public ProdutosController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
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
        public ActionResult<Produto> Post(Produto produto)
        {
            if (produto is null)
                return BadRequest();

            _produtoRepository.Add(produto);

            return new CreatedAtRouteResult("ObterProduto",
                new { id = produto.ProdutoId }, produto);
        }
        [HttpPut]
        public ActionResult<Produto> Put (Produto produto)
        {
            if (produto is null)
                return BadRequest();

            _produtoRepository.Update(produto);

            return Ok (produto);
        }
        [HttpDelete]
        public ActionResult<Produto> Delete(Produto produto)
        {
            if(produto != null)
            {
                _produtoRepository.Delete(produto);
                return NoContent();
            }else
            {
                return NotFound();
            }
        }
    }
}
