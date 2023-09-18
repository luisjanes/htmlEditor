using System;

namespace htmlEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            DrawScreen.Draw();


            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);

        }
        public static void WriteOpitions()
        {
            Console.SetCursorPosition(3, 1);
            Console.Write("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.Write("===========");
            Console.SetCursorPosition(3, 4);
            Console.Write("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.Write("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.Write("2 - Abrir arquivo");
            Console.SetCursorPosition(3, 9);
            Console.Write("0 - sair");
            Console.SetCursorPosition(3, 9);
            Console.Write("Opção: ");
        }

        static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1:
                    File.New();
                    break;
                case 2:
                    File.Open();
                    break;
                case 0:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Escreva uma opção válida");
                    Thread.Sleep(2000);
                    Show();
                    break;
            }
        }
    }
}
