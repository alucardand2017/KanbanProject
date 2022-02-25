using System;

namespace KanbanProject.Views.Shared
{
    static class Painel
    {
       public static void ImprimirTela()
        {

        }
        public static ConsoleColor TextoAmarelo()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            return anterior;
        }
        public static ConsoleColor TextoAmareloEscuro()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            return anterior;
        }
        public static ConsoleColor TextoVermelhoPerigo()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            return anterior;
        }
        public static ConsoleColor TextoVermelhoEscuro()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            return anterior;
        }
        public static ConsoleColor TextoVerde()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            return anterior;
        }
        public static ConsoleColor TextoVerdeEscuro()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            return anterior;
        }
        public static ConsoleColor TextoAzul()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            return anterior;
        }
        public static ConsoleColor TextoAzulEscuro()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            return anterior;
        }
        public static void RetornaCorAnterior(ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
        }
    }
}
