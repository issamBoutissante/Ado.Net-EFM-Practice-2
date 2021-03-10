
namespace Practice_EFM_2
{
    partial class Gestion_Medecin
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
            this.MedecindataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.idMedecin = new System.Windows.Forms.ComboBox();
            this.Specialete = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nouveau = new System.Windows.Forms.Button();
            this.hopitalDataSet = new Practice_EFM_2.HopitalDataSet();
            this.medecinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinTableAdapter = new Practice_EFM_2.HopitalDataSetTableAdapters.medecinTableAdapter();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSpecialiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialiteTableAdapter = new Practice_EFM_2.HopitalDataSetTableAdapters.specialiteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MedecindataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialiteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MedecindataGridView
            // 
            this.MedecindataGridView.AutoGenerateColumns = false;
            this.MedecindataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedecindataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedecinDataGridViewTextBoxColumn,
            this.cinDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.idSpecialiteDataGridViewTextBoxColumn});
            this.MedecindataGridView.DataSource = this.medecinBindingSource;
            this.MedecindataGridView.Location = new System.Drawing.Point(83, 215);
            this.MedecindataGridView.Name = "MedecindataGridView";
            this.MedecindataGridView.Size = new System.Drawing.Size(645, 223);
            this.MedecindataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // Nom
            // 
            this.Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinBindingSource, "nom", true));
            this.Nom.Location = new System.Drawing.Point(166, 39);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(100, 20);
            this.Nom.TabIndex = 2;
            this.Nom.Tag = "nom";
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(24, 50);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 3;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "specialite";
            // 
            // Telephone
            // 
            this.Telephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinBindingSource, "telephone", true));
            this.Telephone.Location = new System.Drawing.Point(166, 148);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(100, 20);
            this.Telephone.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telephone";
            // 
            // Cin
            // 
            this.Cin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinBindingSource, "cin", true));
            this.Cin.Location = new System.Drawing.Point(166, 113);
            this.Cin.Name = "Cin";
            this.Cin.Size = new System.Drawing.Size(100, 20);
            this.Cin.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cin";
            // 
            // Prenom
            // 
            this.Prenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinBindingSource, "prenom", true));
            this.Prenom.Location = new System.Drawing.Point(166, 78);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(100, 20);
            this.Prenom.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prenom";
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(598, 132);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Supprimer.TabIndex = 12;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(598, 89);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 23);
            this.Modifier.TabIndex = 13;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // idMedecin
            // 
            this.idMedecin.DataSource = this.medecinBindingSource;
            this.idMedecin.DisplayMember = "nom";
            this.idMedecin.FormattingEnabled = true;
            this.idMedecin.Location = new System.Drawing.Point(453, 112);
            this.idMedecin.Name = "idMedecin";
            this.idMedecin.Size = new System.Drawing.Size(97, 21);
            this.idMedecin.TabIndex = 14;
            this.idMedecin.ValueMember = "idMedecin";
            // 
            // Specialete
            // 
            this.Specialete.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medecinBindingSource, "idSpecialite", true));
            this.Specialete.DataSource = this.specialiteBindingSource;
            this.Specialete.DisplayMember = "libelle";
            this.Specialete.FormattingEnabled = true;
            this.Specialete.Location = new System.Drawing.Point(166, 186);
            this.Specialete.Name = "Specialete";
            this.Specialete.Size = new System.Drawing.Size(100, 21);
            this.Specialete.TabIndex = 15;
            this.Specialete.ValueMember = "idSpecialite";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nouveau);
            this.groupBox1.Controls.Add(this.Ajouter);
            this.groupBox1.Location = new System.Drawing.Point(314, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 87);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter medecin";
            // 
            // Nouveau
            // 
            this.Nouveau.Location = new System.Drawing.Point(24, 21);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(75, 23);
            this.Nouveau.TabIndex = 4;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = true;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // hopitalDataSet
            // 
            this.hopitalDataSet.DataSetName = "HopitalDataSet";
            this.hopitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medecinBindingSource
            // 
            this.medecinBindingSource.DataMember = "medecin";
            this.medecinBindingSource.DataSource = this.hopitalDataSet;
            // 
            // medecinTableAdapter
            // 
            this.medecinTableAdapter.ClearBeforeFill = true;
            // 
            // idMedecinDataGridViewTextBoxColumn
            // 
            this.idMedecinDataGridViewTextBoxColumn.DataPropertyName = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.HeaderText = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.Name = "idMedecinDataGridViewTextBoxColumn";
            this.idMedecinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cinDataGridViewTextBoxColumn
            // 
            this.cinDataGridViewTextBoxColumn.DataPropertyName = "cin";
            this.cinDataGridViewTextBoxColumn.HeaderText = "cin";
            this.cinDataGridViewTextBoxColumn.Name = "cinDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // idSpecialiteDataGridViewTextBoxColumn
            // 
            this.idSpecialiteDataGridViewTextBoxColumn.DataPropertyName = "idSpecialite";
            this.idSpecialiteDataGridViewTextBoxColumn.HeaderText = "idSpecialite";
            this.idSpecialiteDataGridViewTextBoxColumn.Name = "idSpecialiteDataGridViewTextBoxColumn";
            // 
            // specialiteBindingSource
            // 
            this.specialiteBindingSource.DataMember = "specialite";
            this.specialiteBindingSource.DataSource = this.hopitalDataSet;
            // 
            // specialiteTableAdapter
            // 
            this.specialiteTableAdapter.ClearBeforeFill = true;
            // 
            // Gestion_Medecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Specialete);
            this.Controls.Add(this.idMedecin);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedecindataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Medecin";
            this.Text = "Gestion_Medecin";
            this.Load += new System.EventHandler(this.Gestion_Medecin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedecindataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hopitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialiteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MedecindataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Telephone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.ComboBox idMedecin;
        private System.Windows.Forms.ComboBox Specialete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Nouveau;
        private HopitalDataSet hopitalDataSet;
        private System.Windows.Forms.BindingSource medecinBindingSource;
        private HopitalDataSetTableAdapters.medecinTableAdapter medecinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSpecialiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource specialiteBindingSource;
        private HopitalDataSetTableAdapters.specialiteTableAdapter specialiteTableAdapter;
    }
}