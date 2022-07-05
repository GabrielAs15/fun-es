public string vestibular (double nota)
{
    string msg = "";

    if(nota < 5)
    {
        msg = " O candidato não passou";
    }
    else if (nota > 7)
    {
        msg = " O candidato passou";
    }
    else if (nota > 4 && nota < 8)
    {
        msg = " O candidato esta na lista de espera";
    }

    return msg;
}

public void Main()
{
    try
    {
        Console.WriteLine("### PROGRAMA PARA SABER SE O CANDIDATO PASSOU NO VESTIBULAR ###");

        Console.WriteLine("Informe sua nota");
        int a = Convert.ToInt32(Console.ReadLine());

        string x = vestibular (a);

        Console.WriteLine(x);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro");
        Console.WriteLine(ex.Message);
    }
}

Main();