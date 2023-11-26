using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Компьютерный практикум № 1

        //Задание 1.

        //static void Сollection(List<int> ints)
        //{
        //    foreach (int item in ints)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //static void Element(List<int> ints)
        //{
        //    if (ints.Contains(25))
        //    {
        //        Console.WriteLine("Элемент 25 присутствует в списке.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Элемент 25 отсутствует в списке.");
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    List<int> ints = new List<int>();
        //    ints.Add(1);
        //    ints.Add(10);
        //    ints.Add(25);
        //    ints.Add(17);
        //    ints.Add(10);
        //    Сollection(ints);
        //    Console.WriteLine($"Кол-во элементов: {ints.Count()}");
        //    Console.WriteLine($"Индекс 25: {ints.IndexOf(25)}");
        //    Console.WriteLine($"Удаление из списка первого элемента со значением 10: {ints.Remove(10)}");
        //    Сollection(ints);
        //    Console.WriteLine("Удаление из списка элемента с индексом 2:");
        //    ints.RemoveAt(2);
        //    Сollection(ints);
        //    Element(ints);
        //    Console.WriteLine($"Добавление числа 500 в начало списка:");
        //    ints.Insert(0, 500);
        //    Сollection(ints);
        //    Console.WriteLine($"Отсортирование элеменов списка по возрастанию: ");
        //    ints.Sort();
        //    Сollection(ints);
        //    Console.ReadKey();
        //}


        //Задание 2.

        // static void Number(List<int> ints)
        // {
        //     foreach(var elem in ints)
        //     {
        //         Console.WriteLine(elem);
        //     }
        // }
        // static void Udalenie(List<int> ints)
        // {
        //     for (int i = 0; i < ints.Count; i++)
        //     {
        //         if (ints[i] % 2 != 0)
        //         {
        //             ints.RemoveAt(i);
        //             i--;
        //         }
        //     }
        // }
        //static void Main(string[] args)
        //{
        //     List<int> ints = new List<int>();
        //     Random rnd = new Random();
        //     for (int i = 0; i < 10; i++)
        //     {
        //         ints.Add(rnd.Next(-30, 30));
        //     }
        //     Number(ints);
        //     Console.WriteLine("Удаляем все нечетные числа из списка: ");
        //     Udalenie(ints);
        //     Number(ints);
        //     Console.ReadKey();
        //}


        //Задание 4.

        //static void Output(List<int> list)
        //{
        //    foreach (var elem in list)
        //    {
        //        Console.WriteLine(elem);
        //    }
        //}
        //static int Sum(List<int> list)
        //{
        //    int sum = 0;
        //    foreach (var elem in list)
        //    {
        //        if (elem % 5 == 0)
        //        {
        //            sum += elem;
        //        }
        //    }
        //    return sum;
        //}
        //static void Main(string[] args)
        //{
        //    var list = new List <int>();
        //    Random rnd = new Random();
        //    for (int i = 0; i < 20; i++)
        //    {
        //        list.Add(rnd.Next(5, 50));
        //    }
        //    Output(list);
        //    Console.WriteLine($"Сумма чисел, кратных 5: {Sum(list)}");
        //    Console.ReadKey();
        //}


        //Задание 5.

        //static void Output(List<int> list)
        //{
        //    foreach(var elem in list)
        //    {
        //        Console.WriteLine(elem);
        //    }
        //}
        //static void Meaning(List<int> list)
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (list[i] < 0)
        //        {
        //            list.Insert(i + 1, 10);
        //        }
        //    }
        //}
        
        //static void Main(string[] args)
        //{
        //    var list = new List<int>();
        //    Random rnd = new Random();
        //    for (int i = 0; i < 10; i++)
        //    {
        //       list.Add(rnd.Next(-50, 50));
        //    }
        //    Output(list);
        //    Console.WriteLine("Вставление числа 10 после каждого отрицательного элемента:");
        //    Meaning(list);
        //    Output(list);
        //    Console.ReadKey();
        //}

    }
}
