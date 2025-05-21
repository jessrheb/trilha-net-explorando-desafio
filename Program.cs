using System.Globalization;
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = [];

Suite suite = new(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

Pessoa pessoa1 = new(nome: "Anita", sobrenome: "Cabral Ventura");
Pessoa pessoa2 = new(nome: "Murilo", sobrenome: "Hamamura");

hospedes.Add(pessoa1);
hospedes.Add(pessoa2);

Reserva reserva = new(diasReservados: 12);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine(
    $"Hóspedes: {reserva.ObterQuantidadeHospedes()} ({pessoa1.NomeCompleto}, {pessoa2.NomeCompleto})"
);
Console.WriteLine($"Estadia: Suíte {suite.TipoSuite}/{reserva.DiasReservados} dias");
Console.WriteLine(
    $"Valor da diária: {reserva.CalcularValorDiaria().ToString("C", new CultureInfo("pt-BR"))}"
);
