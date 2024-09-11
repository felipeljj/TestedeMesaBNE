using System;


public class TesteDeMesa2{

    public static void First(){
        //Declaração de variáveis do teste de mesa

        Console.Write("Digite o valor presente: ");
        float valorPresente = float.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite a taxa de juros (sem %): ");
        float taxaJuros = float.Parse(Console.ReadLine() ?? "0")/100;
        Console.Write("Digite o periodo de investimento em meses: ");
        int periodoMes = int.Parse(Console.ReadLine() ?? "0");
        double valorFuturo = 0; //Inicializa com zero para evitar problemas.

        //Calcula o rendimento de um investimento

        valorFuturo = valorPresente * Math.Pow(taxaJuros+1, periodoMes);
        Console.WriteLine($"O rendimento será de {valorFuturo:C2}");

        }

    public static void Second(){



        
    }

}

