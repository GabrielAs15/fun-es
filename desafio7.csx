public string Mes(double mes)
{ 
    string nomedomes = "";

    if(mes <= 0 || mes > 12)
        throw new ArgumentException("Informe apenas números de 1 a 12");

    if (mes == 1)
    { 
        nomedomes = "janeiro";
    }

    else if (mes == 2)
    { 
        nomedomes = "fevereiro";
    }

    else if (mes == 3)
    { 
        nomedomes = "março";
    }

    else if (mes == 4)
    { 
        nomedomes = "abril";
    }

    else if (mes == 5)
    { 
        nomedomes = "maio";
    }

    else if (mes == 6)
    { 
        nomedomes = "junho";
    }

    else if (mes == 7)
    { 
        nomedomes = "julho";
    }

    else if (mes == 8)
    { 
        nomedomes = "agosto";
    }

    else if (mes == 9)
    { 
        nomedomes = "setembro";
    }

    else if (mes == 10)
    { 
        nomedomes = "outubro";
    }

    else if (mes == 11)
    { 
        nomedomes = "novembro";
    }

    else if (mes == 12)
    { 
        nomedomes = "dezembro";
    }

    return nomedomes;
}

public void Main()
{ 
    try {
    Console.WriteLine("### PROGRAMA PARA SABER O MES");

    Console.WriteLine("Informe um número que se refira a um mês");
    double a = Convert.ToDouble(Console.ReadLine()); 

    string x = Mes(a);
    Console.WriteLine(x);
    }

    catch (Exception exe)
    { 
        Console.WriteLine(exe.Message);
    }
}

Main();