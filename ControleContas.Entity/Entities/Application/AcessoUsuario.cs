using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControleContas.Entity.Application
{
    public partial class AcessoUsuario
    {
        [Key]
        public int idAcessoUsuario { get; set; }
        public int? idAcessoSistema { get; set; }
        public int? idUsuario { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAlteracao { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? nmUsuarioSGBD { get; set; }

        [ForeignKey("idAcessoSistema")]
        [InverseProperty("AcessoUsuario")]
        public virtual AcessoSistema? idAcessoSistemaNavigation { get; set; }
        [ForeignKey("idUsuario")]
        [InverseProperty("AcessoUsuario")]
        public virtual Usuario? idUsuarioNavigation { get; set; }
    }
}
