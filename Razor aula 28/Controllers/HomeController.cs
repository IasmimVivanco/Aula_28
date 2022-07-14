using Microsoft.AspNetCore.Mvc;
using Razor_aula_28.Models;
using System.Diagnostics;
using System.Globalization;

namespace Razor_aula_28.Controllers
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
            List<Aluno> Alunos = new List<Aluno>();
            Alunos.Add(new Aluno() { Id = 1, Name = "Willian", Sobrenome = "Santanna", Status = "Reprovado" });
            Alunos.Add(new Aluno() { Id = 2, Name = "Thiago", Sobrenome = "Machado", Status = "Aprovado" });
            Alunos.Add(new Aluno() { Id = 3, Name = "Rodrigo", Sobrenome = "Braga", Status = "Aprovado" });
            Alunos.Add(new Aluno() { Id = 4, Name = "Caroline", Sobrenome = "da Silva", Status = "Recuperação" });
            return View(Alunos);
        }
        public IActionResult Index1()
        {
            List<Boletim> boletim = new List<Boletim>();
            boletim.Add(new Boletim() { Materia = "Português", Nota1 = 5, Nota2 = 6.5, Nota3 = 6.5, Nota4 = 0, Status = "Reprovado", Culture = CultureInfo.InvariantCulture});
            boletim.Add(new Boletim() { Materia = "Matemática", Nota1 = 10, Nota2 = 8, Nota3 = 8, Nota4 = 8, Status = "Aprovado", Culture = CultureInfo.InvariantCulture });
            boletim.Add(new Boletim() { Materia = "Ciências", Nota1 = 6, Nota2 = 7.5, Nota3 = 8, Nota4 = 8, Status = "Aprovado", Culture = CultureInfo.InvariantCulture });
            boletim.Add(new Boletim() { Materia = "História", Nota1 = 8, Nota2 = 9, Nota3 = 10, Nota4 = 7.5, Status = "Aprovado", Culture = CultureInfo.InvariantCulture });

            return View(boletim);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}