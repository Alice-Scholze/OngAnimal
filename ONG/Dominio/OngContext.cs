using Microsoft.EntityFrameworkCore;

namespace ONG.Dominio
{
    public class OngContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Adotante> Adotantes { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Doador> Doadores { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Raca> Racas { get; set; }
        public DbSet<Voluntario> Voluntarios { get; set; }
        public DbSet<Doacao> Docaoes { get; set; }
        public DbSet<DoacaoDinheiro> DoacoesDinheiro { get; set; }
        public DbSet<DoacaoProduto> DoacoesProduto { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Adocao> Adocoes { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Procedimento> Procedimento { get; set; }
        public DbSet<Caixa> Caixa { get; set; }

    }
}
