
namespace Practice_EFM_2
{
    partial class Gestion_Etat_Medecin
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.MedicinCombo = new System.Windows.Forms.ComboBox();
            this.hopitalDataSet = new Practice_EFM_2.HopitalDataSet();
            this.medecinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinTableAdapter = new Practice_EFM_2.HopitalDataSetTableAdapters.medecinTableAdapter();
            this.Imprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hopitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 58);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 392);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "medecin";
            // 
            // MedicinCombo
            // 
            this.MedicinCombo.DataSource = this.medecinBindingSource;
            this.MedicinCombo.DisplayMember = "nom";
            this.MedicinCombo.FormattingEnabled = true;
            this.MedicinCombo.Location = new System.Drawing.Point(97, 22);
            this.MedicinCombo.Name = "MedicinCombo";
            this.MedicinCombo.Size = new System.Drawing.Size(121, 21);
            this.MedicinCombo.TabIndex = 2;
            this.MedicinCombo.ValueMember = "idMedecin";
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
            // Imprimer
            // 
            this.Imprimer.Location = new System.Drawing.Point(238, 20);
            this.Imprimer.Name = "Imprimer";
            this.Imprimer.Size = new System.Drawing.Size(75, 23);
            this.Imprimer.TabIndex = 3;
            this.Imprimer.Text = "Imprimer";
            this.Imprimer.UseVisualStyleBackColor = true;
            this.Imprimer.Click += new System.EventHandler(this.Imprimer_Click);
            // 
            // Gestion_Etat_Medecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Imprimer);
            this.Controls.Add(this.MedicinCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Gestion_Etat_Medecin";
            this.Text = "Gestion_Etat_Medecin";
            this.Load += new System.EventHandler(this.Gestion_Etat_Medecin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hopitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MedicinCombo;
        private HopitalDataSet hopitalDataSet;
        private System.Windows.Forms.BindingSource medecinBindingSource;
        private HopitalDataSetTableAdapters.medecinTableAdapter medecinTableAdapter;
        private System.Windows.Forms.Button Imprimer;
    }
}