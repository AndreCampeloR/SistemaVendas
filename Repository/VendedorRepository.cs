using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Context;
using SistemaVendas.Models;

namespace SistemaVendas.Repository
{
    public class VendedorRepository
    {
          private readonly VendasContext _context;

          public VendedorRepository(VendasContext context)
          {
            _context = context;
          }        

          public void cadastrar(Vendedor vendedor)
          {
            _context.Vendedores.Add(vendedor);
            _context.SaveChanges();
          }
    }
}