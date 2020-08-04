using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace primeira_aula
{
    class Program
    {
        static void Exercise1()
        {

            System.Console.WriteLine("crescente");
            for (int counter = 0; counter < 11; counter++)
            {
                System.Console.WriteLine(counter);
            }

            System.Console.WriteLine("decrescente");
            for (int counter = 11; counter > 0; counter--)
            {
                System.Console.WriteLine(counter);
            }

            System.Console.WriteLine("apenas os pares");
            for (int counter = 0; counter < 11; counter += 2)
            {
                System.Console.WriteLine(counter);
            }

        }

        static void Exercise2()
        {
            var names = new string[5];

            for (var counter = 0; counter < 5; counter++)
            {
                System.Console.WriteLine("Digite um nome");
                var result = Console.ReadLine();
                names[counter] = result;

            }
            foreach (var a in names)
            {
                Console.WriteLine(a);
            }

        }

        static void Exercise3()
        {

            for (int counter = 1; counter < 200; counter += 2)
            {
                Console.WriteLine(counter);
            }
        }

        static void Exercise4()
        {
            var sum = 0.0;

            for (int counter = 0; true; counter++)

            {
                Console.WriteLine("Idade: ");
                var result = Console.ReadLine();

                if (result == "0")
                {
                    var average = (sum / counter).ToString("0.00");
                    Console.WriteLine($"Média das idade {average}");
                    break;
                }

                sum += Int32.Parse(result);

            }

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

        static void Exercise5()
        {
            var womenBetween18And35 = 0;

            for (int counter = 0; counter < 5; counter++)
            {
                System.Console.WriteLine("Digite o nome de uma mulher");
                Console.ReadLine();
                System.Console.WriteLine("Digite sua idade");
                var age = Int32.Parse(Console.ReadLine());

                if (age > 17 && age < 36)
                {
                    womenBetween18And35++;
                }
            }

            System.Console.WriteLine("A porcentagem de mulheres entre 18 e 35");
            System.Console.WriteLine(womenBetween18And35 * 100 / 5);
        }

        static void Exercise6()
        {
            const string registerMode = "1";
            const string votesMode = "2";
            const string resultMode = "3";


            //  tuplas
            var candidates = new (string name, int votes)[2];
            while (true)
            {
                Console.WriteLine("Digite uma opção:\n");
                Console.WriteLine(" 1-Cadastrar\n 2-Votação\n 3-Apuração\n 0-Sair ");
                var option = int.Parse(Console.ReadLine());

            }


        }

        static void Exercisce7()
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

            calcPreco = (price * numberCigarsDay) * 365; // 1 ano
            var total = calcPreco * cigarYears;

            Console.WriteLine($"Custo  em {cigarYears.ToString()} anos com cigarros , R$ {total.ToString("f2")} reais");


        }

        static void Exercisce8()
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

        static void Exercisce9()
        {

            var numbers = new double[3];

            for (var i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Type a number: ");
                numbers[i] = double.Parse(Console.ReadLine());

            }

            if (numbers[0] > (numbers[1] + numbers[2]))
            {
                Console.WriteLine($"O número {numbers[0]} é maior que a soma entre {numbers[1]} e {numbers[2]} ");
            }
            else if (numbers[0] == (numbers[1] + numbers[2]))
            {
                Console.WriteLine($"O número {numbers[0]} é igual a  soma entre {numbers[1]} e {numbers[2]} ");
            }
            else
            {
                Console.WriteLine($"O número {numbers[0]} é menor que a soma entre {numbers[1]} e {numbers[2]} ");
            }


        }

        static void Exercisce10()
        {
            var numbersToCompare = new double[2];

            for (int i = 0; i < numbersToCompare.Length; i++)
            {
                Console.WriteLine("Number  : ");
                numbersToCompare[i] = double.Parse(Console.ReadLine());
            }


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

        static void Exercise11()
        {

            var numberByZero = new int[2];

            for (int i = 0; i < numberByZero.Length; i++)
            {
                Console.WriteLine("Number 1 : ");
                numberByZero[i] = int.Parse(Console.ReadLine());
            }

            if (numberByZero[1] != 0)
            {
                Console.WriteLine($" Quociente {(numberByZero[0] / numberByZero[1]).ToString("F2")}");
            }
            else
            {
                Console.WriteLine($"DIVISÃO POR ZERO  ");
            }

        }

        static void Exercisce12()
        {

            var numbersPairs = new int[5];
            var sumPairs = 0;

            for (int i = 1; i < numbersPairs.Length; i++)
            {
                Console.WriteLine($"{i}º number : ");
                numbersPairs[i] = int.Parse(Console.ReadLine());
                Console.Clear();
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


        static void Exercise13()
        {
            var numbers = new int[10];
            var biggestNumber = 0;

            for (int counter = 0; counter < 10; counter++)
            {
                Console.Write($"number : ");
                var input = Int32.Parse(Console.ReadLine());


                if (input > biggestNumber)
                {
                    biggestNumber = input;
                }

                numbers[counter] = input;
            }

            Console.WriteLine($"O maior número é {biggestNumber}");

        }


        static void Exercisce14()
        {
            var a = 0.0;
            var b = 0.0;
            var c = 0.0;
            var temp = 0.0;
            Console.Write("Number: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Number: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Number: ");
            c = double.Parse(Console.ReadLine());
            
           // if (a > c || b > c)
           // {
                if (a > c)
                {
                    temp = c;
                    c = a;
                    a = temp;
                }
                else if (b > c)
                {
                    temp = c;
                    c = b;
                    b = temp;
                }
            //}
            if (a > b)
            {
                temp = b;
                b = a;
                a = temp;
            }
            Console.Write($"{a} ");
            Console.Write($"{b} ");
            Console.Write($"{c} ");

        }

        static void Exercisce15()
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

        static void Exercisce16()
        {

            double salarioBruto = 0.0;

            Console.Write("Salário Bruto:  ");
            //usa-se o cultureinfo para aceitar tanto , como .(em qualquer idioma)
            salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salarioBruto <= 600.0)
            {
                Console.WriteLine("ISENTO de IMPOSTO");
            }
            else if (salarioBruto > 600.0 && salarioBruto <= 1000.0)
            {
                Console.WriteLine($"SALÁRIO LÍQUIDO : R${(salarioBruto - (0.2 * salarioBruto)).ToString("f2")}");
            }
            else if (salarioBruto > 1200.0 && salarioBruto <= 2000.0)
            {
                Console.WriteLine($"SALÁRIO LÍQUIDO : R${(salarioBruto - (0.25 * salarioBruto)).ToString("f2")}");
            }
            else if (salarioBruto > 2000.0)
            {
                Console.WriteLine($"SALÁRIO LÍQUIDO : R${(salarioBruto - (0.3 * salarioBruto)).ToString("f2")}");
            }
            Console.ReadKey();


        }


        static void Exercisce17()
        {
            while (true)
            {
                var counterT = 1;
                var tabuada = 0;

                Console.Write($"Digite um número para o cálculo da tabuada: ");
                tabuada = int.Parse(Console.ReadLine());

                if (tabuada == -1)
                {
                    Console.WriteLine("### IT'S DONE!! ###");
                    Console.ReadKey();
                    break;
                }

                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine($"{tabuada} x {i} = {tabuada * i} ");
                    Console.ReadKey();

                }
            }

        }

        static void Exercisce18()
        {

            double precoMaca = 1.0;
            int numbApples = 0;

            Console.Write("Digite o número de maçãs a serem compradas: ");
            numbApples = int.Parse(Console.ReadLine());

            if (numbApples < 12)
            {
                precoMaca = 1.30;
                Console.WriteLine($" Valor a pagar R${numbApples * precoMaca}");
            }
            else if (numbApples >= 12)
            {
                Console.WriteLine($" Valor a pagar R${numbApples * precoMaca}");
            }

            Console.ReadKey();


        }




        static void Main(string[] args)
        {

            Exercisce14();
        }
    }
}
