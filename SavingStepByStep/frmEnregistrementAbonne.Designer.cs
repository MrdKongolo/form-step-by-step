namespace SavingStepByStep
{
    partial class frmEnregistrementAbonne
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
            this.components = new System.ComponentModel.Container();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelIdentite = new System.Windows.Forms.Panel();
            this.panelAdresse = new System.Windows.Forms.Panel();
            this.cboDesignation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarteID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtAvenue = new System.Windows.Forms.TextBox();
            this.txtQuartier = new System.Windows.Forms.TextBox();
            this.txtCommune = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtNationalite = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.abonneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelLeft.SuspendLayout();
            this.panelIdentite.SuspendLayout();
            this.panelAdresse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(38)))), ((int)(((byte)(66)))));
            this.panelLeft.Controls.Add(this.btnNouveau);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(84, 333);
            this.panelLeft.TabIndex = 0;
            // 
            // panelIdentite
            // 
            this.panelIdentite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelIdentite.Controls.Add(this.btnSuivant);
            this.panelIdentite.Controls.Add(this.txtNom);
            this.panelIdentite.Controls.Add(this.txtPrenom);
            this.panelIdentite.Controls.Add(this.txtCarteID);
            this.panelIdentite.Controls.Add(this.txtPhone);
            this.panelIdentite.Controls.Add(this.label6);
            this.panelIdentite.Controls.Add(this.label5);
            this.panelIdentite.Controls.Add(this.label4);
            this.panelIdentite.Controls.Add(this.label3);
            this.panelIdentite.Controls.Add(this.label2);
            this.panelIdentite.Controls.Add(this.label1);
            this.panelIdentite.Controls.Add(this.cboType);
            this.panelIdentite.Controls.Add(this.cboDesignation);
            this.panelIdentite.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelIdentite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(38)))), ((int)(((byte)(66)))));
            this.panelIdentite.Location = new System.Drawing.Point(0, 1);
            this.panelIdentite.Name = "panelIdentite";
            this.panelIdentite.Size = new System.Drawing.Size(322, 331);
            this.panelIdentite.TabIndex = 0;
            // 
            // panelAdresse
            // 
            this.panelAdresse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelAdresse.Controls.Add(this.panelIdentite);
            this.panelAdresse.Controls.Add(this.btnEnregistrer);
            this.panelAdresse.Controls.Add(this.btnPrecedent);
            this.panelAdresse.Controls.Add(this.txtLieu);
            this.panelAdresse.Controls.Add(this.btnAnnuler);
            this.panelAdresse.Controls.Add(this.txtDate);
            this.panelAdresse.Controls.Add(this.txtNationalite);
            this.panelAdresse.Controls.Add(this.txtVille);
            this.panelAdresse.Controls.Add(this.txtCommune);
            this.panelAdresse.Controls.Add(this.txtQuartier);
            this.panelAdresse.Controls.Add(this.txtAvenue);
            this.panelAdresse.Controls.Add(this.txtNum);
            this.panelAdresse.Controls.Add(this.label14);
            this.panelAdresse.Controls.Add(this.label13);
            this.panelAdresse.Controls.Add(this.label12);
            this.panelAdresse.Controls.Add(this.label11);
            this.panelAdresse.Controls.Add(this.label10);
            this.panelAdresse.Controls.Add(this.label9);
            this.panelAdresse.Controls.Add(this.label8);
            this.panelAdresse.Controls.Add(this.label7);
            this.panelAdresse.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAdresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(38)))), ((int)(((byte)(66)))));
            this.panelAdresse.Location = new System.Drawing.Point(84, 0);
            this.panelAdresse.Name = "panelAdresse";
            this.panelAdresse.Size = new System.Drawing.Size(322, 331);
            this.panelAdresse.TabIndex = 1;
            // 
            // cboDesignation
            // 
            this.cboDesignation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonneBindingSource, "Designation", true));
            this.cboDesignation.FormattingEnabled = true;
            this.cboDesignation.Items.AddRange(new object[] {
            "Mademoiselle",
            "Madame",
            "Monsieur"});
            this.cboDesignation.Location = new System.Drawing.Point(127, 45);
            this.cboDesignation.Name = "cboDesignation";
            this.cboDesignation.Size = new System.Drawing.Size(164, 24);
            this.cboDesignation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Désignation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Téléphone :";
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonneBindingSource, "Telephone", true));
            this.txtPhone.Location = new System.Drawing.Point(127, 95);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(98, 21);
            this.txtPhone.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carte ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Type Carte :";
            // 
            // txtCarteID
            // 
            this.txtCarteID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonneBindingSource, "CarteID", true));
            this.txtCarteID.Location = new System.Drawing.Point(127, 138);
            this.txtCarteID.Name = "txtCarteID";
            this.txtCarteID.Size = new System.Drawing.Size(142, 21);
            this.txtCarteID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Prénom :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonneBindingSource, "Prenom", true));
            this.txtPrenom.Location = new System.Drawing.Point(127, 215);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(114, 21);
            this.txtPrenom.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(127, 252);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(114, 21);
            this.txtNom.TabIndex = 5;
            // 
            // cboType
            // 
            this.cboType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonneBindingSource, "TypeCarte", true));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Carte d\'électeur",
            "Carte d\'élève",
            "Carte d\'étudiant",
            "Permis de conduire",
            "Carte de service",
            "Passeport"});
            this.cboType.Location = new System.Drawing.Point(127, 175);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(142, 24);
            this.cboType.TabIndex = 3;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuivant.Location = new System.Drawing.Point(215, 282);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(67, 32);
            this.btnSuivant.TabIndex = 6;
            this.btnSuivant.Text = "&Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "N° :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Avenue :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Quartier :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Commune :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Ville :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Nationalité :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "Date naissance :";
            // 
            // txtNum
            // 
            this.txtNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonneBindingSource, "NumMaison", true));
            this.txtNum.Location = new System.Drawing.Point(56, 16);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(59, 21);
            this.txtNum.TabIndex = 0;
            // 
            // txtAvenue
            // 
            this.txtAvenue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonneBindingSource, "Avenue", true));
            this.txtAvenue.Location = new System.Drawing.Point(184, 16);
            this.txtAvenue.Name = "txtAvenue";
            this.txtAvenue.Size = new System.Drawing.Size(110, 21);
            this.txtAvenue.TabIndex = 1;
            // 
            // txtQuartier
            // 
            this.txtQuartier.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonneBindingSource, "Quartier", true));
            this.txtQuartier.Location = new System.Drawing.Point(125, 54);
            this.txtQuartier.Name = "txtQuartier";
            this.txtQuartier.Size = new System.Drawing.Size(164, 21);
            this.txtQuartier.TabIndex = 2;
            // 
            // txtCommune
            // 
            this.txtCommune.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonneBindingSource, "Commune", true));
            this.txtCommune.Location = new System.Drawing.Point(126, 94);
            this.txtCommune.Name = "txtCommune";
            this.txtCommune.Size = new System.Drawing.Size(114, 21);
            this.txtCommune.TabIndex = 3;
            // 
            // txtVille
            // 
            this.txtVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonneBindingSource, "Ville", true));
            this.txtVille.Location = new System.Drawing.Point(126, 129);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(114, 21);
            this.txtVille.TabIndex = 4;
            // 
            // txtNationalite
            // 
            this.txtNationalite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonneBindingSource, "Nationalite", true));
            this.txtNationalite.Location = new System.Drawing.Point(126, 169);
            this.txtNationalite.Name = "txtNationalite";
            this.txtNationalite.Size = new System.Drawing.Size(124, 21);
            this.txtNationalite.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonneBindingSource, "Datenaissance", true));
            this.txtDate.Location = new System.Drawing.Point(126, 210);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(102, 21);
            this.txtDate.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Lieu naissance :";
            // 
            // txtLieu
            // 
            this.txtLieu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonneBindingSource, "LieuNaissance", true));
            this.txtLieu.Location = new System.Drawing.Point(126, 249);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(124, 21);
            this.txtLieu.TabIndex = 7;
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrecedent.Location = new System.Drawing.Point(84, 284);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(58, 30);
            this.btnPrecedent.TabIndex = 8;
            this.btnPrecedent.Text = "<<";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.Location = new System.Drawing.Point(148, 284);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(58, 30);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnregistrer.Location = new System.Drawing.Point(212, 284);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(58, 30);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "&Save";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNouveau.FlatAppearance.BorderSize = 0;
            this.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouveau.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(38)))), ((int)(((byte)(66)))));
            this.btnNouveau.Location = new System.Drawing.Point(7, 127);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(71, 39);
            this.btnNouveau.TabIndex = 0;
            this.btnNouveau.Text = "&Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // abonneBindingSource
            // 
            this.abonneBindingSource.DataSource = typeof(SavingStepByStep.Abonne);
            // 
            // frmEnregistrementAbonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 333);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelAdresse);
            this.MaximizeBox = false;
            this.Name = "frmEnregistrementAbonne";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enregistrement d\'abonné";
            this.Load += new System.EventHandler(this.frmEnregistrementAbonne_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelIdentite.ResumeLayout(false);
            this.panelIdentite.PerformLayout();
            this.panelAdresse.ResumeLayout(false);
            this.panelAdresse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelIdentite;
        private System.Windows.Forms.Panel panelAdresse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDesignation;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtCarteID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtNationalite;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCommune;
        private System.Windows.Forms.TextBox txtQuartier;
        private System.Windows.Forms.TextBox txtAvenue;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.BindingSource abonneBindingSource;
    }
}

