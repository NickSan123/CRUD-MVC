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
    public class EnderecosController : ControllerBase
    {
        private readonly MyDbContext _context;

        public EnderecosController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Enderecoes
        [HttpGet("/endereco/all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Enderecos.ToListAsync());
        }

        [HttpGet("/endereco/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var endereco = await _context.Enderecos.Where(x => x.Id == id).FirstAsync();

            if (endereco == null)
            {
                return NotFound("Endereço não encontrado");
            }
            return Ok(endereco);
        }
        [HttpDelete("/endereco/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var endereco = await _context.Enderecos.Where(x => x.Id == id).FirstAsync();

            if (endereco == null)
            {
                return NotFound("Endereco não encontrado");
            }
            _context.Enderecos.Remove(endereco);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost()]
        public async Task<IActionResult> Create(Endereco endereco)
        {
            _context.Add(endereco);
            await _context.SaveChangesAsync();

            return Ok(endereco);
        }

        [HttpPut(), EndpointDescription("Atualizar endereco")]
        public async Task<IActionResult> Edit(Endereco endereco)
        {
            var enderecoA = await _context.Enderecos.FindAsync(endereco.Id);

            if (enderecoA == null)
            {
                return NotFound("Endereco não encontrado");
            }

            _context.Update(endereco);
            await _context.SaveChangesAsync();

            return Ok(endereco);
        }
    }
}
