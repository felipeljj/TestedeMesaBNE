using System;

public class TesteDeMesa1{

    public static void First(){
        //Declaração de variáveis do teste de mesa
        int a = 10;
        int b = 20;
        int c = (a+b)/2;
        c = c-40;

        //Cria um vetor de sete posições

        int[] v = new int[7];

        //Agora, atribui um valor ao indice 3, conforme pedido no exercicio

        v[3] = a+b+c;

        //Imprimos na tela todas as interações do vetor e definimos as condições do teste.

        for(int i = 0; i<7; i++){

            if( i == 3 && v[i] == 5){
                Console.WriteLine("VERDADEIRO");
            }
            else {
                Console.WriteLine("FALSO");
            }
        }
    }

   public static void Second(){
        //Declaração de variáveis do teste de mesa
        int a = 10;
        int b = 20;
        int c = (a+b)/2;
        c = c-40;

        //Cria um vetor de sete posições

        int[] v = new int[7];

        //Agora, atribui um valor ao indice 3, conforme pedido no exercicio

        v[3] = a+b+c;

        //Imprimos na tela todas as interações do vetor e definimos as condições do teste.

        for(int i = 0; i<7; i++){

            if( i == 3 && v[i] == 5){
                Console.WriteLine("VERDADEIRO");
            }
            else {
                Console.WriteLine("FALSO");
            }
        }
    }

}