using floreria.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace floreria.Models
{
    public partial class Devolucion : IEntity
    {
        public int Id { get; set; }
        public PedidoCab nroPedido { get; set; }
        public Cliente clienteId { get; set; }
        public int importeaDevolver { get; set; }
        public string motivo { get; set; }
        
    }

    [MetadataType(typeof(DevolucionMetadata))]
    public partial class Devolucion
    {
        public class DevolucionMetadata
        {
            [Key]
            public int Id { get; set; }
            [ForeignKey("Id")]
            [StringLength(20)]
            [Required]
            public PedidoCab nroPedido { get; set; }
            [ForeignKey("Id")]
            [StringLength(50)]
            public Cliente clienteId { get; set; }
            public int importeaDevolver { get; set; }
            [StringLength(250)]
            public string motivo { get; set; }

        }
    }
}