public string Cinema (double inteira, double meia, string quarta)
{

    double inteira = ingresso * 28.50;
    double Meia = meia * 14.25;

    string msg = "";

    if(quarta == "quarta")
    {
        msg = inteira/2 + " o valor da inteira e " + Meia + " o valor da meia" ;
    }
    if(quarta != "quarta")
    {
        msg = inteira + " o valor da inteira e " + Meia + " o valor da meia";
    }

    return msg;
}

public void Main()
{
    try
    {
        Console.WriteLine("### PROGRAMA PARA SABER O VALOR TOTAL DO INGRESSO ###");

        Console.WriteLine("Informe a quantidade de inteiras");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de meias");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o dia");
        string c = Console.ReadLine();

        string x = Cinema (a,b,c);

        Console.WriteLine(x);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro");
        Console.WriteLine(ex.Message);
    }
}

Main();