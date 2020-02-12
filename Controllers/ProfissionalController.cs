using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Profissional.Models;
using Profissional.Repositorio;

namespace Profissional.Controllers
{
    [Produces("application/json")]
    [Route("api/profissional")]
    public class ProfissionalController : Controller
    {

        Profissionais profissionais = new Profissionais();


        [AcceptVerbs("GET")]
        [Route("{variavel}")]
        public List<ProfissionalModel> Profissionais()
        {
            return profissionais.GetTodosProfissionais();
        }

        [AcceptVerbs("DELETE")]
        [Route("")]
        public List<ProfissionalModel> DeletarProfissionais()
        {


            return profissionais.GetTodosProfissionais();
        }


        [AcceptVerbs("POST")]
        [Route("")]
        public void InserirProfissional(ProfissionalModel pf) {

            try
            {
                profissionais.InsertProfissional(pf);
            }
            catch (Exception e)
            {
                throw;
            }


           
        }
    }
}