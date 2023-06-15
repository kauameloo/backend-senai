using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projeto_gamer.Infra;
using projeto_gamer.Models;

namespace projeto_gamer.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }
        [TempData]
        public string Message { get; set; }

        Context c = new Context();
        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Username = HttpContext.Session.GetString("Username");

            // se não tiver um usuario logado
            if (ViewBag.Username == null)
            {
                // ir para a pagina de login
                Message = "Acesso Negado! Efetue login para acessar esta página..";
                return LocalRedirect("~/Login/Login");
            }
            else
            {
                // mochila que contém lista de jogadores
                ViewBag.Jogador = c.Jogador.ToList();

                // mochila que contém lista de equipes
                ViewBag.Equipe = c.Equipe.ToList();

                // retorna view do jogador
                return View();
            }
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["IdEquipe"].ToString());

            c.Jogador.Add(novoJogador);

            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            Jogador j = c.Jogador.First(j => j.IdJogador == id);

            c.Jogador.Remove(j);

            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Editar/{id}")]
        public IActionResult Edit(int id)
        {
            ViewBag.Username = HttpContext.Session.GetString("Username");

            Jogador j = c.Jogador.First(j => j.IdJogador == id);

            ViewBag.Jogador = j;
            ViewBag.Equipe = c.Equipe.ToList();

            // se não tiver um usuario logado
            if (ViewBag.Username == null)
            {
                // ir para a pagina de login
                Message = "Acesso Negado! Efetue login para acessar esta página..";
                return LocalRedirect("~/Login/Login");
            }
            else
            {
                return View("Edit");
            }
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form, Jogador e)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = e.Nome;
            novoJogador.Email = e.Email;
            novoJogador.Senha = e.Senha;
            novoJogador.IdEquipe = e.IdEquipe;

            Jogador jogador = c.Jogador.First(x => x.IdJogador == e.IdJogador);

            jogador.Nome = novoJogador.Nome;
            jogador.Email = novoJogador.Email;
            jogador.Senha = novoJogador.Senha;
            jogador.IdEquipe = novoJogador.IdEquipe;

            c.Jogador.Update(jogador);

            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}