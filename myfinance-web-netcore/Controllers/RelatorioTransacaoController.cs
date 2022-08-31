using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myfinance_web_netcore.Domain;

namespace myfinance_web_netcore.Controllers
{
   
    public class RelatorioTransacao : Controller
    {
        private readonly ILogger<RelatorioTransacao> _logger;

        public RelatorioTransacao(ILogger<RelatorioTransacao> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            decimal despesas = 0;
            decimal receita = 0;
            var transacao = new Transacao();
            var lista = transacao.ListaTransacoes(); 
            foreach(var item in lista)
            {
                if(item.Tipo == "D") {
                    despesas += item.Valor;
                } else {
                    receita += item.Valor;
                }
            }
            ViewBag.despesas = despesas;
            ViewBag.receita = receita;
            return View();
        }

        [HttpPost]
        public IActionResult Filtrar() {
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}