using System.Threading.Channels;

namespace Course8
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Disponibilidade { get; set; }

        public Pessoa(string nome, int idade, string disponibilidade)
        {
            Nome = nome;
            Idade = idade;
            Disponibilidade = disponibilidade;
        }

        public void Casar(string disponibilidade2)
        {
            if(disponibilidade2 == "Sim" || disponibilidade2 == "sim")
            {
                string casando = "Casando pessoas!";
            }
            else
            {
                string casando = "Casamento não permitido";
            }
        }

        // TODO: Fazer duas pessoas com nomes diferentes casarem!

        public override string ToString()
        {
            Console.WriteLine($"{Nome} e {Nome} estão casando!");
            return null;
        }
    }
}
