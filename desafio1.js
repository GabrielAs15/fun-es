const readLine = require('prompt-sync')();
function NumeroMaior(n1, n2)
{ 
    mensagem = "";

    if ( n1 > n2)
    {
        mensagem = "O número  " + n1 + "é maior que " + n2;
    }

    else if ( n1 < n2 )
    { 
        mensagem = " O número " + n1 + " é menor que " + n2; 
    }

    else 
    { 
        mensagem = " Os números são iguais"
    }

    return mensagem;
}

function main(){

    try { 
        console.log(" ### PROGRAMA PARA SABER O NÚMERO MAIOR")

        console.log("Informe o  primeiro número")
        let a = Number(readLine())

        console.log("Informe o segundo número")
        let b = Number(readLine())

        let x = NumeroMaior (a, b)
        console.log(x);
    }

    catch(err){
        console.log("Ocorreu um erro")
        console.log(err.mesage)
    }
}

main()