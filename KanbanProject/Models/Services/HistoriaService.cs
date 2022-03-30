using System;
using KanbanProject.Models.Enums;
using KanbanProject.Views.Shared;

namespace KanbanProject.Models.Services
{
    class HistoriaService
    {
        public static void CadastrarHistoria(Projeto projeto)
        {
            ListaHistorias(projeto);
            string nome, descricao, posicao;
            Cadastro(out nome, out descricao, out posicao);
            decimal peso = decimal.Parse(Console.ReadLine());
            projeto.Historias.Add(new Historia(nome, descricao, Enum.Parse<PosicaoKanban>(posicao), peso));
        }

        private static void Cadastro(out string nome, out string descricao, out string posicao)
        {
            Console.Clear();
            Console.WriteLine($"Nome da Historia (por ex. H1, HA): ");
            var nomeFatiado = Console.ReadLine().ToCharArray();
            nome = nomeFatiado[0].ToString() + nomeFatiado[1].ToString();
            Console.WriteLine("Descreva rapidamente a historia:");
            descricao = Console.ReadLine();
            Console.WriteLine("Digite a posição da historia: " +
            "(1) - Backlog\n" +
            "(2) - Especificando\n");
            posicao = Console.ReadLine();
            Console.Write("Qual o peso dessa historia: ");
        }

        public static void CadastrarHistoria(Projeto projeto, int index)
        {
            string nome, descricao, posicao;
            Cadastro(out nome, out descricao, out posicao);
            decimal peso = decimal.Parse(Console.ReadLine());
            projeto.Historias[index].NomeHistoria = nome;
            projeto.Historias[index].Descricao = descricao;
            projeto.Historias[index].Posicao = Enum.Parse<PosicaoKanban>(posicao);
            projeto.Historias[index].Peso = peso;
        }
        private static void ListaHistorias(Projeto projeto)
        {
            Console.Write($"Histórias atuais: ");
            foreach (var item in projeto.Historias)
            {
                Console.Write("-" + item.NomeHistoria);
            }
            Console.WriteLine();
        }
        internal static void AlterarHistoria(Projeto projeto)
        {
            int index = HistoriaService.PesquisarHistorias(projeto);
            HistoriaService.CadastrarHistoria(projeto, index);
            Console.WriteLine("Alteração realizada com sucesso!");
        }
        internal static void RemoverHistoria(Projeto projeto)
        {
            var h = PesquisarHistorias(projeto);
            Console.WriteLine(projeto.Historias[h].NomeHistoria + " => " + projeto.Historias[h].Descricao);
            Console.WriteLine("Deseja realmente excluir essa história");
            char.TryParse(Console.ReadLine(), out char escolha);
            if (escolha == 's')
            {
                projeto.Historias.Remove(projeto.Historias[h]);
                Painel.TextoVermelhoPerigo();
                Console.WriteLine("Historia Removida com sucesso!\n");
                Painel.TextoBranco();
            }
            else if (escolha == 'n')
                return;
            else
            {
                Console.WriteLine("digite um valor válido!");
                return;
            }
        }
        public static int PesquisarHistorias(Projeto projeto)
        {
            ListaHistorias(projeto);
            Console.WriteLine("Qual o nome da história que deseja?");
            string nome = Console.ReadLine().Trim().ToUpper();
            int i = projeto.Historias.FindIndex(p => p.NomeHistoria == nome);
            if (i < 0 || i > projeto.Historias.Count)
            {
                Console.WriteLine("Historia não encontrada, retornando melhor resultado.");
                return 0;
            }
            else
                return i;
        }
    }
}
