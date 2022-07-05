public string notas (int n1, int n2, int n3, int f)
{
    int media = (n1+n2+n3)/3;


    string situacao = "";

    if(faltas >30)
    {
        situacao = "reprovado";
    }
    else if (media>= 8)
    {
        situacao = "Aprovado com sucesso";
    }
    else if (media >= 5 && media < 8)
    {
        situacao = "Aprovado";
    }
    else if (media >= 3 && media <= 5)
    {
        situacao = "Recuperação";
    }
    else if (media <= 3)
    {
        situacao = "Reprovado";
    }
    else if (media == 80)
    {
        situacao = "Desistente";
    }

    return situacao;
}

public void Main()
{
    try
    {
        Console.WriteLine("### PROGRAMA PARA SABER A SITUACAO DO ALUNO COM FALTAS ###");

        Console.WriteLine("Informe sua primeira nota");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe sua segunda nota");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe sua terceira nota");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe suas faltas");
        int d = Convert.ToInt32(Console.ReadLine());

        string x = notas (a, b, c, d);

        Console.WriteLine(x);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro");
        Console.WriteLine(ex.Message);
    }
}

Main();