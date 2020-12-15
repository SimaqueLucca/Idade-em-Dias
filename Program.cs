using System;

class Desafio
{
    static void Main()
    {

        int dias = Int32.Parse(Console.ReadLine());
        int anos = 0, meses = 0;

        while (dias >= 365)
        {
            dias -= 365;
            anos++;
        }

        while (dias >= 30)
        {
            dias -= 30;
            meses++;
        }

        System.Console.WriteLine($"{anos} ano(s)");
        System.Console.WriteLine($"{meses} mes(es)");
        System.Console.WriteLine($"{dias} dia(s)");

    }
}