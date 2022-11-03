using System.Text;
using DesafioProjetoHospedagem.Models;
using System.Globalization;


Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "james", sobrenome: "hetfield");
Pessoa p2 = new Pessoa(nome: "kirk", sobrenome: "Hammett");
Pessoa p3 = new Pessoa(nome: "Cliff", sobrenome: "Burton");
Pessoa p4 = new Pessoa(nome: "Lars", sobrenome: "Ulrich");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 5, valorDiaria: 650);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 17);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");

foreach ( Pessoa cliente in hospedes)
    System.Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cliente.NomeCompleto.ToLower()));

Console.WriteLine($"\nSuíte escolhida: {suite.TipoSuite}");
Console.WriteLine($"Valor diária {suite.ValorDiaria.ToString("C")}");
Console.WriteLine($"Dias de reserva: {reserva.DiasReservados}");
Console.WriteLine($"\nValor estadia: {reserva.CalcularValorDiaria().ToString("C")}");