public string NumeroMaior(int n1, int n2)
{ 
    string msgm = "";

    if ( n1 > n2 ) 
    { 
        msgm = "O número " + n1  + " é maior que " + n2; 
    }
    else if ( n1 < n2 )
    { 
        msgm = " O número " + n1 + " é menor que" + n2;
    }
    else
    { 
        msgm = " Os números são iguais ";
    }

    return msgm;
}

public void Main()
{ 
    try 
    {
        Console.WriteLine(" ### PROGRAMA PARA SABER SE UM NÚMERO É MAIOR QUE O OUTRO");
        
        Console.WriteLine(" Informe um número");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Informe outro número");
        int b = Convert.ToInt32(Console.ReadLine());

        string x = NumeroMaior(a, b);

        Console.WriteLine(x);
    } 

    catch(Exception ex)
    { 
        Console.WriteLine("Ops, ocorreu um erro");
        Console.WriteLine(ex.Message);
    }
}

Main();