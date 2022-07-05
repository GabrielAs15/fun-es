public string OrçamentoFamiliar(double gastos, double ganhos)
{ 
    string msg = "";

    double pow1 = ganhos * 30/100;

    double pow2 = ganhos * 50/100;

    double pow3 = ganhos * 80/100;

    double pow4 = ganhos * 100/100;

    if(gastos <= pow1) 
    { 
        msg = "Parabéns, você está gerenciando bem seus orçamentos!";
    }
    
    else if (gastos <= pow2)
    { 
        msg = "Muito bem, seus gastos não ultrapassam metade dos ganhos!";
    }

    else if ( gastos <= pow3)
    { 
        msg = "Atenção, melhor conter os gastos!";
    }

    else if ( gastos <= pow4)
    { 
        msg = "Cuidado, seu orçamento pode ficar comprometido!";
    }

    else if (gastos > ganhos)
    {
        msg = "Orçamento comprometido! Hora de rever seus gastos!";
    }

    else
        throw new ArgumentException ("Informe apenas números válidos para esta operação!");

    return msg;
}

public void Main()
{ 
    try 
    { 
        Console.WriteLine("### PROGRAMA PARA SABER O ORÇAMENTO FAMILIAR");

        Console.WriteLine("Informe seus gastos");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe seus ganhos");
        double b = Convert.ToDouble(Console.ReadLine());

        string x = OrçamentoFamiliar(a, b);
        Console.WriteLine(x);
    }

    catch ( Exception exe)
    { 
        Console.WriteLine("Informe apenas números válidos para esta operação");
        Console.WriteLine(exe.Message);
    }
}

Main();