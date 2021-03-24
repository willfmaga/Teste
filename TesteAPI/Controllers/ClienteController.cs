using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste;

namespace TesteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            this._clienteService = clienteService;
        }

        [HttpGet]
        [Route("{documento}/{pais}")]
        public Cliente Find(string documento,int pais)
        {
            var cliente = _clienteService.Buscar(documento, pais);

            return cliente;
        }

        [HttpGet]
        [Route("{action}/{nome}")]
        public List<Cliente> Find(string nome)
        {
            var clientes = _clienteService.Buscar(nome);

            return clientes;
        }



    }
}
