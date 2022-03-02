using KanbanProject.Models.Enums;
namespace KanbanProject.Models
{
    public class Tarefa
    {
        public string NomeTarefa { get; set; }
        public string Descricao { get; set; }
        public PosicaoKanban Posicao { get; set; }
        public decimal Peso { get; set; }
        public Tarefa()
        {
        }
        public Tarefa(string nomeTarefa, string descricao ,PosicaoKanban posicao, decimal peso)
        {
            NomeTarefa = nomeTarefa;
            Descricao = descricao;
            Posicao = posicao;
            Peso = peso;
        }
    }
}
