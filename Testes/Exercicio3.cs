using System;
using System.Reflection;


namespace calculadoraInvestimentos{

    class TesteDeMesa3(){

        //Exercicio 1, sem orientação à objetos
        public static void First(){

            //Recebe dados do usuário
            Console.Write("Digite o valor presente: ");
            double valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a taxa de juros (sem %): ");
            double taxaJuros = (Convert.ToDouble(Console.ReadLine())/100);

            //Define mês e dia

            int mes = 8;
            int dia = 10;

            //Converte mes + dias em meses

            double meses = mes + (dia/30.0);
            
            //Calcula rendimento

            double rendimento = valorPresente * Math.Pow(1+taxaJuros, meses);

            Console.WriteLine($"O rendimento após {mes} meses e {dia} dias será de {rendimento:C2}");

        }


    }

    //Exercicios C# POO
    class TesteDeMesa3POO{
        public static void Second(){
            Console.WriteLine("Investimento com resgate de rendimentos");
            Console.Write("Digite o valor presente: ");
            double valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a taxa de juros (sem %): ");
            double taxaJuros = (Convert.ToDouble(Console.ReadLine())/100);
            Console.Write("Digite o periodo de investimento (em meses): ");
            int periodoMeses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de resgate: ");
            double resgate = Convert.ToDouble(Console.ReadLine());

            //Cria um novo objeto calculadora de investimento
            calculadoraInvestimento calculadora = new calculadoraInvestimento(valorPresente, taxaJuros, resgate);

            //Formata o cabeçalho da tabela

            Console.WriteLine("\nResultados:");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| Mês   |   Rendimento   | Resgate Parcial | Saldo Líquido | Rendimento Restante | Saldo Restante |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            //Realiza logica necessária

            for (int i = 1; i <= periodoMeses; i++){
                double rendimento = calculadora.rendimentoMensal();
                double saldoLiquido = calculadora.saldoLiquido(i);

                if (i == 5){ //Se for mes 5, realiza resgate
                    saldoLiquido -= resgate;
                    rendimento -= resgate;
                }
                Console.WriteLine($"| {i,-5} | {rendimento,-14:C2} | {(i == 5 ? resgate : 0),-15:C2} | {saldoLiquido,-13:C2} | {(i == 5 ? rendimento : calculadora.rendimentoRestante(i + 1)), -19:C2} | {(i == 5 ? saldoLiquido + rendimento : calculadora.saldoRestante(i + 1)), -14:C2} |");
            }
            
        }

        public static void Third(){
        {
            // Exibe o título e lê as entradas do usuário
            Console.WriteLine("Investimento com resgate de rendimentos");
            Console.Write("Digite o valor presente: ");
            double valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a taxa de juros (em %): ");
            double taxaJuros = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.Write("Digite o período de investimento (em meses): ");
            int periodoMeses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de resgate: ");
            double resgate = Convert.ToDouble(Console.ReadLine());

            // Cria um novo objeto CalculadoraInvestimento
            calculadoraInvestimento calculadora = new calculadoraInvestimento(valorPresente, taxaJuros, resgate);

            // Formata o cabeçalho da tabela
            Console.WriteLine("\nResultados:");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("| Valor Investido | Taxa de Juros | Rendimento   | Período (a.m.) | Resgate  | Saldo Líquido |");
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // Realiza a lógica e exibe os resultados
            for (int i = 1; i <= periodoMeses; i++)
            {
                double rendimento = calculadora.rendimentoMensal();
                double saldoLiquido = calculadora.saldoLiquido(i);
                double saldoRestante = calculadora.saldoRestante(i);

                // Aplica o resgate no 5º mês
                if (i == 5)
                {
                    saldoLiquido -= resgate;
                }

                // Exibe os valores formatados
                Console.WriteLine($"| {valorPresente,-16:C2} | {taxaJuros ,-12:P0} | {rendimento,-12:C2} | {i,-14} | {(i == 5 ? resgate : 0),-8:C2} | {saldoLiquido,-13:C2} |");
            }
            Console.WriteLine("-------------------------------------------------------------------");
        }
    }

    //Define a calculadora como objeto

    class calculadoraInvestimento{
        private double valorPresente;
        private double taxaJuros; //Taxa de juros mensal
        private double resgate;

        //Define o método construtor

        public calculadoraInvestimento (double valorPresente, double taxaJuros, double resgate){
            this.valorPresente = valorPresente;
            this.taxaJuros = taxaJuros;
            this.resgate = resgate;
        }

        //Metodos da classe

        public double rendimentoMensal(){
            return valorPresente * taxaJuros;
        }

        public double saldoLiquido(int meses){
            double rendimentoTotal = 0;
                for (int i =0; i <= meses; i++){
                    rendimentoTotal += valorPresente * taxaJuros;            
                }
            return valorPresente + rendimentoTotal;
        }

        public double rendimentoRestante(int meses){
            double rendimentoTotal = 0;
            for (int i = 1; i<= meses; i++){
                rendimentoTotal += valorPresente *taxaJuros;
            }
            return rendimentoTotal - resgate;
        }

        public double saldoRestante(int meses){
            double rendimentoTotal = 0;
            for (int i = 1; i<= meses; i++){
                rendimentoTotal += valorPresente*taxaJuros;
            }
            return valorPresente + rendimentoTotal - resgate;
        }

    }
    }
}


