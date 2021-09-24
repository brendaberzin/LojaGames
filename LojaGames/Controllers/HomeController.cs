using LojaGames.Models;
using LojaGames.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaGames.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Funcionario()
        {
            var funcionario = new Funcionario();
            return View(funcionario);
        }

        public ActionResult Cliente()
        {
            var cliente = new Cliente();
            return View(cliente);
        }

        public ActionResult Jogo()
        {
            var jogo = new Jogo();
            return View(jogo);
        }

        Acoes ac = new Acoes();

        [HttpPost]

        public ActionResult CadFuncionario(Funcionario fun)
        {
            ac.CadastrarFuncionario(fun);
            return View(fun);
        }

        public ActionResult CadCliente(Cliente cli)
        {
            ac.CadastrarCliente(cli);
            return View(cli);
        }

        public ActionResult CadJogo(Jogo jog)
        {
            ac.CadastrarJogo(jog);
            return View(jog);
        }

        public ActionResult ListarFuncionario()
        {
            var ExibirFunc = new Acoes();
            var TodosFunc = ExibirFunc.ListarFuncionario();
            return View(TodosFunc);
        }

        public ActionResult ListarCliente()
        {
            var ExibirCli = new Acoes();
            var TodosCli = ExibirCli.ListarCliente();
            return View(TodosCli);
        }

        public ActionResult ListarJogo()
        {
            var ExibirJog = new Acoes();
            var TodosJog = ExibirJog.ListarJogo();
            return View(TodosJog);
        }
    }
}