using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_EFM_2
{
    public partial class Recherche_Medecin : Form
    {
        public Recherche_Medecin()
        {
            InitializeComponent();
        }

        private void Recherche_Medecin_Load(object sender, EventArgs e)
        {
            this.medecinRechercheTableAdapter.Fill(this.hopitalDataSet.medecinRecherche);
        }

        private void RecherchTxt_TextChanged(object sender, EventArgs e)
        {
            this.medecinRechercheBindingSource.Filter = $"subString({ListCriteres.Text},1,{RecherchTxt.Text.Length})='{RecherchTxt.Text}'";
        }
    }
}
