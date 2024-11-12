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

// int soma = 0;

// for (int i = 1; i <= 100; i++)
// {
//     if (i % 2 == 0) // Verifica se o número é par
//     {
//         soma += i; // Adiciona o número par à variável soma
//     }
// }

// Console.WriteLine($"A soma de todos os números pares de 1 a 100 é: {soma}");

//------------------------------------------------------------------------------------------------------------------------------------------------

// 2. Crie um algoritmo que faça uma contagem regressiva de 10 a 1 e exiba "decolar!" ao final. 

// Estrutura de repetição For
// for (int i = 10 ; i > -1 ; i--)
// {
//     Console.WriteLine(i);
//     System.Threading.Thread.Sleep(1000); // Pausa de 1 segundo entre os números
// }

// Console.WriteLine("Decolar!");

//------------------------------------------------------------------------------------------------------------------------------------------------

// 3. Crie um algoritmo que conte o numero de vogais (a, e, i, o, u) na palavra e exiba o resultado.

// Solicita uma palavra ao usuário
//  Console.Write("Digite uma palavra: ");
// string palavra = Console.ReadLine();

// // Inicializa a variável de contagem
// int contadorVogais = 0;

//  // Loop para percorrer cada caractere da palavra
// foreach (char c in palavra.ToLower())  // Converte para minúsculo para facilitar a comparação
// {
//     // Verifica se o caractere é uma vogal
//     if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
//     {
//                 contadorVogais++;
//     }
// }

// // Exibe o número de vogais encontradas
// Console.WriteLine($"A palavra '{palavra}' tem {contadorVogais} vogais.");

//------------------------------------------------------------------------------------------------------------------------------------------------

// 4. Crie um algoritmo que solicite uma palavra ou frase do usuário, verifique se é um palidromo, ou seja, se é igual de trás pra frente. 
// exemplo: ana, radar, etc..



// Solicita uma palavra ou frase ao usuário
// Console.Write("Digite uma palavra ou frase: ");
// string input = Console.ReadLine();

// // Remove os espaços e converte para minúsculas para uma comparação mais fácil
// string palavraLimpa = input.Replace(" ", "").ToLower();

// // Cria uma versão invertida da palavra ou frase
// string palavraInvertida = string.Join("", palavraLimpa.Reverse());

// // Verifica se a palavra original (sem espaços) é igual à invertida
// if (palavraLimpa == palavraInvertida)
// {
//     Console.WriteLine($"'{input}' é um palíndromo.");
// }
// else
// {
//             Console.WriteLine($"'{input}' não é um palíndromo.");
// }
    
//------------------------------------------------------------------------------------------------------------------------------------------------

// 5. Crie um algoritmo onde o computador escolhe um numero aleatorio entre 1 a 100 e o usuario deve adivinhar, após cada tentativa, 
// o programa indica se o numero é maior ou menor.

// // Gerar número aleatório
// Random numeroAleatorio = new Random();
// int numero = numeroAleatorio.Next(1, 101);

// // Iniciar o jogo
// Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100!");
// int tentativa = 0;

// while (tentativa != numero)
// {
//     // Solicitar uma tentativa ao usuário
//     Console.Write("Escreva um número: ");
//     tentativa = Convert.ToInt32(Console.ReadLine());

//     // Verificar se a tentativa é menor, maior ou igual ao número secreto
//     if (tentativa < numero)
//     {
//         Console.WriteLine("Seu número é menor que o número secreto!");
//     }
//     else if (tentativa > numero)
//     {
//         Console.WriteLine("Seu número é maior que o número secreto!");
//     }
//     else
//     {
//         Console.WriteLine($"Parabéns! Você adivinhou o número secreto: {numero}");
//     }
// }

//------------------------------------------------------------------------------------------------------------------------------------------------

 // 6. Solicite ao usuário que informe um número e, em seguida, conte quantos números pares e ímpares existem entre 1 e o número informado.


// int par = 0;
// int impar = 0;
// Console.WriteLine("Informe o seu numero:");
// int numero = Convert.ToInt32(Console.ReadLine());

//  for (int i = 1; i <= numero; i++)
//  {
//     if (i % 2 == 0) // Verifica se o número é par
//     {
//         par++; // Adiciona o número par à variável soma
//     }
//     else
//     {
//         impar++;
//     }
// } 
// Console.WriteLine($"existem {par} numeros pares e {impar} numeros impares dentro do seu numero.");

//------------------------------------------------------------------------------------------------------------------------------------------------

// 7. Crie um programa que leia dois números e execute as quatro operações básicas (soma, subtração, multiplicação e divisão), exibindo o resultado de cada uma.

// Console.WriteLine("Insira o Primeiro Numero: ");
// int numero1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insira o Segundo Numero: ");
// int numero2 = Convert.ToInt32(Console.ReadLine());

// int soma = numero1 + numero2;
// int subtracao = numero1 - numero2;
// int multiplicacao = numero1 * numero2;

// double divisao = numero2 != 0 ? numero1 / numero2 : 0;

// Console.WriteLine($"A Soma de {numero1} e {numero2} é: {soma}");
// Console.WriteLine($"A Subtração de {numero1} e {numero2} é: {subtracao}");
// Console.WriteLine($"A Multiplicação de {numero1} e {numero2} é: {multiplicacao}");

// if (numero2 != 0)
// {
//     Console.WriteLine($"A Divisão de {numero1} e {numero2} é: {divisao}");
// }
// else
// {
//     Console.WriteLine("Divisão por zero não é permitida.");
// }

//------------------------------------------------------------------------------------------------------------------------------------------------

// 8. Solicite ao usuário um número e imprima a tabuada desse número de 1 a 10.

// Console.WriteLine("Insira o numero para imprimir a tabuada:" );
// int numero = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Tabuada do {numero}:");

// for (int i = 0; i <= 10; i++)
// {
//     int resultado = numero * i;
//     Console.WriteLine($"{numero} x {i} = {resultado}");
// }

//------------------------------------------------------------------------------------------------------------------------------------------------
