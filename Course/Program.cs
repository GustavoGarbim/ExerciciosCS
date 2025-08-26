using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria();

            Console.WriteLine("------GarbimBank------");

            Console.Write("Entre com o número da conta: ");
            string numconta = (Console.ReadLine());
            contaBancaria.AdicionarNumConta(numconta); // método para adicionar numero da conta

            Console.Write("Entre com o nome do proprietário da conta: ");
            string nomeconta = Console.ReadLine();
            contaBancaria.AdicionarNome(nomeconta); // método para adicionar nome na conta

            Console.Write("Deseja adicionar um saldo inicial na conta? (s/n): ");
            string perg = Console.ReadLine();

            if (perg == "s")
            {
                Console.Write("Digite a quantia inicial: R$");
                int resp = int.Parse(Console.ReadLine());
                contaBancaria.AdicionarSaldoConta(resp); // método para adicionar saldo na conta
            }
            else
            {
                Console.WriteLine("Carregando...");
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Bem vindo {contaBancaria.Nome}!, sua agência é: {contaBancaria.NumConta} e seu saldo atual é de: {contaBancaria.SaldoConta}$");

            Console.Write($"Entre com um valor para depósito sr(a) {contaBancaria.Nome}: R$:");
            float dep = float.Parse(Console.ReadLine());
            contaBancaria.DepositoConta(dep); // método para realizar deposito na conta

            Console.WriteLine($"Valor total depositado: R$:{dep} | Valor Total conta: R$:{contaBancaria.SaldoConta}");

            Console.Write("Entre com um valor de saque: ");
            float saq = float.Parse(Console.ReadLine());
            Console.WriteLine($"Saque de R$:{saq} realizado! Taxa de 5$ adicionada.");
            contaBancaria.SaqueConta(saq); // método para retirar saldo da conta
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Sistema finalizado!");
            Console.WriteLine($"Dados atualizados: Nome: {contaBancaria.Nome}, Número bancário: {contaBancaria.NumConta}, Saldo da conta: R${contaBancaria.SaldoConta}");
        }
    }
}