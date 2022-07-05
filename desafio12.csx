public double Calculadora(double n1, double n2, strinf)
{ 
    double resultado = 0;

    string operação = "";
    
    if(operação = "soma")
    { 
        resultado = n1 + n2;
    }

    else if (operação = "subtração")
    { 
        resultado = n1 - n2;
    }

    else if(operação = "multiplicação")
    { 
        resultado = n1 * n2;
    }

    else if(operação = "divisão")
    { 
        resultado = n1 / n2;
    }

    else
        throw new ArgumentException ("Operação não suportada");

    return resultado;
}

public void Main()
{ 
    try {
    Console.WriteLine("### PROGRAMA PARA FAZER UMA CALCULADORA ###");

    Console.WriteLine("Informe a operação desejada");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Informe o primeiro número");
    double b = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Informe o segundo número");
    double c = Convert.ToDouble(Console.ReadLine());



    double x = Calculadora(a, b, c);
    Console.WriteLine(x);
    }

    catch (Exception exe)
    { 
        Console.WriteLine(exe.Message);
    }
}

Main();