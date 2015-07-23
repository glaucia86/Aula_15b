using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Site.Models; //camada modelo
using DAL.Persistence;
using DAL.Entity;

namespace Site.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarCliente(ClienteModel Model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var cli = new Cliente();
                    var end = new Endereco();

                    cli.Nome            = Model.Nome;
                    cli.Email           = Model.Email;
                    cli.Sexo            = Model.Sexo;
                    cli.DataNascimento  = Model.DataNascimento;

                    end.Logradouro      = Model.Logradouro;
                    end.Cidade          = Model.Cidade;
                    end.Estado          = Model.Estado;
                    end.Tipo            = Model.Tipo;

                    //Relacionamento entre Enderoco com Cliente (FK)
                    end.Cliente = cli;

                    var d = new ClienteDal();
                    d.Save(cli, end);

                    ViewBag.Mensagem = "Cliente cadastrado com sucesso!";

                    ModelState.Clear();
                }
                catch (Exception e)
                {
                    ViewBag.Mensagem = e.Message;
                }
            }
            return View("Cadastro");
        }
    }
}
