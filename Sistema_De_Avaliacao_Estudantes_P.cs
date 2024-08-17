  using System;
  using System.Collections.Generic;
  using System.Linq;

  class Program
  {
      static void Main(string[] args)
      {
          List<decimal> Notas = new List<decimal>();

          while (true)
          {
              // Entrada de Dados: 
              Console.WriteLine("Digite o nome do aluno, por gentileza");
              string name_Aluno = Console.ReadLine();

              Console.WriteLine("Digite a idade do aluno, por gentileza");
              int idade = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("Digite a nota do aluno em Português:");
              decimal nota_Portugues = Convert.ToDecimal(Console.ReadLine());

              Console.WriteLine("Digite a nota do aluno em Matemática");
              decimal nota_Matematica = Convert.ToDecimal(Console.ReadLine());

              Console.WriteLine("O aluno possui bolsa de estudos? *Digite somente (sim/não)");
              bool bolsa = Console.ReadLine().ToLower() == "sim";

              // Processamento de Dados:
              Notas.Add(nota_Portugues);
              Notas.Add(nota_Matematica);

              decimal media = (nota_Portugues + nota_Matematica) / 2;
              string resultado = media >= 6.0m ? "Aprovado" : "Reprovado";
              Console.WriteLine($"\nO aluno {name_Aluno} está {resultado}.");

              if (bolsa && media < 8.0m)
              {
                  Console.WriteLine("O aluno perdeu a bolsa de estudos.");
              }

              // Exibição das diferentes representações do nome do aluno
              foreach (char c in name_Aluno)
              {
                  string unicodeRepresent = $"\\u{(int)c:X4}";
                  string hexadRepresent = $"\\x{(int)c:X2}";
                  Console.WriteLine($"A representação do caractere '{c}' em modo literal é: {c}");
                  Console.WriteLine(unicodeRepresent);
                  Console.WriteLine(hexadRepresent);
              }

              // Opção para adicionar outro aluno: 
              Console.Write("\nDeseja adicionar outro aluno? (sim/não): ");
              if (Console.ReadLine().ToLower() != "sim")
              {
                  break;
              }

              Console.Clear(); // Limpa a tela para facilitar a leitura dos dados do próximo aluno.
          }

          // Cálculo Final
          decimal mediaFinal = Notas.Average();
          Console.WriteLine($"\nA média das notas de todos os alunos cadastrados é: {mediaFinal:F2}");
      }
  }
