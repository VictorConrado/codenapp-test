using codenapp_test.Desafios.DesafioFibonacci;
using codenapp_test.Desafios.DesafioNormalizadorDeTexto;
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

/*
int[] testes = { 3, 5, 7 };

foreach (int x in testes)
{
    List<int> result = Fibonacci.CalculaFibonacci(x);
    Console.WriteLine($"Quando X = {x} o resultado é {string.Join(", ", result)}");
}
*/

//Normalizador de Texto

string[] entradas = [
    "Como é???????",
    "Não!!!!!!!!",
    "O que???!!!!! Não acredito!!!"
];

Console.WriteLine("Normalizador de Texto:");

foreach (var texto in entradas)
{
    string resultado = NormalizadorDeTexto.Normalizador(texto);

    Console.WriteLine($"Antes:  {texto}");
    Console.WriteLine($"Depois: {resultado}");
}

