using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace WindowsFormsApp_FinalProject
{
    public class YeniDbContext : DbContext
    {
        public YeniDbContext():base("Initial Catalog=Yeni;Data Source=.\\SQLEXPRESS;TrustServerCertificate=True;Persist Security Info=True;User ID=sa;Password=securiskop3;")
        {

        }

        //protected override void OnConfiguring(DbContextConfiguration optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Initial Catalog=Yeni;Data Source=.\SQLEXPRESS;TrustServerCertificate=True;Persist Security Info=True;User ID=sa;Password=securiskop3;");
        //}

        
    }
}
