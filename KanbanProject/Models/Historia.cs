using KanbanProject.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanProject.Models
{
    public class Historia
    {
        public string NomeHistoria { get; set; }
        public PosicaoKanban Posicao { get; set; }
        public decimal Peso { get; set; }
        public Historia()
        {
        }
        public Historia(string nomeHistoria, PosicaoKanban posicao, decimal peso)
        {
            NomeHistoria = nomeHistoria;
            Posicao = posicao;
            Peso = peso;
        }
    }
}
