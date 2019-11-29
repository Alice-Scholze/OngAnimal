using ONG.Domain;
using ONG.Services;
using System;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class CadastroRaca : Form
    {
        public long RacaId { get; set; }
        private Race Raca { get; set; }
        public RaceService raceService { get; set; }

        public CadastroRaca()
        {
            InitializeComponent();
            raceService = new RaceService();
        }

		private void LimparCampos()
		{
			tbNome.Text = "";
			tbEspecie.Text = "";
			gbPorte.Text = "";
			gbClasse.Text = "";
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
				Raca.Name = tbNome.Text;
				Raca.Specie = tbEspecie.Text;
                // groupbox porte
                if (rbPequeno.Checked)
                {
                    Raca.Size = "Pequeno";
                }
                else if (rbMedio.Checked)
                {
                    Raca.Size = "Médio";
                }
                else if (rbGrande.Checked)
                {
                    Raca.Size = "Grande";
                }
                //fim
                // groupbox classe
                if (rbAnfibio.Checked)
                {
                    Raca.Class = "Anfibio";
                }
                else if (rbAracnideo.Checked)
                {
                    Raca.Class = "Aracnideo";
                }
                else if (rbAve.Checked)
                {
                    Raca.Class = "Ave";
                }
               else if (rbCrustaceo.Checked)
                {
                    Raca.Class = "Crustaceo";
                }
                 else if (rbInseto.Checked)
                {
                    Raca.Class = "Inseto";
                }
                else if (rbMamifero.Checked)
                {
                    Raca.Class = "Mamifero";
                }
                else
                {
                    Raca.Class = "Réptil";
                }
                //fim
                Raca.Note = tbObservacao.Text;
				if (RacaId == 0)
				{
					raceService.Insert(Raca);
					MessageBox.Show("Raça adicionada com sucesso!");
				}
				else
				{
                    Raca.Id = RacaId;
					raceService.Update(Raca);
					MessageBox.Show("Raça alterada com sucesso!");
				}
				LimparCampos();
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void CadastroRaca_Load(object sender, EventArgs e)
        {
			if(RacaId == 0)
			{
				Raca = new Race();
			}
			else
			{
				Raca = raceService.GetById(RacaId);
				tbCodigo.Text = Raca.Id.ToString();
				tbNome.Text = Raca.Note;
				tbEspecie.Text = Raca.Specie;
                if (Raca.Size == "Pequeno")
                {
                    rbPequeno.Checked = Raca.Size == "Pequeno";
                }
                if (Raca.Size == "Médio")
                {
                    rbMedio.Checked = Raca.Size == "Médio";
                }
                else
                {
                   rbGrande.Checked = Raca.Size == "Grande";
                }
                //fim
                // groupbox classe
                if (Raca.Class == "Anfibio")
                {
                    rbAnfibio.Checked = Raca.Class == "Anfibio";
                }
                if (Raca.Class == "Aracnideo")
                {
                    rbAracnideo.Checked = Raca.Class == "Aracnideo";
                }
                if (Raca.Class == "Ave")
                {
                    rbAve.Checked =  Raca.Class == "Ave";
                }
                if (Raca.Class == "Crustaceo")
                {
                    rbCrustaceo.Checked =  Raca.Class == "Crustaceo";
                }
                if (Raca.Class == "Inseto")
                {
                    rbInseto.Checked = Raca.Class == "Inseto";
                }
                if (Raca.Class == "Mamifero")
                {
                    rbMamifero.Checked = Raca.Class == "Mamifero";
                }
                else
                {
                   rbReptil.Checked =  Raca.Class == "Réptil";
                }
                //fim

                gbPorte.Text = Raca.Size.ToString();
				gbClasse.Text = Raca.Size.ToString();
				tbObservacao.Text = Raca.Note;
			}

        }		
	}
}
