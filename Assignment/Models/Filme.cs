using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchirieri_de_casete_video.Models
{
    public abstract class Filme : Inchirieri
    {
        public TipFilm TipFilm { get; set; }
        public VersiuneFilm Vers { get; set; }

        public Hashtable _Detalii;

        private String _NumeFilm;
        public String GetNumeFilm()
        {
            return _NumeFilm;
        }
        public void SetNumeFilm(String NumeFilm)
        {
            _NumeFilm = NumeFilm;
        }

        public virtual String GetDetalii()
        {
            return "Fara detalii disponibile.";
        }
    }
}
