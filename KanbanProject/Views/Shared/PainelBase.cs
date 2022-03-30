using System;

namespace KanbanProject.Views.Shared
{
    internal static class PainelBase
    {
        public static void ImprimirLinha()
        {
            for (int i = 0; i < 120; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        public static void TextoAmarelo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void TextoAmareloEscuro()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        public static void TextoAzul()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public static void TextoAzulEscuro()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        public static void TextoBranco()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void TextoVerde()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void TextoVerdeEscuro()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public static void TextoVermelhoEscuro()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        public static void TextoVermelhoPerigo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}