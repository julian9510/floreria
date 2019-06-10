using floreria.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace floreria.Models
{
    public partial class Cliente : IEntity
    {
        public int Id { get; set; }
        public int dni { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
    }

    [MetadataType(typeof(ClienteMetadata))]
    public partial class Cliente
    {
        public class ClienteMetadata
        {
            [Key]
            public int Id { get; set; }
            public int dni { get; set; }
            [StringLength(50)]
            [Required]
            public int nombre { get; set; }
            [StringLength(50)]
            public string direccion { get; set; }
        }
    }
}