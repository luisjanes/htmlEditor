using System;
using System.Text;
using System.Text.RegularExpressions;
namespace htmlEditor
{
    public class File
    {
        public static void Open()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();
            path = @"C:\dev\teste.txt";
            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine("Seu arquivo:");
                Replace(text.ToString());
            }
        }

        public static void New()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Digite seu texto abaixo(ESC para sair):");
            Console.WriteLine("------------------------");
            var text = new StringBuilder();
            do
            {
                text.Append(Console.ReadLine());
                text.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text.ToString());

        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine(" Qual caminho para salvar o arquivo?");
            //string path = @"C:\dev\teste.txt";
            string path = Console.ReadLine();
            path = @"C:\dev\teste.txt";

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo salvo no caminho {path} com sucesso");
            Thread.Sleep(2000);
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(words[i].Substring(words[i].IndexOf('>') + 1, ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))));
                    Console.Write(" ");
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}

