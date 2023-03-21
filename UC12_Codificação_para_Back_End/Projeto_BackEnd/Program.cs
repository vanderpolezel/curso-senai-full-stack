using Projeto_BackEnd;

PessoaFisica novaPF = new PessoaFisica();
novaPF.nome = "Vander";
novaPF.cpf = "123456789";
novaPF.rendimento = 6000.5f
float impostoPagar = novaPF.CalcularImposto(novaPF.rendimento);
Console.WriteLine(impostoPagar);
Console.WriteLine($"{impostoPagar:0.00}");
Console.WriteLine(impostoPagar.ToString("C"));

PessoaJuridica novaPJ = new PessoaJuridica();
//novaPJ.CalcularImposto(6600.5f)
Console.WriteLine(novaPJ.CalcularImposto(6600.5f));


//Console.WriteLine(novaPF.nome);
//Console.WriteLine(novaPF.cpf);

//Concatenação
//Console.WriteLine("Bem vindo - " + novaPF.nome);

//interpolação
//Console.WriteLine($"Bem vindo: {novaPF.nome} de Cpf: {novaPF.cpf}");

    //float impostoPagar = novaPF.CalcularImposto(1200); --retorna 0
    //float impostoPagar = novaPF.CalcularImposto(4560);
  