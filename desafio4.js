const readLine = require ('prompt-sync')();

function Farol(cor){ 

    let ordem = "";

    if(cor == "vermelho"){ 
        ordem = "Não ande ainda, o sinal está vermelho"
    }

    else if (cor == "verde") { 
        ordem = "Pode andar, o sinal está verde"
    }

    else { 
        ordem = "O farol está inoperante"
    }

    return ordem;
    
}

function main(){
    try{
    console.log(" ### PROGRAMA PARA FAROL ###")

    console.log("Informe a cor do farol")
    let a = String (readLine())

    let x = Farol(a);
    console.log(x);}
    
    catch (err){ 
        console.log("O farol está inapto")
        console.log(err.message)
    }

}

main();