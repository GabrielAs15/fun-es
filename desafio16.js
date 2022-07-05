function notas ( nota1, nota2, nota3)
{
    let media = (nota1+nota2+nota3)/3;


    let situacao = "";

    if (media >= 8)
    {
        situacao = "Aprovado com sucesso";
    }
    if (media >= 5 && x < 8)
    {
        situacao = "Aprovado";
    }
    if (media >= 3 && x <= 5)
    {
        situacao = "Recuperação";
    }
    if (media <= 3)
    {
        situacao = "Reprovado";
    }
    if (media == 80)
    {
        situacao = "Desistente";
    }

    return situacao;
}

function main()
{
    try
    {
        console.log("### PROGRAMA PARA SABER A SITUACAO DE UM ALUNO ###");

        console.log("Informe a primeira nota");
        let a = Number(readLine());

        console.log("Informe a segunda nota");
        let b = Number(readLine());

        console.log("Informe a terceira nota");
        let c = Number(readLine());

        let x = notas (a, b, c);

        console.log(x);
    }
    catch (err)
    {
        console.log("Ocorreu um erro");
        console.log(err.message);
    }
}

main();