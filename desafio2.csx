public string NumeroMaior(int n1, int n2, int n3)
{ 
    string msgm = "";

    if ( n1 > n2 && n1 > n3) 
    { 
        msgm = "O número " + n1  + " é maior que " + n2 + " e " + n3; 
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
        
        Console.WriteLine(" Informe o primeiro número");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Informe o segundo  número");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Informe o terceiro número");
        int c = Convert.ToInt32(Console.ReadLine());

        string x = NumeroMaior(a, b, c);

        Console.WriteLine(x);
    } 

    catch(Exception ex)
    { 
        Console.WriteLine("Ops, ocorreu um erro");
        Console.WriteLine(ex.Message);
    }
}

Main();