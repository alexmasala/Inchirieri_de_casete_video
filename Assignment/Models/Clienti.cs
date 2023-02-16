using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchirieri_de_casete_video.Models
{
    public abstract class Clienti : Inchirieri
    {
        private String _NumeClient;

        public String GetNumeClient()
        {
            return _NumeClient;
        }

        public void SetNumeClient(String NumeClient)
        {
            _NumeClient = NumeClient;
        }

        private String _PrenumeClient;

        public String GetPrenumeClient()
        {
            return _PrenumeClient;
        }

        public void SetPrenumeClient(String PrenumeClient)
        {
            _PrenumeClient = PrenumeClient;
        }

        public String Adresa { get; set; }
        public int Telefon { get; set; }
    }
}
