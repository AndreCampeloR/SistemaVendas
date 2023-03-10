using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaVendas.Context;
using SistemaVendas.Models;
using SistemaVendas.Dto.itemPedido;

namespace SistemaVendas.Repository
{
    public class ItemPedidoRepository
    {
          private readonly VendasContext _context;

        public ItemPedidoRepository(VendasContext context)
        {
            _context = context;
        }

        public ItemPedido Cadastrar(ItemPedido item)
        {
            _context.ItensPedido.Add(item);
            _context.SaveChanges();

            return item;
        }

        public List<ItemPedido> Listar()
        {
            var item = _context.ItensPedido.ToList();
            return item;
        }
        public List<ObterItemPedidoDto> ListarPorPedido(int pedidoId)
        {
            var item = _context.ItensPedido.Where(x => x.PedidoId == pedidoId)
                                            .Select(x => new ObterItemPedidoDto(x))
                                            .ToList();
            return item;
        }

        public ItemPedido ObterPorId(int id)
        {
            var item = _context.ItensPedido.Include(x => x.Servico)
                                           .Include(x => x.Pedido)
                                           .FirstOrDefault(x => x.Id == id);
            return item; 
        }

        public ItemPedido AtualizarItemPedido(ItemPedido item)
        {
            _context.ItensPedido.Update(item);
            _context.SaveChanges();

            return item;
        }
        
        public void DeletarItemPedido(ItemPedido item)
        {
            _context.ItensPedido.Remove(item);
            _context.SaveChanges();
        }
    }
}