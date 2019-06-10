using System;
using System.ComponentModel.DataAnnotations;
using floreria.Interface;
using System.ComponentModel.DataAnnotations.Schema;

namespace floreria.Models
{
    public partial class PedidoCab : IEntity
    {
        public int Id { get; set; }
        public DateTime fecha { get; set; }
        public Cliente clienteId { get; set; }
        public PedidoDetalle pedidoD { get; set; }

    }

    [MetadataType(typeof(PedidoCabMetadata))]
    public partial class PedidoCab
    {
        public class PedidoCabMetadata
        {
            [Key]
            public int Id { get; set; }
            public DateTime fecha { get; set; }
            [ForeignKey("Id")]
            [StringLength(50)]
            [Required]
            public Cliente clienteId { get; set; }
            [ForeignKey("Id")]
            public PedidoDetalle pedidoD { get; set; }
        }
    }
}