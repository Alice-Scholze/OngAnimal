using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class TelaInicial : Form
    {
        private int childFormNumber = 0;

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
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

        /*private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }*/

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

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarAnimal tela = new ListarAnimal();
            tela.MdiParent = this;
            tela.Show();
        }

        private void voluntarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarVoluntario tela = new ListarVoluntario();
            tela.MdiParent = this;
            tela.Show();
        }

        private void adotanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarAdotante tela = new ListarAdotante();
            tela.MdiParent = this;
            tela.Show();
        }

        private void doadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarDoador tela = new ListarDoador();
            tela.MdiParent = this;
            tela.Show();
        }

        private void raçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarRaca tela = new ListarRaca();
            tela.MdiParent = this;
            tela.Show();
        }

        private void funçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarFuncao tela = new ListarFuncao();
            tela.MdiParent = this;
            tela.Show();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarCidade tela = new ListarCidade();
            tela.MdiParent = this;
            tela.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarProduto tela = new ListarProduto();
            tela.MdiParent = this;
            tela.Show();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCompra tela = new TelaCompra();
            tela.MdiParent = this;
            tela.Show();
        }

        private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarDoacao tela = new ListarDoacao();
            tela.MdiParent = this;
            tela.Show();
        }

        private void adoçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarAdocao tela = new ListarAdocao();
            tela.MdiParent = this;
            tela.Show();
        }

        private void procedimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarProcedimento tela = new ListarProcedimento();
            tela.MdiParent = this;
            tela.Show();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCaixa tela = new TelaCaixa();
            tela.MdiParent = this;
            tela.Show();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarServico tela = new ListarServico();
            tela.MdiParent = this;
            tela.Show();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
