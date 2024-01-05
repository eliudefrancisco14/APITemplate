using System;
using APITemplateAPI.Models.DB;
using APITemplateAPI.Models.DTO;

namespace APITemplateAPI.Models.Interface
{
    public interface iEmployee
    {
        DTO_Resposta CriarFuncionario(DTO_Employee employee);
        DTO_Resposta VerFuncionarios();
    }
}

