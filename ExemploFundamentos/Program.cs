// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using ExemploFundamentos.Common.Models;


int[] arrayInteiros = new int[3];
arrayInteiros[0] = 1;
arrayInteiros[1] = 2;
arrayInteiros[2] = 3;

Console.WriteLine("Exemplo For:");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
}

Console.WriteLine("Exemplo Foreach:");
int contadorForeach = 0;
foreach (int valor in arrayInteiros) {
    Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
    contadorForeach++;
}


























// Pessoal pessoa = new Pessoal();

// pessoa.Nome = "Thiago";
// pessoa.Idade = 27;
// pessoa.Apresentar();
