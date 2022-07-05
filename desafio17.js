const readLine = require("prompt-sync")()
function notas (n1, n2, n3, faltas)
{
    let media = (n1+n2+n3)/3;


    let situacao = "";

    if(faltas >30)
    {
        situacao = "reprovado";
    }
    else if (media>= 8)
    {
        situacao = "Aprovado com sucesso";
    }
    else if (media >= 5 && media < 8)
    {
        situacao = "Aprovado";
    }
    else if (media >= 3 && media <= 5)
    {
        situacao = "Recuperação";
    }
    else if (media <= 3)
    {
        situacao = "Reprovado";
    }
    else if (media == 80)
    {
        situacao = "Desistente";
    }

    return situacao;
}

function main()
{
    try
    {
        console.log("### PROGRAMA PARA SABER A SITUACAO DO ALUNO COM FALTAS ###");

        console.log("Informe sua primeira nota");
        let a = Number(readLine());

        console.log("Informe sua segunda nota");
        let b = Number(readLine());

        console.log("Informe sua terceira nota");
        let c = Number(readLine());

        console.log("Informe suas faltas");
        let d = Number(readLine());

        let x = notas (a, b, c, d);

        console.log(x);
    }
    catch (err)
    {
        console.log("Ocorreu um erro");
        console.log(ex.message);
    }
}

main();