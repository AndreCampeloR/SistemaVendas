using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Context;
using SistemaVendas.Dto.cliente;
using SistemaVendas.Models;

namespace SistemaVendas.Repository
{
    public class ClienteRepository
    {
        private readonly VendasContext _context;
        
        public ClienteRepository(VendasContext context)
        {
            _context = context;
        }

        public void Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public List<Cliente> Listar()
        {
          var Cliente = _context.Clientes.ToList();
          return Cliente;
        }

         public Cliente ObterPorId(int id)
          {
            var cliente = _context.Clientes.Find(id);
            return cliente;
          }

          public List<ObterClientesDto> ObterPorNome(string nome)
          {
            var cliente = _context.Clientes.Where(x => x.Nome.Contains(nome))
                                                .Select(x => new ObterClientesDto(x))
                                                .ToList();
            return cliente;
          }

          public Cliente AtualizarCliente(Cliente cliente)
          {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();

            return cliente;
          }

          public void DeletarCliente(Cliente cliente)
          {
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
          }

          public void AtualizarSenha(Cliente cliente, AtualizarSenhaClienteDto dto)
          {
             cliente.Senha = dto.Senha;
             AtualizarCliente(cliente);
          }
    }
}