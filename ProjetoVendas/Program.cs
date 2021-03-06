﻿using System;
using System.Collections.Generic;

namespace ProjetoVendas
{
    class Program
    {
        static void Main(string[] args)
        {

            int op = 1, Cpf = 0;
            string Nome = null;

            List<string> cliente = new List<string>();

            Console.WriteLine("Projeto Vendas - MENU");

            while( op != 0)
            {

                Console.Clear();
                Console.WriteLine("\n1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Cliente");
                Console.WriteLine("3 - Cadastrar Vendedor");
                Console.WriteLine("4 - Listar Vendedores");
                Console.WriteLine("5 - Cadastrar Produto");
                Console.WriteLine("6 - Listar Produtos");
                Console.WriteLine("7 - Registrar Venda");
                Console.WriteLine("8 - Listar Vendas");
                Console.WriteLine("9 - Listar Vendas por Cliente");
                Console.WriteLine("0 - Sair");

                Console.Write("\nEscolha uma opção: ");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {

                    case 1:

                        Cliente c = new Cliente();

                        Console.WriteLine("\nCadastro de Clientes.");

                        Console.WriteLine("\nDigite seu nome: ");
                        c.Nome = Console.ReadLine();

                        Console.WriteLine("\nDigite seu CPF: ");
                        c.Cpf = Console.ReadLine();

                        Console.WriteLine($"\nNome: {c.Nome}. CPF: {c.Cpf} ");

                        break;
                    case 2:

                        Console.WriteLine("\nListagem de Clientes.");

                        break;
                    case 3:

                        Funcionario f = new Funcionario();

                        Console.WriteLine("\nCadastro de Funcionários.");

                        Console.WriteLine("\nDigite seu nome: ");
                        f.Nome = Console.ReadLine();

                        Console.WriteLine("\nDigite seu CPF: ");
                        f.Cpf = Console.ReadLine();

                        Console.WriteLine($"\nNome: {f.Nome}. CPF: {f.Cpf} ");

                        break;
                    case 4:

                        Console.WriteLine("\nListagem de Funcionários.");

                        break;
                    case 5:

                        Produtos p = new Produtos();

                        Console.WriteLine("\nCadstro de Produtos.");

                        Console.WriteLine("\nDigite seu nome: ");
                        p.Nome = Console.ReadLine();

                        Console.WriteLine("\nDigite o valor: ");
                        p.Preco = Console.ReadLine();

                        Console.WriteLine("\nDigite a quantidade: ");
                        p.Quantidade = Console.ReadLine();

                        Console.WriteLine($"\nNome: {p.Nome}. Valor: R${p.Preco}. Quantidade: {p.Quantidade} ");

                        break;
                    case 6:

                        Console.WriteLine("\nListagem de Produtos.");

                        break;
                    case 7:

                        Console.WriteLine("\nRegistrar Venda.");

                        break;
                    case 8:

                         Console.WriteLine("\nRegistro de Venda.");

                        break;
                    case 9:

                        Console.WriteLine("\nRegistro de Vendas por Cliente.");

                        break;
                    case 0:

                        Console.WriteLine("\nFechando programa.");

                         break;
                    default:

                        Console.WriteLine("\nVocê escolheu uma opção inválida, tente novamente.");

                        break;

                    }


                Console.WriteLine("\nPrescione uma tela para continuar.");
                Console.ReadKey();

            }

        }
    }
}
