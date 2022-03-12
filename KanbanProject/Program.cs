using System;
using KanbanProject.Controller;
using KanbanProject.Views.Shared;
using KanbanProject.Models.Repositories;
using System.IO;

namespace KanbanProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //carregamento
                string sourceDirectory = @"C:\Temp\DiretorioOrigem";
                string targetDirectory = @"C:\Temp\DiretorioDestino";
                DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
                DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);
                string newSourceFile = BuscandoDiretorio.Verifica(diSource, diTarget);
                var cliente = Carregar.CaminhoCarregar(newSourceFile);
                char rodar;
                var projeto = cliente.Projetos[cliente.IndexProjetoAtual];
                
                
                //loop progama principal
                do
                {
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
                Console.WriteLine("Aconteceu alguma exceção! - " + e.Message);
                Painel.TextoBranco();
            }
        }
        class BuscandoDiretorio
        {
            public static string Verifica(DirectoryInfo source, DirectoryInfo target)
            {
                if (source.FullName.ToLower() == target.FullName.ToLower())
                    throw new ArgumentException("caminho de instalação é o mesmo do de origem");
                // Check if the target directory exists, if not, create it.
                if (Directory.Exists(target.FullName) == false)
                    Directory.CreateDirectory(target.FullName);
                bool flagTarget = false;
                foreach (FileInfo fi in target.GetFiles())
                {
                    if(fi.FullName == target + @"\Data.json")
                    {
                        Console.WriteLine("Arquivo de dados encontrado.");
                        flagTarget = true;
                    }
                }
                if(!flagTarget)
                {
                    File.Copy(source + @"\Data.json", target + @"\Data.json");
                    Console.WriteLine("Criado arquivo Data.Json");
                }
                return target + "/Data.json";
            }

        }
    }
}

