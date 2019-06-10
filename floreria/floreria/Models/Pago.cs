using floreria.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace floreria.Models
{
    public partial class Pago : IEntity
    {
        public int Id { get; set; }
        public PedidoCab nroPedido { get; set; }
        public int importeTotal { get; set; }
        public string tipoPago { get; set; }
        public string tipoEnvio { get; set; }
    }

    [MetadataType(typeof(PagoMetadata))]
    public partial class Pago
    {
        public class PagoMetadata
        {
            [Key]
            public int Id { get; set; }
            [ForeignKey("Id")]
            [StringLength(20)]
            [Required]
            public PedidoCab nroPedido { get; set; }
            public int importeTotal { get; set; }
            [StringLength(50)]
            public string tipoPago { get; set; }
            [StringLength(50)]
            public string tipoEnvio { get; set; }
            
        }
    }
}