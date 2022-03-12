using System.Collections.Generic;
namespace KanbanProject.Models
{
    public class Cliente
    {
        public int IndexProjetoAtual { get; set; }
        public List<Projeto> Projetos { get; set; } = new List<Projeto>();
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public double WIPEspec { get; set; }
        public double WIPImple { get; set; }
        public double WIPRev { get; set; }
        public Cliente()
        {
        }
        public Cliente(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            WIPEspec = 1;
            WIPImple = 1;
            WIPRev = 1;
        }
        public void PrintProjetos()
        {
            int count = 1;
            foreach (var item in Projetos)
            {
                System.Console.WriteLine($"Projeto  {count}: " + item.NomeProjeto);
                System.Console.WriteLine($"Descrição : " + item.Descricao);
                System.Console.WriteLine($"Data inicio : " + item.DataInicio);
                System.Console.WriteLine($"Data Final : " + item.DataFim);
                System.Console.WriteLine($"Responsável : " + item.DonoProduto);
                foreach (var item1 in item.Historias)
                {
                    System.Console.WriteLine($"Historia : " + item1.NomeHistoria);
                    System.Console.WriteLine($"Posicão : " + item1.Posicao);
                    System.Console.WriteLine($"Peso : " + item1.Peso);
                }
                foreach (var item1 in item.Tarefas)
                {
                    System.Console.WriteLine($"Tarefa : " + item1.NomeTarefa);
                    System.Console.WriteLine($"Posicão : " + item1.Posicao);
                    System.Console.WriteLine($"Peso : " + item1.Peso + "\n");
                }
                count++;
            }
        }
        public override string ToString()
        {
            return
                "\n\nNome: " +
                Nome +
                "\n" +
                "Endereço: " +
                Endereco +
                "\n" +
                "Telefone: " +
                Telefone;
        }
    }
}