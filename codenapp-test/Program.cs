using codenapp_test.Desafios.DesafioPalindromo;

var testes = new[]
{
    "Arara", "Ovo", "Roma me tem amor", "O lobo ama o bolo", "Hello"
};

foreach (var t in testes)
    Console.WriteLine($"\"{t}\" -> {(Palindromo.ValidaPalindromo(t) ? "É PALÍNDROMO V" : "NÃO É PALÍNDROMO X")}");
