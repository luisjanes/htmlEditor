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
                Console.WriteLine(text);
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
            string text = "";
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            //string path = @"C:\dev\teste.txt";
            string path = Console.ReadLine();
            path = @"C:\dev\teste.txt";

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo salvo no caminho {path} com sucesso");
            Thread.Sleep(2000);
        }
    }
}

