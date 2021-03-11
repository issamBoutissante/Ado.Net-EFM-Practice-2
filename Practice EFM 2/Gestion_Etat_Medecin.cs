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
    public partial class Gestion_Etat_Medecin : Form
    {
        public Gestion_Etat_Medecin()
        {
            InitializeComponent();
        }

        private void Gestion_Etat_Medecin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hopitalDataSet.medecin' table. You can move, or remove it, as needed.
            this.medecinTableAdapter.Fill(this.hopitalDataSet.medecin);

        }

        private void Imprimer_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Global.ConnectionString);
            DataSet dataSet = new DataSet();
            new SqlDataAdapter($"select * from ligneMedecinOperation l join medecin m on l.idMedecin = m.idMedecin " +
                $"where l.idMedecin = {MedicinCombo.SelectedValue}",connection)
                .Fill(dataSet,"operationParMedecin");

            OperationEffectueParMedecinCrystalReport report = new OperationEffectueParMedecinCrystalReport();
            report.SetDataSource(dataSet.Tables[0]);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
