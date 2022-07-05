const readLine = require("prompt-sync")()
function jokempo (jogador1, jogador2)
{
    let msg = "";

    if(jogador1 == "papel" && jogador2 == "papel")
    {
        msg = "empate";
    }
    else if (jogador1 == "papel" && jogador2 == "pedra")
    {
        msg = "jogador 1 ganhou";
    }
    else if (jogador1 == "papel" && jogador2 == "tesoura")
    {
        msg = "jogador 2 ganhou";
    }
    else if (jogador1 == "pedra" && jogador2 == "papel")
    {
        msg = "jogador 2 ganhou";
    }
    else if (jogador1 == "pedra" && jogador2 == "pedra")
    {
        msg = "empate";
    }
    else if (jogador1 == "pedra" && jogador2 == "tesoura")
    {
        msg = "jogador 1 ganhou";
    }
    else if (jogador1 == "tesoura" && jogador2 == "papel")
    {
        msg = "jogador 1 ganhou";
    }
    else if (jogador1 == "tesoura" && jogador2 == "pedra")
    {
        msg = "jogador 2 ganhou";
    }
    else if (jogador1 == "tesoura" && jogador2 == "tesoura")
    {
        msg = "empate";
    }

    return msg;
}

function main()
{
    try
    {
        console.log("### PROGRAMA DO JOKEMPO ###");

        console.log("Informe a jogada do jogador 1");
        let a = readLine();

        console.log("Informe a jogada do jogador 2");
        let b = readLine();

        let x = jokempo (a,b);

        console.log(x);
    }
    catch (err)
    {
        console.log("Ocorreu um erro");
        console.log(err.message);
    }
}

main();