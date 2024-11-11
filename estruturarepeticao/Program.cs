// // Estrutura de repetição While
// Random numeroAleatorio = new Random();
// int numero = numeroAleatorio.Next(1, 101);
// int contador = 0;
// Console.WriteLine($"Número Alvo: {numero}");
// // Loop quue incrementa o contador até ele atingir o número alvo
// while (contador != numero)
// {
//     Console.WriteLine($"Contador: {contador}.");
//     contador++;
// }
// Console.WriteLine($"Contador atingiu o número alvo: {contador}");


//Estrutura repetição Do/While
// int numero = 0;

// do {
//     Console.WriteLine($"Número: {numero}");
//     numero++;

// }while (numero <= 10);


// Estrutura de repetição For
// O looping For
// for (int i = 0 ; i <= 10 ; i ++)
// {
//     Console.WriteLine($"O valor de i: {i}");
// }


// Estrutura de repetição Foreach
// string[] nomes = {"João", "Maria", "Sirlene", "Paulo"};
// foreach (string nome in nomes)
// {
// Console.WriteLine(nome);
// }




//EXERCICIOS 

// 1. Crie um algoritmo que some todos os numeros pares de 1 a 100 e exiba o resultado no console.

// int i = 0;
// int soma;

// while(i < 100)
// {
//     i++;

// if(i %2 == 0)

//     i + i = soma;
//     Console.WriteLine(soma);
// }

// for (int i = 0 ; i <= 100 ; i ++)
// {
//     i + i = soma
//     Console.WriteLine(soma);
// }

// 2. Crie um algoritmo que faça uma contagem regressiva de 10 a 1 e exiba "decolar!" ao final. 

Estrutura de repetição For
for (int i = 10 ; i > -1 ; i --)
{
    Console.WriteLine(i);
}

Console.WriteLine("Decolar!");


// 3. Crie um algoritmo que conte o numero de vogais (a, e, i, o, u) na palavra e exiba o resultado.
//usar foreach


// 4. Crie um algoritmo que solicite uma palavra ou frase do usuário, verifique se é um palidromo, ou seja, se é igual de trás pra frente. 
// exemplo: ana, radar, etc..



// 5. Crie um algoritmo onde o computador escolhe um numero aleatorio entre 1 a 100 e o usuario deve adivinhar, após cada tentativa, 
// o programa indica se o numero é maior ou menor.


//gerar numero aleatório
Random numeroAleatorio = new Random();
int numero = numeroAleatorio.Next(1, 101);

//pegar primeiro numero do usuário
Console.WriteLine("Escreva um numero:");
int tentativa;
Console.WriteLine($"Seu numero é: {tentativa}");

//Looping
while (true)
{
if( !int.TryParse( Console.read(), out tentativa) ){

Console.WriteLine("O seu numero é invalido!");

}if {
    tentativa < numero
    Console.WriteLine("Seu numero ainda é menor que o numero secreto!");
}if{
    tentativa > numero
    Console.WriteLine("Seu numero é muito maior que o numero secreto!");
}if {
    tentativa == numero
    Console.WriteLine($"Seu numero é igual ao numero secreto, Parabens!!{numero}");
}


}

{
    Console.WriteLine($"Seu numero é maior que o numero escondido... Tente novamente:");
    int tentativa = Convert.ToInt32(Console.ReadLine());
}

 

