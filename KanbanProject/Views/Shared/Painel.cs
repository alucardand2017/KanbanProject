using System;
using System.Linq;
using KanbanProject.Models;
using KanbanProject.Models.Enums;
namespace KanbanProject.Views.Shared
{
    static class Painel
    {
        public static void ImprimirCabecalho(Projeto projeto)
        {
            Console.Clear();
            TextoBranco();
            ImprimirLinha();
            TextoVermelhoEscuro();
            Console.WriteLine("|\t\t\t\t\t\t QUADRO KANBAN\t\t\t\t\t\t\t\t|");
            TextoBranco();
            ImprimirLinha();
            Console.WriteLine("|      Backlog  \t\t Especificação \t\t\t Implementação \t\t\t Revisão de Código\t|");
            Console.WriteLine($"|\t\t\t       \t      2        \t\t\t      2        \t\t\t   2   |        \t|");
            TextoBranco();
            ImprimirLinha();

            ImprimirLinha();
        }
        public static void ImprimirCorpo(Projeto projeto)
        {
            var h1 = projeto.Historias.Where(p => p.Posicao == PosicaoKanban.Backlog).ToList();
            var h2 = projeto.Historias.Where(p => p.Posicao == PosicaoKanban.Espec_doing).ToList();
            var h3 = projeto.Tarefas.Where(p => p.Posicao == PosicaoKanban.Espec_done).ToList();
            var h4 = projeto.Tarefas.Where(p => p.Posicao == PosicaoKanban.Deploy_doing).ToList();
            var h5 = projeto.Tarefas.Where(p => p.Posicao == PosicaoKanban.Deploy_done).ToList();
            var h6 = projeto.Tarefas.Where(p => p.Posicao == PosicaoKanban.Revision_doing).ToList();
            var h7 = projeto.Tarefas.Where(p => p.Posicao == PosicaoKanban.Revision_done).ToList();

            Console.WriteLine("|\t\t|\tem espec.   |    espeficicada\t| em Impleme. |  Implementada\t|\tem rev.| revisada\t|");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("|               |                   |                   |             |                 |              |               |");
            }
            Console.Write("| ");
            foreach (var item in h1)
            {
                Console.Write(item.NomeHistoria + " ");
            }
            for(int i = 0; i< (14-3*h1.Count); i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            foreach (var item in h2)
            {
                Console.Write(item.NomeHistoria + " ");
            }
            for (int i = 0; i < (19 - 3 * h2.Count); i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            foreach (var item in h3)
            {
                Console.Write(item.NomeTarefa + " ");
            }
            for (int i = 0; i < (19 - 3 * h3.Count); i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            foreach (var item in h4)
            {
                Console.Write(item.NomeTarefa + " ");
            }
            for (int i = 0; i < (13 - 3 * h4.Count); i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            foreach (var item in h5)
            {
                Console.Write(item.NomeTarefa + " ");
            }
            for (int i = 0; i < (17 - 3 * h5.Count); i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            foreach (var item in h6)
            {
                Console.Write(item.NomeTarefa + " ");
            }
            for (int i = 0; i < (14 - 3 * h6.Count); i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            foreach (var item in h7)
            {
                Console.Write(item.NomeTarefa + " ");
            }
            for (int i = 0; i < (15 - 3 * h7.Count); i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("|\t\t|\t            |            \t|             |             \t|\t       |        \t|");

            }
            ImprimirLinha();
        }
        public static void ImprimirProjeto(Projeto projeto)
        {
            //TextoBranco();
            //ImprimirLinha();
            //TextoVermelhoEscuro();
            //Console.WriteLine("\t\t\t\t\t\t QUADRO KANBAN: ");
            //TextoBranco();
            //ImprimirLinha();

            ImprimeInfo(projeto.NomeProjeto.ToUpper(), projeto.Descricao.ToUpper());
            foreach (var item in projeto.Historias)
            {
                ImprimeInfo(item.NomeHistoria, item.Descricao);
            }
            foreach (var item in projeto.Tarefas)
            {
                ImprimeInfo(item.NomeTarefa, item.Descricao);
            }
        }
        public static void ImprimeInfo(string nome, string descricao)
        {
            Painel.TextoBranco();
            Painel.ImprimirLinha();
            Painel.TextoAmareloEscuro();
            Console.Write(nome + "  => ");
            Painel.TextoAmarelo();
            Console.WriteLine(descricao);
        }
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
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void TextoBranco()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void TextoAmareloEscuro()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        public static void TextoVermelhoPerigo()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public static void TextoVermelhoEscuro()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        public static void TextoVerde()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void TextoVerdeEscuro()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public static void TextoAzul()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public static void TextoAzulEscuro()
        {
            ConsoleColor anterior = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
    }
}
