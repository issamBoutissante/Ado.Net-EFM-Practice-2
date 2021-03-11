using System;
using System.Windows.Forms;

namespace Practice_EFM_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            ouvreForm(new Gestion_Medecin());
        }

        private void medecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ouvreForm(new Gestion_Medecin());
        }
        void ouvreForm(Form form)
        {
            if (this.ActiveMdiChild != null) ActiveMdiChild.Close();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ouvreForm(new Recherche_Medecin());
        }

        private void ligneOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ouvreForm(new Gestion_Operation());
        }
    }
}
