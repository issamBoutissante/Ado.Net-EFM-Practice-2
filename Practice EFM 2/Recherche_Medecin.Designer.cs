
namespace Practice_EFM_2
{
    partial class Recherche_Medecin
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
            this.ListCriteres = new System.Windows.Forms.ComboBox();
            this.RecherchTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hopitalDataSet = new Practice_EFM_2.HopitalDataSet();
            this.medecinRechercheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinRechercheTableAdapter = new Practice_EFM_2.HopitalDataSetTableAdapters.medecinRechercheTableAdapter();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSpecialiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinRechercheBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListCriteres
            // 
            this.ListCriteres.FormattingEnabled = true;
            this.ListCriteres.Items.AddRange(new object[] {
            "cin",
            "nom",
            "idSpecialite"});
            this.ListCriteres.Location = new System.Drawing.Point(255, 76);
            this.ListCriteres.Name = "ListCriteres";
            this.ListCriteres.Size = new System.Drawing.Size(121, 21);
            this.ListCriteres.TabIndex = 0;
            // 
            // RecherchTxt
            // 
            this.RecherchTxt.Location = new System.Drawing.Point(418, 77);
            this.RecherchTxt.Name = "RecherchTxt";
            this.RecherchTxt.Size = new System.Drawing.Size(100, 20);
            this.RecherchTxt.TabIndex = 1;
            this.RecherchTxt.TextChanged += new System.EventHandler(this.RecherchTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recherche par";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedecinDataGridViewTextBoxColumn,
            this.cinDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.idSpecialiteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medecinRechercheBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(86, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 195);
            this.dataGridView1.TabIndex = 3;
            // 
            // hopitalDataSet
            // 
            this.hopitalDataSet.DataSetName = "HopitalDataSet";
            this.hopitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medecinRechercheBindingSource
            // 
            this.medecinRechercheBindingSource.DataMember = "medecinRecherche";
            this.medecinRechercheBindingSource.DataSource = this.hopitalDataSet;
            // 
            // medecinRechercheTableAdapter
            // 
            this.medecinRechercheTableAdapter.ClearBeforeFill = true;
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
            this.idSpecialiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Recherche_Medecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecherchTxt);
            this.Controls.Add(this.ListCriteres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recherche_Medecin";
            this.Text = "Recherche_Medecin";
            this.Load += new System.EventHandler(this.Recherche_Medecin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinRechercheBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListCriteres;
        private System.Windows.Forms.TextBox RecherchTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HopitalDataSet hopitalDataSet;
        private System.Windows.Forms.BindingSource medecinRechercheBindingSource;
        private HopitalDataSetTableAdapters.medecinRechercheTableAdapter medecinRechercheTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSpecialiteDataGridViewTextBoxColumn;
    }
}