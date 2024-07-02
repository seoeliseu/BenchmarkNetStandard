using System.Diagnostics;

namespace BenchmarkTests
{
    public class AnyCountExists
    {
        public static void ExecuteTest()
        {
            TestWithNumberOfRegister(10000);
            TestWithNumberOfRegister(100000);
            TestWithNumberOfRegister(1000000);
            TestWithNumberOfRegister(10000000);
        }

        private static void TestWithNumberOfRegister(int number)
        {
            var funcionarios = new List<Funcionario>();
            for (int i = 0; i < number; i++)
            {
                funcionarios.Add(new Funcionario("Funcionario " + i, i, 1000 + i, DateTime.Now.AddYears(-10), "Endereco " + i, "Bairro " + i, "Cidade " + i));
            }

            Console.WriteLine($"Test with {number} registers\n");

            var swAny = new Stopwatch();
            swAny.Start();
            var any = funcionarios.Any(f => f.Nome == "Funcionario 99999");
            swAny.Stop();
            Console.WriteLine($"Any: {swAny.ElapsedTicks} ticks\n");

            var swExists = new Stopwatch();
            swExists.Start();
            var exists = funcionarios.Exists(f => f.Nome == "Funcionario 99999");
            swExists.Stop();
            Console.WriteLine($"Exists: {swExists.ElapsedTicks} ticks\n");

            var swCount = new Stopwatch();
            swCount.Start();
            var encontrou = funcionarios.Count(f => f.Nome == "Funcionario 99999") == 1;
            swCount.Stop();
            Console.WriteLine($"Count: {swCount.ElapsedTicks} ticks\n");

            Console.WriteLine("--------------------------------------------------\n");
        }
    }
}
