namespace UtilizacionEntityNetCoreOracle.Entidad
{
    using Microsoft.Extensions.Configuration;
    using System.IO;
    using System.Threading.Tasks;

    public class ObtenerVariablesArchivoConfiguracion
    {
        #region Metodos externos
        public static async Task<string> ObtenerStringConexion(string _llaveConfiguracion)
        {
            var builder = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsetting.json");

            var configuration = builder.Build();

            string stringConexion = configuration[$"ConnectionStrings:{_llaveConfiguracion}"];

            return await Task.FromResult(stringConexion);
        }
        #endregion
    }
}
