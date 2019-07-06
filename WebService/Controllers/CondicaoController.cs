using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebService.Models;

namespace WebService.Controllers
{
    public class CondicaoController : Controller
    {
        public IActionResult Index()
        {
            //Recupero as informações do banco e mostro na view
            return View();
        }

        public IActionResult ConsultarCondicao(string qlqr)
        {
            string url = "asadasdas" + qlqr;
            WebClient client = new WebClient();
            string json = client.DownloadString
                ("http://apiadvisor.climatempo.com.br/api/v1/weather/locale/3477/current?token=5214934660bca53cfa70cb7804f6b8f8");

            Cidade cidade = JsonConvert.
                DeserializeObject<Cidade>(json);
            //Gravar o objeto no banco
            return RedirectToAction("Index");
        }
    }
}