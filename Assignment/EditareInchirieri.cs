using Inchirieri_de_casete_video.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inchirieri_de_casete_video
{
    public partial class EditareInchirieri : Form
    {
       
        FilmeAnimatie _instance;

        public EditareInchirieri(FilmeAnimatie filmeAnimatie)
        {
            InitializeComponent();
            _instance = filmeAnimatie;
        }

        private void btnAnuleaza_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirma_Click_1(object sender, EventArgs e)
        {
            int.TryParse(tbNumarInchiriere.Text, out int NumarInchiriere);
            _instance.NumarInchiriere = NumarInchiriere;

            _instance.SetNumeFilm(tbFilm.Text);

            int.TryParse(tbAn.Text, out int an);
            _instance.An = an;

            Enum.TryParse(cbTipFilm.Text, out TipFilm tip);
            _instance.TipFilm = tip;

            Enum.TryParse(cbVersiuneFilm.Text, out VersiuneFilm versiune);
            _instance.Vers = versiune;

            float.TryParse(tbPretInchiriere.Text, out float pret);
            _instance.PretInchiriere = pret;

            _instance.NumeClient = tbNumeClient.Text;
            _instance.PrenumeClient = tbPrenumeClient.Text;
            _instance.Adresa = tbAdresa.Text;
            int.TryParse(tbTelefon.Text, out int Telefon);
            _instance.Telefon = Telefon;

            this.Close();
        }
        
        private void EditareInchirieri_Load_1(object sender, EventArgs e)
        {
            tbNumarInchiriere.Text = _instance.NumarInchiriere.ToString();
            tbFilm.Text = _instance.GetNumeFilm();
            cbTipFilm.Text = _instance.TipFilm.ToString();
            cbVersiuneFilm.Text = _instance.Vers.ToString();
            tbAn.Text = _instance.An.ToString();
            tbPretInchiriere.Text = _instance.PretInchiriere.ToString();

            tbNumeClient.Text = _instance.NumeClient;
            tbPrenumeClient.Text = _instance.PrenumeClient;
            tbAdresa.Text = _instance.Adresa;
            tbTelefon.Text = _instance.Telefon.ToString();

        }
    }
}
