using System;
using System.Collections.Generic;
using System.Text;

namespace Teste
{
    public interface IClienteService
    {

        List<Cliente> Buscar(string nome);
        Cliente Buscar(string documento, int pais);

        void Add(Cliente cliente);

    }
}
