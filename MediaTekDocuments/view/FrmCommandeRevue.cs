using MediaTekDocuments.controller;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace MediaTekDocuments.view
{
    public partial class FrmCommandeRevue : Form
    {
        private readonly FrmCommandeRevueController controller;
        private List<Revue> lesRevue = new List<Revue>();
        private List<Abonnement> lesCommandesRevue = new List<Abonnement>();
        private List<Exemplaire> lesExemplaireRevue = new List<Exemplaire>();
        private readonly BindingSource bdgCommandes = new BindingSource();
        public FrmCommandeRevue()
        {
            InitializeComponent();
            this.controller = new FrmCommandeRevueController();
        }

        private void FrmCommandeRevue_Load(object sender, EventArgs e)
        {
            lesRevue = controller.GetAllRevues();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            if (!txtNumRevueRecherche.Text.Equals(""))
            {
                Revue revue = lesRevue.Find(x => x.Id.Equals(txtNumRevueRecherche.Text));
                if (revue != null)
                {
                    AfficheRevuesInfos(revue);
                }
                else
                {
                    MessageBox.Show("numéro introuvable");
                    VideRevuesInfos();
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un numéro de livre.");
                VideRevuesInfos();
            }
        }

        private void btnSupprCommandeDvd_Click(object sender, EventArgs e)
        {
            if (dgvListeCommande.SelectedRows.Count > 0)
            {
                Abonnement abonnementSelectionne = bdgCommandes.Current as Abonnement;
                string idAbonnement = abonnementSelectionne.id;
                DateTime dateCommande = abonnementSelectionne.dateCommande;
                DateTime dateFinAbonnement = abonnementSelectionne.dateFinAbonnement;

                lesExemplaireRevue = controller.GetExemplairesRevue(idAbonnement);
                bool suppressionPossible = true;
                foreach (Exemplaire ex in lesExemplaireRevue)
                {
                    if (parutionDansAbonnement(ex.DateAchat, dateCommande, dateFinAbonnement))
                    {
                        suppressionPossible = false;
                        break;
                    }
                }
                if (suppressionPossible)
                {
                    if (MessageBox.Show("Voulez-vous vraiment supprimer cet abonnement ?",
                        "Confirmation",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (controller.SupprimerAbonnementRevue(idAbonnement))
                        {
                            MessageBox.Show("Suppression réussie");
                            AfficheAbonnementRevue();
                        }
                        else
                        {
                            MessageBox.Show("Erreur de suppression");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Impossible de supprimer : des exemplaires existent dans cet abonnement");
                }
            }
            else
            {
                MessageBox.Show("veuillez selectionner un commande de la liste pour supprimer ", "Information");
            }

        }

        private void btnEnregistrCommandeDvd_Click(object sender, EventArgs e)
        {

            if (!txtMontant.Text.Equals("") && !txtNumRevueRecherche.Text.Equals(""))
            {
                try
                {
                    string idCommande = Guid.NewGuid().ToString().Substring(0, 5);
                    DateTime dateCommande = dtpDateCommande.Value;
                    double montant = double.Parse(txtMontant.Text);
                    DateTime dateFinAbonnement = dtpDateCommande.Value;
                    string idRevue = txtNumRevueRecherche.Text;
                    Abonnement abonnementR = new Abonnement(dateFinAbonnement, idRevue, idCommande, dateCommande, montant );
                    if (controller.AjouteAbonnementRevue(abonnementR))
                    {
                        MessageBox.Show("ajout avec succes", "Information");
                        AfficheAbonnementRevue();
                        VidegrbAjoutAbonnement();

                    }
                    else
                    {
                        MessageBox.Show("Erreur lors d'ajout commande", "Erreur");
                    }
                }
                catch
                {
                    MessageBox.Show("le numéro de montant doit être numérique", "Information");
                    txtMontant.Text = "";
                    txtMontant.Focus();
                }
            }
            else
            {
                MessageBox.Show("montant est obligatoire", "Information");
            }
        }

        private void btnAnnulCommandeDvd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VidegrbAjoutAbonnement();             
            }
        }

        private void AfficheRevuesInfos(Revue revue)
        {
            txbRevuesPeriodiciteCom.Text = revue.Periodicite;
            txbRevuesImageCom.Text = revue.Image;
            txbRevuesDateMiseADispoCom.Text = revue.DelaiMiseADispo.ToString();
            txbRevuesNumeroCom.Text = revue.Id;
            txbRevuesGenreCom.Text = revue.Genre;
            txbRevuesPublicCom.Text = revue.Public;
            txbRevuesRayonCom.Text = revue.Rayon;
            txbRevuesTitreCom.Text = revue.Titre;
            string image = revue.Image;
            try
            {
                pcbRevuesImageCom.Image = Image.FromFile(image);
            }
            catch
            {
                pcbRevuesImageCom.Image = null;
            }
            AfficheAbonnementRevue();
        }
        private void VideRevuesInfos()
        {
            txbRevuesPeriodiciteCom.Text = "";
            txbRevuesImageCom.Text = "";
            txbRevuesDateMiseADispoCom.Text = "";
            txbRevuesNumeroCom.Text = "";
            txbRevuesGenreCom.Text = "";
            txbRevuesPublicCom.Text = "";
            txbRevuesRayonCom.Text = "";
            txbRevuesTitreCom.Text = "";
            txtNumRevueRecherche.Text = "";
            pcbRevuesImageCom.Image = null;
            dgvListeCommande.DataSource = null;

        }
        private void RemplirCommandesListe(List<Abonnement> commandes)
        {
            if (commandes != null)
            {
                bdgCommandes.DataSource = commandes;
                dgvListeCommande.DataSource = bdgCommandes;
                dgvListeCommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                // ordre des colonnes
                dgvListeCommande.Columns["id"].Visible = false;
                dgvListeCommande.Columns["dateCommande"].DisplayIndex = 1;
                dgvListeCommande.Columns["montant"].DisplayIndex = 2;
                dgvListeCommande.Columns["dateFinAbonnement"].DisplayIndex = 3;
                dgvListeCommande.Columns["IdRevue"].Visible = false;
            }
            else
            {
                bdgCommandes.DataSource = null;
            }

        }
        private void AfficheAbonnementRevue()
        {
            string idDocuement = txtNumRevueRecherche.Text;
            lesCommandesRevue = controller.GetAbonnementRevue(idDocuement);
            RemplirCommandesListe(lesCommandesRevue);
        }    
        private void VidegrbAjoutAbonnement()
        {
            dtpFinAbonnement.Value = DateTime.Now;
            dtpDateCommande.Value = DateTime.Now;
            txtMontant.Text = null;
        }
        private void dgvListeCommande_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string titreColonne = dgvListeCommande.Columns[e.ColumnIndex].HeaderText;
            List<Abonnement> sortedList = new List<Abonnement>();
            switch (titreColonne)
            {
                case "dateCommande":
                    sortedList = lesCommandesRevue.OrderBy(o => o.dateCommande).ToList();
                    break;
                case "montant":
                    sortedList = lesCommandesRevue.OrderBy(o => o.montant).ToList();
                    break;
                case "dateFinAbonnement":
                    sortedList = lesCommandesRevue.OrderBy(o => o.dateFinAbonnement).ToList();
                    break;
            }
            RemplirCommandesListe(sortedList);
        }
       
        private bool parutionDansAbonnement(DateTime dateAchat,  DateTime dateCommande, DateTime dateFinAbonnement)
        {
            if (dateAchat >= dateCommande && dateAchat <= dateFinAbonnement)
            {
                return true;
            }
            return false;
        }

        private void VideGrpListeAbonnement()
        {
           
        }
    }
}
