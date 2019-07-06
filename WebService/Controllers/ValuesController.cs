using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebService.Controllers
{
    
    [Route("api/endereco/")]
    public class EnderecoController : Controller
    {
        private readonly Context _context;

        public EnderecoController(Context context)
        {
            _context = context;
        }

        [Route("enderecos")]
        [HttpGet]
        public ActionResult<IEnumerable<Endereco>> GetEnderecos()
        {
            return _context.Enderecos.ToList();
        }

        // GET: api/endereco/enderecos/83065230
        [HttpGet("enderecos/{cep}")]

        public IEnumerable<Endereco> GetEnderecoPorCep(string cep)
        {
            return _context.Enderecos.Where(d => d.Cep == cep);
        }

        [Route("EnderecosPorEstado")]

        // GET: api/endereco/EnderecosPorEstado/PR
        [HttpGet("EnderecosPorEstado/{estado}")]

        public IEnumerable<Endereco> GetEnderecoPorEstado(string estado)
        {
            return _context.Enderecos.Where(d => d.Uf == estado);
        }

    }
}
