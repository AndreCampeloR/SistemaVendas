using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Dto;
using SistemaVendas.Dto.cliente;
using SistemaVendas.Models;
using SistemaVendas.Repository;

namespace SistemaVendas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteRepository _repository;
        
        public ClienteController(ClienteRepository repository)
        {
            _repository = repository;
        }
    
        [HttpPost]
        public IActionResult Cadastrar(CadastrarClienteDto dto)
        {
            var cliente = new Cliente(dto);

            _repository.Cadastrar(cliente);

            return Ok(cliente);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var cliente = _repository.Listar();

            if(cliente is not null)
            {
               return Ok(cliente);
            }
            else
            {
            return NotFound(new {Mesagem = "Cliente não encontrado"});
            }
        }

         [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var cliente = _repository.ObterPorId(id);

            if(cliente is not null)
            {
               var clienteDto = new ObterClientesDto(cliente);
               return Ok(clienteDto);
            }

            else
            {
               return NotFound(new {Mesagem = "Cliente não encontrado"});
            }
        }

        [HttpGet("ObterPorNome/{nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            var cliente = _repository.ObterPorNome(nome);
            return Ok(cliente);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, AtualizarClienteDto dto)
        {
            var cliente = _repository.ObterPorId(id);

            if(cliente is not null)
            {
                cliente.MapearAtualizarClienteDto(dto);
                _repository.AtualizarCliente(cliente);
                
                return Ok(cliente);
            }
            else
            {
                return NotFound(new { Mensagem = "Cliente não encontrado"});   
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var cliente = _repository.ObterPorId(id);

            if(cliente is not null)
            {
                _repository.DeletarCliente(cliente);
                
                return NoContent();
            }
            else
            {
                return NotFound(new { Mensagem = "Cliente não encontrado"});   
            }
        }

        [HttpPatch("{id}")]
        public IActionResult AtualizarSenha(int id, AtualizarSenhaClienteDto dto)
        {
            var cliente = _repository.ObterPorId(id);

            if(cliente is not null)
            {
                _repository.AtualizarSenha(cliente, dto);
                
                return Ok(cliente);
            }
            else
            {
                return NotFound(new { Mensagem = "Cliente não encontrado"});   
            }
        }
    }
}