using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Dto.servico;

namespace SistemaVendas.Models
{
    public class Servico
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Descricao {get; set;}

        public Servico()
        {

        }

        public Servico(CadastrarServicoDto dto)
        {
            Nome = dto.Nome;
            Descricao = dto.Descricao;
        }

         public void MapearAtualizarSerivoDto(AtualizarServicoDto dto)
        {
            Nome = dto.Nome;
            Descricao = dto.Descricao;
        }
    }
}