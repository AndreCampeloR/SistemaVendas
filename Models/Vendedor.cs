using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Dto;

namespace SistemaVendas.Models
{
    public class Vendedor
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        public string? Login {get; set;}
        public string? Senha {get; set;}

        public Vendedor()
        {

        }

        public Vendedor(CadastrarVendedorDto dto)
        {
            Nome  = dto.Nome;
            Login = dto.Login;
            Senha = dto.Senha;
        }

        public void MapearAtualizarVendedorDto(AtualizarVendedorDto dto)
        {
            Nome  = dto.Nome;
            Login = dto.Login;
            Senha = dto.Senha;
        }
    }
}