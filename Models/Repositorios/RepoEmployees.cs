using System;
using System.Runtime.ConstrainedExecution;
using APITemplateAPI.Models.DB;
using APITemplateAPI.Models.DB.Context;
using APITemplateAPI.Models.DTO;
using APITemplateAPI.Models.Interface;

namespace APITemplateAPI.Models.Repositorios
{
    public class RepoEmployees : iEmployee
    {
        private readonly APITemplateContext _db;
        public RepoEmployees(APITemplateContext context)
        {
            _db = context;



        }


        public DTO_Resposta CriarFuncionario(DTO_Employee employee)
        {
            DTO_Resposta resposta = new DTO_Resposta();
            TbEmployee employeeData = new TbEmployee
            {
                primeiroNome = employee.primeiroNome,
                ultimoNome = employee.ultimoNome,
                contacto = employee.contacto

            };
            try
            {

                _db.TbEmployees.Add(employeeData);
                _db.SaveChanges();
                resposta.resposta = "Operação Concluida com sucesso";
                resposta.mensagem = "Sucesso";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.resposta = ex.Message;
                resposta.mensagem = "Não foi possivel concluir a operação  com sucesso";
                return resposta;
            }

            throw new NotImplementedException();
        }

        // METODO GET

        public DTO_Resposta VerFuncionarios()
        {
            DTO_Resposta resposta = new DTO_Resposta();
            try
            {
                var employee = from b in _db.TbEmployees
                          select new
                          {
                              id = b.Id,
                              primeiroNome = b.primeiroNome,
                              ultimoNome = b.ultimoNome,
                              contacto = b.contacto
                          };
                resposta.resposta = employee;
                resposta.mensagem = "Sucesso";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.resposta = ex.Message;
                resposta.mensagem = "Erro ao apresentar dados";
                return resposta;
            }
        }
        
    
    }
}

