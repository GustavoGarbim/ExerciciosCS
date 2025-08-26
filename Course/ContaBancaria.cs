using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
namespace Course
{
    class ContaBancaria()
    {
        public string Nome;
        public string NumConta;
        public float SaldoConta;


        public void AdicionarNome(string nome)
        {
            Nome = nome;
        }

        public void AdicionarNumConta(string numConta) {
            NumConta = numConta;
        }

        public void AdicionarSaldoConta(int saldoConta)
        {
            SaldoConta = saldoConta;
        }

        public void DepositoConta(float depConta)
        {
            SaldoConta += depConta;
        }

        public void SaqueConta(float saqueConta)
        {
            SaldoConta -= saqueConta + 5;
        }
    }
}