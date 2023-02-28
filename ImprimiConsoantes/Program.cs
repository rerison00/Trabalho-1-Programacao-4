namespace ImprimiConsoantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantvogais = 0;
            Console.WriteLine("-------------CONTADOR DE CONSOANTES-------------");
            Console.WriteLine("-----------DIGITE UMA FRASE OU PALAVRA-----------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("DIGITE AQUI");
            string entrada = Console.ReadLine();
            string consoantes = "";

            for (int i = 0; i < entrada.Length; i++)
            {
                char letra = entrada[i];
                if (Char.IsLetter(letra) && "aeiouAEIOU".IndexOf(letra) == -1)
                {
                    consoantes += letra;
                }
            }

            Console.WriteLine("Consoantes encontradas: " + consoantes);
        }
    }
}