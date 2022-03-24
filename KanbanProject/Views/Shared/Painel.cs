using System;
using System.Linq;
using KanbanProject.Models;
using KanbanProject.Models.Enums;
namespace KanbanProject.Views.Shared
{
    static class Painel
    {
        public static void ImprimirCabecalho(Cliente cliente)
        {
            Console.Clear();
            TextoBranco();
            TextoVermelhoEscuro();
            Console.Write("|*************************************************| QUADRO KANBAN |****************************************************|");
            Console.WriteLine();
            TextoBranco();
            ImprimirLinha();
            Console.Write("|   Backlog                   Especificação                     Implementação                  Revisão de Código       |");
            Console.WriteLine();
            Console.Write($"|               |                   {cliente.WIPEspec}                   |             {cliente.WIPImple}                 |          {cliente.WIPRev}   |               |");
            Console.WriteLine();
            TextoBranco();

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
            int[] aux1 = { 14, 19, 19, 13, 17, 14, 15 }; //definição do tamanho de cada campo do quadro.
            Console.WriteLine("|\t\t|\tem espec.   |    espeficicada\t| em Impleme. |  Implementada\t|\tem rev.| revisada\t|");
            for (int j = 0; j < 6; j++)
            {
                int[] aux2 = { 0, 0, 0, 0, 0, 0, 0 }; //contador de cada objeto lançado na linha de cada fase do quadro.
                Console.Write("| ");
                //ELEMENTOS A SEREM IMPRESSOS NO QUADRO
                TextoVerde();
                foreach (var item in h1)
                {
                    if ((aux1[0] - 3 * aux2[0]) > 3)
                    {
                        Console.Write(item.NomeHistoria + " ");
                        aux2[0]++;
                    }
                    else
                        break;
                }
                if (h1.Count >= aux2[0])
                    h1.RemoveRange(0, aux2[0]);
                TextoBranco();
                for (int i = 0; i < (aux1[0] - 3 * aux2[0]); i++)
                    Console.Write(" ");
                Console.Write("|"); //

                TextoVerde();
                foreach (var item in h2)
                {
                    if ((aux1[1] - 3 * aux2[1]) > 3)
                    {
                        Console.Write(item.NomeHistoria + " ");
                        aux2[1]++;
                    }
                    else
                        break;
                }
                if (h2.Count >= aux2[1])
                    h2.RemoveRange(0, aux2[1]);
                TextoBranco();
                for (int i = 0; i < (aux1[1] - 3 * aux2[1]); i++)
                    Console.Write(" ");
                Console.Write("|"); //mudei

                TextoVerde();
                foreach (var item in h3)
                {
                    if ((aux1[2] - 3 * aux2[2]) > 3)
                    {
                        Console.Write(item.NomeTarefa + " ");
                        aux2[2]++;
                    }
                    else
                        break;
                }
                if (h3.Count >= aux2[2])
                    h3.RemoveRange(0, aux2[2]);
                TextoBranco();
                for (int i = 0; i < (aux1[2] - 3 * aux2[2]); i++)
                    Console.Write(" ");
                Console.Write("|");

                TextoVerde();
                foreach (var item in h4)
                {
                    if ((aux1[3] - 3 * aux2[3]) > 3)
                    {
                        Console.Write(item.NomeTarefa + " ");
                        aux2[3]++;
                    }
                    else
                        break;
                }
                if (h4.Count >= aux2[3])
                    h4.RemoveRange(0, aux2[3]);
                TextoBranco();
                for (int i = 0; i < (aux1[3] - 3 * aux2[3]); i++)
                    Console.Write(" ");
                Console.Write("|");

                TextoVerde();
                foreach (var item in h5)
                {
                    if ((aux1[4] - 3 * aux2[4]) > 3)
                    {
                        Console.Write(item.NomeTarefa + " ");
                        aux2[4]++;
                    }
                    else
                        break;
                }
                if (h5.Count >= aux2[4])
                    h5.RemoveRange(0, aux2[4]);
                TextoBranco();
                for (int i = 0; i < (aux1[4] - 3 * aux2[4]); i++)
                    Console.Write(" ");
                Console.Write("|");

                TextoVerde();
                foreach (var item in h6)
                {
                    if ((aux1[5] - 3 * aux2[5]) > 3)
                    {
                        Console.Write(item.NomeTarefa + " ");
                        aux2[5]++;
                    }
                    else
                        break;
                }
                if (h6.Count >= aux2[5])
                    h6.RemoveRange(0, aux2[5]);
                TextoBranco();
                for (int i = 0; i < (aux1[5] - 3 * aux2[5]); i++)
                    Console.Write(" ");
                Console.Write("|");

                TextoVerde();
                foreach (var item in h7)
                {
                    if ((aux1[6] - 3 * aux2[6]) > 3)
                    {
                        Console.Write(item.NomeTarefa + " ");
                        aux2[6]++;
                    }
                    else
                        break;
                }
                if (h7.Count >= aux2[6])
                    h7.RemoveRange(0, aux2[6]);
                TextoBranco();
                for (int i = 0; i < (aux1[6] - 3 * aux2[6]); i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.WriteLine();
            }
            ImprimirLinha();
        }
        public static void ImprimirProjeto(Projeto projeto)
        {
            ImprimeInfo(projeto.NomeProjeto.ToUpper(), projeto.Descricao.ToUpper());
            Console.WriteLine();
            TextoAmareloEscuro();
            Console.Write("Data:");
            TextoAmarelo();
            Console.Write(projeto.DataInicio);
            TextoAmareloEscuro();
            Console.Write(" - Previsão: ");
            TextoAmarelo();
            Console.WriteLine(projeto.DataFim);
            TextoBranco();
            ImprimirLinha();
            foreach (var item in projeto.Historias)
            {
                ImprimeInfo(item.Peso, item.NomeHistoria, item.Descricao);
            }
            foreach (var item in projeto.Tarefas)
            {
                ImprimeInfo(item.Peso, item.NomeTarefa, item.Descricao);
            }
            TextoBranco();
            Console.WriteLine();
            ImprimirLinha();
        }
        public static void ImprimirTelaPrincipal(Cliente cliente, Projeto projeto)
        {
            Console.Clear();
            Console.SetWindowSize(120, 30);
            Console.Beep();
            Console.Title = "QUADRO KANBAN";
            ImprimirCabecalho(cliente);
            ImprimirCorpo(projeto);
            ImprimirProjeto(projeto);
            Console.WriteLine();
            TextoBranco();
        }
        public static void ImprimeInfo(string nome, string descricao)
        {
            ImpressaoDadosTH(nome, descricao);
        }
        private static void ImpressaoDadosTH(string nome, string descricao)
        {
            TextoVerdeEscuro();
            Console.Write(nome + " => ");
            TextoAmarelo();
            Console.Write(descricao);
            Console.Write(" | ");
        }

        public static void ImprimeInfo(decimal peso, string nome, string descricao)
        {
            TextoBranco();
            Console.Write(peso + " => ");
            ImpressaoDadosTH(nome, descricao);
        }
        //estruturas básicas do layout
        public static void TextoAzul()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public static void TextoVerde()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void TextoBranco()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void TextoAmarelo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void ImprimirLinha()
        {
            for (int i = 0; i < 120; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        public static void TextoAzulEscuro()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        public static void TextoVerdeEscuro()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
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
    }
}
