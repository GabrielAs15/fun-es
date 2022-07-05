public string sorvete (double quantidade,double gramas)
{
    string msg = "";

    double x = quantidade * 3.50;

    if(gramas >= 100 && gramas < 1001)
    {
        msg = "vai pagar " + x + " patrão";
    }
    else if (gramas > 1000)
    {
        x = quantidade * 3.00;
        msg = "vai pagar " + x + " patrão";
    }

  return msg;
}

public void Main()
{
    try
    {
        Console.WriteLine("### PROGRAMA PARA SABER O PREÇO DO SORVETE ###");

        Console.WriteLine("Informe quantos sorvetes deseja");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de gramas");
        int b = Convert.ToInt32(Console.ReadLine());

        string x = sorvete (a,b);

        Console.WriteLine(x);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro");
        Console.WriteLine(ex.Message);
    }
}

Main();