<<<<<<< HEAD
﻿namespace ListaExercicio02 {
    internal class Program {
        static void Main(string[] args) {
            
            int n = int.Parse(Console.ReadLine());

            List<int> numeros = new List<int>();

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++) {
                numeros.Add(int.Parse(s[i]));
            }

            int posicao = 0;
            for (int i = 0;i < n; i++) {
                if (numeros[i] % 2 == 0) {
                    Console.Write(numeros[i] + " ");
                    posicao++;
                }                
            }
            Console.WriteLine();
            Console.WriteLine(posicao);
        }
    }
}
=======
﻿namespace Lista02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
        }
    }
}
>>>>>>> 363e0d0f036c0b6db04cc0f7791200b611edf65a
