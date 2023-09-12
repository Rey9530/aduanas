using aduanas.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace aduanas
{
    public class AplicationDbContext : IdentityDbContext<UserCustom>
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        { }
        /*        public DbSet<Categorias> Categorias { get; set; }
                public DbSet<Cuestionario> Cuestionario { get; set; }
                public DbSet<CuestionarioPreguntas> CuestionarioPreguntas { get; set; }
                public DbSet<CuestionarioPreguntasRespuestas> CuestionarioPreguntasRespuestas { get; set; }*/
    }
}
