using System;

class Program{

    static void Main(){
        //Cria um menu simples para navegação entre os testes.
        Console.WriteLine("Teste de mesa. Digite a opção desejada:" +
        "\n1) Primeiro teste (exercicio 1)" +
        "\n2) Segundo teste (exercicio 1)"+
        "\n3) Terceiro teste (exercicio 1)"+
        "\n4) Primeiro teste (exercicio 2)");

        //lê a entrada do teclado e a converte para int32
        int index = Convert.ToInt32(Console.ReadLine());

        //Define que código executar a depender da entrada.
        switch(index){
            case 1:
                Console.WriteLine("Resultado:");
                TesteDeMesa1.First();
                break;

            case 2:
                Console.WriteLine("Resultado:");
                TesteDeMesa1.Second();
                break;

            case 3:
                Console.WriteLine("Resultado:");
                TesteDeMesa1.Third();
                break;
            case 4:
                Console.WriteLine("Resultado:");
                TesteDeMesa2.First();
                break;
        }



    }
}
