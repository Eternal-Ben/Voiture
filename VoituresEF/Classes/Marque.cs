using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoituresEF
{
    [Table("Marque")]
    public class Marque
    {
        [Column("IdMarque")]
        public int Id { get; set; }
        [Column("Libelle")]
        [Required]
        [MinLength]
        public string Nom { get; set; }
        public virtual ICollection<Modele>
    }
}
