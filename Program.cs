string nome, sobrenome, sobrenomeEmMaiusculo;

Console.Write("Digite seu primeiro nome: ");
nome = Console.ReadLine()!;

Console.Write("Digite seu segundo nome: ");
sobrenome = Console.ReadLine()!;

sobrenomeEmMaiusculo = sobrenome.ToUpper();

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome completo: {sobrenomeEmMaiusculo}, {nome}");

