public string Semestre( double mes)
{ 
    string semestre = "";

    if(mes > 0 && mes < 7)
    { 
        semestre = "Você está no primeiro semestre";
    }

    else if(mes > 6 && mes < 13)
    { 
        semestre = "Você está no segundo semestre"; 
    }

    else 
        throw new ArgumentException("Informe um número que se refira a um mês do ano (1 a 12)");

    return semestre;
}

public void Main()
{ 
    try
    {
        Console.WriteLine("### PROGRAMA PARA SABER O SEMESTRE ###");

        Console.WriteLine("Informe um número de 1 a 12");
        double a = Convert.ToDouble(Console.ReadLine());

        string x = Semestre(a);
        Console.WriteLine(x);
    }

    catch (Exception exe)
    { 
        Console.WriteLine(exe.Message);
    }
}

Main();