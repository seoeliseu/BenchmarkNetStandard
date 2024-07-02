namespace BenchmarkTests
{
    public class Funcionario(string nome, int idade,
                       double salario, DateTime dataNascimento,
                       string endereco, string bairro, string cidade)
    {
        public string Nome { get; set; } = nome;
        public int Idade { get; set; } = idade;
        public double Salario { get; set; } = salario;
        public DateTime DataNascimento { get; set; } = dataNascimento;
        public string Endereco { get; set; } = endereco;
        public string Bairro { get; set; } = bairro;
        public string Cidade { get; set; } = cidade;
    }
}
