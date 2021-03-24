using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Teste
{
    public static class Util
    {
        public static List<Cliente> CarregarClientesBanco()
        {
            var conteudobanco = File.ReadAllText("clientes.txt");
            var clientes = JsonConvert.DeserializeObject<List<Cliente>>(conteudobanco);
            return clientes;
        }


    }
}
