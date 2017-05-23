using System;

namespace RenameFiles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Me dia por onde começar: ");
            var path = Console.ReadLine();

            RenomearArquivos.Executar(path);
        }
    }
}
