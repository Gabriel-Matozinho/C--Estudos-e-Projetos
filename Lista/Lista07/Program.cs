using System.Globalization;

namespace Lista07 {
    internal class Program {
        static void Main(string[] args) {

            //Entrada e declaração do valor da variável 'n'
            int n = int.Parse(Console.ReadLine());

            //Declaração das listas
            List<string> nomeAluno = new List<string>();
            List<double> nota01 = new List<double>();
            List<double> nota02 = new List<double>();

            //Loop para adicionar os nomes e as notas nas respectivas listas
            for (int i = 0; i < n; i++) {
                //vetor para fazer a entrada de dados ser lida na horizontal 
                string[] s = Console.ReadLine().Split(' ');
                nomeAluno.Add(s[0]);
                nota01.Add(double.Parse(s[1],CultureInfo.InvariantCulture));
                nota02.Add(double.Parse(s[2],CultureInfo.InvariantCulture));
            }

            //Saida de dados
            Console.WriteLine("Alunos aprovado");

            //Logica para fazer a soma dos valores das notas dentro das listas e trazer os alunos acima da média
            double soma = 0.0;
            for (int i = 0;i < n; i++) {
                soma = nota01[i] + nota02[i];
                double media = soma / 2;
                if(media >= 6.0) {
                    string aluno = nomeAluno[i];
                    Console.WriteLine(aluno);
                }
            }
        }
    }
}
