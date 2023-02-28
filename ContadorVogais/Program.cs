namespace ContadorVogais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantvogais = 0;
            char[] caracteres = { 'a', 'e', 'i', 'o', 'u'};
            Console.WriteLine("----------------CONTADOR DE VOGAIS----------------");
            Console.WriteLine("-----------DIGITE UMA FRASE OU PALAVRA-----------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("DIGITE AQUI");
            char[] frase = Console.ReadLine().ToLower().ToCharArray();

            for (int conta = 0; conta < frase.Length; conta++)
            {
                if (caracteres.Contains(frase[conta]))
                {
                    quantvogais++;
                }
            }

            Console.WriteLine("Total de {0} Vogais.", quantvogais);
            Console.Read();

            Console.ReadKey();
        }
    }
}