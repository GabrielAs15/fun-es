public string facul (string preço)
{
    string msg = "";

    if(preço == "SI")
    {
        msg = "deve pagar 550,00";
    }
    else if (preço == "ADS")
    {
        msg = "deve pagar 750,00";
    }
    else if (preço == "CS")
    {
        msg = "deve pagar 1150,00";
    }
    else if (preço == "EC")
    {
        msg = "deve pagar 1300,00";
    }
    else if (preço == "ES")
    {
        msg = "deve pagar 950,00";
    }

    return msg;
}

public void Main()
{
    try
    {
        Console.WriteLine("### PROGRAMA PARA SABER O VALOR DA FACULDADE ###");

        Console.WriteLine("Informe seu curso");
        string a = Console.ReadLine();

        string x = facul (a);

        Console.WriteLine(x);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro");
        Console.WriteLine(ex.Message);
    }
}

Main();