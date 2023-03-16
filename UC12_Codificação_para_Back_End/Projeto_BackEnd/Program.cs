using Projeto_BackEnd;

PessoaFisica novaPF = new PessoaFisica();
novaPF.nome = "Vander";
novaPF.cpf = "123456789";

Console.WriteLine(novaPF.nome);
Console.WriteLine(novaPF.cpf);

//Concatenação
Console.WriteLine("Bem vindo - " + novaPF.nome);

//interpolação
Console.WriteLine($"Bem vindo: {novaPF.nome} de Cpf: {novaPF.cpf}");