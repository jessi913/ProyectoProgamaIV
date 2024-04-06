using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoProgramcionIV.Models
{
    [Table("GrupoDescuento")]
    public class GrupoDescuento
    {
        [Key]

        public int GrupodescuentoId { get; set; }

        [Required]
        [StringLength(50)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        public int Porcentaje { get; set; }

        [Required]

        public DateTime FechaCreacion { get; set; }
    }
}