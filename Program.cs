/*Faça em sua máquina utilizando os mesmos conceitos dado em aula.
Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
Só será possível executar tais métodos se o celular estiver ligado.
Envie o link do repositório como entrega desta atividade.*/


using projeto_celular;

Celular motorola = new Celular();



Console.WriteLine($"Digite o modelo:");
string Modelo;
Modelo = Console.ReadLine();

Console.WriteLine($"Digite a cor:");
string Cor;
Cor = Console.ReadLine();

Console.WriteLine($"Digite o Tamanho:");
string Tamanho;
Tamanho = Console.ReadLine();



Console.WriteLine($"Gostaria de ligar o aparelho?");



/*bool estado;
estado=bool.Parse(Console.ReadLine());


*/


string opcao;

Console.WriteLine($"Por favor escolha uma opcao:");
Console.WriteLine(@$"
[s]Ligar
[n]Nao ligar


");


opcao = Console.ReadLine();


if (opcao == "s" )
{

    motorola.Ligar();





Console.WriteLine(@$"
 Escolha o que deseja fazer
*************************
|                       |
|      CELULAR          |      
|   [1].Fazer Ligacao   |
|   [2].Enviar Mensagem |
|   [3].Desligar 
    [0].Sair            |             
*************************



");
string acao;
acao = Console.ReadLine();










    switch (acao)
    {


        case "1":


            motorola.FazerLigacao();
            break;






        case "2":


            motorola.EnviarMensagem();
            break;


        case "3":




            motorola.Desligado();
            break;




        default:
            Console.WriteLine($"digite uma opcao valida");

            break;
    }




Console.WriteLine($"Informacoes sobre o celular escolhido:");

Console.WriteLine($"cor:"+ Cor);

Console.WriteLine($"modelo:"+ Modelo);

Console.WriteLine($"tamanho:"+ Tamanho);

}


Console.WriteLine($"Encerrando...");

Console.WriteLine($"digite qualquer tecla para sair...");
Console.ReadKey();




