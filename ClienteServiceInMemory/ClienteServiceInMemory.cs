using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teste
{
    public class ClienteServiceInMemory : IClienteService
    {
        private List<Cliente> clientes = new List<Cliente>();

        public ClienteServiceInMemory()
        {
            this.clientes = new List<Cliente>() { 
                new Cliente { Nome = "Eduardo Silva", Documento  = "123456", Pais = 55},
                new Cliente { Nome = "William Magalhaes", Documento = "654321", Pais = 55}
            };
            
        }

        public void Add(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public List<Cliente> Buscar(string nome)
        {
            var cliente = clientes.Where(c => c.Nome.ToUpper().Contains(nome.ToUpper())).ToList();
            return cliente;
        }

        public Cliente Buscar(string documento, int pais)
        {
            var cliente = clientes.Where(c => c.Documento == documento).FirstOrDefault();
            return cliente;
        }
    }
}
