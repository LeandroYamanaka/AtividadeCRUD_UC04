using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade_2.Models;

namespace Atividade_2.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Contato(Contato y)
        {
            ContatoRepository NewContato = new ContatoRepository();
            NewContato.Insert(y);
            ViewBag.Mensagem = "Sua mensagem foi enviada!";
            return View();
        }
    }
}