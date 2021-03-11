using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_EFM_2
{
    public partial class Gestion_Operation : Form
    {
        public Gestion_Operation()
        {
            InitializeComponent();
        }

        private void Gestion_Operation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hopitalDataSet.specialite' table. You can move, or remove it, as needed.
            this.specialiteTableAdapter.Fill(this.hopitalDataSet.specialite);
            // TODO: This line of code loads data into the 'hopitalDataSet.ligneMedecinOperation' table. You can move, or remove it, as needed.
            this.ligneMedecinOperationTableAdapter.Fill(this.hopitalDataSet.ligneMedecinOperation);
            // TODO: This line of code loads data into the 'hopitalDataSet.operation' table. You can move, or remove it, as needed.
            this.operationTableAdapter.Fill(this.hopitalDataSet.operation);
            // TODO: This line of code loads data into the 'hopitalDataSet.medecin' table. You can move, or remove it, as needed.
            this.medecinTableAdapter.Fill(this.hopitalDataSet.medecin);

        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            this.operationBindingSource.AddNew();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                this.operationBindingSource.EndEdit();
                this.operationTableAdapter.Update(this.hopitalDataSet.operation);
                MessageBox.Show("L'operation a ete ajoute","termine");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void Affecter_Click(object sender, EventArgs e)
        {
            try
            {
                this.ligneMedecinOperationBindingSource.EndEdit();
                this.ligneMedecinOperationTableAdapter.Update(this.hopitalDataSet.ligneMedecinOperation);
                MessageBox.Show("L'operation a ete affecte","termine");
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void NouveauLigne_Click(object sender, EventArgs e)
        {
            this.ligneMedecinOperationBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Global.ConnectionString);
            SqlCommand command = new SqlCommand("spGetNombreOperation", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@date", dateSpecifier.Text);
            command.Parameters.AddWithValue("@idSpecialite", specialite.SelectedValue);
            try
            {
                connection.Open();
                int nombre=(int)command.ExecuteScalar();
                nombreDoperation.Text = nombre.ToString();
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
