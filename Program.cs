using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hello everyone");

        greetWhite();
        greetBlack();
    }


    // Метод от White — оставляем без изменений
    static void greetWhite()
    {
        Console.WriteLine("hello white");
    }

    // Новый метод от Black — только объявляем, не вызываем
    static void greetBlack()
    {
        Console.WriteLine("hello black");
    }
}
