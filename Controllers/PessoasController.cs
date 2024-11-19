using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUD_MVC.Data;
using CRUD_MVC.Models;

namespace CRUD_MVC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoasController : ControllerBase
    {
        private readonly MyDbContext _context;

        public PessoasController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Pessoas
        [HttpGet("/pessoa/all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Pessoas.ToListAsync());
        }
        [HttpGet("/pessoa/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var pessoa = await _context.Pessoas.Where(x => x.Id == id).FirstAsync();

            if(pessoa == null)
            {
                return NotFound("Pessoa não encontrada");
            }
            return Ok(pessoa);
        }
        [HttpDelete("/pessoa/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var pessoa = await _context.Pessoas.Where(x => x.Id == id).FirstAsync();

            if (pessoa == null)
            {
                return NotFound("Pessoa não encontrada");
            }
            _context.Pessoas.Remove(pessoa);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("/pessoa")]
        public async Task<IActionResult> Create(Pessoa pessoa)
        {
            _context.Add(pessoa);
            await _context.SaveChangesAsync();
            
            return Ok(pessoa);
        }

        [HttpPut("/pessoa"), EndpointDescription("Atualizar pessoa")]
        public async Task<IActionResult> Edit(Pessoa pessoa)
        {
            var pessoaA = await _context.Pessoas.FindAsync(pessoa.Id);

            if (pessoaA == null)
            {
                return NotFound("Pessoa não encontrada");
            }

            _context.Update(pessoa);
            await _context.SaveChangesAsync();

            return Ok(pessoa);
        }
    }
}
