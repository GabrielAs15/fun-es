const readLine = require("prompt-sync")()
function OrçamentoFamiliar( gastos, ganhos)
{ 
    let msg = "";

    let pow1 = ganhos * 30/100;

    let pow2 = ganhos * 50/100;

    let pow3 = ganhos * 80/100;

    let pow4 = ganhos * 100/100;

    if(gastos <= pow1) 
    { 
        msg = "Parabéns, você está gerenciando bem seus orçamentos!";
    }
    
    else if (gastos <= pow2)
    { 
        msg = "Muito bem, seus gastos não ultrapassam metade dos ganhos!";
    }

    else if ( gastos <= pow3)
    { 
        msg = "Atenção, melhor conter os gastos!";
    }

    else if ( gastos <= pow4)
    { 
        msg = "Cuidado, seu orçamento pode ficar comprometido!";
    }

    else if (gastos > ganhos)
    {
        msg = "Orçamento comprometido! Hora de rever seus gastos!";
    }

    return msg;
}

function main()
{ 
    try 
    { 
        console.log("### PROGRAMA PARA SABER O ORÇAMENTO FAMILIAR");

        console.log("Informe seus gastos");
        let a = Number(readLine());

        console.log("Informe seus ganhos");
        let b = Number(readLine());

        let x = OrçamentoFamiliar(a, b);
        console.log(x);
    }

    catch (err)
    { 
        console.log(err.message);
    }
}

main();