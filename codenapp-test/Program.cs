using codenapp_test.Desafios.DesafioFibonacci;
using codenapp_test.Desafios.DesafioPalindromo;

// Palíndromo 

/*
var testes = new[]
{
    "Arara", "Ovo", "Roma me tem amor", "O lobo ama o bolo", "Hello"
};

foreach (var t in testes)
    Console.WriteLine($"\"{t}\" -> {(Palindromo.ValidaPalindromo(t) ? "É PALÍNDROMO V" : "NÃO É PALÍNDROMO X")}");
*/

// Fibonacci

int[] testes = { 3, 5, 7 };

foreach (int x in testes)
{
    List<int> result = Fibonacci.CalculaFibonacci(x);
    Console.WriteLine($"Quando X = {x} o resultado é {string.Join(", ", result)}");
}
