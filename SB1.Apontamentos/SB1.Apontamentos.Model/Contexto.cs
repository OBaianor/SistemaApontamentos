using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace SB1.Apontamentos.Model
{
    public class Contexto : DbContext
    {
        public DbSet<CadastroColaborador> CadastroColaborador { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            optionsBuilder.UseSqlServer("Password=replaceegood666;Persist Security Info=True;User ID=sa;Initial Catalog=SistemaApontamentos;Encrypt=False;Data Source=DESKTOP-1VK0UID\\SQLEXPRESS") ;
        }
    }
}
