using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using APICatalogo.Models;
using APICatalogo.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    public class CategoriasController : Controller
    {

#region  Repositories
        private readonly ICategoryRepository _categoryRepository;

#endregion

#region Construtor
        public CategoriasController(ICategoryRepository categortRepository)
        {
            _categoryRepository = categortRepository;
        }
#endregion

        [HttpGet]
        public ActionResult<List<Categoria>> Get()
        {
            var categoria = _categoryRepository.GetAll().ToList();
            return Ok(categoria);
        }
        [HttpGet("{id}")]
        public ActionResult<Categoria> Get(int id)
        {
            var categoria = _categoryRepository.GetById(id);
            if(categoria != null)
            {
                return Ok(categoria);
            }else
            {
                return NotFound();
            }
        }
        [HttpPut]
        public ActionResult<Produto> Put(Categoria categoria)
        {
            _categoryRepository.Update(categoria);
            return new CreatedAtRouteResult("Get",
                new { id = categoria.CategoriaId }, categoria);
        }
        [HttpPost]
        public ActionResult<Categoria> Post (Categoria categoria)
        {
            try{

                _categoryRepository.Add(categoria);
                return Ok(categoria);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            return BadRequest();
        }
    }
}