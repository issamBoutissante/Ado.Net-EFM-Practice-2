using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Practice_EFM_2
{
    public partial class Getion_Etats : Form
    {
        public Getion_Etats()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperationEffectueCrystalReport Report = new OperationEffectueCrystalReport();
            Report.SetParameterValue("FirstDate", FirstDate.Text);
            Report.SetParameterValue("LastDate", LastDate.Text);
            DataSet ds = new DataSet();
            new SqlDataAdapter($"select * from ligneMedecinOperation where dateOperation between " +
                $"'{FirstDate.Text}' and '{LastDate.Text}'",new SqlConnection(Global.ConnectionString))
                .Fill(ds, "LigneOperation");
            Report.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = Report;
        }
    }
}
