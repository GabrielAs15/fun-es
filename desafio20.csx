public string jokempo (string jogador1, string jogador2)
{
    string msg = "";

    if(jogador1 == "papel" && jogador2 == "papel")
    {
        msg = "empate";
    }
    else if (jogador1 == "papel" && jogador2 == "pedra")
    {
        msg = "jogador 1 ganhou";
    }
    else if (jogador1 == "papel" && jogador2 == "tesoura")
    {
        msg = "jogador 2 ganhou";
    }
    else if (jogador1 == "pedra" && jogador2 == "papel")
    {
        msg = "jogador 2 ganhou";
    }
    else if (jogador1 == "pedra" && jogador2 == "pedra")
    {
        msg = "empate";
    }
    else if (jogador1 == "pedra" && jogador2 == "tesoura")
    {
        msg = "jogador 1 ganhou";
    }
    else if (jogador1 == "tesoura" && jogador2 == "papel")
    {
        msg = "jogador 1 ganhou";
    }
    else if (jogador1 == "tesoura" && jogador2 == "pedra")
    {
        msg = "jogador 2 ganhou";
    }
    else if (jogador1 == "tesoura" && jogador2 == "tesoura")
    {
        msg = "empate";
    }

    return msg;
}

public void Main()
{
    try
    {
        Console.WriteLine("### PROGRAMA DO JOKEMPO ###");

        Console.WriteLine("Informe a jogada do jogador 1");
        string a = Console.ReadLine();

        Console.WriteLine("Informe a jogada do jogador 2");
        string b = Console.ReadLine();

        string x = jokempo (a,b);

        Console.WriteLine(x);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro");
        Console.WriteLine(ex.Message);
    }
}

Main();