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
        public string Descricao { get; set; }
        public PosicaoKanban Posicao { get; set; }
        public decimal Peso { get; set; }
        public Historia()
        {
        }
        public Historia(string nomeHistoria,string descricao , PosicaoKanban posicao, decimal peso)
        {
            NomeHistoria = nomeHistoria;
            Descricao = descricao;
            Posicao = posicao;
            Peso = peso;
        }
    }
}
