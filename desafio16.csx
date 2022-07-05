public string notas (int nota1, int nota2, int nota3)
{
    int media = (nota1+nota2+nota3)/3;


    string situacao = "";

    if (media >= 8)
    {
        situacao = "Aprovado com sucesso";
    }
    if (media >= 5 && x < 8)
    {
        situacao = "Aprovado";
    }
    if (media >= 3 && x <= 5)
    {
        situacao = "Recuperação";
    }
    if (media <= 3)
    {
        situacao = "Reprovado";
    }
    if (media == 80)
    {
        situacao = "Desistente";
    }

    return situacao;
}

public void Main()
{
    try
    {
        Console.WriteLine("### PROGRAMA PARA SABER A SITUACAO DE UM ALUNO ###");

        Console.WriteLine("Informe a primeira nota");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a terceira nota");
        int c = Convert.ToInt32(Console.ReadLine());

        string x = notas (a, b, c);

        Console.WriteLine(x);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro");
        Console.WriteLine(ex.Message);
    }
}

Main();