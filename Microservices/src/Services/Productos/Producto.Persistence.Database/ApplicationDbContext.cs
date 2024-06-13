using Microsoft.EntityFrameworkCore;
using Productos.Domain;
using Productos.Persistence.Database.Configuration;
namespace Productos.Persistence.Database
{
    public class ApplicationDbContext : DbContext
    { 
        //Exposicion donde se agrega la cadena de conexion del microservicio
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

            
        }

        //Asignacion de atributos a la clase Productos
        public DbSet<Producto> Productos { get; set; }

        // Se inyecta nuestra configuracion a la hora de la crecion de modelos en la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("Productos");
            ModelConfiguration(modelBuilder);
        }

        //Se trae nuestra configuration para agregarla en el proceso normal de la creacion de modelos
        private void ModelConfiguration(ModelBuilder modelBuilder) {
            new ProductoConfiguration(modelBuilder.Entity<Producto>());
        }
    }
}
