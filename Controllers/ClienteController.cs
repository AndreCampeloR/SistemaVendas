using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Repository;

namespace SistemaVendas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteRepository _repository;
        
        public ClienteController(ClienteRepository repository)
        {
            _repository = repository;
        }
    
        
    }
}