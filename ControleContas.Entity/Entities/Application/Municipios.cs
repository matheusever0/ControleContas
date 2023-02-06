using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControleContas.Entity.Application
{
    public partial class Municipios
    {
        public Municipios()
        {
            Usuario = new HashSet<Usuario>();
        }

        [Key]
        public int idMunicipio { get; set; }
        public int? CPF { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? dsLogradouro { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? dsComplemento { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? dsBairro { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? dsMunicipio { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string? uf { get; set; }
        public int? cdIbge { get; set; }
        public int? ddd { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtInclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dtAlteracao { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? nmUsuarioSGBD { get; set; }

        [InverseProperty("idMunicipioNavigation")]
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
