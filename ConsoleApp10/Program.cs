using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int numberOfElements = 100000; // Количество элементов для вставки

        // Создаём и заполняем текстом, для примера
        string text = "C:\\Users\\Twe1ve\\Downloads\\Text.txt.txt";

        // Отслеживание времени для List<T>
        var stopwatch = new Stopwatch();
        List<string> list = new List<string>();

        stopwatch.Start();
        for (int i = 0; i < numberOfElements; i++)
        {
            list.Insert(0, text); // Вставка в начало списка
        }
        stopwatch.Stop();
        Console.WriteLine($"Время вставки в List: {stopwatch.ElapsedMilliseconds} мс");

        // Отслеживание времени для LinkedList<T>
        stopwatch.Reset();
        LinkedList<string> linkedList = new LinkedList<string>();

        stopwatch.Start();
        for (int i = 0; i < numberOfElements; i++)
        {
            linkedList.AddFirst(text); // Вставка в начало связного списка
        }
        stopwatch.Stop();
        Console.WriteLine($"Время вставки в LinkedList: {stopwatch.ElapsedMilliseconds} мс");
    }
}