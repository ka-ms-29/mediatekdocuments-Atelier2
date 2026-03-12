using MediaTekDocuments.controller;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MediaTekDocuments.view
{
    /// <summary>
    /// classe d'affichage la form : gestion des abonnements de revue
    /// </summary>
    public partial class FrmCommandeRevue : Form
    {
        private readonly FrmCommandeRevueController controller;
        private List<Revue> lesRevue = new List<Revue>();
        private List<Abonnement> lesCommandesRevue = new List<Abonnement>();
        private List<Exemplaire> lesExemplaireRevue = new List<Exemplaire>();
        private readonly BindingSource bdgCommandes = new BindingSource();
        private const string TITRE_INFORMATION = "Information";


        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public FrmCommandeRevue()
        {
            InitializeComponent();
            this.controller = new FrmCommandeRevueController();
        }
        /// <summary>
        /// les initialisaton lors du chargement du formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCommandeRevue_Load(object sender, EventArgs e)
        {
            lesRevue = controller.GetAllRevues();
        }
        /// <summary>
        /// Recherche et affichage du livre dont on a saisi le numéro.
        /// Si non trouvé, affichage d'un MessageBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show("Veuillez entrer un numéro de revue.");
                VideRevuesInfos();
            }
        }
        /// <summary>
        /// suppression d'un abonnement (commande de revue) si aucun exemplaire n'est rattaché 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprCommandeDvd_Click(object sender, EventArgs e)
        {
            if (dgvListeCommande.SelectedRows.Count > 0)
            {
               operationSupprimAbonnement();
            }
            else
            {
                MessageBox.Show("veuillez selectionner un commande de la liste pour supprimer ", TITRE_INFORMATION);
            }

        }
        /// <summary>
        /// Enregistre un abonnement pour le revue recherché.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrCommandeDvd_Click(object sender, EventArgs e)
        {

            if (!txtMontant.Text.Equals("") && !txtNumRevueRecherche.Text.Equals(""))
            {
                try
                {
                    string idCommande = Guid.NewGuid().ToString().Substring(0, 5);
                    DateTime dateCommande = dtpDateCommande.Value;
                    double montant = double.Parse(txtMontant.Text);
                    DateTime dateFinAbonnement = dtpFinAbonnement.Value;
                    string idRevue = txtNumRevueRecherche.Text;
                    Abonnement abonnementR = new Abonnement(dateFinAbonnement, idRevue, idCommande, dateCommande, montant);
                    if (controller.AjouteAbonnementRevue(abonnementR))
                    {
                        MessageBox.Show("ajout avec succes", TITRE_INFORMATION);
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
                    MessageBox.Show("le numéro de montant doit être numérique", TITRE_INFORMATION);
                    txtMontant.Text = "";
                    txtMontant.Focus();
                }
            }
            else
            {
                MessageBox.Show("montant est obligatoire", TITRE_INFORMATION);
            }
        }
        /// <summary>
        /// Annule demande d'ajout abonnement et vide les champs de saisie pour ajouter un abonnement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulCommandeDvd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VidegrbAjoutAbonnement();
            }
        }
        /// <summary>
        /// Affichage des informations de revue recherché et appel à l'affichage des commande de revue recherché.
        /// </summary>
        /// <param name="revue"></param>
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
        /// <summary>
        /// vide les textBox de groupBox d'Information de revue'.
        /// </summary>
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
        /// <summary>
        /// Remplit le dategrid avec la liste reçue en paramètre
        /// </summary>
        /// <param name="commandes"></param>
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
        /// <summary>
        /// Récupère la liste des abonnements d'un revue,
        /// envoi la liste pour affichage et remlissage dataGridView
        /// </summary>
        private void AfficheAbonnementRevue()
        {
            string idDocuement = txtNumRevueRecherche.Text;
            lesCommandesRevue = controller.GetAbonnementRevue(idDocuement);
            RemplirCommandesListe(lesCommandesRevue);
        }
        /// <summary>
        /// vide les champs à saisie d'un nouvelle/renouvellement abonnement
        /// </summary>
        private void VidegrbAjoutAbonnement()
        {
            dtpFinAbonnement.Value = DateTime.Now;
            dtpDateCommande.Value = DateTime.Now;
            txtMontant.Text = null;
        }
        /// <summary>
        /// Tri sur les colonnes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// vérifiant la date de l'exemplaire, comprise entre la date de la commande et la date de fin d'abonnement
        /// </summary>
        /// <param name="dateAchat"></param>
        /// <param name="dateCommande"></param>
        /// <param name="dateFinAbonnement"></param>
        /// <returns></returns>
        public static bool parutionDansAbonnement(DateTime dateAchat, DateTime dateCommande, DateTime dateFinAbonnement)
        {
            if (dateAchat >= dateCommande && dateAchat <= dateFinAbonnement)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// opération sur le bouton supprimer.
        /// </summary>
        private void operationSupprimAbonnement()
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
    
    }
}
