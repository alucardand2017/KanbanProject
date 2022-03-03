using System;
using KanbanProject.Controller;
using KanbanProject.Models;
using KanbanProject.Views.Shared;
using KanbanProject.Models.Repositories;
using KanbanProject.Models.Services;
using System.IO;

namespace KanbanProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var cliente = Carregar.CaminhoCarregar();
                var projeto = cliente.Projetos[cliente.IndexProjetoAtual];
                char rodar;
                do
                {
                    Painel.ImprimirTelaPrincipal(cliente.Projetos[cliente.IndexProjetoAtual]);
                    MenuController.MenuPrincipal(cliente, cliente.IndexProjetoAtual);
                    //logica para sair do programa
                    Console.WriteLine("Deseja sair do programa: (s/n)");
                    char.TryParse(Console.ReadLine(), out char escolha);
                    rodar = escolha;
                } while (rodar == 'n');
            }

            catch (IOException e)
            {
                Painel.TextoVermelhoPerigo();
                Console.WriteLine("arquivo não encontrado! - " + e.Message);
            }
            catch (Exception e)
            {
                Painel.TextoVermelhoPerigo();
                Console.WriteLine("Aconteceu alguma exceção! - " + e.Message);
            }
            
        }
    }

}

