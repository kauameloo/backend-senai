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

        Context c = new Context();
        [Route("Listar")]
        public IActionResult Index()
        {
            // mochila que contém lista de jogadores
            ViewBag.Jogador = c.Jogador.ToList();

            // mochila que contém lista de equipes
            ViewBag.Equipe = c.Equipe.ToList();

            // retorna view do jogador
            return View();
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
            Jogador j = c.Jogador.First(j => j.IdJogador == id);

            ViewBag.Jogador = j;

            return View("Edit");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form, Jogador j)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = j.Nome;
            novoJogador.Email = j.Email;
            novoJogador.Senha = j.Senha;

            Jogador jogador = c.Jogador.First(x => x.IdJogador == j.IdJogador);

            jogador.Nome = novoJogador.Nome;
            jogador.Email = novoJogador.Email;
            jogador.Senha = novoJogador.Senha;

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