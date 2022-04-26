using Carro;

CarroEstacionamento carroestacionamento = new CarroEstacionamento();

carroestacionamento.Nome = Console.ReadLine();
carroestacionamento.Cor = Console.ReadLine();
carroestacionamento.QuantidadeDePortas = int.Parse(Console.ReadLine());
carroestacionamento.Placa = int.Parse(Console.ReadLine());

Console.WriteLine($"Carro : {carroestacionamento.NomeDoCarro()}");
Console.WriteLine($"Cor do Carro : {carroestacionamento.CorDoCarro()}");
Console.WriteLine($"Numero de Portas : {carroestacionamento.PortasDoCarro()}");
Console.WriteLine($"Placa do Veiculo : {carroestacionamento.NumerosDasPlaca()}");
