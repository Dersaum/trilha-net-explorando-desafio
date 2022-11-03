namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if ( hospedes.Count <= Suite.Capacidade )
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Houve um problema. A quantidade de hóspedes excedeu o limite da suíte reservada");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int count = 0;

            foreach ( Pessoa cliente in Hospedes)
            {
                count++;
            }
           
            return count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if ( DiasReservados >= 10 )
            {
                decimal desconto = 0.90M;
                valor = valor * desconto;
            }

            return valor;
        }
    }
}