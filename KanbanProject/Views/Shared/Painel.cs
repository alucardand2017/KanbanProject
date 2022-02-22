using System;

namespace KanbanProject.Views.Shared
{
    static class Painel
    {
       public static void ImprimirTela()
        {

        }
        public static ConsoleColor TextoDestaque()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            return anterior;
        }
        public static ConsoleColor TextoErro()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            return anterior;
        }
        public static ConsoleColor TextoDigitacao()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            return anterior;
        }
        public static void RetornaCorAnterior(ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
        }
    }
}
