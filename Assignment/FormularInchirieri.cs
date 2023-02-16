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
    public partial class FormularInchirieri : Form
    {
        List<FilmeAnimatie> lista = new List<FilmeAnimatie>();

        public FormularInchirieri()
        {
            InitializeComponent();
        }

        #region OPERATII CRUD
        // CREATE
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            int.TryParse(tbNumarInchiriere.Text, out int NumarInchiriere);
            if (NumarInchiriere == 0)
            {
                isValid = false;
            }

            String NumeFilm = tbFilm.Text;
            if (String.IsNullOrEmpty(NumeFilm) || string.IsNullOrWhiteSpace(NumeFilm)
                || NumeFilm.Length < 2)
            {  MessageBox.Show("Numele filmului < 2 cifre.","Eroare",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);

                isValid = false;
            }

            DateTime inchiriere = dtpDataInchirierii.Value;
            DateTime returnare = dtpDataReturnarii.Value;
            if (isValid && DateTime.Compare(inchiriere, returnare) > 0)
            {
                isValid = false;
            }

            Enum.TryParse(cbTipFilm.Text, out TipFilm tip);

            Enum.TryParse(cbVersiuneFilm.Text, out VersiuneFilm versiune);

            float.TryParse(tbPretInchiriere.Text, out float pret);
            if (pret == 0)
            {
                MessageBox.Show("Pret invalid.", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                isValid = false;
            }

            int.TryParse(tbAn.Text, out int an);
            if (an == 0)
            {
                MessageBox.Show("An invalid.", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                isValid = false;
            }

            String numeClient = tbNumeClient.Text;
            if (String.IsNullOrEmpty(numeClient) || string.IsNullOrWhiteSpace(numeClient)
               || numeClient.Length < 3)
            {
                isValid = false;
            }

            String prenumeClient = tbPrenumeClient.Text;
            if (String.IsNullOrEmpty(prenumeClient) || string.IsNullOrWhiteSpace(prenumeClient)
               || prenumeClient.Length < 3)
            {
                isValid = false;
            }

            String adresa = tbAdresa.Text;
            if (String.IsNullOrEmpty(adresa) || string.IsNullOrWhiteSpace(adresa)
               || adresa.Length < 3)
            {
                MessageBox.Show("Adresa < 3 caractere.", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                isValid = false;
            }

            int.TryParse(tbTelefon.Text, out int telefon);
            if (telefon == 0)
            {
                isValid = false;
            }

            if (isValid)
            {
                try
                {
                   
                    FilmeAnimatie filmeAnimatie = new FilmeAnimatie(NumarInchiriere, NumeFilm, tip, versiune, an, pret, numeClient, prenumeClient, adresa, telefon); 

                    lista.Add(filmeAnimatie);

                    populeazaListView();

                    curataCampuri();
                }
                catch (CustomExceptionAn ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("A fost creata o instanta de inchiriere.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
               

                MessageBox.Show("Formularul contine erori!", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        // DELETE
        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (lvInchirieri.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Doresti sa stergi inchirierea?", "Sterge inchirierea",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lista.RemoveAt(lvInchirieri.SelectedIndices[0]);
                    populeazaListView();
                }
            }
        }

        // UPDATE
        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (lvInchirieri.SelectedItems.Count != 0)
            {
                FilmeAnimatie filmeAnimatie = lista.ElementAt(lvInchirieri.SelectedIndices[0]);

                EditareInchirieri editare = new EditareInchirieri(filmeAnimatie);
                editare.ShowDialog();

                populeazaListView();
            }
        }

        // READ
        private void populeazaListView()
        {
            lvInchirieri.Items.Clear();

            foreach (FilmeAnimatie each in lista)
            {
                ListViewItem item = new ListViewItem(new String[] { each.NumarInchiriere.ToString(), each.GetNumeFilm(), each.TipFilm.ToString(), each.Vers.ToString(), each.An.ToString(), each.PretInchiriere.ToString(), each.NumeClient, each.PrenumeClient });
                lvInchirieri.Items.Add(item);
            }
        }
        #endregion

        #region EVENT HANDLING
        private void btnCurata_Click(object sender, EventArgs e)
        {
            curataCampuri();
        }

        private void lvInchirieri_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left &&
                lvInchirieri.FocusedItem.Bounds.Contains(e.Location.X, e.Location.Y))
            {
                btnEditeaza_Click(sender, e);
            }
        }
        #endregion

        #region VALIDARE FORMULAR
        private void tbNumarInchiriere_Validating(object sender, CancelEventArgs e)
        {
            int.TryParse(tbNumarInchiriere.Text, out int NumarInchiriere);
            if ((NumarInchiriere == 0) || NumarInchiriere.ToString().Length == 0)
            {
                epNumarInchiriere.SetError((Control)sender, "Completeaza nr. inchiriere (>0)");
                e.Cancel = true; 
            }
        }

        private void tbNumarInchiriere_Validated(object sender, EventArgs e)
        {
            epNumarInchiriere.Clear();
        }

        private void dtpDataReturnarii_Validating(object sender, CancelEventArgs e)
        {
            DateTime inchiriere = dtpDataInchirierii.Value;
            DateTime returnare = dtpDataReturnarii.Value;

            if (DateTime.Compare(inchiriere, returnare) > 0)
            {
                epData.SetError(dtpDataReturnarii, "Data inchirierii < data returnarii");
                e.Cancel = true;
            }
        }

        private void dtpDataReturnarii_Validated(object sender, EventArgs e)
        {
            epData.Clear();
        }

        private void tbNumeClient_Validating_1(object sender, CancelEventArgs e)
        {
            String NumeClient = tbNumeClient.Text;
            if (String.IsNullOrEmpty(NumeClient) || string.IsNullOrWhiteSpace(NumeClient)
                || NumeClient.Length < 3)
            {
                epNumeClient.SetError((Control)sender, "Completeaza numele clientului. (minim 3 litere)");
                e.Cancel = true;
            }
        }

        private void tbNumeClient_Validated(object sender, EventArgs e)
        {
            epNumeClient.Clear();
        }

        private void tbPrenumeClient_Validating(object sender, CancelEventArgs e)
        {
            String PrenumeClient = tbPrenumeClient.Text;
            if (String.IsNullOrEmpty(PrenumeClient) || string.IsNullOrWhiteSpace(PrenumeClient)
                || PrenumeClient.Length < 3)
            {
                epPrenumeClient.SetError((Control)sender, "Completeaza prenumele clientului. (minim 3 litere)");
                e.Cancel = true;
            }
        }

        private void tbPrenumeClient_Validated(object sender, EventArgs e)
        {
            epPrenumeClient.Clear();
        }

        private void tbTelefon_Validating(object sender, CancelEventArgs e)
        {
            int.TryParse(tbTelefon.Text, out int Telefon);
            if ((Telefon == 0) || Telefon.ToString().Length != 10)
            {
                epTelefon.SetError((Control)sender, "Completeaza nr. de telefon (10 cifre)");
                e.Cancel = true;
            }
        }

        private void tbTelefon_Validated(object sender, EventArgs e)
        {
            epTelefon.Clear();
        }
        #endregion

        #region IMPLEMENTARE ContextMenuStrip
        private void lvInchirieri_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cms.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void cmsEditeaza_Click_1(object sender, EventArgs e)
        {
            btnEditeaza_Click(sender, e);
        }

        private void cmsSterge_Click_1(object sender, EventArgs e)
        {
            btnSterge_Click(sender, e);

        }
        #endregion

        #region IMPLEMENTARE MenuStrip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mașala Alexandra","Despre",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }
        #endregion

        #region METODE
        private void curataCampuri()
        {
            tbNumarInchiriere.Clear();
            tbFilm.Clear();
            tbAn.Clear();
            tbPretInchiriere.Clear();

            cbTipFilm.SelectedIndex = -1;
            cbVersiuneFilm.SelectedIndex = -1;

            dtpDataInchirierii.Value = DateTime.Now;
            dtpDataReturnarii.Value = DateTime.Now;

            tbNumeClient.Clear();
            tbPrenumeClient.Clear();
            tbAdresa.Clear();
            tbTelefon.Clear();
        }
        #endregion
    }
}
