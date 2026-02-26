namespace MediaTekDocuments.view
{
    partial class FrmCommandeLivre
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
            this.lblNumLivre = new System.Windows.Forms.Label();
            this.txtNumLivre = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.dgvListeCommande = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.txbLivresIsbnCom = new System.Windows.Forms.TextBox();
            this.txbLivresImageCom = new System.Windows.Forms.TextBox();
            this.txbLivresRayonCom = new System.Windows.Forms.TextBox();
            this.txbLivresPublicCom = new System.Windows.Forms.TextBox();
            this.txbLivresGenreCom = new System.Windows.Forms.TextBox();
            this.txbLivresCollectionCom = new System.Windows.Forms.TextBox();
            this.txbLivresAuteurCom = new System.Windows.Forms.TextBox();
            this.txbLivresTitreCom = new System.Windows.Forms.TextBox();
            this.txbLivresNumeroCom = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.pcbLivresImageCom = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.grbCommandes = new System.Windows.Forms.GroupBox();
            this.btnSupprCommandLivr = new System.Windows.Forms.Button();
            this.btnModifiCommandLivr = new System.Windows.Forms.Button();
            this.grbAjoutCommande = new System.Windows.Forms.GroupBox();
            this.cboSuivi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudExemplaire = new System.Windows.Forms.NumericUpDown();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.dtpDateCommande = new System.Windows.Forms.DateTimePicker();
            this.btnAnnulCommandeLivr = new System.Windows.Forms.Button();
            this.btnEnregistrCommandeLivr = new System.Windows.Forms.Button();
            this.lblNumSaisir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCommande)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLivresImageCom)).BeginInit();
            this.grbCommandes.SuspendLayout();
            this.grbAjoutCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExemplaire)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumLivre
            // 
            this.lblNumLivre.AutoSize = true;
            this.lblNumLivre.Location = new System.Drawing.Point(12, 21);
            this.lblNumLivre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumLivre.Name = "lblNumLivre";
            this.lblNumLivre.Size = new System.Drawing.Size(0, 16);
            this.lblNumLivre.TabIndex = 0;
            // 
            // txtNumLivre
            // 
            this.txtNumLivre.Location = new System.Drawing.Point(271, 18);
            this.txtNumLivre.Name = "txtNumLivre";
            this.txtNumLivre.Size = new System.Drawing.Size(203, 22);
            this.txtNumLivre.TabIndex = 1;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(523, 16);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(128, 27);
            this.btnRecherche.TabIndex = 2;
            this.btnRecherche.Text = " Rechrche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
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
            this.dgvListeCommande.Size = new System.Drawing.Size(1114, 105);
            this.dgvListeCommande.TabIndex = 3;
            this.dgvListeCommande.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListeCommande_ColumnHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblImage);
            this.groupBox1.Controls.Add(this.txbLivresIsbnCom);
            this.groupBox1.Controls.Add(this.txbLivresImageCom);
            this.groupBox1.Controls.Add(this.txbLivresRayonCom);
            this.groupBox1.Controls.Add(this.txbLivresPublicCom);
            this.groupBox1.Controls.Add(this.txbLivresGenreCom);
            this.groupBox1.Controls.Add(this.txbLivresCollectionCom);
            this.groupBox1.Controls.Add(this.txbLivresAuteurCom);
            this.groupBox1.Controls.Add(this.txbLivresTitreCom);
            this.groupBox1.Controls.Add(this.txbLivresNumeroCom);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.pcbLivresImageCom);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblNum);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Location = new System.Drawing.Point(15, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1136, 314);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information livre";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(745, 22);
            this.lblImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(61, 17);
            this.lblImage.TabIndex = 53;
            this.lblImage.Text = "Image :";
            // 
            // txbLivresIsbnCom
            // 
            this.txbLivresIsbnCom.Location = new System.Drawing.Point(590, 33);
            this.txbLivresIsbnCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresIsbnCom.Name = "txbLivresIsbnCom";
            this.txbLivresIsbnCom.ReadOnly = true;
            this.txbLivresIsbnCom.Size = new System.Drawing.Size(132, 22);
            this.txbLivresIsbnCom.TabIndex = 52;
            // 
            // txbLivresImageCom
            // 
            this.txbLivresImageCom.Location = new System.Drawing.Point(202, 248);
            this.txbLivresImageCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresImageCom.Name = "txbLivresImageCom";
            this.txbLivresImageCom.ReadOnly = true;
            this.txbLivresImageCom.Size = new System.Drawing.Size(520, 22);
            this.txbLivresImageCom.TabIndex = 51;
            // 
            // txbLivresRayonCom
            // 
            this.txbLivresRayonCom.Location = new System.Drawing.Point(202, 217);
            this.txbLivresRayonCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresRayonCom.Name = "txbLivresRayonCom";
            this.txbLivresRayonCom.ReadOnly = true;
            this.txbLivresRayonCom.Size = new System.Drawing.Size(275, 22);
            this.txbLivresRayonCom.TabIndex = 50;
            // 
            // txbLivresPublicCom
            // 
            this.txbLivresPublicCom.Location = new System.Drawing.Point(202, 186);
            this.txbLivresPublicCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresPublicCom.Name = "txbLivresPublicCom";
            this.txbLivresPublicCom.ReadOnly = true;
            this.txbLivresPublicCom.Size = new System.Drawing.Size(275, 22);
            this.txbLivresPublicCom.TabIndex = 49;
            // 
            // txbLivresGenreCom
            // 
            this.txbLivresGenreCom.Location = new System.Drawing.Point(202, 156);
            this.txbLivresGenreCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresGenreCom.Name = "txbLivresGenreCom";
            this.txbLivresGenreCom.ReadOnly = true;
            this.txbLivresGenreCom.Size = new System.Drawing.Size(275, 22);
            this.txbLivresGenreCom.TabIndex = 48;
            // 
            // txbLivresCollectionCom
            // 
            this.txbLivresCollectionCom.Location = new System.Drawing.Point(202, 125);
            this.txbLivresCollectionCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresCollectionCom.Name = "txbLivresCollectionCom";
            this.txbLivresCollectionCom.ReadOnly = true;
            this.txbLivresCollectionCom.Size = new System.Drawing.Size(520, 22);
            this.txbLivresCollectionCom.TabIndex = 47;
            // 
            // txbLivresAuteurCom
            // 
            this.txbLivresAuteurCom.Location = new System.Drawing.Point(202, 94);
            this.txbLivresAuteurCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresAuteurCom.Name = "txbLivresAuteurCom";
            this.txbLivresAuteurCom.ReadOnly = true;
            this.txbLivresAuteurCom.Size = new System.Drawing.Size(275, 22);
            this.txbLivresAuteurCom.TabIndex = 46;
            // 
            // txbLivresTitreCom
            // 
            this.txbLivresTitreCom.Location = new System.Drawing.Point(202, 63);
            this.txbLivresTitreCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresTitreCom.Name = "txbLivresTitreCom";
            this.txbLivresTitreCom.ReadOnly = true;
            this.txbLivresTitreCom.Size = new System.Drawing.Size(520, 22);
            this.txbLivresTitreCom.TabIndex = 45;
            // 
            // txbLivresNumeroCom
            // 
            this.txbLivresNumeroCom.Location = new System.Drawing.Point(202, 33);
            this.txbLivresNumeroCom.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresNumeroCom.Name = "txbLivresNumeroCom";
            this.txbLivresNumeroCom.ReadOnly = true;
            this.txbLivresNumeroCom.Size = new System.Drawing.Size(132, 22);
            this.txbLivresNumeroCom.TabIndex = 44;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(10, 156);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 17);
            this.label22.TabIndex = 43;
            this.label22.Text = "Genre :";
            // 
            // pcbLivresImageCom
            // 
            this.pcbLivresImageCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbLivresImageCom.Location = new System.Drawing.Point(749, 41);
            this.pcbLivresImageCom.Margin = new System.Windows.Forms.Padding(4);
            this.pcbLivresImageCom.Name = "pcbLivresImageCom";
            this.pcbLivresImageCom.Size = new System.Drawing.Size(378, 258);
            this.pcbLivresImageCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLivresImageCom.TabIndex = 42;
            this.pcbLivresImageCom.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 186);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 17);
            this.label19.TabIndex = 41;
            this.label19.Text = "Public :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Rayon :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Titre :";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(10, 33);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(172, 17);
            this.lblNum.TabIndex = 34;
            this.lblNum.Text = "Numéro de document :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Auteur(e) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 248);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Chemin de l\'image :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 125);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 17);
            this.label12.TabIndex = 39;
            this.label12.Text = "Collection :";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(478, 33);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(95, 17);
            this.lblCode.TabIndex = 36;
            this.lblCode.Text = "Code ISBN :";
            // 
            // grbCommandes
            // 
            this.grbCommandes.Controls.Add(this.btnSupprCommandLivr);
            this.grbCommandes.Controls.Add(this.btnModifiCommandLivr);
            this.grbCommandes.Controls.Add(this.dgvListeCommande);
            this.grbCommandes.Location = new System.Drawing.Point(15, 366);
            this.grbCommandes.Name = "grbCommandes";
            this.grbCommandes.Size = new System.Drawing.Size(1136, 194);
            this.grbCommandes.TabIndex = 55;
            this.grbCommandes.TabStop = false;
            this.grbCommandes.Text = "Liste des commande ";
            // 
            // btnSupprCommandLivr
            // 
            this.btnSupprCommandLivr.Location = new System.Drawing.Point(139, 152);
            this.btnSupprCommandLivr.Name = "btnSupprCommandLivr";
            this.btnSupprCommandLivr.Size = new System.Drawing.Size(106, 30);
            this.btnSupprCommandLivr.TabIndex = 5;
            this.btnSupprCommandLivr.Text = "Supprimer";
            this.btnSupprCommandLivr.UseVisualStyleBackColor = true;
            this.btnSupprCommandLivr.Click += new System.EventHandler(this.btnSupprCommandLivr_Click);
            // 
            // btnModifiCommandLivr
            // 
            this.btnModifiCommandLivr.Location = new System.Drawing.Point(11, 152);
            this.btnModifiCommandLivr.Name = "btnModifiCommandLivr";
            this.btnModifiCommandLivr.Size = new System.Drawing.Size(106, 30);
            this.btnModifiCommandLivr.TabIndex = 4;
            this.btnModifiCommandLivr.Text = "Modifier";
            this.btnModifiCommandLivr.UseVisualStyleBackColor = true;
            this.btnModifiCommandLivr.Click += new System.EventHandler(this.btnModifiCommandLivr_Click);
            // 
            // grbAjoutCommande
            // 
            this.grbAjoutCommande.Controls.Add(this.cboSuivi);
            this.grbAjoutCommande.Controls.Add(this.label5);
            this.grbAjoutCommande.Controls.Add(this.label4);
            this.grbAjoutCommande.Controls.Add(this.label3);
            this.grbAjoutCommande.Controls.Add(this.label2);
            this.grbAjoutCommande.Controls.Add(this.nudExemplaire);
            this.grbAjoutCommande.Controls.Add(this.txtMontant);
            this.grbAjoutCommande.Controls.Add(this.dtpDateCommande);
            this.grbAjoutCommande.Controls.Add(this.btnAnnulCommandeLivr);
            this.grbAjoutCommande.Controls.Add(this.btnEnregistrCommandeLivr);
            this.grbAjoutCommande.Location = new System.Drawing.Point(14, 565);
            this.grbAjoutCommande.Name = "grbAjoutCommande";
            this.grbAjoutCommande.Size = new System.Drawing.Size(1136, 207);
            this.grbAjoutCommande.TabIndex = 56;
            this.grbAjoutCommande.TabStop = false;
            this.grbAjoutCommande.Text = "Ajouter une nouvelle commande";
            // 
            // cboSuivi
            // 
            this.cboSuivi.FormattingEnabled = true;
            this.cboSuivi.Location = new System.Drawing.Point(949, 33);
            this.cboSuivi.Name = "cboSuivi";
            this.cboSuivi.Size = new System.Drawing.Size(177, 24);
            this.cboSuivi.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(881, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Statut :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Numbre d\'éxemplaire :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 87);
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
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Date : ";
            // 
            // nudExemplaire
            // 
            this.nudExemplaire.Location = new System.Drawing.Point(530, 35);
            this.nudExemplaire.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExemplaire.Name = "nudExemplaire";
            this.nudExemplaire.Size = new System.Drawing.Size(120, 22);
            this.nudExemplaire.TabIndex = 4;
            this.nudExemplaire.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(115, 85);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(160, 22);
            this.txtMontant.TabIndex = 3;
            // 
            // dtpDateCommande
            // 
            this.dtpDateCommande.Location = new System.Drawing.Point(75, 36);
            this.dtpDateCommande.MinDate = new System.DateTime(2026, 2, 18, 0, 0, 0, 0);
            this.dtpDateCommande.Name = "dtpDateCommande";
            this.dtpDateCommande.Size = new System.Drawing.Size(200, 22);
            this.dtpDateCommande.TabIndex = 2;
            // 
            // btnAnnulCommandeLivr
            // 
            this.btnAnnulCommandeLivr.Location = new System.Drawing.Point(140, 150);
            this.btnAnnulCommandeLivr.Name = "btnAnnulCommandeLivr";
            this.btnAnnulCommandeLivr.Size = new System.Drawing.Size(106, 30);
            this.btnAnnulCommandeLivr.TabIndex = 1;
            this.btnAnnulCommandeLivr.Text = "Annuler";
            this.btnAnnulCommandeLivr.UseVisualStyleBackColor = true;
            this.btnAnnulCommandeLivr.Click += new System.EventHandler(this.btnAnnulCommandeLivr_Click);
            // 
            // btnEnregistrCommandeLivr
            // 
            this.btnEnregistrCommandeLivr.Location = new System.Drawing.Point(14, 150);
            this.btnEnregistrCommandeLivr.Name = "btnEnregistrCommandeLivr";
            this.btnEnregistrCommandeLivr.Size = new System.Drawing.Size(106, 30);
            this.btnEnregistrCommandeLivr.TabIndex = 0;
            this.btnEnregistrCommandeLivr.Text = "Enregistrer";
            this.btnEnregistrCommandeLivr.UseVisualStyleBackColor = true;
            this.btnEnregistrCommandeLivr.Click += new System.EventHandler(this.btnEnregistrCommandeLivr_Click);
            // 
            // lblNumSaisir
            // 
            this.lblNumSaisir.AutoSize = true;
            this.lblNumSaisir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSaisir.Location = new System.Drawing.Point(25, 20);
            this.lblNumSaisir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumSaisir.Name = "lblNumSaisir";
            this.lblNumSaisir.Size = new System.Drawing.Size(200, 17);
            this.lblNumSaisir.TabIndex = 57;
            this.lblNumSaisir.Text = "Saisir un numéro du livre :";
            // 
            // FrmCommandeLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 811);
            this.Controls.Add(this.lblNumSaisir);
            this.Controls.Add(this.grbAjoutCommande);
            this.Controls.Add(this.grbCommandes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.txtNumLivre);
            this.Controls.Add(this.lblNumLivre);
            this.Name = "FrmCommandeLivre";
            this.Text = "Gestion des commandes des livres";
            this.Load += new System.EventHandler(this.FrmCommandeLivre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCommande)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLivresImageCom)).EndInit();
            this.grbCommandes.ResumeLayout(false);
            this.grbAjoutCommande.ResumeLayout(false);
            this.grbAjoutCommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExemplaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumLivre;
        private System.Windows.Forms.TextBox txtNumLivre;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.DataGridView dgvListeCommande;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox txbLivresIsbnCom;
        private System.Windows.Forms.TextBox txbLivresImageCom;
        private System.Windows.Forms.TextBox txbLivresRayonCom;
        private System.Windows.Forms.TextBox txbLivresPublicCom;
        private System.Windows.Forms.TextBox txbLivresGenreCom;
        private System.Windows.Forms.TextBox txbLivresCollectionCom;
        private System.Windows.Forms.TextBox txbLivresAuteurCom;
        private System.Windows.Forms.TextBox txbLivresTitreCom;
        private System.Windows.Forms.TextBox txbLivresNumeroCom;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pcbLivresImageCom;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.GroupBox grbCommandes;
        private System.Windows.Forms.Button btnSupprCommandLivr;
        private System.Windows.Forms.Button btnModifiCommandLivr;
        private System.Windows.Forms.GroupBox grbAjoutCommande;
        private System.Windows.Forms.Button btnAnnulCommandeLivr;
        private System.Windows.Forms.Button btnEnregistrCommandeLivr;
        private System.Windows.Forms.Label lblNumSaisir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudExemplaire;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.DateTimePicker dtpDateCommande;
        private System.Windows.Forms.ComboBox cboSuivi;
    }
}