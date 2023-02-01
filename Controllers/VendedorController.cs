using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Dto;
using SistemaVendas.Repository;
using SistemaVendas.Models;

namespace SistemaVendas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendedorController : ControllerBase
    {
        private readonly VendedorRepository _repository;
        
        public VendedorController(VendedorRepository repository)
        {
            _repository = repository;
        }
        
        [HttpPost]
        public IActionResult Cadastrar(CadastrarVendedorDto dto)
        {
            var vendedor = new Vendedor(dto);

            _repository.Cadastrar(vendedor);

            return Ok(vendedor);
        }
        
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var vendedor = _repository.ObterPorId(id);

            if(vendedor is not null)
            {
               var vendedorDto = new ObterVendedorDto(vendedor);
               return Ok(vendedorDto);
            }

            else
               return NotFound(new {Mesagem = "Vendedor não encontrado"});
        }
    }
}