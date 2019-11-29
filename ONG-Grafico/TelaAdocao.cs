using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class TelaAdocao : Form
    {
        private Adoption Adocao { get; set; }
        public AdoptionService adoptionService { get; set; }
        public AnimalService animalService { get; set; }
        public AdopterService adopterService { get; set; }

        public TelaAdocao()
        {
            InitializeComponent();
            ConfigurarCombobox();
            adoptionService = new AdoptionService();
            animalService = new AnimalService();
            adopterService = new AdopterService();
        }

        private void ConfigurarCombobox()
        {
            cbAnimal.DisplayMember = "Nome";
            cbAnimal.ValueMember = "Id";

            cbAdotante.DisplayMember = "Nome";
            cbAdotante.ValueMember = "Id";
        }

        private void CarregarComboboxAnimal()
        {
            List<Animal> animais = animalService.GetAll();
            cbAnimal.DataSource = animais;
        }

        private void CarregarComboboxAdotante()
        {
            List<Adopter> adotantes = adopterService.GetAll();
            cbAdotante.DataSource = adotantes;
        }

        private void Adocao_Load(object sender, EventArgs e)
        {
            CarregarComboboxAnimal();
            CarregarComboboxAdotante();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Adoption adocao = new Adoption();

                Int64 animalId = (Int64)cbAnimal.SelectedValue;
                adocao.Animal = animalService.GetById(animalId);

                int adotanteId = (int)cbAdotante.SelectedValue;
                adocao.Adopter = adopterService.GetById(adotanteId);

                DateTime data;

                var x = DateTime.TryParse(tbData.Text, out data);

                if (x == false)
                {
                    throw new Exception("Data invalida");
                }

                adocao.Date = data;

                adoptionService.Insert(adocao);

                MessageBox.Show("Adoção cadastrada com sucesso!");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
