namespace htmlEditor
{
    public class DrawScreen
    {
        public static void Draw()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            DrawLines();
            for (int i = 0; i <= 11; i++)
            {
                Console.Write("|");
                for (int z = 0; z <= 60; z++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write(Environment.NewLine);
            }
            DrawLines();
            static void DrawLines()
            {
                Console.Write("+");
                for (int i = 0; i <= 60; i++)
                {
                    Console.Write("-");
                }
                Console.Write("+");
                Console.Write(Environment.NewLine);
            }
            Menu.WriteOpitions();
        }
    }
}