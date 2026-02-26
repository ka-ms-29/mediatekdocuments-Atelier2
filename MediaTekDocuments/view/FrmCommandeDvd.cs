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

namespace MediaTekDocuments.view
{
    public partial class FrmCommandeDvd : Form
    {
        private readonly FrmCommandeDvdController controller;
        private List<Dvd> lesDvd = new List<Dvd>();
        private readonly BindingSource bdgSuivi = new BindingSource();
        private readonly BindingSource bdgCommandes = new BindingSource();
        private List<CommandeDocument> lesCommandesDvd = new List<CommandeDocument>();
        private Boolean modifier = false;
        public FrmCommandeDvd()
        {
            InitializeComponent();
            this.controller = new FrmCommandeDvdController();
        }

        private void FrmCommandeDvd_Load(object sender, EventArgs e)
        {
            RemplirListeSuivi();
            lesDvd = controller.GetAllDvd();
            EnCoursModifCommandeLivre(modifier);
            AccesGroupBoxAjoutCommande(false);
        }

        public void RemplirListeSuivi()
        {
            List<Suivi> lesSuivi = controller.GetAllSuivi();
            bdgSuivi.DataSource = lesSuivi;
            cboSuivi.DataSource = bdgSuivi;
            cboSuivi.SelectedIndex = 0;
            cboSuivi.DisplayMember = "Libelle";
            cboSuivi.ValueMember = "IdSuivi";
        }
        
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
        private void VideGrpCommandeLivre()
        {
            txtMontant.Text = "";
            nudExemplaire.Value = 1;
            dtpDateCommande.Value = DateTime.Now;
            //cboSuivi.SelectedIndex = 1;
        }
        private void AccesGroupBoxAjoutCommande(bool acces)
        {
            grbAjoutCommande.Enabled = acces;
        }
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
        private void AfficheLesCommandesDvd()
        {
            string idDocuement = txtNumDvd.Text;
            lesCommandesDvd = controller.GetCommandesLivre(idDocuement);
            RemplirCommandesListe(lesCommandesDvd);
            AccesGroupBoxAjoutCommande(true);
        }
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

        private void btnSupprCommandeDvd_Click(object sender, EventArgs e)
        {
            if (dgvListeCommande.SelectedRows.Count > 0)
            {
                //CommandeDocument commandeselectionne = (CommandeDocument)bdgCommandes.List[bdgCommandes.Position];
                CommandeDocument commandeselectionne = bdgCommandes.Current as CommandeDocument;
                string idCommande = commandeselectionne.id;

                if (MessageBox.Show("Voulez-vous vraiment supprimer ce commande ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (controller.SupprimerCommandeDocument(idCommande))
                    {
                        MessageBox.Show("Suppression avec succes", "Information");
                        AfficheLesCommandesDvd();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de suppression du commande", "Erreur");
                    }
                }
                else
                {
                    MessageBox.Show("Annulation de suppression commande", "information");
                }
            }
            else
            {
                MessageBox.Show("veuillez selectionner un commande de la liste pour supprimer ", "Information");

            }
        }

        private void btnModifiCommandeDvd_Click(object sender, EventArgs e)
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

        private void btnAnnulCommandeDvd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VideGrpCommandeLivre();
                modifier = false;
                EnCoursModifCommandeLivre(false);
            }
        }

        private void btnEnregistrCommandeDvd_Click(object sender, EventArgs e)
        {
            if (!modifier)
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
                            MessageBox.Show("ajout avec succes", "Information");
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
            else
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
    }
}
