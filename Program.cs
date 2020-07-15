using System;
class Program
{

    static void Main(string[] args)
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
        foreach(var a in names)
        {
            Console.Write($" {a}");

        }

    }

    static void b()
    {
        int counter1 = 10;
        while (counter1 != 0)
        {
            Console.WriteLine(counter1);
            counter1--;

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
        foreach(var a in names)
        {
            Console.WriteLine(a);

        }

    }

    static void exercise3()
    {


    }

    static void exercise4()
    {


    }

    static void exercise5()
    {


    }

    static void exercise6()
    {


    }

    static void exercise7()
    {


    }

}

