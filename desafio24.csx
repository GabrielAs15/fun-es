public string febre (double temperatura)
{
    string msg = "";

    if(temperatura <= 37)
    {
        msg = "temperatura normal";
    }
    else if (temperatura > 37 && temperatura < 37.6)
    {
        msg = "febricula";
    }
    else if (temperatura > 37.5 && temperatura < 38.5)
    {
        msg = "febre moderada";
    }
    else if (temperatura > 38.5)
    {
        msg = "febre alta";
    }

    return msg;
}

public void Main()
{
    try
    {
        Console.WriteLine("### PROGRAMA PARA MEDIR A TEMPERATURA CORPORAL ###");

        Console.WriteLine("Informe a sua temperatura");
        int a = Convert.ToInt32(Console.ReadLine());

        string x = febre (a);

        Console.WriteLine(x);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro");
        Console.WriteLine(ex.Message);
    }
}

Main();