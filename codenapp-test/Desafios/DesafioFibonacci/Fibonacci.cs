using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codenapp_test.Desafios.DesafioFibonacci
{
    public class Fibonacci
    {
        public static List<int> CalculaFibonacci(int x)
        {
            List<int> SequenciaFibonacci = new List<int>();

            if (x <= 0) return SequenciaFibonacci;

            SequenciaFibonacci.Add(0);
            if (x == 1) return SequenciaFibonacci;

            SequenciaFibonacci.Add(1);

            for (int i = 2; i < x; i++)
            {
                int proximoValor = SequenciaFibonacci[i - 1] + SequenciaFibonacci[i - 2];
                SequenciaFibonacci.Add(proximoValor);
            }

            return SequenciaFibonacci;
        }
    }
}
