const readLine = require ('prompt-sync')();
function Orçamento (ganhos, gastos) { 

    let msg = "";
    if(ganhos > gastos){
        msg = "Você está dentro do orçamento!"
    }

    else if (gastos > ganhos){
        msg = "Você está fora do orçamento, não gaste mais!"

    }

    else{
        throw new Error (msg = "Informe um número")
    }

    return msg;

}

function main(){
    try{
    console.log("### PROGRAMA PARA SABER SEU ORÇAMENTO FAMILIAR");

    console.log("Informe seus ganhos");
    let a = Number(readLine());

    console.log("Informe seus gastos");
    let b = Number(readLine());

    let x = Orçamento(a, b);
    console.log(x);}
    
    catch (err) { 
        console.log("Informe apenas um número");
        console.log(err.message);
    }


}
main()