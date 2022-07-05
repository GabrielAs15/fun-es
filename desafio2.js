const readLine = require('prompt-sync')();
function NumeroMaior(n1, n2, n3)
{ 
    mensagem = "";

    if (isNaN(n1,n2, n3))
        throw new Error ("Informe um número")
    if ( n1 > n2 && n1 > n3)
    {
        mensagem = "O número  " + n1 + " é maior que " + n2 + " e " + n3;
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

        console.log("Informe o terceiro número")
        let c = Number(readLine())

        let x = NumeroMaior (a, b,c)
        console.log(x);
    }

    catch(err){
        console.log("Ocorreu um erro")
        console.log(err.message)
    }
}

main()