public string peso (double p)
{
    string msg = "";

    if(p <18.5)
    {
        msg = "abaixo do peso";
    }
    else if (p > 18.5 && p < 24.9)
    {
        msg = "peso normal";
    }
    else if (p > 25 && p < 29.9)
    {
        msg = "sobrepeso";
    }
    else if (p > 30 && p < 34.9)
    {
        msg = "obsedade grau 1";
    }
    else if (p > 35 && p < 39.9)
    {
        msg = "obsedade grau 2";
    }
    else if (p > 40)
    {
        msg = "obsedade grau 3";
    }

    return msg;
}

public void Main()
{
    try
    {
        Console.WriteLine("### PROGRAMA PARA SABER O SEU PESO ###");

        Console.WriteLine("Informe seu peso");
        int a = Convert.ToInt32(Console.ReadLine());

        string x = peso (a);

        Console.WriteLine(x);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro");
        Console.WriteLine(ex.Message);
    }
}

Main();