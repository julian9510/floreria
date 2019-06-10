using floreria.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace floreria.Models
{
    public partial class Flor : IEntity
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public string especie { get; set; }
        public int stock { get; set; }
    }

    [MetadataType(typeof(FlorMetadata))]
    public partial class Flor
    {
        public class FlorMetadata
        {
            [Key]
            public int Id { get; set; }
            [StringLength(50)]
            [Required]
            public string nombre { get; set; }
            public int precio { get; set; }
            [StringLength(50)]
            public string especie { get; set; }
            public int stock { get; set; }
        }
    }
}