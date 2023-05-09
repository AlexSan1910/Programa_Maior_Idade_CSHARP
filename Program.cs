using ExercicioIdade.Models;

namespace POOMaiorIdade{
    class Program{
        static void Main(string[] args){

            // Instanciando novos objetos

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa p3 = new Pessoa();

            Console.WriteLine("Determinando qual é a pessoa mais velha");
            
            // Primeira Pessoa

            Console.Write("Nome da Primeira Pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade da Primeira Pessoa: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine()); // fazendo a conversão para inteiro, pois o ReadLine, captura informações no tipo string.

            // Segunda Pessoa

            Console.Write("Nome da Segunda Pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade da Segunda Pessoa: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine()); // fazendo a conversão para inteiro, pois o ReadLine, captura informações no tipo string.

            // Terceira Pessoa

            Console.Write("Nome da Terceira Pessoa: ");
            p3.Nome = Console.ReadLine();
            Console.Write("Idade da Terceira Pessoa: ");
            p3.Idade = Convert.ToInt32(Console.ReadLine()); // fazendo a conversão para inteiro, pois o ReadLine, captura informações no tipo string.
            
            // Condição para definir o mais velho

            if (p1.Idade > p2.Idade && p1.Idade > p3.Idade){
                p1.ExibirDados();
            }
            else if(p2.Idade > p1.Idade && p2.Idade > p3.Idade){
                p2.ExibirDados();
            }
            else if(p3.Idade > p2.Idade && p3.Idade > p1.Idade){
                p3.ExibirDados();
            }
        }
    }
}