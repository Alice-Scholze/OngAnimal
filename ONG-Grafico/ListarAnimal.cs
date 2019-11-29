using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class ListarAnimal : Form
    {
        public AnimalService animalService { get; set; }
        public ListarAnimal()
        {
            InitializeComponent();
            ConfigurarDatagrid();
            animalService = new AnimalService();
        }

        private void ConfigurarDatagrid()
        {
            dgAnimal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAnimal.AutoGenerateColumns = true;
            //dgAnimal.ColumnCount = 7;
            //dgAnimal.ColumnHeadersVisible = true;
            //dgAnimal.Columns[0].Name = "Código";
            //dgAnimal.Columns[0].DataPropertyName = "Id";
            //dgAnimal.Columns[1].Name = "Nome";
            //dgAnimal.Columns[1].DataPropertyName = "Nome";
            //dgAnimal.Columns[2].Name = "Raça";
            //dgAnimal.Columns[2].DataPropertyName = "Raca";
            //dgAnimal.Columns[3].Name = "Data Entrada";
            //dgAnimal.Columns[3].DataPropertyName = "DataEntrada";
            //dgAnimal.Columns[4].Name = "Data Saída";
            //dgAnimal.Columns[4].DataPropertyName = "DataSaida";
            //dgAnimal.Columns[5].Name = "Sexo";
            //dgAnimal.Columns[5].DataPropertyName = "Sexo";
            //dgAnimal.Columns[6].Name = "Observacao";
            //dgAnimal.Columns[6].DataPropertyName = "Observacao";
            dgAnimal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarDados()
        {
            List<Animal> animais = animalService.GetAll();
            dgAnimal.DataSource = animais;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            CadastroAnimal tela = new CadastroAnimal();
            tela.FormClosed += Tela_FormClosed;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void ListarAnimal_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (dgAnimal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um animal");
                return;
            }

            long animalId = (long)dgAnimal.SelectedRows[0].Cells[0].Value;
            CadastroAnimal tela = new CadastroAnimal();
            tela.FormClosed += Tela_FormClosed;
            tela.AnimalId = animalId;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgAnimal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um animal");
                return;
            }

            try
            {
                long animalId = (long)dgAnimal.SelectedRows[0].Cells[0].Value;
                var resultado = MessageBox.Show("Tem certeza que deseja excluir o animal?", "Apagar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    animalService.Delete(animalId);
                    CarregarDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
