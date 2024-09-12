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

    public static void Fourth()
    {
        //Pergunta e recebe os valores do usuário
        Console.Write("Digite o valor presente: ");
        double valorPresente = float.Parse(Console.ReadLine() ?? "0");
        Console.Write("Digite a taxa de juros (sem %): ");
        float taxaJuros = float.Parse(Console.ReadLine() ?? "0") / 100;
        Console.Write("Digite o período de investimento em meses: ");
        int periodoMes = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Gostaria de realizar um resgate? (Y/N): ");
        
        //Declaração de variáveis úteis
        bool flagResgate = false;
        int valorResgate = 0;
        int mesResgate = 0;
        string input = Console.ReadLine() ?? "n";
        double Rendimento = 0;
        double rendimentoLiquido = 0;
        double rendaAcumulada = valorPresente;
        double saldo = -1;
        double contador = 0;
        int index = 1; // Controla o índice dos meses (reseta após o resgate)
        bool resgateEfetuado = false; // Flag para indicar que o resgate foi feito

        //Logica para simular o resgate, se requisitado
        if (input.ToUpper() == "Y")
        {
            Console.Write("Em que mês você quer fazer o resgate?: ");
            mesResgate = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Qual o valor do resgate?: ");
            valorResgate = int.Parse(Console.ReadLine() ?? "0");
            flagResgate = true;
        }
        else
        {
            Console.WriteLine("Você escolheu não fazer resgate.");
            flagResgate = false;
        }

        // Cabeçalho da tabela para organização
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("| Valor Presente | Periodo a.m | Taxa Juros | Rendimento    | Rend. Liquido | Resgate     | Renda Acumulada | Saldo      |");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

        //Loop para iterar a cada mês e realizar o teste de mesa

        for (int i = 1; i <= periodoMes; i++)
        {
            double resgatado = 0;

            if (flagResgate == true && i == mesResgate)
            {
                // Resgate no mês escolhido
                Rendimento = valorPresente * Math.Pow(taxaJuros + 1, contador);
                rendimentoLiquido = Rendimento - valorPresente;
                resgatado = valorResgate;
                saldo = Rendimento - resgatado;
                // Renda acumulada após o resgate (será atualizada na próxima iteração)
                rendaAcumulada = valorPresente + rendimentoLiquido - resgatado;
                // Marca que o resgate foi efetuado, mas o valorPresente será atualizado apenas na próxima iteração
                resgateEfetuado = true;
                index = mesResgate; 
            }
            else
            {
                // Calcula os valores normais
                Rendimento = valorPresente * Math.Pow(taxaJuros + 1, index);
                rendimentoLiquido = Rendimento - valorPresente;
                saldo = Rendimento;
                contador++;
            }
            // Exibe os valores formatados em uma tabela para organização
            Console.WriteLine($"| {valorPresente,14:C2} | {index,10} | {taxaJuros * 100,10}% | {Rendimento,12:C2} | {rendimentoLiquido,13:C2} | {resgatado,10:C2} | {rendaAcumulada,15:C2} | {saldo,10:C2} |");
            
            // Se o resgate foi feito, atualiza o valorPresente na próxima iteração
            if (resgateEfetuado)
            {
                valorPresente = rendaAcumulada;
                resgateEfetuado = false; // Reset da flag
            }
            // Controla o índice (reseta para 1 após o mês de resgate)
            if (index == mesResgate)
            {
                index = 1;
            }
            else
            {
                index++;
            }
        }
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
    }
    
    public static void Fifth(){


    }

}

