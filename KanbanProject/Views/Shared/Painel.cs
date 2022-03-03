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
            Console.Write("|*************************************************| QUADRO KANBAN |****************************************************|");
            Console.WriteLine();
            TextoBranco();
            ImprimirLinha();
            Console.Write("|      Backlog  \t\t Especificação \t\t\t Implementação \t\t\t Revisão de Código\t|");
            Console.WriteLine();
            Console.Write($"|\t\t\t       \t      2        \t\t\t      2        \t\t\t   2   |        \t|");
            Console.WriteLine();
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
            //for (int i = 0; i < 5; i++)
            //{

            //    Console.WriteLine("|\t\t|\t            |            \t|             |             \t|\t       |        \t|");

            //}
            ImprimirLinha();
        }
        public static void ImprimirProjeto(Projeto projeto)
        {
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
        public static void ImprimirTelaPrincipal(Projeto projeto)
        {
            Console.Clear();
            Console.SetWindowSize(120, 40);
            Console.Beep();
            Console.Title = "QUADRO KANBAN";
            ImprimirCabecalho(projeto);
            ImprimirCorpo(projeto);
            ImprimirProjeto(projeto);
            TextoBranco();
        }
        public static void ImprimeInfo(string nome, string descricao)
        {
            TextoBranco();
            ImprimirLinha();
            TextoAmareloEscuro();
            Console.Write(nome + "  => ");
            TextoAmarelo();
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
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void TextoBranco()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void TextoAmareloEscuro()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        public static void TextoVermelhoPerigo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public static void TextoVermelhoEscuro()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        public static void TextoVerde()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void TextoVerdeEscuro()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public static void TextoAzul()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public static void TextoAzulEscuro()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
    }
}
