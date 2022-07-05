const readLine = require ("prompt-sync")()
function Cinema ( inteira, meia, quarta)
{

    let ingresso = inteira * 28.50;
    let Meia = meia * 14.25;

    let msg = "";

    if(quarta == "nacional")
    {
        ingresso = inteira * 5;
        Meia = meia * 5;
        msg = ingresso + " o valor da inteira e "+ Meia + " o valor da meia" ;
    }
    else if(quarta == "quarta")
    {
        msg = ingresso/2 + " o valor da inteira e " + Meia + " o valor da meia" ;
    }
    else if(quarta != "quarta")
    {
        msg = ingresso + " o valor da inteira e " + Meia + " o valor da meia";
    }


    return msg;
}

function main()
{
    try
    {
        console.log("### PROGRAMA PARA SABER O VALOR TOTAL DO INGRESSO ###");

        console.log("Informe a quantidade de inteiras");
        let a = Number(readLine());

        console.log("Informe a quantidade de meias");
        let b = Number (readLine());

        console.log("Informe o dia");
        let c = readLine();

        let x = Cinema (a,b,c);

        console.log(x);
    }
    catch (err)
    {
        console.log("Ocorreu um erro");
        console.log(err.message);
    }
}

main();