using System;
using System.Security.Cryptography.X509Certificates;


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

        //Recebe os valores do usuário
        Console.Write("Digite o valor presente: ");
        float valorPresente = float.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite a taxa de juros (sem %): ");
        float taxaJuros = float.Parse(Console.ReadLine() ?? "0")/100;
        Console.Write("Digite o periodo de investimento em meses: ");
        int periodoMes = int.Parse(Console.ReadLine() ?? "0");
        double Rendimento = 0;
        double rendimentoLiquido = 0;
        double rendaAcumulada = valorPresente;


        //Calcula o rendimento para cada mês e o rendimento acumulado.
    
        Console.WriteLine("--/Mês/--/Taxa Juros/--/Rendimento/--/Rend. Liquido/--/Renda Acumulada/--");
        for(int i = 1; i <= periodoMes; i++){
            
            Rendimento = valorPresente * Math.Pow(taxaJuros+1, i);
            rendimentoLiquido = Rendimento - valorPresente;
            rendaAcumulada += rendimentoLiquido;

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine($"--/ {i} /----/{taxaJuros*100}%/----/{Rendimento:C2}/----/{rendimentoLiquido:C2}/-----/{rendaAcumulada:C2}/-- ");

        }

    }

    public static void Third(){
        //Recebe os valores do usuário
        Console.Write("Digite o valor presente: ");
        float valorPresente = float.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite a taxa de juros (sem %): ");
        float taxaJuros = float.Parse(Console.ReadLine() ?? "0")/100;
        Console.Write("Digite o periodo de investimento em anos: ");
        int periodoAno = int.Parse(Console.ReadLine() ?? "0");
        int periodoMes = periodoAno * 12;
        double Rendimento = 0;

        //Realiza os calculos

        Rendimento = valorPresente * Math.Pow(taxaJuros+1,periodoMes);
        Console.WriteLine($"O rendimento em {periodoAno} anos será de {Rendimento:C2}");



    }

}

