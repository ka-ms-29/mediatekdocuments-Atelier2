using MediaTekDocuments.controller;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTekDocuments.view
{
    /// <summary>
    /// class d'affichage la form d'authentification.
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        private readonly FrmAuthentificationController controller;

        /// <summary>
        /// Constructeur : création du contrôleur lié à ce formulaire
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            this.controller = new FrmAuthentificationController();
        }
        /// <summary>
        /// Boutton de "Se connecter" : operation pour récupérer l'utilisateur correspondant au nom et mot de passe saisis,
        /// et affichage de la form FrmMediték adapté au service de l'utilisateur.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string pwd = txtpwd.Text;
            string nom = txtLogin.Text;
            if (String.IsNullOrEmpty(pwd) || String.IsNullOrEmpty(nom))
            {
                MessageBox.Show("Tous les champs doivent etre remplis", "Information");

            }
            else
            {
                List<Utilisateurs> lesUtilisateurs = controller.GetUtilisateurs(nom, pwd);

                if (lesUtilisateurs.Count == 0)
                {
                    MessageBox.Show("Nom ou mot de passe incorrect");
                    videLesChmpsSaisie();
                }
                else if (lesUtilisateurs.Count > 1)
                {
                    MessageBox.Show("Erreur: plusieurs utilisateurs trouvés");
                    videLesChmpsSaisie();
                }
                else
                {
                    Utilisateurs utilisateur = lesUtilisateurs[0];
                    string service = utilisateur.idservice;
                    switch (service)
                    {
                        case "1":
                        case "2":
                        case "3":
                            FrmMediatek frmMediatek = new FrmMediatek(utilisateur);
                            frmMediatek.Show();
                            this.Hide();
                            break;

                        case "4":
                            MessageBox.Show("Utilisateur culture n'a pas l'autorisation d'accès à l'application");
                            Application.Exit();
                            break;

                        default:
                            MessageBox.Show("Erreur: service inconnu");
                            videLesChmpsSaisie();
                            break;
                    }
                }
            }
        }
        /// <summary>
        /// Vide les champs de saisie : Login et Password.
        /// </summary>
        private void videLesChmpsSaisie()
        {
            txtLogin.Text = "";
            txtpwd.Text = "";

        }


    }
}
