

using System.Text.RegularExpressions;

namespace codenapp_test.Desafios.DesafioNormalizadorDeTexto
{
    public class NormalizadorDeTexto
    {
        public static string Normalizador(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;
            return Regex.Replace(input, @"([?!])\1+", "$1");
        }
    }
}

