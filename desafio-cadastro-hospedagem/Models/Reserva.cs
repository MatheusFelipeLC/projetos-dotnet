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
            
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
               
             Console.WriteLine($"A quantidade de Pessoas Excede a capadidade do Quarto!");   
                
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int nHospedes = Hospedes.Count;
            return nHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = DiasReservados * (Suite.ValorDiaria);

        
            if (DiasReservados >= 10)
            {
                valor = (valor - valor/10);
            }

            return valor;
        }
    }
}