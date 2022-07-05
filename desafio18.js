const readLine = require ("prompt-sync")()
function peso (p)
{
    let msg = "";

    if(p <18.5)
    {
        msg = "abaixo do peso";
    }
    else if (p > 18.5 && p < 24.9)
    {
        msg = "peso normal";
    }
    else if (p > 25 && p < 29.9)
    {
        msg = "sobrepeso";
    }
    else if (p > 30 && p < 34.9)
    {
        msg = "obsedade grau 1";
    }
    else if (p > 35 && p < 39.9)
    {
        msg = "obsedade grau 2";
    }
    else if (p > 40)
    {
        msg = "obsedade grau 3";
    }

    return msg;
}

function main()
{
    try
    {
        console.log("### PROGRAMA PARA SABER O SEU PESO ###");

        console.log("Informe seu peso");
        let a = Number(readLine());

        let x = peso (a);

        console.log(x);
    }
    catch (err)
    {
        console.log("Ocorreu um erro");
        console.log(err.message);
    }
}

main();