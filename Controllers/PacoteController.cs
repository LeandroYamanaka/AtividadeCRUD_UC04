using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade_2.Models;
using Microsoft.AspNetCore.Http;

namespace Atividade_2.Controllers
{
    public class PacoteController : Controller
    {

        public IActionResult EditarPacote(int IdPacote)
        {
            PacoteRepository pack = new PacoteRepository();
            Pacote x = pack.BuscarId(IdPacote);
            return View(x);
        }

        [HttpPost]

        public IActionResult EditarPacote(Pacote pacoteEncontrado)
        {
            PacoteRepository pack = new PacoteRepository();
            pack.EditarPacote(pacoteEncontrado);
            ViewBag.Mensagem = "Pacote Editado!";
            return RedirectToAction("Listadepacotes");
        }

        public IActionResult Vitrine()
        {
            PacoteRepository pack = new PacoteRepository();
            List<Pacote> listpacote = pack.Listar();
            return View(listpacote);
        }

        public IActionResult Listadepacotes()
        {
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Vitrine");

            if (HttpContext.Session.GetString("Nivel") == "Usuario")
                return RedirectToAction("Vitrine");

            PacoteRepository pack = new PacoteRepository();
            List<Pacote> listpacote = pack.Listar();
            return View(listpacote);
        }
        public IActionResult Registrarpacotes()
        {
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Vitrine");

            if (HttpContext.Session.GetString("Nivel") == "Usuario")
                return RedirectToAction("Vitrine");
            return View();
        }

        [HttpPost]

        public IActionResult Registrarpacotes(Pacote x)
        {
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Vitrine");

            if (HttpContext.Session.GetString("Nivel") == "Usuario")
                return RedirectToAction("Vitrine");

            PacoteRepository pack = new PacoteRepository();
            pack.Insert(x);
            ViewBag.Mensagem = "Pacote Cadastrado !";
            return View();
        }
        public IActionResult Excluir(int IdPacote)
        {
            PacoteRepository x = new PacoteRepository();
            x.RemoverPacote(IdPacote);
            return RedirectToAction("Listadepacotes");

        }

    }
}