using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codenapp_test.Desafios.DesafioPalindromo
{
    public class Palindromo
    {
        public static bool ValidaPalindromo(string entrada)
        {
            var LimpaTexto = new System.Text.StringBuilder();
            foreach (char caractere in entrada)
                if (char.IsLetter(caractere))
                    LimpaTexto.Append(char.ToLower(caractere));

            string textoLimpo = LimpaTexto.ToString();

            int esquerda = 0;
            int direita = textoLimpo.Length - 1;

            while (esquerda < direita)
            {
                if (textoLimpo[esquerda] != textoLimpo[direita])
                    return false;
                esquerda++;
                direita--;
            }

            return true;
        }
    }
}
