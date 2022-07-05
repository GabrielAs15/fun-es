const readLine = require ("prompt-sync")()
function facul (preço)
{
    let msg = "";

    if(preço == "SI")
    {
        msg = "deve pagar 550,00";
    }
    else if (preço == "ADS")
    {
        msg = "deve pagar 750,00";
    }
    else if (preço == "CS")
    {
        msg = "deve pagar 1150,00";
    }
    else if (preço == "EC")
    {
        msg = "deve pagar 1300,00";
    }
    else if (preço == "ES")
    {
        msg = "deve pagar 950,00";
    }

    return msg;
}

function main()
{
    try
    {
        console.log("### PROGRAMA PARA SABER O VALOR DA FACULDADE ###");

        console.log("Informe seu curso");
        let a = readLine();

        let x = facul (a);
        console.log(x);
    }
    catch (err)
    {
        console.log("Ocorreu um erro");
        console.log(err.message);
    }
}

main();