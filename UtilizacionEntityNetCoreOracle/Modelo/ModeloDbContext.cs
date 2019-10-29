namespace UtilizacionEntityNetCoreOracle.Modelo
{
    using Microsoft.EntityFrameworkCore;
    using UtilizacionEntityNetCoreOracle.Entidad;

    public class ModeloDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(ObtenerVariablesArchivoConfiguracion.ObtenerStringConexion("miStringConexion").Result);
        }

        public virtual DbSet<TemporalCedulas> TemporalCedulas {get;set;}
    }
}
