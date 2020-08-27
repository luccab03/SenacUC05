using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotasAluno.Models;

namespace NotasAluno.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detalhe(int index){
            ViewBag.Index = index;
            return View();
        }

        public IActionResult Cadastro(){
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Aluno aluno){
            BaseDados.Adicionar(aluno);
            ViewBag.Aluno = aluno;
            return View("Concluido");
        }

        public IActionResult Listagem(){
            List<Aluno> alunos = BaseDados.Listar();
            return View(alunos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

