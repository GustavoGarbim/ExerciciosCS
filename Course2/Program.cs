using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

/*Pedi um desafio um pouco mais avançado para POO baseado no outro sistema bancário, o desafio foi criar a lógica do sistema do 0 e implementar os métodos corretamente.*/

namespace SistemaBancario
{
    class Program
    {
        static List<ContaBancaria> contas = new List<ContaBancaria>();

        static void Main(string[] args)
        {
            string opcaoUsuario = "";
            while (opcaoUsuario.ToUpper() != "S")
            {
                ExibirMenu();
                opcaoUsuario = Console.ReadLine().ToUpper();

                switch (opcaoUsuario)
                {
                    case "1":
                        CriarConta();
                        break;
                    case "2":
                        ListarContas();
                        break;
                    case "3":
                        RealizarDeposito();
                        break;
                    case "4":
                        RealizarSaque();
                        break;
                    case "5":
                        RealizarTransferencia();
                        break;
                    case "L":
                        Console.Clear();
                        break;
                    case "S":
                        Console.WriteLine("Obrigado por utilizar nossos serviços.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }



        private static void ExibirMenu() {
            Console.WriteLine("Selecione a opção 1 para Criar Conta.");
            Console.WriteLine("Selecione a opção 2 para Listar Contas.");
            Console.WriteLine("Selecione a opção 3 para Realizar Deposito.");
            Console.WriteLine("Selecione a opção 4 para Realizar Saque.");
            Console.WriteLine("Selecione a opção 5 para Realizar Transferencia.");
            Console.WriteLine("Selecione a opção L para Limpar o Console.");
            Console.WriteLine("Selecione a opção S para fechar nosso sistema.");
        }
        private static void CriarConta()
        {
            Console.WriteLine("--- Criação de Nova Conta ---");

            Console.Write("Digite o Nome do Titular: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o tipo de conta (0 para Corrente, 1 para Poupança): ");
            int tipoSelecionadoInt = int.Parse(Console.ReadLine());

            TipoConta tipoConta;
            if (tipoSelecionadoInt == 1)
            {
                tipoConta = TipoConta.Poupanca;
            }
            else
            {
                tipoConta = TipoConta.Corrente;
            }

            Console.Write("Deseja fazer um depósito inicial? (s/n): ");
            string resp = Console.ReadLine().ToLower();

            double saldoInicial = 0;
            if (resp == "s")
            {
                Console.Write("Digite o valor do depósito inicial: R$");
                saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            ContaBancaria novaConta = new ContaBancaria(nome, tipoConta, saldoInicial);

            contas.Add(novaConta);

            Console.WriteLine("Conta criada com sucesso!");
            Console.WriteLine(novaConta);
        }
        private static void ListarContas() {
            if (contas.Count == 0)
            {
                Console.WriteLine("A lista de contas está vazia!");
            }
            else
            {
                foreach (var conta in contas)
                {
                    Console.WriteLine(conta);
                }
            }
        }
        private static void RealizarDeposito() {
            Console.Write("Digite o numero da conta do deposito: ");
            int num = int.Parse(Console.ReadLine());
            ContaBancaria contaParaDepositar = EncontrarConta(num);
            if (contaParaDepositar == null)
            {
                Console.WriteLine("Conta não encontrada!");
            }
            else
            {
                Console.Write("Digite o valor para deposito: R$");
                double valor2 = double.Parse(Console.ReadLine());
                contaParaDepositar.Depositar(valor2);
            }
        }
        private static void RealizarSaque(){
            Console.Write("Digite o numero da conta de saque: ");
            int num = int.Parse(Console.ReadLine());
            ContaBancaria contaParaSacar = EncontrarConta(num);
            if (contaParaSacar == null)
            {
                Console.WriteLine("Conta não encontrada!");
            }
            else
            {
                Console.Write("Digite o valor para saque: R$");
                double valor2 = double.Parse(Console.ReadLine());
                contaParaSacar.Sacar(valor2);
            }
        }
        private static void RealizarTransferencia() {
            Console.WriteLine("------Transferencia bancaria------");
            Console.Write("Digite o numero da conta de Origem: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da transferencia: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o numero da conta de Destino: ");
            int num2 = int.Parse(Console.ReadLine());

            ContaBancaria contaOrigemTrans = EncontrarConta(num1);
            ContaBancaria contaDestinoTrans = EncontrarConta(num2);

            if (contaOrigemTrans == null && contaDestinoTrans == null)
            {
                Console.WriteLine("Conta não encontrada!");
            }
            else
            {
                Console.Write("Digite o valor a ser transferido: ");
                contaOrigemTrans.Sacar(valor1);
                contaDestinoTrans.Depositar(valor1);
            }
        }
        private static ContaBancaria EncontrarConta(int numeroConta) {
            foreach (var i in contas)
            {
                if (i.NumeroConta == numeroConta)
                {
                    return i;
                }
            }
            return null;
        }
    }
}