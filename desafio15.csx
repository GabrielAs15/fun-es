public string cor(string cor1, string cor2)
{
  string msg = "";

  if (cor1 == "azul" && cor2 == "azul")
  {
    msg = "azul";
  }
  if (cor1 == "azul" && cor2 == "vermelho")
  {
    msg = "roxo";
  }
  if (cor1 == "azul" && cor2 == "amarelo")
  {
    msg = "verde";
  }
  if (cor1 == "vermelho" && cor2 == "azul")
  {
    msg = "roxo";
  }
  if (cor1 == "vermelho" && cor2 == "vermelho")
  {
    msg = "vermelho";
  }
  if (cor1 == "vermelho" && cor2 == "amarelo")
  {
    msg = "laranja";
  }
  if (cor1 == "amarelo" && cor2 == "azul")
  {
    msg = "verde";
  }
  if (cor1 == "amarelo" && cor2 == "vermelho")
  {
    msg = "laranja";
  }
  if (cor1 == "amarelo" && cor2 == "amarelo")
  {
    msg = "amarelo";
  }
  return msg;
}

public void Main()
{
    try
    {
        Console.WriteLine("### PROGRAMA PARA FAZER CORES ###");

        Console.WriteLine("Informe a primeira cor");
        string a = Console.ReadLine();

        Console.WriteLine("informe a segunda cor");
        string b = Console.ReadLine();

        string x = cor(a, b);

        Console.WriteLine(x);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro");
        Console.WriteLine(ex.Message);
    }
}

Main();