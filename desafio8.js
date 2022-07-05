const readLine = require ("prompt-sync")();

function Semestre(mes)
{ 
    let semestre = "";

    if(mes > 0 && mes < 7)
    { 
        semestre = "Você está no primeiro semestre";
    }

    else if(mes > 6 && mes < 13)
    { 
        semestre = "Você está no segundo semestre"; 
    }

    else 
        throw new Error("Informe um número que se refira a um mês do ano (1 a 12)");

    return semestre;
}

function main()
{ 
    try
    {
        console.log("### PROGRAMA PARA SABER O SEMESTRE ###");

        console.log("Informe um número de 1 a 12");
        let a = Number(readLine());

        let x = Semestre(a);
        console.log(x);
    }

    catch (err)
    { 
        console.log(err.message);
    }
}

main();