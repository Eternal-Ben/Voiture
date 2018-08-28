using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//il manque Entity framework pour que cela fonctionne correctement.

namespace VoituresEF
{
    class Modele
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int IdMarque { get; set; }
        [ForeignKey("IdMarque")]
        public virtual Marque Marque { get; set; }
        public int IdSegment { get; set; }
        [ForeignKey("IdSegment")]
        public virtual Segment Segment { get; set; }
    }
}
