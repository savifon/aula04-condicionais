using System;

/*
Faça um programa que lê as duas notas parciais obtidas por um aluno numa disciplina ao longo de um semestre, e calcule a sua média. A atribuição de conceitos obedece à tabela abaixo:
  Média de Aproveitamento  Conceito
  Entre 9.0 e 10.0        A
  Entre 7.5 e 9.0         B
  Entre 6.0 e 7.5         C
  Entre 4.0 e 6.0         D
  Entre 4.0 e zero        E
O algoritmo deve mostrar na tela as notas, a média, o conceito correspondente e a mensagem “APROVADO” se o conceito for A, B ou C ou “REPROVADO” se o conceito for D ou E.
*/

class MainClass {
	public static char CalculaConceito (double n1, double n2) {
		double media = (n1+n2)/2;

		if (media >= 9 && media <= 10)
			return 'A';
		else if (media >= 7.5 && media < 9)
			return 'B';
		else if (media >= 6 && media < 7.5)
			return 'C';
		else if (media >= 4 && media < 6)
			return 'D';
		else
			return 'E';
	}

  public static void Main (string[] args) {
    double n1, n2;

		Console.Write("Informe sua primeira nota: ");
		n1 = double.Parse(Console.ReadLine());

		Console.Write("Informe sua segunda nota: ");
		n2 = double.Parse(Console.ReadLine());

		Console.WriteLine("O seu conceito é: {0}", CalculaConceito(n1, n2));
  }
}