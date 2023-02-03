using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaVendas.Context;
using SistemaVendas.Dto.pedido;
using SistemaVendas.Models;

namespace SistemaVendas.Repository
{
    public class PedidoRepository
    {
        private readonly VendasContext _context;
        
        public PedidoRepository(VendasContext context)
        {
            _context = context;
        }

        public Pedido Cadastrar(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();

            return pedido;
        }

        public Pedido ObterPorId(int id)
        {
            var pedido = _context.Pedidos.Include(x => x.Vendedor)
                                         .Include(x => x.Cliente)
                                         .FirstOrDefault(x => x.Id == id);
            return pedido;
        }

        public List<ObterPedidoDto> ObterVendedorPedido(int id)
        {
            var pedido = _context.Pedidos.Where(x => x.VendedorId == id)
                                                .Select(x => new ObterPedidoDto(x))
                                                .ToList();
            return pedido;
        }
        public List<ObterPedidoDto> ObterCleintePedido(int id)
        {
            var pedido = _context.Pedidos.Where(x => x.ClienteId == id)
                                                .Select(x => new ObterPedidoDto(x))
                                                .ToList();
            return pedido;
        }

         public Pedido AtualizarPedido(Pedido Pedido)
          {
            _context.Pedidos.Update(Pedido);
            _context.SaveChanges();

            return Pedido;
          }

          public void DeletarPedido(Pedido Pedido)
          {
            _context.Pedidos.Remove(Pedido);
            _context.SaveChanges();
          }
    }
}