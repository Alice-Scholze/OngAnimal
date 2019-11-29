using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class CadastroAnimal : Form
    {
        public long AnimalId { get; set; }
        private Animal Animal { get; set; }

        private AnimalService animalService { get; set; }
        public RaceService raceService { get; set; }

        public CadastroAnimal()
        {
            InitializeComponent();
            ConfigurarCombobox();
            animalService = new AnimalService();
            raceService = new RaceService();
        }

        private void ConfigurarCombobox()
        {
            cbRaca.DisplayMember = "Nome";
            cbRaca.ValueMember = "Id";
        }

        private void CarregarCombobox()
        {
            List<Race> racas = raceService.GetAll();
            cbRaca.DataSource = racas;
        }

        private void LimparCampos()
        {
            tbNome.Text = "";
            tbEntrada.Text = "";
            tbSaida.Text = "";
            tbObservacao.Text = "";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Animal.Name = tbNome.Text;
                // combobox
                long racaCod = (long)cbRaca.SelectedValue;
                Animal.Race = raceService.GetById(racaCod);
                //fim
                //entrada da data
                DateTime data;
                var x = DateTime.TryParse(tbEntrada.Text, out data);
                if (x == false)
                {
                    throw new Exception("Data invalida");
                } 
                Animal.DateEntry = data;
                //fim entrada da data
                //******Verificar data de saída, deixar como nulo
                string saida = tbSaida.Text;
                if (saida != null)
                {
                    Animal.DateDeparture = Convert.ToDateTime(saida);
                }
                Animal.Note = tbObservacao.Text;
                // groupbox 
                if (rbFemea.Checked)
                {
                    Animal.Gender = "Femea";
                }
                else
                {
                    Animal.Gender = "Macho";
                } 
                //fim
                if (AnimalId == 0)
                {
                    animalService.Insert(Animal);
                    MessageBox.Show("Animal adicionado com sucesso!");
                }
                else
                {
                    Animal.Id = AnimalId;
                    animalService.Update(Animal);
                    MessageBox.Show("Animal alterado com sucesso!");
                }
                LimparCampos();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CadastroAnimal_Load(object sender, EventArgs e)
        {
            CarregarCombobox();

            if (AnimalId == 0)
            {
                Animal = new Animal();
            }
            else
            {
                Animal = animalService.GetById(AnimalId);
                tbCodigo.Text = Animal.Id.ToString();
                tbNome.Text = Animal.Name;
                cbRaca.Text = Convert.ToString(Animal.Race);
                tbEntrada.Text = Convert.ToString(Animal.DateEntry);
                tbSaida.Text = Convert.ToString(Animal.DateDeparture);
                if (Animal.Gender == "Femea")
                {
                    rbFemea.Checked =  Animal.Gender == "Femea";
                }
                else
                {
                   rbMacho.Checked = Animal.Gender == "Macho";
                }
                tbObservacao.Text = Animal.Note;

            }
        }

		
	}
}
