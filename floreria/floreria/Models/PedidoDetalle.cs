using floreria.Interface;
using System.ComponentModel.DataAnnotations;

namespace floreria.Models
{
    public partial class PedidoDetalle : IEntity
    {
        public int Id { get; set; }
        public string flor { get; set; }
        public int cantidad { get; set; }
        public int importe { get; set; }
    }

    [MetadataType(typeof(PedidoDetalleMetadata))]
    public partial class PedidoDetalle
    {
        public class PedidoDetalleMetadata
        {
            [Key]
            public int Id { get; set; }
            [StringLength(50)]
            public string flor { get; set; }
            public int cantidad { get; set; }
            public int importe { get; set; }
        }
    }
}