using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETICHETTE
{
    public partial class frmPrincipale : Form
    {
        public frmPrincipale()
        {
            InitializeComponent();
        }

        private void btnSalvaFornitori_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxFornitore.Text))
            {
                MessageBox.Show("Inserire il nome del fornitore", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxFornitore.Select();
                return;
            }

            using (var db = new LiteDatabase("Etichette.db"))
            {
                var col = db.GetCollection<Fornitore>("fornitori");

                var r = col.FindOne(x => x.Denominazione.Equals(tbxFornitore.Text));
                if (r != null)
                {
                    MessageBox.Show("Fornitore già esistente", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nuovoFornitore = new Fornitore
                {
                    Denominazione = tbxFornitore.Text,
                    Attivo = true
                };

                col.Insert(nuovoFornitore);
            }

            tbxFornitore.Text = "";
            CaricaFornitori();
        }

        private void CaricaFornitori()
        {
            dgvFornitori.Rows.Clear();
            cbxFornitori.Items.Clear();

            using (var db = new LiteDatabase("Etichette.db"))
            {
                var col = db.GetCollection<Fornitore>("fornitori");

                if (col.Count() > 0)
                {
                    int indice = 0;
                    foreach (Fornitore f in col.FindAll())
                    {
                        dgvFornitori.Rows.Insert(indice, f.Id, f.Denominazione);
                        cbxFornitori.Items.Insert(indice, f);                        
                        indice++;
                    }

                    cbxFornitori.DisplayMember = "Denominazione";
                    cbxFornitori.ValueMember = "Id";
                }                
            }
        }

        private void frmPrincipale_Load(object sender, EventArgs e)
        {
            CaricaFornitori();
            CaricaEtichette();
        }

        private void btnFornitoriElimina_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase("Etichette.db"))
            {
                var col = db.GetCollection<Fornitore>("fornitori");

                if (dgvFornitori.SelectedRows.Count > 0)
                {
                    int ID = (int)dgvFornitori.SelectedRows[0].Cells["ID"].Value;
                    col.Delete(ID);
                }              
            }
            CaricaFornitori();
        }

        private void btnEtichettaSalva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxEtichetta.Text))
            {
                MessageBox.Show("Inserire il nome dell'etichetta", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxFornitore.Select();
                return;
            }

            using (var db = new LiteDatabase("Etichette.db"))
            {
                var col = db.GetCollection<Etichetta>("etichette");
                
                Fornitore fornitore = (Fornitore)cbxFornitori.SelectedItem;

                var r = col.FindOne(x => (x.Denominazione.Equals(tbxEtichetta.Text) && x.FornitoreEtichetta.Id == fornitore.Id));
                if (r != null)
                {
                    MessageBox.Show("Etichetta già esistente", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nuovaEtichetta = new Etichetta
                {
                    Denominazione = tbxEtichetta.Text,
                    FornitoreEtichetta = (Fornitore)cbxFornitori.SelectedItem,
                    Altezza = (double)nudEtichettaAltezza.Value,
                    Larghezza = (double)nudEtichettaLarghezza.Value,
                    MargineSuperiore = (double)nudEtichettaMargineSuperiore.Value,
                    MargineLaterale = (double)nudEtichettaMargineLaterale.Value,
                    PassoVerticale = (double)nudEtichettaPassoVerticale.Value,
                    PassoOrizzontale = (double)nudEtichettaPassoOrizzontale.Value,
                    QtVerticale = (double)nudEtichettaQtVerticale.Value,
                    QtOrizzontale = (double)nudEtichettaQtOrizzontale.Value,
                    PaginaAltezza = (double)nudPaginaAltezza.Value,
                    PaginaLarghezza = (double)nudPaginaLarghezza.Value,
                    Attivo = true
                };

                col.Insert(nuovaEtichetta);
            }

            tbxEtichetta.Text = "";
            CaricaEtichette();
        }

        private void CaricaEtichette()
        {
            dgvEtichette.Rows.Clear();

            using (var db = new LiteDatabase("Etichette.db"))
            {
                var col = db.GetCollection<Etichetta>("etichette");

                if (col.Count() > 0)
                {
                    int indice = 0;
                    foreach (Etichetta f in col.FindAll())
                    {
                        dgvEtichette.Rows.Insert(indice, f.Id, f.FornitoreEtichetta?.Denominazione, f.Denominazione);
                        indice++;
                    }
                }
            }
        }

        private void btnEtichettaElimina_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase("Etichette.db"))
            {
                var col = db.GetCollection<Etichetta>("etichette");

                if (dgvEtichette.SelectedRows.Count > 0)
                {
                    int ID = (int)dgvEtichette.SelectedRows[0].Cells[0].Value;
                    col.Delete(ID);
                }
            }
            CaricaEtichette();
        }

        private void dgvEtichette_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new LiteDatabase("Etichette.db"))
            {
                var col = db.GetCollection<Etichetta>("etichette");

                if (dgvEtichette.SelectedRows.Count > 0)
                {
                    int ID = (int)dgvEtichette.SelectedRows[0].Cells[0].Value;
                    Etichetta etichetta = col.FindById(ID);

                    tbxEtichetta.Text = etichetta.Denominazione;
                    cbxFornitori.SelectedValue = etichetta.FornitoreEtichetta.Id;
                    nudEtichettaAltezza.Value = (decimal)etichetta.Altezza;
                    nudEtichettaLarghezza.Value = (decimal)etichetta.Larghezza;
                    nudEtichettaMargineSuperiore.Value = (decimal)etichetta.MargineSuperiore;
                    nudEtichettaMargineLaterale.Value = (decimal)etichetta.MargineLaterale;
                    nudEtichettaPassoVerticale.Value = (decimal)etichetta.PassoVerticale;
                    nudEtichettaPassoOrizzontale.Value = (decimal)etichetta.PassoOrizzontale;
                    nudEtichettaQtVerticale.Value = (decimal)etichetta.QtVerticale;
                    nudEtichettaQtOrizzontale.Value = (decimal)etichetta.QtOrizzontale;
                    nudPaginaAltezza.Value = (decimal)etichetta.PaginaAltezza;
                    nudPaginaLarghezza.Value = (decimal)etichetta.PaginaLarghezza;
                }
            }
            CaricaEtichette();
        }
    }
}
