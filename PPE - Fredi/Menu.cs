using PPE_Fredi.Deplacements;
using PPE_Fredi.Licencies;
using PPE_Fredi.Deplacement;
using PPE_Fredi.NoteDeFrais;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_Fredi
{
    public partial class Menu : Form
    {
        private int childFormNumber = 0;
        private AjouterLicencies childFormLicencies;
        private SuppressionLicencies childFormSupprLicencies;
        private ModifierLicencies childFormModifLicencies;
        private AfficherLicencies childFormAffLicencies;
        private AjouterDeplacement childFormDeplacement;
        private SuppressionDeplacement childFormSupprDeplacement;
        private ModifierDeplacement childFormModifDeplacement;
        private AfficherDeplacement childFormAffDeplacement;
        private EditerLesJustificatifs childFormEditerLesJustificatifs;
        private GestionDesRemboursements childFormGestionDesRemboursements;
        private Parametres childFormParametre;
        private Form laFeuilleOUverte;

        public Menu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void NouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                laFeuilleOUverte.Close();
            }
            catch
            {

            }
            AjouterLicencies childFormLicencies = new AjouterLicencies();
            childFormLicencies.MdiParent = this;
            childFormLicencies.WindowState = FormWindowState.Maximized;
            childFormLicencies.Show();
            laFeuilleOUverte = childFormLicencies;
        }

        private void NouveauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                laFeuilleOUverte.Close();
            }
            catch
            {

            }
            AjouterDeplacement childFormDeplacement = new AjouterDeplacement();
            childFormDeplacement.MdiParent = this;
            childFormDeplacement.WindowState = FormWindowState.Maximized;
            childFormDeplacement.Show();
            laFeuilleOUverte = childFormDeplacement;
        }


        private void ParamètreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                laFeuilleOUverte.Close();
            }
            catch
            {

            }
            Parametres childFormParametres = new Parametres();     
            childFormParametres.MdiParent = this;
            childFormParametres.WindowState = FormWindowState.Maximized;
            childFormParametres.Show();
            laFeuilleOUverte = childFormParametres;
        }

        private void SupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                laFeuilleOUverte.Close();
            }
            catch
            {

            }
            SuppressionLicencies childFormSupprLicencies = new SuppressionLicencies();
            childFormSupprLicencies.MdiParent = this;
            childFormSupprLicencies.WindowState = FormWindowState.Maximized;
            childFormSupprLicencies.Show();
            laFeuilleOUverte = childFormSupprLicencies;
        }

        private void SupprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                laFeuilleOUverte.Close();
            }
            catch
            {

            }
            SuppressionDeplacement childFormDeplacement = new SuppressionDeplacement();
            childFormDeplacement.MdiParent = this;
            childFormDeplacement.WindowState = FormWindowState.Maximized;
            childFormDeplacement.Show();
            laFeuilleOUverte = childFormDeplacement;
        }

        private void ModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                laFeuilleOUverte.Close();
            }
            catch
            {

            }
            ModifierLicencies childFormModifLicencies = new ModifierLicencies();
            childFormModifLicencies.MdiParent = this;
            childFormModifLicencies.WindowState = FormWindowState.Maximized;
            childFormModifLicencies.Show();
            laFeuilleOUverte = childFormModifLicencies;
        }

        private void AfficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                laFeuilleOUverte.Close();
            }
            catch
            {

            }
            AfficherLicencies childFormAffLicencies = new AfficherLicencies();
            childFormAffLicencies.MdiParent = this;
            childFormAffLicencies.WindowState = FormWindowState.Maximized;
            childFormAffLicencies.Show();
            laFeuilleOUverte = childFormAffLicencies;
        }

        private void ModifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                laFeuilleOUverte.Close();
            }
            catch
            {

            }
            ModifierDeplacement childFormModifDeplacement = new ModifierDeplacement();
            childFormModifDeplacement.MdiParent = this;
            childFormModifDeplacement.WindowState = FormWindowState.Maximized;
            childFormModifDeplacement.Show();
            laFeuilleOUverte = childFormModifDeplacement;
        }

        private void AfficherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                laFeuilleOUverte.Close();
            }
            catch
            {

            }
            AfficherDeplacement childFormAffDeplacement = new AfficherDeplacement();
            childFormAffDeplacement.MdiParent = this;
            childFormAffDeplacement.WindowState = FormWindowState.Maximized;
            childFormAffDeplacement.Show();
            laFeuilleOUverte = childFormAffDeplacement;
        }

        private void GestionDesRemboursementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                laFeuilleOUverte.Close();
            }
            catch
            {

            }
            GestionDesRemboursements childFormGestionDesRemboursements = new GestionDesRemboursements();
            childFormGestionDesRemboursements.MdiParent = this;
            childFormGestionDesRemboursements.WindowState = FormWindowState.Maximized;
            childFormGestionDesRemboursements.Show();
            laFeuilleOUverte = childFormGestionDesRemboursements;
        }

        private void EditerLesJustificatifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                laFeuilleOUverte.Close();
            }
            catch
            {

            }
            EditerLesJustificatifs childFormediterLesJustificatifs = new EditerLesJustificatifs();
            childFormediterLesJustificatifs.MdiParent = this;
            childFormediterLesJustificatifs.WindowState = FormWindowState.Maximized;
            childFormediterLesJustificatifs.Show();
            laFeuilleOUverte = childFormediterLesJustificatifs;
        }
    }
}
