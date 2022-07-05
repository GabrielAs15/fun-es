public string pagar (string valor)
{
    string msg = "";

    if(valor == "isento")
    {
        msg = "tem que pagar 55.00";
    }
    else if (valor == "normal")
    {
        msg = "tem que pagar 110.00";
    }


    return msg;
}

public void Main()
{
    try
    {
        Console.WriteLine("### PROGRRAMA PARA SABER O VALOR DA MENSALIDADE ###");

        Console.WriteLine("Informe o valor");
        string a = Console.ReadLine();

        string x = pagar (a);

        Console.WriteLine(x);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro");
        Console.WriteLine(ex.Message);
    }
}

Main();