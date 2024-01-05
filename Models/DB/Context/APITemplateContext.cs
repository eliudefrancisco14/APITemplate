using System;
using Microsoft.EntityFrameworkCore;

namespace APITemplateAPI.Models.DB.Context
{
	public class APITemplateContext : DbContext
    {
		public APITemplateContext()
		{
		}
        public APITemplateContext(DbContextOptions<APITemplateContext> options): base(options)
        {
        }
        public DbSet<TbEmployee> TbEmployees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Configuração da conexão com o SQLServer
                optionsBuilder.UseSqlServer("Server=PRECIOSO\\PRECIOSO;Database=template;Integrated Security=True;MultipleActiveResultSets=true;Encrypt=False;TrustServerCertificate=True");
            }
        }
    }
}

