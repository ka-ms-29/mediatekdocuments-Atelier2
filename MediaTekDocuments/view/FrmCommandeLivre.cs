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
    /// class d'affichage la gestion des commandes livres.
    /// </summary>
    public partial class FrmCommandeLivre : Form
    {
        private readonly FrmCommandeDocumentController controller;
        private readonly BindingSource bdgSuivi = new BindingSource();
        private readonly BindingSource bdgCommandes = new BindingSource();
        private List<CommandeDocument> lesCommandesLivre = new List<CommandeDocument>();
        private Boolean modifier = false;
        /// <summary>
        /// Constructeur : création du contrôleur lié à ce formulaire
        /// </summary>
        public FrmCommandeLivre()
        {
            InitializeComponent();
            this.controller = new FrmCommandeDocumentController();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCommandeLivre_Load(object sender, EventArgs e)
        {
            RemplirListeSuivi();
            EnCoursModifCommandeLivre(modifier);
            AccesGroupBoxAjoutCommande(false);
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
        /// Affichage des informations du livre sélectionné
        /// </summary>
        /// <param name="livre">le livre</param>
        private void AfficheLivresInfos(Livre livre)
        {
            txbLivresAuteurCom.Text = livre.Auteur;
            txbLivresCollectionCom.Text = livre.Collection;
            txbLivresImageCom.Text = livre.Image;
            txbLivresIsbnCom.Text = livre.Isbn;
            txbLivresNumeroCom.Text = livre.Id;
            txbLivresGenreCom.Text = livre.Genre;
            txbLivresPublicCom.Text = livre.Public;
            txbLivresRayonCom.Text = livre.Rayon;
            txbLivresTitreCom.Text = livre.Titre;
            string image = livre.Image;
            try
            {
                pcbLivresImageCom.Image = Image.FromFile(image);
            }
            catch
            {
                pcbLivresImageCom.Image = null;
            }
            AfficheLesCommandesLivre();

        }
        /// <summary>
        /// vide le gropBox des informations du livre
        /// </summary>
        private void VideLivresInfos()
        {
            txtNumLivre.Text = "";
            txbLivresAuteurCom.Text = "";
            txbLivresCollectionCom.Text = "";
            txbLivresImageCom.Text = "";
            txbLivresIsbnCom.Text = "";
            txbLivresNumeroCom.Text = "";
            txbLivresGenreCom.Text = "";
            txbLivresPublicCom.Text = "";
            txbLivresRayonCom.Text = "";
            txbLivresTitreCom.Text = "";
            pcbLivresImageCom.Image = null;
            dgvListeCommande.DataSource = null;
        }
        /// <summary>
        /// vide le gropBox de ajout commande livre
        /// </summary>
        private void VideGrpCommandeLivre()
        {
            txtMontant.Text = "";
            nudExemplaire.Value = 1;
            dtpDateCommande.Value = DateTime.Now;
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
        /// Remplir la liste des commandes du livre.
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
        /// Affiche les commande d'un livre dans le datagridview.
        /// </summary>
        private void AfficheLesCommandesLivre()
        {
            string idDocuement = txtNumLivre.Text;
            lesCommandesLivre = controller.GetCommandeDocument(idDocuement);
            RemplirCommandesListe(lesCommandesLivre);
            AccesGroupBoxAjoutCommande(true);
        }
        /// <summary>
        /// recherche d'un livre à partir de son numéro et affichage de ses informations et de ses commandes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void btnRecherche_Click(object sender, EventArgs e)
        {
            if (!txtNumLivre.Text.Equals(""))
            {
                List<Livre> lesLivres = controller.GetAllLivres();
                Livre livre = lesLivres.Find(x => x.Id.Equals(txtNumLivre.Text));
                if (livre != null)
                {
                    // Affichage dans le GroupBox
                    AfficheLivresInfos(livre);
                }
                else
                {
                    MessageBox.Show("Livre introuvable.");
                    VideLivresInfos();
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un numéro de livre.");
                VideLivresInfos();
            }
        }
        /// <summary>
        /// verifie si l'utilisateur est en train de modifier une commande ou d'ajouter une nouvelle commande.
        /// <param name="modifier"></param>
        private void EnCoursModifCommandeLivre(Boolean modifier)
        {
            if (modifier)
            {
                grbAjoutCommande.Text = "modifier le suivi du commande :";
                cboSuivi.Enabled = true;
                txtNumLivre.Enabled = false;
                nudExemplaire.Enabled = false;
                txtMontant.Enabled = false;
                dtpDateCommande.Enabled = false;
            }
            else
            {
                grbAjoutCommande.Text = "Ajouter on nouveau commande : ";
                cboSuivi.Enabled = false;
                txtNumLivre.Enabled = true;
                nudExemplaire.Enabled = true;
                txtMontant.Enabled = true;
                dtpDateCommande.Enabled = true;

            }
        }
        /// <summary>
        /// supprime une commande selectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprCommandLivr_Click(object sender, EventArgs e)
        {
            if (dgvListeCommande.SelectedRows.Count > 0)
            {
                //CommandeDocument commandeselectionne = (CommandeDocument)bdgCommandes.List[bdgCommandes.Position];
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
                            AfficheLesCommandesLivre();
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de suppression du commande", "Erreur");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Annulation de suppression commande", "information");
                }
            }
        }
        /// <summary>
        /// change l'état de groupbox pour modifier l'étape de suivi d'une commande selectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifiCommandLivr_Click(object sender, EventArgs e)
        {
            if (dgvListeCommande.SelectedRows.Count > 0)
            {
                modifier = true;
                EnCoursModifCommandeLivre(modifier);
                //CommandeDocument commandeDocument = (CommandeDocument)dgvListeCommande.CurrentRow.DataBoundItem;
                CommandeDocument commandeselectionne = (CommandeDocument)bdgCommandes.List[bdgCommandes.Position];
                cboSuivi.SelectedIndex = cboSuivi.FindStringExact(commandeselectionne.EtapeSuivi);

            }
            else
            {
                MessageBox.Show("veuillez selectionner un commande de la liste pour modifier ", "Information");
            }
        }
        /// <summary>
        /// enregistre ajout ou modification d'une commande.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrCommandeLivr_Click(object sender, EventArgs e)
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
        /// Annule l'ajout ou modificatio d'une commande.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulCommandeLivr_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VideGrpCommandeLivre();
                modifier = false;
                EnCoursModifCommandeLivre(false);
            }
        }
        /// <summary>
        /// faire tri sur les colonne de la liste.
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
                    sortedList = lesCommandesLivre.OrderBy(o => o.dateCommande).ToList();
                    break;
                case "montant":
                    sortedList = lesCommandesLivre.OrderBy(o => o.montant).ToList();
                    break;
                case "nbExemplaire":
                    sortedList = lesCommandesLivre.OrderBy(o => o.nbExemplaire).ToList();
                    break;
                case "EtapeSuivi":
                    sortedList = lesCommandesLivre.OrderBy(o => o.EtapeSuivi).ToList();
                    break;
            }
            RemplirCommandesListe(sortedList);
        }
        /// <summary>
        /// vérifie si la nouvelle étape est autorisée par rapport à l’étape précédente.
        /// </summary>
        /// <param name="statutActuel"></param>
        /// <param name="nouveauStatut"></param>
        /// <returns></returns>
        private bool TransitionAutorisee(string statutActuel, string nouveauStatut)
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
        /// permet d'enregistrer une nouvelle commande de DVD dans la base de données.
        /// </summary>
        private void EnregistreAjouterCommande()
        {
            EnCoursModifCommandeLivre(false);
            if (!txtMontant.Text.Equals("") && !txtNumLivre.Text.Equals(""))
            {
                try
                {
                    string idCommande = Guid.NewGuid().ToString().Substring(0, 5);
                    DateTime dateCommande = dtpDateCommande.Value;
                    double montant = double.Parse(txtMontant.Text);
                    int nbExemplaire = int.Parse(nudExemplaire.Text);
                    string idsuivi = "1";
                    string EtapeSuivi = "en cours";
                    string idLivreDvd = txtNumLivre.Text;
                    CommandeDocument DucumentL = new CommandeDocument(nbExemplaire, idLivreDvd, idsuivi, EtapeSuivi, idCommande, dateCommande, montant);
                    if (controller.AjoutCommandeDocument(DucumentL))
                    {
                        MessageBox.Show("ajout avec succes", "Information");
                        AfficheLesCommandesLivre();
                        VideGrpCommandeLivre();

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
        }
        /// <summary>
        /// permet de modifier le suivi d'une commande de DVD dans la base de données.
        /// </summary>
        private void EnregistreModifierCommande()
        {
            EnCoursModifCommandeLivre(true);
            //DataGridViewRow row = dgvListeCommande.SelectedRows[0];
            //CommandeDocument commandeselectionne = row.DataBoundItem as CommandeDocument;
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
                AfficheLesCommandesLivre();
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
