
namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main(string[] args)
        {


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

            static void exercise8()
            {

                var number1 = 0;
                var number2 = 0;
                bool isMultiple = true;

                Console.WriteLine("Number 1 : ");
                number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Number 2 : ");
                number2 = int.Parse(Console.ReadLine());

                isMultiple = number1 % number2 == 0;

                if (isMultiple)
                {
                    Console.WriteLine($">> {number1} << it´s multiple of >> {number2} << !");

                }
                else
                {
                    Console.WriteLine($">> {number1} << it´s not multiple of >> {number2} << !");

                }


            }

            static void exercise9()
            {
                var numbers = new double[3];

                Console.WriteLine("Number 1 : ");
                numbers[0] = double.Parse(Console.ReadLine());

                Console.WriteLine("Number 2 : ");
                numbers[1] = double.Parse(Console.ReadLine());

                Console.WriteLine("Number 3 : ");
                numbers[2] = double.Parse(Console.ReadLine());

                if (numbers[0] > (numbers[1] + numbers[1]))
                {
                    Console.WriteLine($"O número {numbers[0]} é maior que a soma entre {numbers[1]} e {numbers[2]} ");
                }

                else if (numbers[0] == (numbers[1] + numbers[1]))
                {
                    Console.WriteLine($"O número {numbers[0]} é igual a  soma entre {numbers[1]} e {numbers[2]} ");
                }

                else
                {
                    Console.WriteLine($"O número {numbers[0]} é menor que a soma entre {numbers[1]} e {numbers[2]} ");
                }


            }

            static void exercise10()
            {
                var numbersToCompare = new double[2];

                Console.WriteLine("Number 1 : ");
                numbersToCompare[0] = double.Parse(Console.ReadLine());

                Console.WriteLine("Number 2 : ");
                numbersToCompare[1] = double.Parse(Console.ReadLine());


                if (numbersToCompare[0] > numbersToCompare[1])
                {
                    Console.WriteLine($"Os números são iguais!  ");
                }

                else if (numbersToCompare[0] < numbersToCompare[1])
                {
                    Console.WriteLine($"O número {numbersToCompare[1]} é maior que  {numbersToCompare[0]}  ");
                }

                else
                {
                    Console.WriteLine($"O número {numbersToCompare[0]} é igual ao  {numbersToCompare[1]}  ");
                }




            }

            static void exercise11()
            {
                var numberByZero = new double[2];

                Console.WriteLine("Number 1 : ");
                numberByZero[0] = double.Parse(Console.ReadLine());

                Console.WriteLine("Number 2 : ");
                numberByZero[1] = double.Parse(Console.ReadLine());

                if (numberByZero[1] != 0)
                {
                    Console.WriteLine($" Quociente {(numberByZero[0] / numberByZero[1]).ToString("F2")}");
                }

                else
                {
                    Console.WriteLine($"DIVISÃO POR ZERO  ");
                }

            }

            static void exercise12()
            {

                var numbersPairs = new int[5];
                var counter = 1;
                var sumPairs = 0;

                while (counter < 5)

                {
                    Console.WriteLine($"{counter}º number : ");
                    numbersPairs[counter] = int.Parse(Console.ReadLine());
                    Console.Clear();

                    counter++;

                }
                foreach (var a in numbersPairs)
                {
                    if (numbersPairs[a] % 2 == 0)

                    {
                        sumPairs += numbersPairs[a];
                    }
                }

                Console.WriteLine($"A soma dos pares é {sumPairs} ");

            }

            static void exercise13()
            {
                // var numbersPairs = new int[5];
                List<int> numeros = new List<int>();
                var counter = 1;
                var num = 0;
                int exc = 0;


                while (counter < 11)

                {
                    Console.WriteLine($"{counter.ToString()}º number : ");
                    numeros.Add(num = int.Parse(Console.ReadLine()));

                    // numbersPairs[counter] = int.Parse(Console.ReadLine());
                    counter++;
                }

                Console.WriteLine($"O maior número é o {numeros.Max()}");

                //metodo bubble
                // for (int i = 0; i < numeros.Length - 1; i++)
                // {
                //     for (int j = 0; j < numeros.Length - (i + 1); j++)
                //     {
                //         if (numeros[j] > numeros[j + 1])
                //         {
                //             exc = numeros[j];
                //             numeros[j] = numeros[j + 1];
                //             numeros[j + 1] = exc;
                //         }
                //     }

                //     foreach (var a in numeros)
                //     {
                //         Console.WriteLine($"{ numeros[a]} ");
                //     }


            }

            static void exercicse14()

            {
                int i = 1;
                List<int> _lista = new List<int>();

                while (i <= 4)
                {

                    Console.WriteLine($"Digite o {i}º número: ");
                    _lista.Add(int.Parse(Console.ReadLine()));

                    i++;
                }
                _lista.Sort();

                Console.WriteLine();
                Console.WriteLine("Os numeros digitados em ordem são : ");

                foreach (int numb in _lista)
                {
                    Console.WriteLine(numb);
                }

            }

            static void exercicse15()

            {
                List<int> numerosMultlplos = new List<int>();
                var counter = 1;
                var num = 0;
                int multCinco = 0;
                int multTres = 0;


                while (counter < 11)

                {
                    Console.WriteLine($" {counter.ToString()}º number : ");
                    numerosMultlplos.Add(num = int.Parse(Console.ReadLine()));

                    counter++;
                }

                foreach (var c in numerosMultlplos)
                {
                    if (c % 3 == 0)
                    {
                        multTres++;
                    }

                    else if (c % 5 == 0)
                    {
                        multCinco++;
                    }

                }

                Console.WriteLine($"Os multiplos de três são {multTres} ");
                Console.WriteLine($"Os multiplos de três são {multCinco} ");
                Console.ReadKey();



            }


            static void exercicse16()

            {


            }



        }

    }
}






