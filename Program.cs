using System;

namespace primeira_aula
{
    class Program
			{
				static void Main(string[] args)
				{

                    Console.WriteLine("Digite seu nome");
                    string name = Console.ReadLine();
                    Console.WriteLine("Digite sua idade");
                    int  userAge = int.Parse(Console.ReadLine());

                    bool verifyAge = userAge <= 40;
                    bool verifyName = name == "Rodrigo";
                    bool itsTrueverifyname = verifyAge == true && verifyName == true;
                    Console.WriteLine(itsTrueverifyname);

               
                    Console.WriteLine("Digite seu nome");
                    string name2 = Console.ReadLine();
                    bool resp = name2 == "Rodrigo";

                    if (resp)
                    {
                         Console.WriteLine($"Resposta certa {name2} aguarde os próximos passos");
                    }
                    else if(!resp)
                    {
                         Console.WriteLine($"Resposta errada{name2} tente novamente!");
     
                    }

                     Console.WriteLine("......");   
					
				}
			}
	}