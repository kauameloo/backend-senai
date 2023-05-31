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
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }

        // Instância do objeto da classe Context
        Context c = new Context();
        [Route("Listar")] // http://localhost/Equipe/Listar
        public IActionResult Index()
        {
            // "mochila" que contém a lista das equipes
            // podemos usar essa "mochila" na view de Equipe
            ViewBag.Equipe = c.Equipe.ToList();

            // retorna a view da Equipe
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();
            
            novaEquipe.Nome = form["Nome"].ToString();

            // retorna string, precisamos que retorne imagem
            // novaEquipe.Imagem = form["Imagem"].ToString();


            // lógica do upload de imagem
             if (form.Files.Count > 0)
            {
                
                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                //gera o caminho completo até o caminho do arquivo(imagem - nome com extensão)
                var path = Path.Combine(folder, file.FileName);

                //using para que a instrução dentro dele seja encerrado assim que for executada
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }
            //fim da lógica de upload


            c.Equipe.Add(novaEquipe);
            // c.Add(novaEquipe);

            c.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}