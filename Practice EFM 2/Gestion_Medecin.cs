using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Practice_EFM_2
{
    public partial class Gestion_Medecin : Form
    {
        public Gestion_Medecin()
        {
            InitializeComponent();
        }
        private void Gestion_Medecin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hopitalDataSet.specialite' table. You can move, or remove it, as needed.
            this.specialiteTableAdapter.Fill(this.hopitalDataSet.specialite);
            // TODO: This line of code loads data into the 'hopitalDataSet.medecin' table. You can move, or remove it, as needed.
            this.medecinTableAdapter.Fill(this.hopitalDataSet.medecin);

        }


        private void Nouveau_Click(object sender, EventArgs e)
        {
            this.medecinBindingSource.AddNew();
        }
        
        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;
            try
            {
                this.medecinBindingSource.EndEdit();
                this.medecinTableAdapter.Update(this.hopitalDataSet.medecin);
                MedecindataGridView.Refresh();
                MessageBox.Show("l'ajout a ete effectue","Termime");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;
            DialogResult result = MessageBox.Show("tu sur que tu veux Modifier", "supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            try
            {
                this.medecinBindingSource.EndEdit();
                this.medecinTableAdapter.Update(this.hopitalDataSet.medecin);
                MedecindataGridView.Refresh();
                MessageBox.Show("la modification a ete effectue","Termine");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("tu sur que tu veux supprimer","supprimer",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            try
            {
                this.medecinBindingSource.RemoveAt(this.medecinBindingSource.Position);
                this.medecinTableAdapter.Update(this.hopitalDataSet.medecin);
                MessageBox.Show("la supprission a ete effectue", "Termine");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool Valider()
        {
            foreach (TextBox c in this.Controls)
                if (string.IsNullOrEmpty(c.Text))
                {
                    MessageBox.Show("il faut remplir les champs", "Error");
                    return false;
                }
            if (string.IsNullOrEmpty(Specialete.SelectedValue.ToString()))
                return false;
            return true;
        }

    }
}
