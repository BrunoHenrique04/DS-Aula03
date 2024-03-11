using System;
using System.Collections.Generic;
using Aula03Colecoes.Models;
using Aula03Colecoes.Models.Enuns;


namespace Aula03Colecoes
{
    
    class Teste
    {
         static List<Funcionario> lista = new List<Funcionario>();
            static void Main(string[] args) 
            {
               
                //CriarLista();
                //ExibirLista();
                ExemplosListasColecoes();
                

            }

        public static void CriarLista()
        {
            Funcionario f1 = new Funcionario();
            f1.Id = 1;
            f1.Nome = "Duds";
            f1.Cpf = "1234567891011";
            f1.Datadeadimissao = DateTime.Parse("01/01/2000");
            f1.Salario = 100.000M;
            f1.Tipofuncionario = TipofuncionarioEnum.clt;
            lista.Add(f1);

            Funcionario f2 = new Funcionario();
            f2.Id = 2;
            f2.Nome = "João";
            f2.Cpf = "1234567891012";
            f2.Datadeadimissao = DateTime.Parse("10/12/2010");
            f2.Salario = 150.000M;
            f2.Tipofuncionario = TipofuncionarioEnum.aprendiz; 
            lista.Add(f2);

            Funcionario f3 = new Funcionario();
            f3.Id = 3;
            f3.Nome = "Maria";
            f3.Cpf = "1234567891013";
            f3.Datadeadimissao = DateTime.Parse("20/07/2018"); 
            f3.Salario = 120.000M; 
            f3.Tipofuncionario = TipofuncionarioEnum.clt;
            lista.Add(f3);

            Funcionario f4 = new Funcionario();
            f4.Id = 4;
            f4.Nome = "José";
            f4.Cpf = "1234567891014";
            f4.Datadeadimissao = DateTime.Parse("11/10/2019");
            f4.Salario = 80.000M; 
            f4.Tipofuncionario = TipofuncionarioEnum.aprendiz;
            lista.Add(f4);

            Funcionario f5 = new Funcionario();
            f5.Id = 5;
            f5.Nome = "Ana";
            f5.Cpf = "1234567891015";
            f5.Datadeadimissao = DateTime.Parse("04/05/2017"); 
            f5.Salario = 110.000M;
            f5.Tipofuncionario = TipofuncionarioEnum.clt;
            lista.Add(f5);

            Funcionario f6 = new Funcionario();
            f6.Id = 6;
            f6.Nome = "Pedro";
            f6.Cpf = "1234567891016";
            f6.Datadeadimissao = DateTime.Parse("30/09/2016"); 
            f6.Salario = 95.000M; 
            f6.Tipofuncionario = TipofuncionarioEnum.aprendiz; 
            lista.Add(f6);


        }

        public static void ExibirLista()
        {
            string dados = "";

            for(int i=0; i < lista.Count; i++)
            {
                dados += "=====================================\n";
                dados += string.Format("Id: {0}\n", lista[i].Id);
                dados += string.Format("Nome: {0 \n}", lista[i].Nome);
                dados += string.Format("CPF: {0} \n", lista[i].Cpf);
                dados += string.Format("Adimissão: {0:dd/mm/yyyy}");
                dados += string.Format("Salário: {0:c2} \n ", lista[i].Salario);
                dados += string.Format("Tipo: {0} \n", lista[i].Tipofuncionario);
                dados += "=====================================\n";
                        
             
            }

        }

        public static void ObterPorId(int id)
        {
            Funcionario fBusca = lista.Find(x => x.Id == id);
            
            Console.WriteLine($"Personagem encontrado: {fBusca.Nome}");
        }

        public static void ExemplosListasColecoes()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("****** Exemplos - Aula 03 Listar e Coleções ******");
            Console.WriteLine("==================================================");
            CriarLista();
            int opcaoEcolhida = 0;

            do
            {
                Console.WriteLine("==================================================");
                Console.WriteLine("---Digite o número referente a opção desejada: ---");
                Console.WriteLine("1 - Obter Por Id");
                Console.WriteLine("2 - Adicionar funcionário");
                Console.WriteLine("3 - Obter Por Id digitado");
                Console.WriteLine("4 - Obter Por Salário digitado");
                Console.WriteLine("5 - Obter Por Nome");
                Console.WriteLine("==================================================");
                Console.WriteLine("-----Ou tecle qualquer outro número para sair-----");
                Console.WriteLine("==================================================");

                opcaoEcolhida = int.Parse(Console.ReadLine());
                string mensagem = string.Empty;
                switch (opcaoEcolhida)
                {
                    case 1:
                        Console.WriteLine("Digite o Id funcionário que você deseja buscar");
                        int a = int.Parse(Console.ReadLine());
                        ObterPorId(a);
                        break;
                    case 2:
                        AdicionarFuncionario();
                        break;
                    case 3:
                        Console.WriteLine("Digite o Id funcionário que você deseja buscar");
                        int id = int.Parse(Console.ReadLine());
                        ObterPorId(id);
                        break;
                    case 4:
                        Console.WriteLine("Digite o salário para obter todos acima do valor indicado: ");
                        decimal salario = decimal.Parse(Console.ReadLine());
                        ObterPorSalario(salario);
                        break;
                    case 5:
                        Console.WriteLine("Digite o nome para obter o funcionario: ");
                        string nome = Console.ReadLine();
                        ObterPorNome(nome);
                        break;
                    default:
                        Console.WriteLine("Saindo do sistema....");
                        break;
                }
            } while (opcaoEcolhida >= 1 && opcaoEcolhida <= 100);

            Console.WriteLine("===================================================");
            Console.WriteLine("* Obrigado por ultilizar o sistema e volte sempre *");
            Console.WriteLine("===================================================");

        }

        public static void AdicionarFuncionario()
        {
            Funcionario f = new Funcionario();
            
            Console.WriteLine("Digite o nome: ");
            f.Nome = Console.ReadLine();
            
            Console.WriteLine("Digite o Salário");
            f.Salario = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a data de admissão: ");
            f.Datadeadimissao = DateTime.Parse(Console.ReadLine()); //TODO: CORRIGIR O DATE TIME QUE NÃO ESTA FUNCIONANDO

            if (string.IsNullOrEmpty(f.Nome))
            {
                Console.WriteLine("O nome deve ser preenchido");
                return;
            }
            else if (f.Salario == 0)
            {
                Console.WriteLine("Valor do salário não pode ser 0");   
                return;
            }
            else
            {
                lista.Add(f);
                ExibirLista();
            }

        
        }

        public static void ObterPorSalario(decimal valor) //TODO: OBTER POR SALARIO NÃO ESTA FUNCIONANDO
        {
            lista = lista.FindAll(x => x.Salario >= valor);
            ExibirLista();
        }

        public static void ObterPorNome(string nome)
        {

            if (lista.Find(X => X.Nome == nome) != null)
            {
                Funcionario fBusca = lista.Find(x => x.Nome == nome);
                Console.WriteLine($"Personagem encontrado: {fBusca.Nome}");
            }
            else
            {
                Console.WriteLine("Funcionario não foi encontrado!!");
            }
           
        }

        
    }


}