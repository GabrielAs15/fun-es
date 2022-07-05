const readLine = require ("prompt-sync")()
function pagar (valor)
{
    let msg = "";

    if(valor == "isento")
    {
        msg = "tem que pagar 55.00";
    }
    else if (valor == "normal")
    {
        msg = "tem que pagar 110.00";
    }


    return msg;
}

function main()
{
    try
    {
        console.log("### PROGRRAMA PARA SABER O VALOR DA MENSALIDADE ###");

        console.log("Informe o valor");
        let a = readLine();

        let x = pagar (a);
        console.log(x);
    }
    catch (err)
    {
        console.log("Ocorreu um erro");
        console.log(err.message);
    }
}

main();