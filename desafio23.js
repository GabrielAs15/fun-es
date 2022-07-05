const readLine = require("prompt-sync")()
function vestibular (nota)
{
    let msg = "";

    if(nota < 5)
    {
        msg = " O candidato não passou";
    }
    else if (nota > 7)
    {
        msg = " O candidato passou";
    }
    else if (nota > 4 && nota < 8)
    {
        msg = " O candidato esta na lista de espera";
    }

    return msg;
}

function main()
{
    try
    {
        Console.WriteLine("### PROGRAMA PARA SABER SE O CANDIDATO PASSOU NO VESTIBULAR ###");

        Console.WriteLine("Informe sua nota");
        let a = Number(readLine());

        let x = vestibular (a);

        console.log(x);
    }
    catch (err)
    {
        console.log("Ocorreu um erro");
        console.log(err.message);
    }
}

main();