using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Models;

namespace SistemaVendas.Dto.servico
{
    public class ObterServicoDto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }

        public ObterServicoDto(Servico servico)
        {
            Id = servico.Id;
            Nome = servico.Nome;
            Descricao = servico.Descricao;
        }
    }
}