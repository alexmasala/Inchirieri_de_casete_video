using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchirieri_de_casete_video.Models
{
    public class FilmeAnimatie : Filme, InterfataClienti, IComparable
    {
        private int _An;
        public int An
        {
            get
            {
                return _An;
            }

            set
            {
                if (value < 1880 || value > 2020)
                {
                    throw new CustomExceptionAn();
                }
                _An = value;
            }
        }

        public string NumeClient { get ; set; }
        public string PrenumeClient { get ; set; }
        public string Adresa { get; set; }
        public int Telefon { get; set; }

        public override string DescrieInchiriere()
        {
            return "Inchirierea cu numarul " + this.NumarInchiriere + " s-a facut pentru un film de " + TipFilm.ANIMATIE;
        }


        public FilmeAnimatie(int _NumarInchiriere, String NumeFilm)
        {
            this.NumarInchiriere = _NumarInchiriere;
            this.SetNumeFilm(NumeFilm);
            this.TipFilm = TipFilm.ANIMATIE;
            this.Vers = Vers;
            this.An = An;
            this.PretInchiriere = PretInchiriere;

            this._Detalii = new Hashtable()
            {
                {"Versiune", "Bluray" },
                {"Pret inchiriere (RON)", 40 }
            };
        }

        public FilmeAnimatie(int _NumarInchiriere, String NumeFilm, TipFilm unTip, VersiuneFilm oVers, int An, float PretInchiriere, String NumeClient, String PrenumeClient, String Adresa, int Telefon ) //DateTime inchirierii, DateTime returnare
        {
            this.NumarInchiriere = _NumarInchiriere;
            this.SetNumeFilm(NumeFilm);
            this.TipFilm = unTip;
            this.Vers = oVers;
            this.An = An;
            this.PretInchiriere = PretInchiriere;

            this.NumeClient=NumeClient;
            this.PrenumeClient=PrenumeClient;
            this.Adresa=Adresa;
            this.Telefon=Telefon;

            this._Detalii = new Hashtable()
            {
                {"Versiune", "Bluray" },
                {"Pret inchiriere (RON)", 40 }
            };
        }

        public int CompareTo(object obj)
        {
            return this.NumarInchiriere.CompareTo((obj as FilmeAnimatie).NumarInchiriere);
        }
    }
}
