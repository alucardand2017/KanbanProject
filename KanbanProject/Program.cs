using System;
using KanbanProject.Controller;
using KanbanProject.Views.Shared;
using KanbanProject.Models.Repositories;
using System.IO;
using KanbanProject.Models;
using System.Threading;

namespace KanbanProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //carregamento
                string fileName = @"\Data.json";
                string targetDirectory = @"D:\ANDERSON\EstudoCSharp\Kanban\KanbanProject\KanbanProject\DiretorioOrigem";
                DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);             
                string newSourceFile = BuscandoDiretorio.Verifica(fileName, diTarget);
                var cliente = Carregar.CaminhoCarregar(newSourceFile);
                char rodar;
                var projeto = cliente.Projetos[cliente.IndexProjetoAtual];
                do
                {
                    Console.Clear();
                    Painel.ImprimirTelaPrincipal(cliente, cliente.Projetos[cliente.IndexProjetoAtual]);
                    MenuController.MenuPrincipal(newSourceFile, cliente, cliente.IndexProjetoAtual);
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
                Painel.TextoBranco();
            }
            catch (Exception e)
            {
                Painel.TextoVermelhoPerigo();
                Console.WriteLine("Aconteceu alguma exceção! - " + e.Message +"\n\n"+ e.StackTrace);
                Painel.TextoBranco();
            }
        }
        class BuscandoDiretorio
        {
            public static string Verifica(string fileName,  DirectoryInfo target)
            {
                
                // Check if the target directory exists, if not, create it.
                if (File.Exists(target.FullName + fileName) == false)                {
                    Directory.CreateDirectory(target.FullName);
                    File.Create(target.FullName + fileName).Close();    
                }
                MenuController.VerificandoBancoDeDados(target.FullName + fileName);
                return (target.FullName + fileName);
            }
        }
    }
}

