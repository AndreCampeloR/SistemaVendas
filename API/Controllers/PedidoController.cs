using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Dto;
using SistemaVendas.Dto.pedido;
using SistemaVendas.Models;
using SistemaVendas.Repository;

namespace SistemaVendas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly PedidoRepository _repository;
        
        public PedidoController(PedidoRepository repository)
        {
            _repository = repository;
        }
    
        [HttpPost]
        public IActionResult Cadastrar(CadastrarPedidoDto dto)
        {
            var pedido = new Pedido(dto);

            _repository.Cadastrar(pedido);

            return Ok(pedido);
        }

        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            var pedido = _repository.Listar();

            if(pedido is not null)
            {
               return Ok(pedido);
            }
            else
            {
            return NotFound(new {Mesagem = "Pedido não encontrado"});
            }
        }

         [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var pedido = _repository.ObterPorId(id);

            if(pedido is not null)
            {
               return Ok(pedido);
            }

            else
               return NotFound(new {Mesagem = "Pedido não encontrado"});
        }
         [HttpGet("ObterVendedorPedido/{id}")]
        public IActionResult ObterVendedorPedido(int id)
        {
            var pedido = _repository.ObterVendedorPedido(id);

            if(pedido is not null)
            {
               return Ok(pedido);
            }

            else
               return NotFound(new {Mesagem = "Pedido não encontrado"});
        }
         [HttpGet("ObterClientePedido/{id}")]
        public IActionResult ObterClientePedido(int id)
        {
            var pedido = _repository.ObterCleintePedido(id);

            if(pedido is not null)
            {
               return Ok(pedido);
            }

            else
               return NotFound(new {Mesagem = "Pedido não encontrado"});
        }
        
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, AtualizarPedidoDto dto)
        {
            var pedido = _repository.ObterPorId(id);

            if(pedido is not null)
            {
                pedido.MapearAtualizarPedidoDto(dto);
                _repository.AtualizarPedido(pedido);
                
                return Ok(pedido);
            }
            else
            {
                return NotFound(new { Mensagem = "Pedido não encontrado"});   
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var pedido = _repository.ObterPorId(id);

            if(pedido is not null)
            {
                _repository.DeletarPedido(pedido);
                
                return NoContent();
            }
            else
            {
                return NotFound(new { Mensagem = "Pedido não encontrado"});   
            }
        }
    }
}