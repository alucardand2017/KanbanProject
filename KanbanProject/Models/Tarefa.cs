using KanbanProject.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanProject.Models
{
    public class Tarefa
    {
        public string NomeTarefa { get; set; }
        public PosicaoKanban Posicao { get; set; }
        public decimal Peso { get; set; }
        public Tarefa()
        {
        }
        public Tarefa(string nomeTarefa, PosicaoKanban posicao, decimal peso)
        {
            NomeTarefa = nomeTarefa;
            Posicao = posicao;
            Peso = peso;
        }
    }
}
