using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoProgramcionIV.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(15)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Required]
        public int GrupoDescuentoId { get; set; }

        [ForeignKey("GrupoDescuentoId")]
        public virtual GrupoDescuento GrupoDescuento { get; set; }

        [ForeignKey("CondicionPagoId")]
        public int CondicionPagoId { get; set; }

        // Agrega esta propiedad de navegación
        public virtual CondicionPag CondicionPago { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }
    
}
}