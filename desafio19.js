const readLine = require("prompt-sync")()
function  sorvete (quantidade, gramas)
{
    let msg = "";

    let x = quantidade * 3.50;

    if(gramas >= 100 && gramas < 1001)
    {
        msg = "vai pagar " + x + " patrão";
    }
    else if (gramas > 1000)
    {
        x = quantidade * 3.00;
        msg = "vai pagar " + x + " patrão";
    }

  return msg;
}

function main()
{
    try
    {
        console.log("### PROGRAMA PARA SABER O PREÇO DO SORVETE ###");

        console.log("Informe quantos sorvetes deseja");
        let a =Number(readLine());

        console.log("Informe a quantidade de gramas");
        let b = Number(readLine());

        let x = sorvete (a,b);

        console.log(x);
    }
    catch (err)
    {
        console.log("Ocorreu um erro");
        console.log(ex.message);
    }
}

main();