public string Farol(string cor) 
{
    string ordem = "";

    if ( cor == "vermelho")
    {
        ordem = "Não ande, o sinal está vermelho";
    }
    
    else if( cor == "verde")
    { 
        ordem = " Ande, o sinal está verde ";
    }
    
    else 
    { 
        ordem = " O farol está inoperante";
    }

    return ordem;
}

public void Main() 
{ 
    try 
    {
    Console.WriteLine("### PROGRAMA PARA SEMÁFORO");

    Console.WriteLine(" Informe uma cor");
    string a = Convert.ToString(Console.ReadLine());

    string x = Farol(a);
    Console.WriteLine(x);}

    catch (Exception exe) 
    {
        Console.WriteLine("O Farol está inoperante");
        Console.WriteLine(exe.Message);
    }
}

Main();