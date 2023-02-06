using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControleContas.Entity.Application
{
    public partial class NumeroCelular
    {
        [Key]
        public int idNumeroCelular { get; set; }
        public int? idUsuario { get; set; }
        public int? nuCelular { get; set; }
        public bool? sgAtivo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAlteracao { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? nmUsuarioSGBD { get; set; }

        [ForeignKey("idUsuario")]
        [InverseProperty("NumeroCelular")]
        public virtual Usuario? idUsuarioNavigation { get; set; }
    }
}
