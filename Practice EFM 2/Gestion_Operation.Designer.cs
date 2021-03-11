
namespace Practice_EFM_2
{
    partial class Gestion_Operation
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
            this.label1 = new System.Windows.Forms.Label();
            this.CodeOperation = new System.Windows.Forms.TextBox();
            this.CinMedecin = new System.Windows.Forms.ComboBox();
            this.Libelle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.operationLibelle = new System.Windows.Forms.ComboBox();
            this.Nouveau = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Affecter = new System.Windows.Forms.Button();
            this.prixOperation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.durreOperation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateOperation = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.hopitalDataSet = new Practice_EFM_2.HopitalDataSet();
            this.medecinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinTableAdapter = new Practice_EFM_2.HopitalDataSetTableAdapters.medecinTableAdapter();
            this.operationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationTableAdapter = new Practice_EFM_2.HopitalDataSetTableAdapters.operationTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ligneMedecinOperationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligneMedecinOperationTableAdapter = new Practice_EFM_2.HopitalDataSetTableAdapters.ligneMedecinOperationTableAdapter();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOperationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOperationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idOperationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NouveauLigne = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateSpecifier = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.specialite = new System.Windows.Forms.ComboBox();
            this.specialiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialiteTableAdapter = new Practice_EFM_2.HopitalDataSetTableAdapters.specialiteTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreDoperation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hopitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneMedecinOperationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialiteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // CodeOperation
            // 
            this.CodeOperation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationBindingSource, "code", true));
            this.CodeOperation.Location = new System.Drawing.Point(104, 163);
            this.CodeOperation.Name = "CodeOperation";
            this.CodeOperation.Size = new System.Drawing.Size(100, 20);
            this.CodeOperation.TabIndex = 1;
            // 
            // CinMedecin
            // 
            this.CinMedecin.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ligneMedecinOperationBindingSource, "idMedecin", true));
            this.CinMedecin.DataSource = this.medecinBindingSource;
            this.CinMedecin.DisplayMember = "cin";
            this.CinMedecin.FormattingEnabled = true;
            this.CinMedecin.Location = new System.Drawing.Point(525, 39);
            this.CinMedecin.Name = "CinMedecin";
            this.CinMedecin.Size = new System.Drawing.Size(121, 21);
            this.CinMedecin.TabIndex = 2;
            this.CinMedecin.ValueMember = "idMedecin";
            // 
            // Libelle
            // 
            this.Libelle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationBindingSource, "libelle", true));
            this.Libelle.Location = new System.Drawing.Point(104, 215);
            this.Libelle.Name = "Libelle";
            this.Libelle.Size = new System.Drawing.Size(100, 20);
            this.Libelle.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Libelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Operation";
            // 
            // operationLibelle
            // 
            this.operationLibelle.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ligneMedecinOperationBindingSource, "idOperation", true));
            this.operationLibelle.DataSource = this.operationBindingSource;
            this.operationLibelle.DisplayMember = "libelle";
            this.operationLibelle.FormattingEnabled = true;
            this.operationLibelle.Location = new System.Drawing.Point(525, 98);
            this.operationLibelle.Name = "operationLibelle";
            this.operationLibelle.Size = new System.Drawing.Size(121, 21);
            this.operationLibelle.TabIndex = 6;
            this.operationLibelle.ValueMember = "idOperation";
            // 
            // Nouveau
            // 
            this.Nouveau.Location = new System.Drawing.Point(248, 163);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(75, 23);
            this.Nouveau.TabIndex = 8;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = true;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(248, 217);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 9;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Affecter
            // 
            this.Affecter.Location = new System.Drawing.Point(675, 98);
            this.Affecter.Name = "Affecter";
            this.Affecter.Size = new System.Drawing.Size(75, 23);
            this.Affecter.TabIndex = 10;
            this.Affecter.Text = "Affecter";
            this.Affecter.UseVisualStyleBackColor = true;
            this.Affecter.Click += new System.EventHandler(this.Affecter_Click);
            // 
            // prixOperation
            // 
            this.prixOperation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ligneMedecinOperationBindingSource, "prix", true));
            this.prixOperation.Location = new System.Drawing.Point(525, 240);
            this.prixOperation.Name = "prixOperation";
            this.prixOperation.Size = new System.Drawing.Size(121, 20);
            this.prixOperation.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Prix";
            // 
            // durreOperation
            // 
            this.durreOperation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ligneMedecinOperationBindingSource, "duree", true));
            this.durreOperation.Location = new System.Drawing.Point(525, 186);
            this.durreOperation.Name = "durreOperation";
            this.durreOperation.Size = new System.Drawing.Size(121, 20);
            this.durreOperation.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Durre";
            // 
            // dateOperation
            // 
            this.dateOperation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ligneMedecinOperationBindingSource, "dateOperation", true));
            this.dateOperation.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ligneMedecinOperationBindingSource, "dateOperation", true));
            this.dateOperation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOperation.Location = new System.Drawing.Point(525, 140);
            this.dateOperation.Name = "dateOperation";
            this.dateOperation.Size = new System.Drawing.Size(121, 20);
            this.dateOperation.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date d\'operation";
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
            // operationBindingSource
            // 
            this.operationBindingSource.DataMember = "operation";
            this.operationBindingSource.DataSource = this.hopitalDataSet;
            // 
            // operationTableAdapter
            // 
            this.operationTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedecinDataGridViewTextBoxColumn,
            this.idOperationDataGridViewTextBoxColumn,
            this.dateOperationDataGridViewTextBoxColumn,
            this.dureeDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ligneMedecinOperationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(389, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(399, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // ligneMedecinOperationBindingSource
            // 
            this.ligneMedecinOperationBindingSource.DataMember = "ligneMedecinOperation";
            this.ligneMedecinOperationBindingSource.DataSource = this.hopitalDataSet;
            // 
            // ligneMedecinOperationTableAdapter
            // 
            this.ligneMedecinOperationTableAdapter.ClearBeforeFill = true;
            // 
            // idMedecinDataGridViewTextBoxColumn
            // 
            this.idMedecinDataGridViewTextBoxColumn.DataPropertyName = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.HeaderText = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.Name = "idMedecinDataGridViewTextBoxColumn";
            // 
            // idOperationDataGridViewTextBoxColumn
            // 
            this.idOperationDataGridViewTextBoxColumn.DataPropertyName = "idOperation";
            this.idOperationDataGridViewTextBoxColumn.HeaderText = "idOperation";
            this.idOperationDataGridViewTextBoxColumn.Name = "idOperationDataGridViewTextBoxColumn";
            // 
            // dateOperationDataGridViewTextBoxColumn
            // 
            this.dateOperationDataGridViewTextBoxColumn.DataPropertyName = "dateOperation";
            this.dateOperationDataGridViewTextBoxColumn.HeaderText = "dateOperation";
            this.dateOperationDataGridViewTextBoxColumn.Name = "dateOperationDataGridViewTextBoxColumn";
            // 
            // dureeDataGridViewTextBoxColumn
            // 
            this.dureeDataGridViewTextBoxColumn.DataPropertyName = "duree";
            this.dureeDataGridViewTextBoxColumn.HeaderText = "duree";
            this.dureeDataGridViewTextBoxColumn.Name = "dureeDataGridViewTextBoxColumn";
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOperationDataGridViewTextBoxColumn1,
            this.codeDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.operationBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(36, 288);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(347, 150);
            this.dataGridView2.TabIndex = 18;
            // 
            // idOperationDataGridViewTextBoxColumn1
            // 
            this.idOperationDataGridViewTextBoxColumn1.DataPropertyName = "idOperation";
            this.idOperationDataGridViewTextBoxColumn1.HeaderText = "idOperation";
            this.idOperationDataGridViewTextBoxColumn1.Name = "idOperationDataGridViewTextBoxColumn1";
            this.idOperationDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "libelle";
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            // 
            // NouveauLigne
            // 
            this.NouveauLigne.Location = new System.Drawing.Point(675, 37);
            this.NouveauLigne.Name = "NouveauLigne";
            this.NouveauLigne.Size = new System.Drawing.Size(75, 23);
            this.NouveauLigne.TabIndex = 19;
            this.NouveauLigne.Text = "Nouveau";
            this.NouveauLigne.UseVisualStyleBackColor = true;
            this.NouveauLigne.Click += new System.EventHandler(this.NouveauLigne_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Date";
            // 
            // dateSpecifier
            // 
            this.dateSpecifier.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSpecifier.Location = new System.Drawing.Point(202, 23);
            this.dateSpecifier.Name = "dateSpecifier";
            this.dateSpecifier.Size = new System.Drawing.Size(121, 20);
            this.dateSpecifier.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "specialite";
            // 
            // specialite
            // 
            this.specialite.DataSource = this.specialiteBindingSource;
            this.specialite.DisplayMember = "libelle";
            this.specialite.FormattingEnabled = true;
            this.specialite.Location = new System.Drawing.Point(202, 49);
            this.specialite.Name = "specialite";
            this.specialite.Size = new System.Drawing.Size(121, 21);
            this.specialite.TabIndex = 22;
            this.specialite.ValueMember = "idSpecialite";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Get Nombre d\'operation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreDoperation
            // 
            this.nombreDoperation.Location = new System.Drawing.Point(223, 91);
            this.nombreDoperation.Name = "nombreDoperation";
            this.nombreDoperation.Size = new System.Drawing.Size(100, 20);
            this.nombreDoperation.TabIndex = 25;
            // 
            // Gestion_Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nombreDoperation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.specialite);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateSpecifier);
            this.Controls.Add(this.NouveauLigne);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateOperation);
            this.Controls.Add(this.prixOperation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.durreOperation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Affecter);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.operationLibelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Libelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CinMedecin);
            this.Controls.Add(this.CodeOperation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Operation";
            this.Text = "Gestion_Operation";
            this.Load += new System.EventHandler(this.Gestion_Operation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hopitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneMedecinOperationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialiteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodeOperation;
        private System.Windows.Forms.ComboBox CinMedecin;
        private System.Windows.Forms.TextBox Libelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox operationLibelle;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Affecter;
        private System.Windows.Forms.TextBox prixOperation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox durreOperation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateOperation;
        private System.Windows.Forms.Label label7;
        private HopitalDataSet hopitalDataSet;
        private System.Windows.Forms.BindingSource medecinBindingSource;
        private HopitalDataSetTableAdapters.medecinTableAdapter medecinTableAdapter;
        private System.Windows.Forms.BindingSource operationBindingSource;
        private HopitalDataSetTableAdapters.operationTableAdapter operationTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ligneMedecinOperationBindingSource;
        private HopitalDataSetTableAdapters.ligneMedecinOperationTableAdapter ligneMedecinOperationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOperationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dureeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button NouveauLigne;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateSpecifier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox specialite;
        private System.Windows.Forms.BindingSource specialiteBindingSource;
        private HopitalDataSetTableAdapters.specialiteTableAdapter specialiteTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nombreDoperation;
    }
}