namespace Exercicios_estruturaFor;
class Program {
    static void Main(string[] args) {
        /*
        Console.Write("Digite um valor: ");
        int x  = int.Parse(Console.ReadLine());

        for (int i = 1; i <= x; i++) {
            if (i % 2 == 1) {
                Console.WriteLine(i);
            }
        }
        */

        /*
         int n = int.Parse(Console.ReadLine());
         int cont_in = 0;
         int cont_out = 0;

         for (int i = 0; i < n; i++) {            
             int x = int.Parse(Console.ReadLine());
             if(x >= 10 && x <= 20) {
                 cont_in++;
             }
             else if(x !< 10 || x  !> 20) { 
                 cont_out++;
             }                      
         }
         Console.WriteLine($"{cont_in} in");
         Console.WriteLine($"{cont_out} out");
        */

        /*
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i< n; i++) {
            string[] line = Console.ReadLine().Split(" ");
            double a = double.Parse(line[0]);
            double b = double.Parse(line[1]);
            double c = double.Parse(line[2]);

            double media = (a * 2.0 + b * 3.0 + c * 5) / 10.0;
            Console.WriteLine(media.ToString("F1"));
        */

        /*
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++) {
            string[] divisao = Console.ReadLine().Split(" ");
            int a = int.Parse(divisao[0]);
            int b = int.Parse(divisao[1]);
            
            if (b == 0) {
                Console.WriteLine("Divisão impossível");
            }
            else  {
                double resultado = (double)a / b;
                Console.WriteLine(resultado);
            }            
        } 
        */


        /*
        int n = int.Parse(Console.ReadLine());
        int fat = 1;

        for(int i = 1; i <= n; i++) {
            fat *= i;
        }
        Console.WriteLine(fat);
        */

        /*
        int n = int.Parse(Console.ReadLine());
        for(int i = 1; i <= n; i++) {
            if (n % i == 0) { 
                Console.WriteLine(i);
            } 

        } 
        */        
    } 
}