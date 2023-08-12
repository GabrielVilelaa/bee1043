using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            int menor, medio, maior;

            if (A < B && A < C)
            {
                menor = A;
                if (B < C)
                {
                    medio = B;
                    maior = C;
                }
                else
                {
                    medio = C;
                    maior = B;
                }
            }
            else if (B < A && B < C)
            {
                menor = B;
                if (A < C)
                {
                    medio = A;
                    maior = C;
                }
                else
                {
                    medio = C;
                    maior = A;
                }
            }
            else
            {
                menor = C;
                if (A < B)
                {
                    medio = A;
                    maior = B;
                }
                else
                {
                    medio = B;
                    maior = A;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(medio);
            Console.WriteLine(maior);

            Console.WriteLine();
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
    }
}
