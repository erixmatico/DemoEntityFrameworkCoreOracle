namespace UtilizacionEntityNetCoreOracle.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("NOMBRE_TABLA", Schema = "ESQUEMA_DE_BASE DE DATOS")]
    public class TemporalCedulas
    {
        [Column("CEDULA")]
        [Key]
        public decimal Cedula { get; set; }
        [Column("PUNTAJE")]
        public Nullable<decimal> Puntaje { get; set; }
    }
}
