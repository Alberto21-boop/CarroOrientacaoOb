using System;

namespace Carro
{
    internal class CarroEstacionamento
    {
        public string Nome { get; set; } = default!;
        public string Cor { get; set; } = default!;
        public int QuantidadeDePortas { get; set; }
        public int Placa { get; set; }

        public string NomeDoCarro()
        {
            return Nome;
        }
        public string CorDoCarro()
        {
            return Cor;
        }
        public int PortasDoCarro()
        {
            return QuantidadeDePortas;
        }
        public int NumerosDasPlaca()
        {
            return Placa;
        }
    }
}