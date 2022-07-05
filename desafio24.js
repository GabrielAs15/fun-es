const readLine = require ("prompt-sync")()
function febre (temperatura)
{
    let msg = "";

    if(temperatura <= 37)
    {
        msg = "temperatura normal";
    }
    else if (temperatura > 37 && temperatura < 37.6)
    {
        msg = "febricula";
    }
    else if (temperatura > 37.5 && temperatura < 38.5)
    {
        msg = "febre moderada";
    }
    else if (temperatura > 38.5)
    {
        msg = "febre alta";
    }

    return msg;
}

function main()
{
    try
    {
        console.log("### PROGRAMA PARA MEDIR A TEMPERATURA CORPORAL ###");

        console.log("Informe a sua temperatura");
        let a = Number(readLine());

        let x = febre (a);

        console.log(x);
    }
    catch (err)
    {
        console.log("Ocorreu um erro");
        console.log(err.message);
    }
}

main();