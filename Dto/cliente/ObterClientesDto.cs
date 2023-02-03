using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Models;

namespace SistemaVendas.Dto.cliente
{
    public class ObterClientesDto
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        public string? Login {get; set;}

        public ObterClientesDto(Cliente cliente) 
        {
            Id = cliente.Id;
            Nome = cliente.Nome;
            Login = cliente.Login;
        }
    }
    
}