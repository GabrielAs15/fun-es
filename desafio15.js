const readLine = require ("prompt-sync")()
function cor(cor1, cor2)
{
  let msg = "";

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

function main()
{
    try
    {
        console.log("### PROGRAMA PARA FAZER CORES ###");

        console.log("Informe a primeira cor");
        let a = readLine();

        console.log("informe a segunda cor");
        let b = readLine();

        let x = cor(a, b);

        console.log(x);
    }
    catch (err)
    {
        console.log("Ocorreu um erro");
        console.log(ex.message);
    }
}

main();