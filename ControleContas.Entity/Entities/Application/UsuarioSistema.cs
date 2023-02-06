using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControleContas.Entity.Application
{
    public partial class UsuarioSistema
    {
        [Key]
        public int idUsuarioSistema { get; set; }
        public int? idUsuario { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? dsLogin { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? dsSenha { get; set; }
        public bool? sgAtivo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAlteracao { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? nmUsuarioSGBD { get; set; }

        [ForeignKey("idUsuario")]
        [InverseProperty("UsuarioSistema")]
        public virtual Usuario? idUsuarioNavigation { get; set; }
    }
}
