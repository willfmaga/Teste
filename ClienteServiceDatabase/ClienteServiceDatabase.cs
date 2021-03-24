using System;
using System.Collections.Generic;
using System.Linq;

namespace Teste
{
    public class ClienteServiceDatabase : IClienteService
    {
        private List<Cliente> _clientes;

        public ClienteServiceDatabase()
        {
            _clientes = Util.CarregarClientesBanco();
        }

        public void Add(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        public List<Cliente> Buscar(string nome)
        {
            var cliente = _clientes.Where(c => c.Nome.ToUpper().Contains(nome.ToUpper())).ToList();
            return cliente;
        }

        public Cliente Buscar(string documento, int pais)
        {
            var cliente = _clientes.Where(c => c.Documento == documento).FirstOrDefault();
            return cliente;
        }
    }
}
