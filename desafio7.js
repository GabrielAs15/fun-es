const readLine = require ("prompt-sync")();

function Mes(mes)
{ 
    let nomedomes = "";    

    if (mes == 1)
    { 
        nomedomes = "janeiro";
    }

    else if (mes == 2)
    { 
        nomedomes = "fevereiro";
    }

    else if (mes == 3)
    { 
        nomedomes = "março";
    }

    else if (mes == 4)
    { 
        nomedomes = "abril";
    }

    else if (mes == 5)
    { 
        nomedomes = "maio";
    }

    else if (mes == 6)
    { 
        nomedomes = "junho";
    }

    else if (mes == 7)
    { 
        nomedomes = "julho";
    }

    else if (mes == 8)
    { 
        nomedomes = "agosto";
    }

    else if (mes == 9)
    { 
        nomedomes = "setembro";
    }

    else if (mes == 10)
    { 
        nomedomes = "outubro";
    }

    else if (mes == 11)
    { 
        nomedomes = "novembro";
    }

    else if (mes == 12)
    { 
        nomedomes = "dezembro";
    }

    else {
        throw new Error("Informe apenas um número de 1 a 12")
    }

    return nomedomes;
}

function main()
{ 
    try {
    console.log("### PROGRAMA PARA SABER O MES");

    console.log("Informe um número que se refira a um mês");
    let a = Number(readLine()); 

    let x = Mes(a);
    console.log(x);
    }

    catch (err)
    { 
        
        console.log(err.message);
    }
}

main();