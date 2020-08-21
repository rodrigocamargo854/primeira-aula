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

            // 1)Crie um programa que imprima:

            // a)Os números de 1 a 10 de forma crescente
            // b)Os números de 1 a 10 de forma descrecente
            // c)Os números de 1 a 10 de forma crescente, mas apenas aqueles
            // que forem par.

            // a)Os números de 1 a 10 de forma crescente
            System.Console.WriteLine("crescente");
            for (int counter = 0; counter < 11; counter++)
            {
                System.Console.WriteLine(counter);
            }

            // b)Os números de 1 a 10 de forma descrecente
            System.Console.WriteLine("decrescente");
            for (int counter = 11; counter > 0; counter--)
            {
                System.Console.WriteLine(counter);
            }

            // c)Os números de 1 a 10 de forma crescente, mas apenas aqueles
            // que forem par.
            System.Console.WriteLine("apenas os pares");
            for (int counter = 0; counter < 11; counter += 2)
            {
                System.Console.WriteLine(counter);
            }
        }

        static void Exercise2()
        {

            // 2)Imprimir a soma dos números inteiros de 1 a 100.
            var numbers = 0;

            for (var counter = 0; counter < 101; counter++)
            {
                System.Console.WriteLine(counter);
                numbers++;
            }
        }

        // 3)Imprimir todo os números ímpares menores de 200.

        static void Exercise3()
        {
            for (int counter = 1; counter <= 200; counter += 2)
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

            for (counter = 0; counter < ages.Length; counter++)
            {
                System.Console.Write("Age ");
                var Ages = Console.ReadLine();

                ages[counter] = int.Parse(Ages);

                if (ages[counter] > 18 && ages[counter] < 35)
                {
                    WomenAges++;
                }
            }

            var Percent = (WomenAges * 100) / counter;
            Console.WriteLine($" Percentual de mulheres é {Percent} %");
        }

        static void Exercise5()
        {
            int counter = 0;
            var womenBetween18And35 = 0;
            for (int c = 0; c < 5; c++)
            {
                System.Console.WriteLine("Digite o nome de uma mulher");
                Console.ReadLine();
                System.Console.WriteLine("Digite sua idade");
                var age = Int32.Parse(Console.ReadLine());
                bool verify = age > 17 && age < 36;

                if (verify)
                {
                    womenBetween18And35++;
                }
            }
            Console.WriteLine("A porcentagem de mulheres entre 18 e 35");
            Console.WriteLine(womenBetween18And35 * 100 / 5);
        }

        static void Exercise6()
        {
            const string registerMode = "1";
            const string votesMode = "2";
            const string resultMode = "3";
            var candidates = new (string name, int votes)[3];

            while (true)
            {
                System.Console.WriteLine("Selecione um dos modos a baixo:");
                System.Console.WriteLine($"{registerMode}) Cadastro de candidatos");
                System.Console.WriteLine($"{votesMode}) Votar");
                System.Console.WriteLine($"{resultMode}) Apuração dos votos");
                var mode = Console.ReadLine();

                if (mode == resultMode)
                {
                    break;
                }

                if (mode == registerMode)
                {
                    var password = "";
                    while (password != "Pa$$w0rd")
                    {
                        System.Console.WriteLine("Digite a senha");
                        password = Console.ReadLine();
                    }
                    //preenche a tupla com os nomes dos candidatos
                    for (int i = 0; i < candidates.Length; i++)
                    {
                        System.Console.WriteLine($"Digite o nome do candidato nº{i + 1}");
                        candidates[i].name = Console.ReadLine();
                    }
                }
                //mostra menu de votacão interpolando com o index i
                if (mode == votesMode)
                {
                    for (int i = 0; i < candidates.Length; i++)
                    {
                        System.Console.WriteLine($"Vote {i + 1} para o candidato: {candidates[i].name}");
                    }

                    // utiliza a entrada como indice para encontrar o candidato
                    var vote = Int32.Parse(Console.ReadLine());
                    candidates[vote - 1].votes++;
                }
            }

            // apuração
            var winner = candidates[0];
            var isDraw = false;
            var drawCandidates = winner.name;

            for (int i = 1; i < candidates.Length; i++)
            {
                var currentCandidate = candidates[i];

                if (currentCandidate.votes > winner.votes)
                {
                    winner = currentCandidate;
                    drawCandidates = currentCandidate.name;
                }
                else if (currentCandidate.votes == winner.votes)
                {
                    isDraw = true;
                    drawCandidates += $", {currentCandidate.name}";
                }
            }

            if (isDraw)
            {
                System.Console.WriteLine($"Segundo turno entre: {drawCandidates}!");
            }
            else
            {
                System.Console.WriteLine($"O vencedor é: {winner.name}");
                System.Console.WriteLine($"Com o total de: {winner.votes} votos!");
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
        // Fazer um algoritmo para ler 03 números reais
        //  do teclado e verificar se o primeiro é maior
        // que a soma dos outros dois.
        static void Exercisce8()
        {
            var c = 2;
            var number1 = 0;
            var number2 = 0;
            bool isMultiple = true;

            for (int i = 0; i < c; i++)
            {
                Console.WriteLine($"Number{c}: ");
                number1 = int.Parse(Console.ReadLine());
            }
            isMultiple = number1 % number2 == 0;
            string msg = "O número ";
            msg += isMultiple ? $"{number1}  é multiplo de {number2}!" : $"{number1} não é multiplo de {number2}!";

        }

        static void Exercisce9()
        {
            var c = 3;
            var numbers = new double[c];
            for (var i = 0; i < c; i++)
            {
                Console.WriteLine("Type a number: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }
            bool type1 = numbers[0] > (numbers[1] + numbers[2]);
            string msg = "O primeiro número ";
            msg += type1 ? $"é maior que a soma entre {numbers[1]} e {numbers[2]}" : $"não é maior que a soma entre{numbers[1]} e {numbers[2]}";
            Console.WriteLine(msg);
        }
        // Ler 02 números reais do teclado (A e B), 
        //verificar e imprimir qual deles é maior,
        //  ou a mensagem "A = B" caso sejam iguais.
        static void Exercisce10()
        {
            var numbersToCompare = new double[2];
            for (int i = 0; i < numbersToCompare.Length; i++)
            {
                Console.WriteLine("Number  : ");

                try
                {
                    numbersToCompare[i] = double.Parse(Console.ReadLine());
                }

                catch (System.Exception)
                {
                    Console.WriteLine("Digite somente números por favor:");
                }
            }

            string msg = "O número ";
            bool compare1 = numbersToCompare[0] > numbersToCompare[1];
            bool compare2 = numbersToCompare[0] < numbersToCompare[1];
            bool compare3 = numbersToCompare[0] == numbersToCompare[1];

            msg += compare1 ? $"{numbersToCompare[0]} é maior" : $"{numbersToCompare[1]} é maior";
            Console.WriteLine(msg);


            if (numbersToCompare[0] == numbersToCompare[1])
            {
                Console.WriteLine("Estes números são iguais!");
            }
        }

        static void Exercise11()
        {
            var a = 2;
            var numberByZero = new double[a];
            bool verify = numberByZero[1] == 0;

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Number  : ");
                numberByZero[i] = double.Parse(Console.ReadLine());
            }

            string msg = "Análise: ";
            msg += verify == false ? $" Quociente {(numberByZero[0] / numberByZero[1]).ToString("F2")}" : $"Divisão por Zero";
            Console.WriteLine(msg);

        }

        static void Exercisce12()
        {
            var c = 5;
            var numbersPairs = new int[c];
            var sumPairs = 0;

            for (int i = 1; i < c; i++)
            {
                Console.WriteLine($"{i}º number : ");
                numbersPairs[i] = int.Parse(Console.ReadLine());
                Console.Clear();

                if (numbersPairs[i] % 2 == 0)

                {
                    sumPairs += numbersPairs[i];
                }
            }

            Console.WriteLine($"A soma dos pares é {sumPairs} ");
        }


        static void Exercise13()
        {
            var j = 3;
            var numbers = new double[j];
            Double biggestNumber = 0.0;

            for (int counter = 0; counter < j; counter++)
            {
                Console.Write($"number : ");
                Double input = 0.0;

                try
                {
                    input = Double.Parse(Console.ReadLine());

                }

                catch (SystemException)
                {
                    Console.WriteLine("Digite um número por favor!");

                }

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

            if (a > c || b > c)
            {

                if (a > c && b > c)
                {
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
                }

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
            }
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

            for (int i = 0; i < 11 ; i++)
            {
                Console.WriteLine($" {counter.ToString()}º number : ");
                numerosMultlplos.Add(num = int.Parse(Console.ReadLine()));
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
            Exercise13();
        }
    }
}
