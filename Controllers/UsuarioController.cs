using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade_2.Models;
using Microsoft.AspNetCore.Http;
using MySqlConnector;


namespace Atividade_2.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login(Usuario u)
        {
            Repository user = new Repository();
            Usuario usuarioSessao = new Usuario();

            usuarioSessao = user.ValidarLogin(u);

            if (usuarioSessao != null)
            {
                HttpContext.Session.SetInt32("IdUsuario", usuarioSessao.IdUsuario);
                HttpContext.Session.SetString("Login", usuarioSessao.Login);
                HttpContext.Session.SetString("Senha", usuarioSessao.Senha);
                HttpContext.Session.SetString("Nivel", usuarioSessao.Nivel);
                ViewBag.Mensagem = "Login Realizado !";
                return RedirectToAction("Login");
            }
            else
            {
                ViewBag.Mensagem = "Falha no Login";
                return View();
            }
        }
        public IActionResult Cadastrousuarios()
        {
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login");
            }
            else if (HttpContext.Session.GetString("Nivel") == "Colaborador")
            {
                return RedirectToAction("Login");
            }
            else if (HttpContext.Session.GetString("Nivel") == "Usuario")
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }

        }


        [HttpPost]

        public IActionResult Cadastrousuarios(Usuario u)
        {
            Repository user = new Repository();
            user.Insert(u);
            ViewBag.Mensagem = "Cadastrado com sucesso!";
            return View();
        }

        public IActionResult Editar(int IdUsuario)
        {
            Repository user = new Repository();
            Usuario newuser = new Usuario();
            newuser = user.BuscarId(IdUsuario);
            return View(newuser);
        }

        [HttpPost]

        public IActionResult Editar(Usuario u)
        {
            Repository user = new Repository();
            user.AtualizarUsuario(u);
            ViewBag.Mensagem = "Usuario Editado!";
            return RedirectToAction("Listadeusuarios");
        }

        public IActionResult Listadeusuarios()
        {
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login");
            }
            else if (HttpContext.Session.GetString("Nivel") == "Colaborador")
            {
                return RedirectToAction("Login");
            }
            else if (HttpContext.Session.GetString("Nivel") == "Usuario")
            {
                return RedirectToAction("Login");
            }
            else
            {
                Repository user = new Repository();
                List<Usuario> lista = user.Listar();
                return View(lista);
            }


        }


        public IActionResult Excluir(int IdUsuario)
        {
            Repository u = new Repository();
            u.RemoverUsuario(IdUsuario);
            return RedirectToAction("Listadeusuarios");

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }

    }

}
