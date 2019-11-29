using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ONG_Grafico
{
    public partial class ListarProcedimento : Form
    {
        public ProcedureService procedureService { get; set; }
        public ListarProcedimento()
        {
            InitializeComponent();
            ConfigurarDatagrid();
            procedureService = new ProcedureService();
        }

        private void ConfigurarDatagrid()
        {
            dgProcedimento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProcedimento.AutoGenerateColumns = true;
            //dgProcedimento.ColumnCount = 5;
            //dgProcedimento.ColumnHeadersVisible = true;
            //dgProcedimento.Columns[0].Name = "Código";
            //dgProcedimento.Columns[0].DataPropertyName = "Id";
            //dgProcedimento.Columns[1].Name = "Data";
            //dgProcedimento.Columns[1].DataPropertyName = "Data";
            //dgProcedimento.Columns[2].Name = "Animal";
            //dgProcedimento.Columns[2].DataPropertyName = "Animal";
            //dgProcedimento.Columns[3].Name = "Voluntario";
            //dgProcedimento.Columns[3].DataPropertyName = "Voluntario";
            //dgProcedimento.Columns[4].Name = "Serviço";
            //dgProcedimento.Columns[4].DataPropertyName = "Servico";
            dgProcedimento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarDados()
        {
            List<Procedure> procedimentos = procedureService.GetAll();
            dgProcedimento.DataSource = procedimentos;
        }

        private void ListarProcedimento_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaProcedimento tela = new TelaProcedimento();
            tela.FormClosed += Tela_FormClosed;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }
    }
}
