using Projeto_BackEnd;

PessoaFisica novaPF = new PessoaFisica();
String novoEndPF = new Endereco();

novaPF.nome = "Vander";
novaPF.cpf = "123456789";
novaPF.rendimento = 6000.5f;
novaPF.dataNas = new DateTime(2001,01,01);
float impostoPagar = novaPF.CalcularImposto(novaPF.rendimento);

novoEndPF.logradouro = "Rua x";
novoEndPf.numero =180;
novoEndPF.complemento = 'Senai';
novoEndPF.endComercial = true

novaPF.endereco = novoEndPF;

//interpolação
Console.WriteLine(@$"

Nome: {novaPF.nome}
Endereço: {novoEndPF.logradoutro}, Num: {novoEndPF.numero}
Maior de idade: {novaPF.ValidarDataNasc(novaPF.dataNasc)}
");


Console.WriteLine(impostoPagar);
Console.WriteLine($"{impostoPagar:0.00}");
Console.WriteLine(impostoPagar.ToString("C"));

PessoaJuridica novaPJ = new PessoaJuridica();
//novaPJ.CalcularImposto(6600.5f)
Console.WriteLine(novaPJ.CalcularImposto(6600.5f));

DateTime temp = new DateTime(2000, 01, 01)
Console.WriteLine(novaPF.ValidarDataNasc("01/01/2001"));

//Console.WriteLine(novaPF.nome);
//Console.WriteLine(novaPF.cpf);

//Concatenação
//Console.WriteLine("Bem vindo - " + novaPF.nome);

//interpolação
//Console.WriteLine($"Bem vindo: {novaPF.nome} de Cpf: {novaPF.cpf}");

    //float impostoPagar = novaPF.CalcularImposto(1200); --retorna 0
    //float impostoPagar = novaPF.CalcularImposto(4560);
  