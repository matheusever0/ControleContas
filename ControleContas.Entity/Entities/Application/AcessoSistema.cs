using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControleContas.Entity.Application
{
    public partial class AcessoSistema
    {
        public AcessoSistema()
        {
            AcessoUsuario = new HashSet<AcessoUsuario>();
        }

        [Key]
        public int idAcessoSistema { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? dsAcessoSistema { get; set; }
        public bool? sgAtivo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAlteracao { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? nmUsuarioSGBD { get; set; }

        [InverseProperty("idAcessoSistemaNavigation")]
        public virtual ICollection<AcessoUsuario> AcessoUsuario { get; set; }
    }
}
