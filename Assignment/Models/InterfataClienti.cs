using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchirieri_de_casete_video.Models
{
    interface InterfataClienti 
    {
        string NumeClient { get; set; }
        string PrenumeClient { get; set; }
        string Adresa { get; set; }
        int Telefon { get; set; }

    }
}
