using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            Id = dto.Id;
            Nome = dto.Nome;
            Descricao = dto.Descricao;
        }

         public void MapearAtualizarSerivoDto(AtualizarServicoDto dto)
        {
            Id = dto.Id;
            Nome = dto.Nome;
            Descricao = dto.Descricao;
        }
    }
}