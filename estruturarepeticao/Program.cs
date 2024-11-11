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
string[] nomes = {"João", "Maria", "Sirlene", "Paulo"};
foreach (string nome in nomes)
{
Console.WriteLine(nome);
}