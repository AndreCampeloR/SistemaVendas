using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Models;

namespace SistemaVendas.Dto
{
    public class ObterVendedorDto
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        public string? Login {get; set;}
        public string Senha {get; set;}

        public ObterVendedorDto(Vendedor vendedor) 
        {
            Id = vendedor.Id;
            Nome = vendedor.Nome;
            Login = vendedor.Login;
            Senha = vendedor.Senha;
        }
    }

    
}