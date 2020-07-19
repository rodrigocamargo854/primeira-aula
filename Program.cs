
namespace Program
{
    using System.Globalization;
    using System;
    class Program
    {

        static void Main(string[] args)
        {
            var number1 = 0;
            var number2 = 0;
            bool isMultiple = true;

            Console.WriteLine("Number 1 : ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 2 : ");
            number2 = int.Parse(Console.ReadLine());

            isMultiple = number1 % number2 == 0;

            if(isMultiple)
            {
                Console.WriteLine($">> {number1} << it´s multiple of >> {number2} << !");

            }
            else
            {
                Console.WriteLine($">> {number1} << it´s not multiple of >> {number2} << !");

            }





        }

        static void c()
        {
            int counter = 0;
            while (counter <= 10)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(counter);
                }
                counter++;

            }
        }

        static void exercise2()
        {
            var names = new string[5];
            var counter = 0;

            while (counter < 5)
            {
                System.Console.WriteLine("Digite um nome");
                var result = Console.ReadLine();

                names[counter] = result;
                counter++;
            }
            foreach (var a in names)
            {
                Console.WriteLine(a);
            }

        }

        static void exercise3()
        {


        }

        static void exercise4()
        {
            double ages = 0;
            double media = 0;
            int counter = 0;
            while (true)
            {
                Console.WriteLine("Idade: ");
                ages = double.Parse(Console.ReadLine());
                ages++;
                if (ages == 0)
                {
                    break;
                }

            }

            media = ages / counter;
            Console.WriteLine($"Média das idade {media.ToString("F2")}");
        }

        static void exercise5()
        {
            var counter = 0;
            var WomenAges = 0;
            var ages = new int[5];

            while (counter < 5)
            {
                System.Console.Write("Age ");
                var Ages = Console.ReadLine();

                ages[counter] = int.Parse(Ages);
                counter++;
            }

            foreach (var a in ages)
            {
                if (a > 18 && a < 35)
                {
                    WomenAges++;
                }
            }
            var Percent = (WomenAges * 100) / counter;
            Console.WriteLine($" Percentual de mulheres é {Percent} %");

        }

        static void exercise6()
        {
            while (true)
            {
                Console.WriteLine("Digite uma opção:");
                Console.WriteLine("1-Cadastrar\n 2-Votação\n 3-Apuração\n 0-Sair ");
                var option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Digitou 1");
                }

                else if (option == 2)
                {
                    Console.WriteLine("Digitou 2");
                }

                else if (option == 3)
                {
                    Console.WriteLine("Digitou 1");
                }

                Console.ReadKey();

            }

        }


        static void exercise7()
        {
            int numberCigarsDay = 0;
            var cigarYears = 0;
            double price = 0.0;
            double calcPreco = 0.0;

            Console.WriteLine("##CALCULO DE GASTO  POR FUMANTE###");
            Console.ReadKey();

            Console.Write("Anos de fumante: ");
            cigarYears = Int32.Parse(Console.ReadLine());
            Console.Write("Cigarros por dia: ");
            numberCigarsDay = int.Parse(Console.ReadLine());
            Console.Write("Preço da Carteira: ");

            // coleto o valor e já efetuo o cálculo total.
            price = ((double.Parse(Console.ReadLine())) / 20) / 10;

            calcPreco = (price * numberCigarsDay) * 365;// 1 ano
            var total = calcPreco * cigarYears;

            Console.WriteLine($"Custo  em {cigarYears.ToString()} anos com cigarros , R$ {total.ToString("f2")} reais");

        }


    }
}