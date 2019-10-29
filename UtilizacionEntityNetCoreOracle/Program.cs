using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using UtilizacionEntityNetCoreOracle.Modelo;
using System.Linq;

namespace UtilizacionEntityNetCoreOracle
{
    class Program
    {
        static void Main(string[] args)
        {
            ModeloDbContext db = new ModeloDbContext();

            var datos = (from dato in db.TemporalCedulas
                         select dato).Take(100);

            foreach (var item in datos)
            {
                Console.WriteLine(item.Cedula);
            }

            Console.ReadKey();
        }
    }
}
