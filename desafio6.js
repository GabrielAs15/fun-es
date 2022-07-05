const readLine = require("prompt-sync")();
function DiadaSeamana(número){

    let msg = "";

    if (isNaN()){ 
        msg = "Dia da semana inválido"
    }

    if (número < 0 || número > 6) { 
        msg = "Dia da semana inválido"
    }

    else if ( número == 0 )
    { 
        msg = "domingo";
    }

    else if ( número == 1 )
    { 
        msg = "segunda";
    }

    else if ( número == 2)
    { 
        msg = "terça";
    }

    else if ( número == 3)
    { 
        msg = "quarta";
    }

    else if ( número == 4)
    { 
        msg = "quinta";
    }

    else if ( número == 5)
    { 
        msg = "sexta";
    }

    else if ( número == 6)
    { 
        msg = "sábado";
    }

    return msg;
}

function main() { 
    try {
        console.log("### PROGRAMA PARA DIZER O DIA DA SEMANA")

        console.log("Informe um número de 0 a 6")
        let a = Number(readLine())
        
        let x = DiadaSeamana(a)
        console.log(x)
    }

    catch(err) { 
        console.log("Dia da semana inválido")
        console.log(err.message)
    }
}

main()