using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITemplateAPI.Models;
using APITemplateAPI.Models.DB;
using APITemplateAPI.Models.DTO;
using APITemplateAPI.Models.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APITemplateAPI.Controllers
{
    [EnableCors("BackOffice")]
    [Route("api/template")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly iEmployee _employee;

        public EmployeeController(iEmployee employee)
        {
            _employee = employee;
        }

        [HttpPost("CriarFuncionario")]
        public DTO_Resposta PostCriarCor(DTO_Employee employee)
        {
            DTO_Resposta resposta = new DTO_Resposta();
            // Get the username from the JWT token
            resposta = _employee.CriarFuncionario(employee);

            return resposta;
        }

        [HttpGet("VerFuncionarios")]
        public DTO_Resposta GetVerCores()
        {
            DTO_Resposta resposta = new DTO_Resposta();

            resposta = _employee.VerFuncionarios();

            return resposta;
        }


    }
}

