using System;

namespace ONG.Dominio
{
    public class Voluntario : Pessoa
    {
        public virtual Funcao Funcao { get; set; }
        public string CRM { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
