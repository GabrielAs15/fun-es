const readLine = require ("prompt-sync")();
function Cinema ( ingresso,  meia,  quarta)
{

    let inteira = ingresso * 28.50;
    let Meia = meia * 14.25;

    let msg = "";

    if(quarta == "quarta")
    {
        msg = inteira/2 + " é o valor da inteira e " + Meia + " é o valor da meia" ;
    }
    if(quarta != "quarta")
    {
        msg = inteira + " é o valor da inteira e " + Meia + " é o valor da meia";
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
        let b = Number(readLine());

        console.log("Informe o dia");
        let c = readLine();

        let x = Cinema (a,b,c);

        console.log(x);
    }
    catch (err)
    {
        console.log("Ocorreu um erro");
        console.log(ex.message);
    }
}

main();