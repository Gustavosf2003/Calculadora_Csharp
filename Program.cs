using System;

namespace calculator
{
    class Program
    {

        static void Main(string[] args)
        {

            Menu();


        }


        static void Menu()
        {

            Console.Clear();

            Console.WriteLine(" Operadores Possíveis");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("5- Potência");
            Console.WriteLine("6- Sair");
            Console.WriteLine("");


            Console.WriteLine(" Selecione uma opção:");
            short result = short.Parse(Console.ReadLine());

            switch (result)
            {

                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Potencia(); break;
                case 6: Fechar(); break;
                default: Menu(); break;


            }


        }

        static void Soma()
        {

            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());



            float resultado = v1 + v2;

            Console.WriteLine("");
            Console.WriteLine("O resultado é: " + resultado);
            Console.ReadKey();

            Menu();


        }


        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());




            float resultado = v1 - v2;

            Console.WriteLine("");
            Console.WriteLine("O resultado é: " + resultado);
            Console.ReadKey();


            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());




            float resultado = v1 * v2;

            Console.WriteLine("");
            Console.WriteLine("O resultado é: " + resultado);
            Console.ReadKey();
            Menu();
        }



        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());




            float resultado = v1 / v2;

            Console.WriteLine("");
            Console.WriteLine("O resultado é: " + resultado);
            Console.ReadKey();
            Menu();
        }


        static void Potencia()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());










            float resultado = v1 * v1;

            Console.WriteLine("");
            Console.WriteLine("O resultado é: " + resultado);
            Console.ReadKey();
            Menu();
        }




        static void Fechar()
        {
            System.Environment.Exit(0);
        }

    }
}
