using System;
namespace APITemplateAPI.Models.DTO
{
	public class DTO_Employee
	{
		public DTO_Employee()
		{
		}

        public long Id { get; set; }
        public string primeiroNome { get; set; }
        public string ultimoNome { get; set; }
        public string contacto { get; set; }
    }
}

