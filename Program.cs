
namespace Program
{

    using System;
    class Program
    {


        static void Main(string[] args)
        {
            var pass = "Pa$$word";
            var Cands = new string[2];

            int cand1Count = 0;
            int cand2Count = 0;
            int idCount = 0;

            while (true)
            {
                Console.WriteLine("Digite uma opção:\n");
                Console.WriteLine(" 1-Cadastrar\n 2-Votação\n 3-Apuração\n 0-Sair ");
                var option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.Write("Password :");
                    pass = Console.ReadLine();

                    if (pass == "Pa$$word")
                    {
                        Console.Write("Nome Candidato1 : ");
                        Cands[0] = Console.ReadLine();
                        Console.Write("Nome Candidato2 : ");
                        Cands[1] = Console.ReadLine();
                        
                        

                    }
                    else
                    {
                        Console.Write("Password errado ");
                        Console.Write("Tente novamente ");
                        Console.ReadKey();
                    }
                    Console.Clear();

                }

                else if (option == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("***Votação***");
                        Console.WriteLine($" Escolha 1 para {Cands[0]}\n Escolha 2 para {Cands[1]}\n Escolha 3 para SAIR ");
                        idCount = int.Parse(Console.ReadLine());

                        if (idCount == 1)
                        {
                            cand1Count++;
                            Console.Write($"Voto Computado");
                            Console.ReadKey();

                        }
                        else if (idCount == 2)
                        {
                            cand2Count++;
                            Console.Write($"Voto Computado");
                            Console.ReadKey();

                        }
                        else if (idCount == 3)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("***Opção inválida - voltando menu inicial***");
                        }
                        Console.Clear();
                    }

                }

                else if (option == 3)
                {

                    if (cand1Count > cand2Count)
                    {
                        Console.Write($"{Cands[0]}  venceu!!   ");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    else if (cand2Count > cand1Count)
                    {
                        Console.Write($"{Cands[1]}  venceu!!   ");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    else if (cand2Count !=0 && (cand1Count == cand2Count) )
                    {
                        Console.Write(" SEGUNDO TURNO \n");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    else if (  cand2Count == 0 && cand1Count == 0 )
                    {
                        Console.Write("Não há votos para Apurar ");
                        Console.ReadKey();
                        break;

                    }


                }
                else if (option == 0)
                {

                    Console.WriteLine("****FIM DO PROGRAMA *****");
                    Console.ReadKey();
                    break;
                }

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


        }


    }
}