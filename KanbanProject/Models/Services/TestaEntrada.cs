
using System;

namespace KanbanProject.Models.Services
{
    static class TestaEntrada
    {
        public static int Inteiro(string escolha)
        {
            if (int.TryParse(escolha, out int j))

                return j;
            else
                throw new ArgumentException("Digite a escolha dentre os números!");
        }
    }
}