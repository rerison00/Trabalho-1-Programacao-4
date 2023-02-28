namespace ImprimiVogais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantvogais = 0;
            int i = 0;
            string frasevogal = "";  
            Console.WriteLine("----------------CONTADOR DE VOGAIS----------------");
            Console.WriteLine("-----------DIGITE UMA FRASE OU PALAVRA-----------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("DIGITE AQUI");
            char[] frase = Console.ReadLine().ToLower().ToCharArray();

            for (i = 0; i < frase.Length; i++) 
            { 
                if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
                {
                    //Console.WriteLine("{0} ", frase[i]);
                    frasevogal += frase[i].ToString();
                }
            }
            Console.WriteLine("Frase com apenas Vogais: " + frasevogal);
        }
    }
}