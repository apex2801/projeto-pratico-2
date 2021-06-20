using System;

namespace sequenciasPARES_RETANGULOS_
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = "";
            do
            {
                Console.Clear();
                Console.WriteLine("-- projeto pratico --");
                Console.WriteLine("1 - calculadora / 2 - sobre / 3 - sair");

                Console.WriteLine("qual sua opção ? ");


                Console.WriteLine($"voce digitou {opcaoUsuario}.");
                opcaoUsuario = Console.ReadLine();

                if (opcaoUsuario == "1")
                {
                    exibirSequenciasDePares();
                }
                if (opcaoUsuario == "2")
                {
                    exibirRetanguloPreenchido();
                }
                if (opcaoUsuario == "3")
                {
                    Console.WriteLine("sair");
                }
            }
            while (opcaoUsuario == "0");
            {

            }





        }
        static void exibirSequenciasDePares()
        {
            Console.WriteLine("--calculadora--");
            
          
double num1, num2;//variáveis que irão conter os números digitados
            string tmp;

            Console.WriteLine("Digite um número: ");
            tmp = Console.ReadLine();
            num1 = int.Parse(tmp);

            Console.WriteLine("Digite mais um número: ");
            Console.ReadLine();
            num2 = int.Parse(tmp);

            double resultado;

            //realiza a soma e imprime no console
            resultado = num1 + num2;
            Console.WriteLine("Soma: " + resultado);

            //realiza a subtração e imprime no console
            resultado = num1 - num2;
            Console.WriteLine("Subtração: " + resultado);

            //realiza a multiplicação e imprime no console
            resultado = num1 * num2;
            Console.WriteLine("Multiplicação: " + resultado);

            //realiza a divisão e imprime no console
            resultado = num1 / num2;
            Console.WriteLine("Divisão: " + resultado);






            Console.ReadKey();
        }

        static void exibirRetanguloPreenchido()
        {
            Console.WriteLine("sobre");
             
             
             Console.WriteLine("--desenvolvido pelo arthur para a aula PC--");
            
            
            
            Console.ReadKey();
        }


    }
}
