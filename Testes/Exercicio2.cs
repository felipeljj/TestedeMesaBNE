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
        float taxaJuros = (float.Parse(Console.ReadLine() ?? "0")/100)/12;
        Console.Write("Digite o periodo de investimento em anos: ");
        int periodoAno = int.Parse(Console.ReadLine() ?? "0");
        int periodoMes = periodoAno * 12;
        double Rendimento = 0;

        //Realiza os calculos

        Rendimento = valorPresente * Math.Pow(taxaJuros+1,periodoMes);
        Console.WriteLine($"O rendimento em {periodoAno} anos será de {Rendimento:C2}");

    }

    public static void Fourth(){
       //Recebe os valores do usuário
        Console.Write("Digite o valor presente: ");
        double valorPresente = float.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite a taxa de juros (sem %): ");
        float taxaJuros = float.Parse(Console.ReadLine() ?? "0")/100;
        Console.Write("Digite o periodo de investimento em meses: ");
        int periodoMes = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Gostaria de realizar um resgate? (Y/N): ");
        int flagResgate = 0;
        int valorResgate = 0;
        int mesResgate = 0;
        string input = Console.ReadLine() ?? "n";
        if (input.ToUpper() == "Y"){
            Console.Write("Em que mês você quer fazer o resgate?: ");
            mesResgate = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Qual o valor do resgate?: ");
            valorResgate = int.Parse(Console.ReadLine() ?? "0");
            flagResgate=1;
        }
        else{
            Console.WriteLine("Você escolheu não fazer resgate.");
            flagResgate = 0;
        }
        double Rendimento = 0;
        double rendimentoLiquido = 0;
        double rendaAcumulada = valorPresente;
        double saldo = 0;


        //Calcula o rendimento para cada mês e o rendimento acumulado.
    
        Console.WriteLine("--/Valor Presente/----/Mês/--/Taxa Juros/--/Rendimento/-----/Rend. Liquido/---/Resgate/---/Renda Acumulada/----/Saldo/--");
        for(int i = 1; i <= periodoMes; i++){
            
            Rendimento = valorPresente * Math.Pow(taxaJuros+1, i);
            double resgatado;
            if (flagResgate == 1 && i == mesResgate){
                resgatado = valorResgate;
                rendaAcumulada = valorPresente+rendimentoLiquido-resgatado;
                valorPresente = rendaAcumulada;
                rendimentoLiquido = Rendimento - valorPresente;
                saldo = Rendimento-resgatado;

            }
            else{
                Rendimento = valorPresente * Math.Pow(taxaJuros+1, i);
                resgatado = 0;
                rendimentoLiquido = Rendimento - valorPresente;
                rendaAcumulada = valorPresente+rendimentoLiquido;
                saldo = Rendimento;
            }
            
            Console.WriteLine($"--/{valorPresente:C2}/----/ {i} /------/{taxaJuros*100}%/---------/{Rendimento:C2}/------/{rendimentoLiquido:C2}/------/{resgatado:C2}/----{rendaAcumulada:C2}/----/{saldo:C2}/----");

        }




    }
}

