namespace VerificaPalindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diige uma palavra ou frase:");
            string entrada = Console.ReadLine();
            string textoIncluso = "";

            foreach (char c in entrada)
            {
                if (char.IsLetterOrDigit(c)) // Verificando se é letra ou decimal
                {
                    textoIncluso += char.ToLower(c);
                }
            }

            bool isPalindromo = true;
            int medida = textoIncluso.Length;

            for (int i = 0; i < medida / 2; i++)
            {
                if (textoIncluso[i] != textoIncluso[medida - 1 - i])//Verifico o inicio da palavra se é diferente do final
                {
                    isPalindromo = false;
                    break;  //caso venha a falhar em um, eu não preciso ler os demais
                }
            }
            if (isPalindromo) 
            {
                Console.WriteLine("É um palindromo!");
            }
            else
            {
                Console.WriteLine("Não é um palindromo");
            }
        }
       
    }
}
