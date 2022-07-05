public string DiadaSemana( double número)
{
    string msg = "";

    if( número < 0 || número > 6)
    { 
        msg = "Dia da semana inválido";
    }
 
    else if ( número == 0)
    { 
        msg = "domingo";
    }

    else if ( número == 1)
    { 
        msg = "segunda";
    }

    else if ( número == 2)
    { 
        msg = "terça";
    }

    else if ( número == 3)
    { 
        msg = "quarta";
    }

    else if ( número == 4)
    { 
        msg = "quinta";
    }

    else if ( número == 5 )
    { 
        msg = "sexta";
    }

    else if ( número == 6)
    { 
        msg = "sábado";
    }

    return msg;
}

public void Main()
{ 
    try{
    Console.WriteLine("### PROGRAMA PARA DIZER O DIA DA SEMANA");

    Console.WriteLine("Informe um número de 0 a 6");
    double a = Convert.ToDouble(Console.ReadLine());

    string x = DiadaSemana(a);
    Console.WriteLine(x);}
    
    catch ( Exception exe) 
    { 
        Console.WriteLine("Dia da semana inválido");
        Console.WriteLine(exe.Message);
    }
}
Main();