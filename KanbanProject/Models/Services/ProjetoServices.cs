﻿using System;
using System.Threading;
using KanbanProject.Views.Shared;
namespace KanbanProject.Models.Services
{
    class ProjetoServices
    {
        public static void CadastrarProjeto(Cliente cliente)
        {
            string nomeProjeto, descricao;
            DateTime dInicio, dFim;
            Cadastro(out nomeProjeto, out descricao, out dInicio, out dFim);
            bool flagData = true;
            do
            {
                Console.Write("Data de Inicio (dd/MM/YYYY): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime _dataInicio))
                {
                    Console.Write("Previsão de término (dd/MM/YYYY): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime _dataFim) && _dataFim > _dataInicio)
                    {
                        dInicio = _dataInicio;
                        dFim = _dataFim;
                        flagData = false;
                    }
                    else
                        Console.WriteLine("Digite uma data válida. Repita a operação!");
                }
                else
                    Console.WriteLine("Digitação um data válida. Repita a operação!");

            } while (flagData);

            Console.Write("Inserir responsável do produto: ");
            string donoProduto = Console.ReadLine();
            cliente.Projetos.Add(new Projeto(nomeProjeto, descricao, dInicio, dFim, donoProduto));
        }
        private static void Cadastro(out string nomeProjeto, out string descricao, out DateTime dInicio, out DateTime dFim)
        {
            Console.Write("Inserir Nome do Projeto: ");
            nomeProjeto = Console.ReadLine();
            Console.WriteLine("Inserir Descrição do projeto:");
            descricao = Console.ReadLine();
            dInicio = DateTime.Now;
            dFim = DateTime.Now;
        }
        public static void CadastrarProjeto(Projeto projeto)
        {
            string nomeProjeto, descricao;
            DateTime dInicio, dFim;
            Cadastro(out nomeProjeto, out descricao, out dInicio, out dFim);
            bool flagData = true;
            do
            {
                Console.Write("Data de Inicio (dd/MM/YYYY): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime _dataInicio))
                {
                    Console.Write("Previsão de término (dd/MM/YYYY): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime _dataFim) && _dataFim > _dataInicio)
                    {
                        dInicio = _dataFim;
                        dFim = _dataInicio;
                        flagData = false;
                    }
                    else
                    {
                        Painel.TextoVermelhoPerigo();
                        Console.WriteLine("Digitação errada. Repita a operação!");
                        Painel.TextoBranco();
                    }
                }
                else
                {
                    Painel.TextoVermelhoPerigo();
                    Console.WriteLine("Digitação errada. Repita a operação!");
                    Painel.TextoBranco();
                }
            } while (flagData);
            Console.Write("Inserir responsável do produto: ");
            string donoProduto = Console.ReadLine();
        }
        public static int PesquisarGeralProjeto(Cliente cliente)
        {
            int index = 0;
            foreach (var item in cliente.Projetos)
            {
                Console.Write("(" + index + ") - ");
                item.PrintProjeto();
                index++;
            }
            int cont = cliente.Projetos.Count;
            if (cont != 0)
            {
                bool flagProjeto = true;
                Console.WriteLine("Digite o indice do projeto que deseja puxar:");
                for (int i = 0; i < cont; i++)
                    Console.WriteLine($"- ({i})");
                do
                {
                    if (int.TryParse(Console.ReadLine(), out int x) && x < cont && x >= 0)
                    {
                        flagProjeto = false;
                        return x;
                    }
                    else
                    {
                        Console.WriteLine("Digite um número válido dentre os possíveis!");
                    }
                } while (flagProjeto);   
            }
            throw new ArgumentException("Erro grave na pesquisa de projetos!");
        }
        public static void RemoverProjeto(Cliente cliente)
        {
            Painel.TextoAmarelo();
            int resp = PesquisarGeralProjeto(cliente);
            Painel.ImprimirProjeto(cliente.Projetos[resp]);
            Console.WriteLine("Deseja realmente deletar esse projeto? (s/n)");
            char.TryParse(Console.ReadLine(), out char del);
            if (del == 's')
            {
                cliente.Projetos.Remove(cliente.Projetos[resp]);
                cliente.IndexProjetoAtual = 0;
                Painel.TextoVermelhoPerigo();
                Console.WriteLine("Projeto Removido com sucesso!\n");
                Painel.TextoBranco();
            }
            else if (del == 'n')
                return;
            else
            {
                Console.WriteLine("digite um valor válido!");
                return;
            }
        }
        public static void AlterarProjeto(Projeto projeto)
        {
            char cont = '0';
            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção:\n(0) - alterar Informações Gerais (1) - cadastrar Historia (2) - alterar Historia " +
                    "(3) - remover Historia \n(4) - cadastrar Tarefa           (5) - alterar Tarefa     (6) - remover Tarefa   (7) - sair");
                char.TryParse(Console.ReadLine().ToLower(), out cont);
                switch (cont)
                {
                    case '0':
                        Console.Clear();
                        Painel.ImprimeInfo(projeto.NomeProjeto, projeto.Descricao);
                        CadastrarProjeto(projeto);
                        break;
                    case '1':
                        HistoriaService.CadastrarHistoria(projeto);
                        break;
                    case '2':
                        HistoriaService.AlterarHistoria(projeto);
                        break;
                    case '3':
                        HistoriaService.RemoverHistoria(projeto);
                        break;
                    case '4':
                        TarefaService.CadastrarTarefa(projeto);
                        break;
                    case '5':
                        TarefaService.AlterarTarefa(projeto);
                        break;
                    case '6':
                        TarefaService.RemoverTarefa(projeto);
                        break;
                    case '7':
                        break;
                    default:
                        cont = '0';
                        Console.Clear();
                        Console.WriteLine("Digite uma oção válida!");
                        break;
                }
            } while (cont != '7');
        }
    }
}

