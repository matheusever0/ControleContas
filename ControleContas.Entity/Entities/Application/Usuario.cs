using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControleContas.Entity.Application
{
    public partial class Usuario
    {
        public Usuario()
        {
            AcessoUsuario = new HashSet<AcessoUsuario>();
            Email = new HashSet<Email>();
            NumeroCelular = new HashSet<NumeroCelular>();
            UsuarioSistema = new HashSet<UsuarioSistema>();
        }

        [Key]
        public int idUsuario { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? nmUsuario { get; set; }
        public int? CPF { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAniversario { get; set; }
        public int? idMunicipio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAlteracao { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? nmUsuarioSGBD { get; set; }

        [ForeignKey("idMunicipio")]
        [InverseProperty("Usuario")]
        public virtual Municipios? idMunicipioNavigation { get; set; }
        [InverseProperty("idUsuarioNavigation")]
        public virtual ICollection<AcessoUsuario> AcessoUsuario { get; set; }
        [InverseProperty("idUsuarioNavigation")]
        public virtual ICollection<Email> Email { get; set; }
        [InverseProperty("idUsuarioNavigation")]
        public virtual ICollection<NumeroCelular> NumeroCelular { get; set; }
        [InverseProperty("idUsuarioNavigation")]
        public virtual ICollection<UsuarioSistema> UsuarioSistema { get; set; }
    }
}
