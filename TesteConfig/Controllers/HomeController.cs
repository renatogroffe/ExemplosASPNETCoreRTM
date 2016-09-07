﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace TesteConfig.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _configuration;

        public HomeController(
            IConfiguration config)
        {
            _configuration = config;
        }

        public IActionResult Index()
        {
            ViewData["Config1"] =
                _configuration["Configuracoes:Configuracao1"];

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact(
            [FromServices]IOptions<Contato> valoresContato)
        {
            Contato contato = valoresContato.Value;

            ViewData["NomeContato"] = contato.Nome;
            ViewData["EmailContato"] = contato.Email;
            ViewData["TelefoneContato"] = contato.Telefone;

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
