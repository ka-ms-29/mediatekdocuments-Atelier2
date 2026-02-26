namespace MediaTekDocuments.view
{
    partial class FrmCommandeRevue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbAjoutCommande = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.dtpDateCommande = new System.Windows.Forms.DateTimePicker();
            this.btnAnnulCommandeDvd = new System.Windows.Forms.Button();
            this.btnEnregistrCommandeDvd = new System.Windows.Forms.Button();
            this.grbCommandesDvd = new System.Windows.Forms.GroupBox();
            this.btnSupprCommandeDvd = new System.Windows.Forms.Button();
            this.dgvListeCommande = new System.Windows.Forms.DataGridView();
            this.lblNumSaisir = new System.Windows.Forms.Label();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.txtNumRevueRecherche = new System.Windows.Forms.TextBox();
            this.grbInfoDvdCom = new System.Windows.Forms.GroupBox();
            this.label57 = new System.Windows.Forms.Label();
            this.txbRevuesImageCom = new System.Windows.Forms.TextBox();
            this.txbRevuesRayonCom = new System.Windows.Forms.TextBox();
            this.txbRevuesPublicCom = new System.Windows.Forms.TextBox();
            this.txbRevuesGenreCom = new System.Windows.Forms.TextBox();
            this.txbRevuesDateMiseADispoCom = new System.Windows.Forms.TextBox();
            this.txbRevuesPeriodiciteCom = new System.Windows.Forms.TextBox();
            this.txbRevuesTitreCom = new System.Windows.Forms.TextBox();
            this.txbRevuesNumeroCom = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.pcbRevuesImageCom = new System.Windows.Forms.PictureBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFinAbonnement = new System.Windows.Forms.DateTimePicker();
            this.grbAjoutCommande.SuspendLayout();
            this.grbCommandesDvd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCommande)).BeginInit();
            this.grbInfoDvdCom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRevuesImageCom)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAjoutCommande
            // 
            this.grbAjoutCommande.Controls.Add(this.dtpFinAbonnement);
            this.grbAjoutCommande.Controls.Add(this.label1);
            this.grbAjoutCommande.Controls.Add(this.label3);
            this.grbAjoutCommande.Controls.Add(this.label2);
            this.grbAjoutCommande.Controls.Add(this.txtMontant);
            this.grbAjoutCommande.Controls.Add(this.dtpDateCommande);
            this.grbAjoutCommande.Controls.Add(this.btnAnnulCommandeDvd);
            this.grbAjoutCommande.Controls.Add(this.btnEnregistrCommandeDvd);
            this.grbAjoutCommande.Location = new System.Drawing.Point(20, 639);
            this.grbAjoutCommande.Name = "grbAjoutCommande";
            this.grbAjoutCommande.Size = new System.Drawing.Size(1136, 150);
            this.grbAjoutCommande.TabIndex = 62;
            this.grbAjoutCommande.TabStop = false;
            this.grbAjoutCommande.Text = "Ajouter une nouvelle abonnement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Mmontant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Date Commande : ";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(508, 35);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(189, 22);
            this.txtMontant.TabIndex = 3;
            // 
            // dtpDateCommande
            // 
            this.dtpDateCommande.Location = new System.Drawing.Point(159, 35);
            this.dtpDateCommande.MinDate = new System.DateTime(2026, 2, 18, 0, 0, 0, 0);
            this.dtpDateCommande.Name = "dtpDateCommande";
            this.dtpDateCommande.Size = new System.Drawing.Size(200, 22);
            this.dtpDateCommande.TabIndex = 2;
            // 
            // btnAnnulCommandeDvd
            // 
            this.btnAnnulCommandeDvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulCommandeDvd.Location = new System.Drawing.Point(159, 91);
            this.btnAnnulCommandeDvd.Name = "btnAnnulCommandeDvd";
            this.btnAnnulCommandeDvd.Size = new System.Drawing.Size(132, 30);
            this.btnAnnulCommandeDvd.TabIndex = 1;
            this.btnAnnulCommandeDvd.Text = "Annuler";
            this.btnAnnulCommandeDvd.UseVisualStyleBackColor = true;
            this.btnAnnulCommandeDvd.Click += new System.EventHandler(this.btnAnnulCommandeDvd_Click);
            // 
            // btnEnregistrCommandeDvd
            // 
            this.btnEnregistrCommandeDvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrCommandeDvd.Location = new System.Drawing.Point(13, 91);
            this.btnEnregistrCommandeDvd.Name = "btnEnregistrCommandeDvd";
            this.btnEnregistrCommandeDvd.Size = new System.Drawing.Size(130, 30);
            this.btnEnregistrCommandeDvd.TabIndex = 0;
            this.btnEnregistrCommandeDvd.Text = "Enregistrer";
            this.btnEnregistrCommandeDvd.UseVisualStyleBackColor = true;
            this.btnEnregistrCommandeDvd.Click += new System.EventHandler(this.btnEnregistrCommandeDvd_Click);
            // 
            // grbCommandesDvd
            // 
            this.grbCommandesDvd.Controls.Add(this.btnSupprCommandeDvd);
            this.grbCommandesDvd.Controls.Add(this.dgvListeCommande);
            this.grbCommandesDvd.Location = new System.Drawing.Point(20, 382);
            this.grbCommandesDvd.Name = "grbCommandesDvd";
            this.grbCommandesDvd.Size = new System.Drawing.Size(1136, 251);
            this.grbCommandesDvd.TabIndex = 61;
            this.grbCommandesDvd.TabStop = false;
            this.grbCommandesDvd.Text = "Liste des abonnements pour cette revue";
            // 
            // btnSupprCommandeDvd
            // 
            this.btnSupprCommandeDvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprCommandeDvd.Location = new System.Drawing.Point(11, 206);
            this.btnSupprCommandeDvd.Name = "btnSupprCommandeDvd";
            this.btnSupprCommandeDvd.Size = new System.Drawing.Size(132, 30);
            this.btnSupprCommandeDvd.TabIndex = 5;
            this.btnSupprCommandeDvd.Text = "Supprimer";
            this.btnSupprCommandeDvd.UseVisualStyleBackColor = true;
            this.btnSupprCommandeDvd.Click += new System.EventHandler(this.btnSupprCommandeDvd_Click);
            // 
            // dgvListeCommande
            // 
            this.dgvListeCommande.AllowUserToAddRows = false;
            this.dgvListeCommande.AllowUserToDeleteRows = false;
            this.dgvListeCommande.AllowUserToResizeColumns = false;
            this.dgvListeCommande.AllowUserToResizeRows = false;
            this.dgvListeCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeCommande.Location = new System.Drawing.Point(11, 31);
            this.dgvListeCommande.MultiSelect = false;
            this.dgvListeCommande.Name = "dgvListeCommande";
            this.dgvListeCommande.ReadOnly = true;
            this.dgvListeCommande.RowHeadersVisible = false;
            this.dgvListeCommande.RowHeadersWidth = 51;
            this.dgvListeCommande.RowTemplate.Height = 24;
            this.dgvListeCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListeCommande.Size = new System.Drawing.Size(1114, 162);
            this.dgvListeCommande.TabIndex = 3;
            this.dgvListeCommande.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListeCommande_ColumnHeaderMouseClick);
            // 
            // lblNumSaisir
            // 
            this.lblNumSaisir.AutoSize = true;
            this.lblNumSaisir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSaisir.Location = new System.Drawing.Point(28, 30);
            this.lblNumSaisir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumSaisir.Name = "lblNumSaisir";
            this.lblNumSaisir.Size = new System.Drawing.Size(210, 17);
            this.lblNumSaisir.TabIndex = 65;
            this.lblNumSaisir.Text = "Saisir un numéro du revue :";
            // 
            // btnRecherche
            // 
            this.btnRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.Location = new System.Drawing.Point(469, 26);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(128, 27);
            this.btnRecherche.TabIndex = 64;
            this.btnRecherche.Text = " Rechrche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // txtNumRevueRecherche
            // 
            this.txtNumRevueRecherche.Location = new System.Drawing.Point(245, 28);
            this.txtNumRevueRecherche.Name = "txtNumRevueRecherche";
            this.txtNumRevueRecherche.Size = new System.Drawing.Size(203, 22);
            this.txtNumRevueRecherche.TabIndex = 63;
            // 
            // grbInfoDvdCom
            // 
            this.grbInfoDvdCom.Controls.Add(this.label57);
            this.grbInfoDvdCom.Controls.Add(this.txbRevuesImageCom);
            this.grbInfoDvdCom.Controls.Add(this.txbRevuesRayonCom);
            this.grbInfoDvdCom.Controls.Add(this.txbRevuesPublicCom);
            this.grbInfoDvdCom.Controls.Add(this.txbRevuesGenreCom);
            this.grbInfoDvdCom.Controls.Add(this.txbRevuesDateMiseADispoCom);
            this.grbInfoDvdCom.Controls.Add(this.txbRevuesPeriodiciteCom);
            this.grbInfoDvdCom.Controls.Add(this.txbRevuesTitreCom);
            this.grbInfoDvdCom.Controls.Add(this.txbRevuesNumeroCom);
            this.grbInfoDvdCom.Controls.Add(this.label35);
            this.grbInfoDvdCom.Controls.Add(this.pcbRevuesImageCom);
            this.grbInfoDvdCom.Controls.Add(this.label36);
            this.grbInfoDvdCom.Controls.Add(this.label37);
            this.grbInfoDvdCom.Controls.Add(this.label43);
            this.grbInfoDvdCom.Controls.Add(this.label44);
            this.grbInfoDvdCom.Controls.Add(this.label45);
            this.grbInfoDvdCom.Controls.Add(this.label46);
            this.grbInfoDvdCom.Controls.Add(this.label47);
            this.grbInfoDvdCom.Location = new System.Drawing.Point(20, 67);
            this.grbInfoDvdCom.Name = "grbInfoDvdCom";
            this.grbInfoDvdCom.Size = new System.Drawing.Size(1136, 298);
            this.grbInfoDvdCom.TabIndex = 60;
            this.grbInfoDvdCom.TabStop = false;
            this.grbInfoDvdCom.Text = "Information Revue";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(745, 19);
            this.label57.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(61, 17);
            this.label57.TabIndex = 50;
            this.label57.Text = "Image :";
            // 
            // txbRevuesImageCom
            // 
            this.txbRevuesImageCom.Location = new System.Drawing.Point(202, 245);
            this.txbRevuesImageCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesImageCom.Name = "txbRevuesImageCom";
            this.txbRevuesImageCom.ReadOnly = true;
            this.txbRevuesImageCom.Size = new System.Drawing.Size(520, 22);
            this.txbRevuesImageCom.TabIndex = 49;
            // 
            // txbRevuesRayonCom
            // 
            this.txbRevuesRayonCom.Location = new System.Drawing.Point(202, 214);
            this.txbRevuesRayonCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesRayonCom.Name = "txbRevuesRayonCom";
            this.txbRevuesRayonCom.ReadOnly = true;
            this.txbRevuesRayonCom.Size = new System.Drawing.Size(275, 22);
            this.txbRevuesRayonCom.TabIndex = 48;
            // 
            // txbRevuesPublicCom
            // 
            this.txbRevuesPublicCom.Location = new System.Drawing.Point(202, 183);
            this.txbRevuesPublicCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesPublicCom.Name = "txbRevuesPublicCom";
            this.txbRevuesPublicCom.ReadOnly = true;
            this.txbRevuesPublicCom.Size = new System.Drawing.Size(275, 22);
            this.txbRevuesPublicCom.TabIndex = 47;
            // 
            // txbRevuesGenreCom
            // 
            this.txbRevuesGenreCom.Location = new System.Drawing.Point(202, 153);
            this.txbRevuesGenreCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesGenreCom.Name = "txbRevuesGenreCom";
            this.txbRevuesGenreCom.ReadOnly = true;
            this.txbRevuesGenreCom.Size = new System.Drawing.Size(275, 22);
            this.txbRevuesGenreCom.TabIndex = 46;
            // 
            // txbRevuesDateMiseADispoCom
            // 
            this.txbRevuesDateMiseADispoCom.Location = new System.Drawing.Point(202, 122);
            this.txbRevuesDateMiseADispoCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesDateMiseADispoCom.Name = "txbRevuesDateMiseADispoCom";
            this.txbRevuesDateMiseADispoCom.ReadOnly = true;
            this.txbRevuesDateMiseADispoCom.Size = new System.Drawing.Size(132, 22);
            this.txbRevuesDateMiseADispoCom.TabIndex = 45;
            // 
            // txbRevuesPeriodiciteCom
            // 
            this.txbRevuesPeriodiciteCom.Location = new System.Drawing.Point(202, 91);
            this.txbRevuesPeriodiciteCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesPeriodiciteCom.Name = "txbRevuesPeriodiciteCom";
            this.txbRevuesPeriodiciteCom.ReadOnly = true;
            this.txbRevuesPeriodiciteCom.Size = new System.Drawing.Size(132, 22);
            this.txbRevuesPeriodiciteCom.TabIndex = 44;
            // 
            // txbRevuesTitreCom
            // 
            this.txbRevuesTitreCom.Location = new System.Drawing.Point(202, 60);
            this.txbRevuesTitreCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesTitreCom.Name = "txbRevuesTitreCom";
            this.txbRevuesTitreCom.ReadOnly = true;
            this.txbRevuesTitreCom.Size = new System.Drawing.Size(520, 22);
            this.txbRevuesTitreCom.TabIndex = 43;
            // 
            // txbRevuesNumeroCom
            // 
            this.txbRevuesNumeroCom.Location = new System.Drawing.Point(202, 30);
            this.txbRevuesNumeroCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesNumeroCom.Name = "txbRevuesNumeroCom";
            this.txbRevuesNumeroCom.ReadOnly = true;
            this.txbRevuesNumeroCom.Size = new System.Drawing.Size(132, 22);
            this.txbRevuesNumeroCom.TabIndex = 42;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(10, 153);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(63, 17);
            this.label35.TabIndex = 41;
            this.label35.Text = "Genre :";
            // 
            // pcbRevuesImageCom
            // 
            this.pcbRevuesImageCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbRevuesImageCom.Location = new System.Drawing.Point(749, 38);
            this.pcbRevuesImageCom.Margin = new System.Windows.Forms.Padding(4);
            this.pcbRevuesImageCom.Name = "pcbRevuesImageCom";
            this.pcbRevuesImageCom.Size = new System.Drawing.Size(378, 247);
            this.pcbRevuesImageCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRevuesImageCom.TabIndex = 40;
            this.pcbRevuesImageCom.TabStop = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(10, 183);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(62, 17);
            this.label36.TabIndex = 39;
            this.label36.Text = "Public :";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(10, 214);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(64, 17);
            this.label37.TabIndex = 38;
            this.label37.Text = "Rayon :";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(10, 60);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(52, 17);
            this.label43.TabIndex = 35;
            this.label43.Text = "Titre :";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(10, 30);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(172, 17);
            this.label44.TabIndex = 33;
            this.label44.Text = "Numéro de document :";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(10, 91);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(95, 17);
            this.label45.TabIndex = 36;
            this.label45.Text = "Périodicité :";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(10, 245);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(150, 17);
            this.label46.TabIndex = 34;
            this.label46.Text = "Chemin de l\'image :";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(10, 122);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(151, 17);
            this.label47.TabIndex = 37;
            this.label47.Text = "Délai mise à dispo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(731, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Date fin d\'abonnement : ";
            // 
            // dtpFinAbonnement
            // 
            this.dtpFinAbonnement.Location = new System.Drawing.Point(925, 36);
            this.dtpFinAbonnement.MinDate = new System.DateTime(2026, 2, 18, 0, 0, 0, 0);
            this.dtpFinAbonnement.Name = "dtpFinAbonnement";
            this.dtpFinAbonnement.Size = new System.Drawing.Size(200, 22);
            this.dtpFinAbonnement.TabIndex = 45;
            // 
            // FrmCommandeRevue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 811);
            this.Controls.Add(this.lblNumSaisir);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.txtNumRevueRecherche);
            this.Controls.Add(this.grbAjoutCommande);
            this.Controls.Add(this.grbCommandesDvd);
            this.Controls.Add(this.grbInfoDvdCom);
            this.Name = "FrmCommandeRevue";
            this.Text = "Abonnement de Revue";
            this.Load += new System.EventHandler(this.FrmCommandeRevue_Load);
            this.grbAjoutCommande.ResumeLayout(false);
            this.grbAjoutCommande.PerformLayout();
            this.grbCommandesDvd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCommande)).EndInit();
            this.grbInfoDvdCom.ResumeLayout(false);
            this.grbInfoDvdCom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRevuesImageCom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAjoutCommande;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.DateTimePicker dtpDateCommande;
        private System.Windows.Forms.Button btnAnnulCommandeDvd;
        private System.Windows.Forms.Button btnEnregistrCommandeDvd;
        private System.Windows.Forms.GroupBox grbCommandesDvd;
        private System.Windows.Forms.Button btnSupprCommandeDvd;
        private System.Windows.Forms.DataGridView dgvListeCommande;
        private System.Windows.Forms.Label lblNumSaisir;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.TextBox txtNumRevueRecherche;
        private System.Windows.Forms.GroupBox grbInfoDvdCom;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox txbRevuesImageCom;
        private System.Windows.Forms.TextBox txbRevuesRayonCom;
        private System.Windows.Forms.TextBox txbRevuesPublicCom;
        private System.Windows.Forms.TextBox txbRevuesGenreCom;
        private System.Windows.Forms.TextBox txbRevuesDateMiseADispoCom;
        private System.Windows.Forms.TextBox txbRevuesPeriodiciteCom;
        private System.Windows.Forms.TextBox txbRevuesTitreCom;
        private System.Windows.Forms.TextBox txbRevuesNumeroCom;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.PictureBox pcbRevuesImageCom;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.DateTimePicker dtpFinAbonnement;
        private System.Windows.Forms.Label label1;
    }
}