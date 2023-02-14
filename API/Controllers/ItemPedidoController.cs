using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Dto.itemPedido;
using SistemaVendas.Models;
using SistemaVendas.Repository;

namespace SistemaVendas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class ItemPedidoController : ControllerBase
    {
        private readonly ItemPedidoRepository _repository;

        public ItemPedidoController(ItemPedidoRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarItemPedidoDto dto)
        {
            var item = new ItemPedido(dto);
            _repository.Cadastrar(item);
            return Ok(item);
        }
        
        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            var item = _repository.Listar();

            if(item is not null)
            {
                return Ok(item);
            }
            else
            {
                return NotFound(new { Mensagem = "Não há itens"});
            }
        }

        [HttpGet("{id}")]
        public IActionResult ConsultarPorId(int id)
        {
            var item = _repository.ObterPorId(id);

            if(item is not null)
            {
                return Ok(item);
            }
            else
            {
                return NotFound(new { Mensagem = "Item não encontrado"});
            }
        }
        
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, AtualizarItemPedidoDto dto)
        {
            var item = _repository.ObterPorId(id);

            if(item is not null)
            {
                item.MapearAtualizarItemPedidoDTO(dto);
                _repository.AtualizarItemPedido(item);
                return Ok(item);
            }
            else
            {
                return NotFound(new { Mensagem = "Item não encontrado ou não existente"});
            }

        }
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var item = _repository.ObterPorId(id);


            if(item is not null)
            {
                _repository.DeletarItemPedido(item);
                return NoContent();

            }
                else
            {
                return NotFound(new { Mensagem = "Item não encontrado"});
            }
        
        }
    }
}