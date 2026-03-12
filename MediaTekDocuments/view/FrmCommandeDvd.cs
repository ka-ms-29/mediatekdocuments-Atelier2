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
    /// class d'affichage la gestion des commandes DVDs.
    /// </summary>
    public partial class FrmCommandeDvd : Form
    {
        private readonly FrmCommandeDocumentController controller;
        private List<Dvd> lesDvd = new List<Dvd>();
        private readonly BindingSource bdgSuivi = new BindingSource();
        private readonly BindingSource bdgCommandes = new BindingSource();
        private List<CommandeDocument> lesCommandesDvd = new List<CommandeDocument>();
        private Boolean modifier = false;
        private const string TITRE_INFORMATION = "Information";
        /// <summary>
        /// Constructeur : création du contrôleur lié à ce formulaire
        /// </summary>
        public FrmCommandeDvd()
        {
            InitializeComponent();
            this.controller = new FrmCommandeDocumentController();
        }
        /// <summary>
        /// les initialisaton lors du chargement du formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCommandeDvd_Load(object sender, EventArgs e)
        {
            RemplirListeSuivi();
            lesDvd = controller.GetAllDvd();
            EnCoursModifCommandeLivre(modifier);
            AccesGroupBoxAjoutCommande(false);
            txtNumDvd.Focus();
        }
        /// <summary>
        /// Remlir la liste des suivi dans le combo box à partir de la base de données.
        /// </summary>
        public void RemplirListeSuivi()
        {
            List<Suivi> lesSuivi = controller.GetAllSuivi();
            bdgSuivi.DataSource = lesSuivi;
            cboSuivi.DataSource = bdgSuivi;
            cboSuivi.SelectedIndex = 0;
            cboSuivi.DisplayMember = "Libelle";
            cboSuivi.ValueMember = "IdSuivi";
        }
        /// <summary>
        /// Affichage des informations du DVD sélectionné
        /// </summary>
        /// <param name="dvd"></param>
        private void AfficheDvdInfos(Dvd dvd)
        {
            txbDvdRealisCom.Text = dvd.Realisateur;
            txbDvdSynopsisCom.Text = dvd.Synopsis;
            txbDvdImageCom.Text = dvd.Image;
            txbDureeDvd.Text = dvd.Duree.ToString();
            txbDvdNumeroCom.Text = dvd.Id;
            txbDvdGenreCom.Text = dvd.Genre;
            txbDvdPublicCom.Text = dvd.Public;
            txbDvdRayonCom.Text = dvd.Rayon;
            txbDvdTitreCom.Text = dvd.Titre;
            string image = dvd.Image;
            try
            {
                pcbDvdImageCom.Image = Image.FromFile(image);
            }
            catch
            {
                pcbDvdImageCom.Image = null;
            }
            AfficheLesCommandesDvd();
        }
        /// <summary>
        /// vide le gropBox des informations du DVD
        /// </summary>
        private void VideDvdInfos()
        {
            txbDvdRealisCom.Text = "";
            txbDvdSynopsisCom.Text = "";
            txbDvdImageCom.Text = "";
            txbDureeDvd.Text = "";
            txbDvdNumeroCom.Text = "";
            txbDvdGenreCom.Text = "";
            txbDvdPublicCom.Text = "";
            txbDvdRayonCom.Text = "";
            txbDvdTitreCom.Text = "";
            pcbDvdImageCom.Image = null;
            txtNumDvd.Text = "";
            dgvListeCommande.DataSource = null;

        }
        /// <summary>
        /// verifie si l'utilisateur est en train de modifier une commande ou d'ajouter une nouvelle commande.
        /// </summary>
        /// <param name="modifier"></param>
        private void EnCoursModifCommandeLivre(Boolean modifier)
        {
            if (modifier)
            {
                grbAjoutCommande.Text = "modifier le suivi du commande :";
                cboSuivi.Enabled = true;
                txtNumDvd.Enabled = false;
                nudExemplaire.Enabled = false;
                txtMontant.Enabled = false;
                dtpDateCommande.Enabled = false;
            }
            else
            {
                grbAjoutCommande.Text = "Ajouter on nouveau commande : ";
                cboSuivi.Enabled = false;
                txtNumDvd.Enabled = true;
                nudExemplaire.Enabled = true;
                txtMontant.Enabled = true;
                dtpDateCommande.Enabled = true;

            }
        }
        /// <summary>
        /// vide le gropBox de ajout commande DVD
        /// </summary>
        private void VideGrpCommandeLivre()
        {
            txtMontant.Text = "";
            nudExemplaire.Value = 1;
            dtpDateCommande.Value = DateTime.Now;
            cboSuivi.SelectedIndex = 0;
        }
        /// <summary>
        /// met en accès ou non le groupBox de ajout commande livre selon le paramètre d'entrée
        /// </summary>
        /// <param name="acces"></param>
        private void AccesGroupBoxAjoutCommande(bool acces)
        {
            grbAjoutCommande.Enabled = acces;
        }
        /// <summary>
        /// Remplir la liste des commandes du DVD.
        /// </summary>
        /// <param name="commandes"></param>
        private void RemplirCommandesListe(List<CommandeDocument> commandes)
        {
            if (commandes != null)
            {
                bdgCommandes.DataSource = commandes;
                dgvListeCommande.DataSource = bdgCommandes;
                dgvListeCommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                // ordre des colonnes
                dgvListeCommande.Columns["id"].Visible = false;
                dgvListeCommande.Columns["IdLivreDvd"].Visible = false;
                dgvListeCommande.Columns["IdSuivi"].Visible = false;
                dgvListeCommande.Columns["DateCommande"].DisplayIndex = 1;
                dgvListeCommande.Columns["Montant"].DisplayIndex = 2;
                dgvListeCommande.Columns["NbExemplaire"].DisplayIndex = 3;
                dgvListeCommande.Columns["EtapeSuivi"].DisplayIndex = 4;

            }
            else
            {
                bdgCommandes.DataSource = null;
            }

        }
        /// <summary>
        /// Affiche les commande d'un DVD dans le datagridview.
        /// </summary>
        private void AfficheLesCommandesDvd()
        {
            string idDocuement = txtNumDvd.Text;
            lesCommandesDvd = controller.GetCommandeDocument(idDocuement);
            RemplirCommandesListe(lesCommandesDvd);
            AccesGroupBoxAjoutCommande(true);
        }
        /// <summary>
        /// vérifie si la nouvelle étape est autorisée par rapport à l’étape précédente.
        /// </summary>
        /// <param name="statutActuel"></param>
        /// <param name="nouveauStatut"></param>
        /// <returns></returns>
        private static bool TransitionAutorisee(string statutActuel, string nouveauStatut)
        {
            if (statutActuel == "4")
            {
                return false;
            }
            if (statutActuel == "3" && (nouveauStatut == "1" || nouveauStatut == "2"))
            {
                return false;
            }
            if (nouveauStatut == "4" && statutActuel != "3")
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// recherche d'un DVD à partir de son numéro et affichage de ses informations et de ses commandes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecherche_Click(object sender, EventArgs e)
        {
            if (!txtNumDvd.Text.Equals(""))
            {
                Dvd dvd = lesDvd.Find(x => x.Id.Equals(txtNumDvd.Text));
                if (dvd != null)
                {
                    // Affichage dans le GroupBox
                    AfficheDvdInfos(dvd);
                }
                else
                {
                    MessageBox.Show("Livre introuvable.");
                    VideDvdInfos();
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un numéro de livre.");
                VideDvdInfos();
            }
        }
        /// <summary>
        /// supprime une commande selectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprCommandeDvd_Click(object sender, EventArgs e)
        {
            if (dgvListeCommande.SelectedRows.Count > 0)
            {
                
                CommandeDocument commandeselectionne = bdgCommandes.Current as CommandeDocument;
                string idCommande = commandeselectionne.id;
                string idSuivi = commandeselectionne.idsuivi;

                if (MessageBox.Show("Voulez-vous vraiment supprimer ce commande ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (idSuivi == "3")
                    {
                        MessageBox.Show("Impossible de supprimer une commande déjà livrée !", "Erreur de suppression");
                    }
                    else
                    {
                        if (controller.SupprimerCommandeDocument(idCommande))
                        {
                            AfficheLesCommandesDvd();
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de suppression du commande", "Erreur");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Annulation de suppression commande", TITRE_INFORMATION);
                }
            }
            else
            {
                MessageBox.Show("veuillez selectionner un commande de la liste pour supprimer ", TITRE_INFORMATION);

            }
        }
        /// <summary>
        /// change l'état de groupbox pour modifier l'étape de suivi d'une commande selectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifiCommandeDvd_Click(object sender, EventArgs e)
        {
            if (dgvListeCommande.SelectedRows.Count > 0)
            {
                modifier = true;
                EnCoursModifCommandeLivre(modifier);
                CommandeDocument commandeselectionne = (CommandeDocument)bdgCommandes.List[bdgCommandes.Position];
                cboSuivi.SelectedIndex = cboSuivi.FindStringExact(commandeselectionne.EtapeSuivi);

            }
            else
            {
                MessageBox.Show("veuillez selectionner un commande de la liste pour modifier ", TITRE_INFORMATION);
            }
        }
        /// <summary>
        /// Annule l'ajout ou modificatio d'une commande.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulCommandeDvd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VideGrpCommandeLivre();
                modifier = false;
                EnCoursModifCommandeLivre(false);
            }
        }
        /// <summary>
        /// enregistre ajout ou modification d'une commande.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrCommandeDvd_Click(object sender, EventArgs e)
        {
            if (!modifier)
            {
                EnregistreAjouterCommande();

            }
            else
            {
                EnregistreModifierCommande();

            }
        }
        /// <summary>
        /// tri sur les colonne de la liste.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListeCommande_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string titreColonne = dgvListeCommande.Columns[e.ColumnIndex].HeaderText;
            List<CommandeDocument> sortedList = new List<CommandeDocument>();
            switch (titreColonne)
            {
                case "dateCommande":
                    sortedList = lesCommandesDvd.OrderBy(o => o.dateCommande).ToList();
                    break;
                case "montant":
                    sortedList = lesCommandesDvd.OrderBy(o => o.montant).ToList();
                    break;
                case "nbExemplaire":
                    sortedList = lesCommandesDvd.OrderBy(o => o.nbExemplaire).ToList();
                    break;
                case "EtapeSuivi":
                    sortedList = lesCommandesDvd.OrderBy(o => o.EtapeSuivi).ToList();
                    break;
            }
            RemplirCommandesListe(sortedList);
        }
        /// <summary>
        /// permet d'enregistrer une nouvelle commande de DVD dans la base de données.
        /// </summary>
        private void EnregistreAjouterCommande()
        {
            EnCoursModifCommandeLivre(false);
            if (!txtMontant.Text.Equals("") && !txtNumDvd.Text.Equals(""))
            {
                try
                {
                    string idCommande = Guid.NewGuid().ToString().Substring(0, 5);
                    DateTime dateCommande = dtpDateCommande.Value;
                    double montant = double.Parse(txtMontant.Text);
                    int nbExemplaire = int.Parse(nudExemplaire.Text);
                    string idsuivi = "1";
                    string EtapeSuivi = "en cours";
                    string idLivreDvd = txtNumDvd.Text;
                    CommandeDocument DucumentL = new CommandeDocument(nbExemplaire, idLivreDvd, idsuivi, EtapeSuivi, idCommande, dateCommande, montant);
                    if (controller.AjoutCommandeDocument(DucumentL))
                    {
                        MessageBox.Show("ajout avec succes", TITRE_INFORMATION);
                        AfficheLesCommandesDvd();
                        VideGrpCommandeLivre();

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
        /// permet de modifier le suivi d'une commande de DVD dans la base de données.
        /// </summary>
        private void EnregistreModifierCommande()
        {
            EnCoursModifCommandeLivre(true);
            
            CommandeDocument commandeselectionne = (CommandeDocument)bdgCommandes.List[bdgCommandes.Position];

            string idCommande = commandeselectionne.id;
            string ancienSuivi = commandeselectionne.idsuivi;
            string nouveauSuivi = cboSuivi.SelectedValue.ToString();
            if (!TransitionAutorisee(ancienSuivi, nouveauSuivi))
            {
                MessageBox.Show("Transition non autorisée !");
                return;
            }
            if (controller.ModifierSuiviCommande(idCommande, nouveauSuivi))
            {
                MessageBox.Show("Statut modifié avec succès !");
                AfficheLesCommandesDvd();
                modifier = false;
                EnCoursModifCommandeLivre(false);

            }
            else
            {
                MessageBox.Show("Erreur lors de la modification !");
                modifier = false;
                EnCoursModifCommandeLivre(false);
            }
        }
    }
}
