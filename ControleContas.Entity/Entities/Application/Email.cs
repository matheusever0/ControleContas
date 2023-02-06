using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControleContas.Entity.Application
{
    public partial class Email
    {
        [Key]
        public int idEmail { get; set; }
        public int? idUsuario { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? dsEmail { get; set; }
        public bool? sgAtivo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAlteracao { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? nmUsuarioSGBD { get; set; }

        [ForeignKey("idUsuario")]
        [InverseProperty("Email")]
        public virtual Usuario? idUsuarioNavigation { get; set; }
    }
}
