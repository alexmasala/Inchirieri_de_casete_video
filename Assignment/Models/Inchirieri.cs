using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchirieri_de_casete_video.Models
{
    public abstract class Inchirieri
    {
        public int NumarInchiriere { get; set; }
        public float PretInchiriere { get; set; }

        public abstract String DescrieInchiriere();
    }
}
