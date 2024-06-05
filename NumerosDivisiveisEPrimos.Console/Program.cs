// See https://aka.ms/new-console-template for more information
using NumerosDivisiveisEPrimos.Lib;

Init();

void Init()
{
    long numero = 0;
    Console.Clear();
    Console.WriteLine("====================================================================");
    Console.WriteLine("Seja muito bem vindo para descobrir os numeros divisiveis e primos.");
    Console.WriteLine("====================================================================");
     Console.WriteLine("");
    Console.Write("Informe seu número ==> ");

    if (!long.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Informe apenas numeros!!");
        InformaSaidaConsole();
        return;
    }



    var numerosDivisiveis = numero.NumerosDivisiveis();

    Console.WriteLine("-----------------");
    Console.WriteLine("");
    Console.WriteLine("Números divisiveis => " + string.Join(", ", numerosDivisiveis));
    Console.WriteLine("");
    Console.WriteLine("Números primos => " + string.Join(", ", numerosDivisiveis.NumerosPrimos()));
    Console.WriteLine("");
    Console.WriteLine("-----------------");

    InformaSaidaConsole();
}

void InformaSaidaConsole()
{ 
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("====================================================================");
    Console.WriteLine("");
    Console.WriteLine("Selecione X para sair ou qualquer tecla para continuar.");
    var digito = Console.ReadLine() ?? string.Empty;
    if (!digito.ToLower().Equals("x"))
    {
        ReiniciarConsole();
    }
}

void ReiniciarConsole()
{
    Init();  
}