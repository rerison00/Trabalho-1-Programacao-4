using Calculadora.Entidades;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao = "[";
            var calcular = new Calcular();
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------------------CALCULADORA------------------");
                Console.WriteLine("-----------ESCOLHA A OPCAO QUE DESEJA-----------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("******************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("|1| - Somar");
                Console.WriteLine("|2| - Subtrair");
                Console.WriteLine("|3| - Divisao");
                Console.WriteLine("|4| - Multiplicacao");
                Console.WriteLine("|5| - Encerrar a calculadora");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1": 
                        Console.WriteLine("Digite o primeiro numero e logo em seguida o segundo");
                        Console.WriteLine("Resultado: " + calcular.Somar(Console.ReadLine(), Console.ReadLine()));
                        break;

                    case "2":
                        Console.WriteLine("Digite o primeiro numero e logo em seguida o segundo");
                        Console.WriteLine("Resultado: " + calcular.Subtrair(Console.ReadLine(), Console.ReadLine()));
                        break;

                    case "3":
                        Console.WriteLine("Digite o primeiro numero e logo em seguida o segundo");
                        Console.WriteLine("Resultado: " + calcular.Divisao(Console.ReadLine(), Console.ReadLine()));
                        break;

                    case "4":
                        Console.WriteLine("Digite o primeiro numero e logo em seguida o segundo");
                        Console.WriteLine("Resultado: " + calcular.Multiplicacao(Console.ReadLine(), Console.ReadLine()));
                        break;

                    default: Console.WriteLine("Opcao errada!"); break;
                }
                Console.WriteLine("APERTE ENTER PARA CONTINUAR");
                Console.ReadLine();
                Console.Clear();
            } while (opcao != "5");
        }
    }
}