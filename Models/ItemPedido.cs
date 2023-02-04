using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Dto.itemPedido;

namespace SistemaVendas.Models
{
    public class ItemPedido
    {
        public int Id {get; set;}
        public int PedidoId {get; set;}
        public Pedido Pedido {get; set;}
        public int ServicoId {get; set;}
        public Servico Servico {get; set;}
        public int Quantidade {get; set;}
        public decimal Valor {get; set;}

         public ItemPedido()
        {

        }

        public ItemPedido(CadastrarItemPedidoDto dto)
        {
            PedidoId = dto.PedidoId;
            ServicoId = dto.ServicoId;
            Quantidade = dto.Quantidade;
            Valor = dto.Valor;
        }

        public void MapearAtualizarItemPedidoDTO(AtualizarItemPedidoDto dto)
        {
            PedidoId = dto.PedidoId;
            ServicoId = dto.ServicoId;
            Quantidade = dto.Quantidade;
            Valor = dto.Valor;
        }
    }
}