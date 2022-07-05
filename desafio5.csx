public string Orçamento( double ganhos, double gastos)
{ 
    string msg = "";

    if ( ganhos > gastos)
    { 
        msg = "Você está dentro do orçamento!";
    }

    else if( gastos > ganhos)
    { 
        msg = "Você está fora do orçamento, não gaste mais!";
    }

    else
    {
        msg = "Informe um número";
    }

    return msg;
}

public void Main()
{ 
    try 
    {
    Console.WriteLine(" ### PROGRAMA PARA SABER O ORÇAMENTO FAMILIAR");

    Console.WriteLine(" Informe a quantidade de ganhos");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Informe os seus gasstos");
    double b = Convert.ToDouble(Console.ReadLine());

    string x = Orçamento(a, b);
    Console.WriteLine(x);
    }

    catch(Exception exe)
    {
        Console.WriteLine("Informe apenas números");
        Console.WriteLine(exe.Message);
    }
}

Main();